using StoreDAL.BMs;
using StoreDAL.Is;
using StoreDAL.VMs;
using System;
using System.Windows.Forms;
using Unity;

namespace StoreViews
{
    public partial class FormCategoryAdd : Form
    {
		[Dependency]
		public new IUnityContainer Container { get; set; }

		public int Id { set { id = value; } }
        public bool Copy { set { copy = value; } }

        private readonly ICategoryService service;

		private int? id;
        private bool? copy;

		public FormCategoryAdd(ICategoryService service)
		{
			InitializeComponent();
			this.service = service;
		}

		private void FormCategoryAdd_Load(object sender, EventArgs e)
		{
			if (id.HasValue)
			{
				try
				{
					CategoryVM view = service.Get(id.Value);
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

		private void bSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxName.Text))
			{
				MessageBox.Show("Заполните", "Ошибка", MessageBoxButtons.OK,
				MessageBoxIcon.Error);
				return;
			}
			try
			{
				if (copy.HasValue)
				{
					CategoryVM toCopy = service.Get(id.Value);

					CategoryBM original = new CategoryBM
					{
						Name = toCopy.Name
					};
					CategoryBM Copyed = original.DeepCopy() as CategoryBM;

					service.Add(Copyed);

				}
				else if (id.HasValue)
				{
					service.Update(new CategoryBM
					{
						Id = id.Value,
						Name = textBoxName.Text
					});
				}
				else
				{
					service.Add(new CategoryBM
					{
						Name = textBoxName.Text
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
        private void bCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
