﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlLibrary;

namespace WindowsFormsApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			controlComboBox.LoadEnumeration(typeof(TestEnum));

            List<Product> list = new List<Product>();
            list.Add(new Product("1", "1"));
            list.Add(new Product("2", "1"));
            list.Add(new Product("3", "2"));

            controlTreeView1.SetList(list, (x) => x.Category);

		}

		private void controlComboBox_ComboBoxSelectedElementChange(object sender, EventArgs e)
		{
			MessageBox.Show(controlComboBox.SelectedInt.ToString());
		}

		private void button1_Click(object sender, EventArgs e)
		{
			controlComboBox.SelectedIndex = 0;
		}

    }
}
