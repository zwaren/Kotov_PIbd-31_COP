using System;
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
        List<Product> list;

		public Form1()
		{
			InitializeComponent();

			controlComboBox.LoadEnumeration(typeof(TestEnum));

			list = new List<Product>();
			list.Add(new Product { Name = "1", Category = "1", Count = 5});
            list.Add(new Product { Name = "2", Category = "1", Count = 10});
            list.Add(new Product { Name = "3", Category = "2", Count = 7});

		}

		private void controlComboBox_ComboBoxSelectedElementChange(object sender, EventArgs e)
		{
			MessageBox.Show(controlComboBox.SelectedInt.ToString());
		}

		private void button1_Click(object sender, EventArgs e)
		{
			controlComboBox.SelectedIndex = 0;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			WordDiagramCreater.CreateDiagram(list, "Name", "Count", @"D:\diagram.docx");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string format = "Name Category Count";
			PDFReporter.CreatePDFReport(PDFReporter.Alignment.Horizontal, format, list, @"D:\report.pdf");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			var list1 = new Deserialization().Deserialize<Product>(@"D:\serial.json");
			if (list1 != null)
				controlTreeView1.SetList(list1, (x) => x.Category);
		}
	}
}
