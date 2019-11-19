﻿using StoreDAL.Is;
using StoreDAL.VMs;
using StoreDAL.BMs;
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
    public partial class FormCategoryAdd : Form
    {
		[Dependency]
		public new IUnityContainer Container { get; set; }

		public int Id { set { id = value; } }

		private readonly ICategoryService service;

		private int? id;

		public FormCategoryAdd(ICategoryService service)
		{
			InitializeComponent();
			this.service = service;
		}

		private void FormDesigner_Load(object sender, EventArgs e)
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
				if (id.HasValue)
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
