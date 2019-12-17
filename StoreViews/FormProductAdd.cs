using StoreDAL.BMs;
using StoreDAL.Is;
using StoreDAL.VMs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace StoreViews
{

    public partial class FormProductAdd : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public int Id { set { id = value; } }

        private readonly IProductService service;
        private readonly ICategoryService _service;

        private int? id;

        public FormProductAdd(IProductService service, ICategoryService _service)
        {
            InitializeComponent();
            List<CategoryVM> catVM = _service.GetList();
            //selectComponentControl.LoadEnumeration(catVM, (x) => x.Name);
            this.service = service;
        }

        private void FormProductAdd_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    ProductVM view = service.Get(id.Value);
                    if (view != null)
                    {
                        textBoxName.Text = view.Name;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Заполните", "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (id.HasValue)
                {
                    service.Update(new ProductBM
                    {
                        Id = id.Value,
                        Name = textBoxName.Text,
                        CategoryId = selectComponentControl.SelectedIndex,
                        Count = Int32.Parse(controlTextBox.Text)
                    });
                }
                else
                {
                    service.Add(new ProductBM
                    {
                        Name = textBoxName.Text,
                        CategoryId = selectComponentControl.SelectedIndex,
                        Count = Int32.Parse(controlTextBox.Text)
                    });
                }
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
