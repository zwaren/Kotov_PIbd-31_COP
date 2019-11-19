using StoreDAL.Is;
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
			
		}
	}
}
