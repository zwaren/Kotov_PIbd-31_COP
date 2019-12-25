using PluginService;
using StoreDAL.Is;
using StoreDAL.VMs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace StoreViews
{
    public partial class FormMain : Form
    {
		[Dependency]
		public new IUnityContainer Container { get; set; }

		private readonly ICategoryService cService;
		private readonly IProductService pService;

        List<ProductVM> list;

        List<IPlugin> _plugins;


        public FormMain(ICategoryService cService, IProductService pService)
		{
			InitializeComponent();
			this.cService = cService;
			this.pService = pService;
		}

		private void bCategory_Click(object sender, EventArgs e)
		{
			var form = Container.Resolve<FormCategoryList>();
			form.ShowDialog();
			LoadData();
		}

		private void LoadData()
		{
			list = pService.GetList();
			controlTreeView.SetList(list, (x) => cService.Get(x.CategoryId));
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			LoadData();

			this.LoadPlugins("C:\\Users\\user\\source\\repos\\Kotov_PIbd-31_COP\\plugins\\");
			this.AddPluginsItems();
		}

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormProductList>();
			form.ShowDialog();
			LoadData();
		}

        private void BBackUp_Click(object sender, EventArgs e)
        {
			SaveFileDialog path = new SaveFileDialog();
			if (path.ShowDialog() == DialogResult.OK)
			{
				createBackUpComponent1.BackUp(pService.GetList(), path.FileName);
				LoadData();
			}
        }

        private void BWordReport_Click(object sender, EventArgs e)
        {
			SaveFileDialog path = new SaveFileDialog();
			if (path.ShowDialog() == DialogResult.OK)
			{
				wordReport1.SetData(pService.GetList().Select(x =>
				{
					var list1 = new List<String>();
					list1.Add(x.Id.ToString());
					list1.Add(x.Name);
					list1.Add(cService.Get(x.CategoryId).Name);
					return list1;
				}).ToList());
				string[] cols = { "Id", "Name", "Category" };
				wordReport1.CreateTable(cols, null, path.FileName);
				LoadData();
			}
        }

        private void BWordDiagram_Click(object sender, EventArgs e)
        {
			SaveFileDialog path = new SaveFileDialog();
			if (path.ShowDialog() == DialogResult.OK)
			{
				wordDiagramCreater1.CreateDiagram(list, "Name", "Count", path.FileName);
				LoadData();
			}
			
        }

        private void LoadPlugins(string path)
        {
            string[] pluginFiles = Directory.GetFiles(path, "*.dll");
            _plugins = new List<IPlugin>();

            foreach (string pluginPath in pluginFiles)
            {
                Type objType = null;
                try
                {
                    // пытаемся загрузить библиотеку
                    Assembly assembly = Assembly.LoadFrom(pluginPath);
                    if (assembly != null)
                    {
                        objType = assembly.GetType(Path.GetFileNameWithoutExtension(pluginPath) + ".Plugin");
                    }
                }
                catch
                {
                    continue;
                }
                try
                {
                    if (objType != null)
                    {
                        _plugins.Add((IPlugin)Activator.CreateInstance(objType));
                    }
                }
                catch
                {
                    continue;
                }
            }
        }

        private void AddPluginsItems()
        {
            lvPlugins.Items.Clear();
            foreach (IPlugin plugin in this._plugins)
            {
                if (plugin == null)
                {
                    continue;
                }
                lvPlugins.Items.Add(plugin.Name);
                lvPlugins.Items[lvPlugins.Items.Count - 1].SubItems.Add(plugin.Version.ToString());
                lvPlugins.Items[lvPlugins.Items.Count - 1].SubItems.Add(plugin.Author);
            }
        }


        private void lvPlugins_DoubleClick(object sender, EventArgs e)
        {
            if (lvPlugins.SelectedItems.Count > 0)
            {
                int selectedIndex = lvPlugins.SelectedItems[0].Index;
                if (_plugins[selectedIndex].Exec(pService, cService))
                {
                    MessageBox.Show("Успех", "Да", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Не успех", "Нет", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadData();
            }
        }
    }
}
