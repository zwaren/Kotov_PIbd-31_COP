using StoreDAL.BMs;
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

namespace CategoryChange
{
    public partial class Form1 : Form
    {
        IProductService pService;
        ICategoryService cService;

        public Form1(IProductService pService, ICategoryService cService)
        {
            InitializeComponent();
            this.pService = pService;
            this.cService = cService;
        }

        private void BApply_Click(object sender, EventArgs e)
        {
            var pr = (ProductVM) cbProduct.SelectedItem;
            var cat = (CategoryVM) cbCategory.SelectedItem;
            pService.Update(new ProductBM
            {
                Id = pr.Id,
                Name = pr.Name,
                CategoryId = cat.Id,
                Count = pr.Count
            });
            DialogResult = DialogResult.OK;
            Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbProduct.Items.AddRange(pService.GetList().ToArray());
            cbCategory.Items.AddRange(cService.GetList().ToArray());
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
