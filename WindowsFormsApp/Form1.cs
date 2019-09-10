using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			controlComboBox.LoadEnumeration(typeof(TestEnum));
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
