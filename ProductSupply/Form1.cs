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

namespace ProductSupply
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

        private void BAdd_Click(object sender, EventArgs e)
        {
            var pr = (ProductVM) cbProduct.SelectedItem;
            int count = int.Parse(tbCount.Text);
            if (count <= 0)
            {
                MessageBox.Show("Введите положительное число", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            pService.Update(new ProductBM
            {
                Id = pr.Id,
                Name = pr.Name,
                CategoryId = pr.CategoryId,
                Count = pr.Count + count
            });
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbProduct.Items.AddRange(pService.GetList().ToArray());
        }
    }
}
