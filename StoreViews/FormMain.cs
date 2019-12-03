using StoreDAL.Is;
using StoreDAL.VMs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
            list = pService.GetList();
            controlTreeView.SetList(list, (x) => cService.Get(x.CategoryId));
		}

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormProductList>();
            form.ShowDialog();
        }

        private void BBackUp_Click(object sender, EventArgs e)
        {
            createBackUpComponent1.BackUp(pService.GetList(), @"D:\test\products.json");
        }

        private void BWordReport_Click(object sender, EventArgs e)
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
            wordReport1.CreateTable(cols, null, @"D:\test\products.docx");
        }
    }
}
