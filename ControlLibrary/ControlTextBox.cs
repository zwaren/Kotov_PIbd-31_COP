using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ControlLibrary
{
	public partial class ControlTextBox : UserControl
	{
		public Color DangerColor { get; set; }
		public Color AcceptColor { get; set; }
		string regex = @"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)";

		public string TemplateMail
		{
			get { return maskedTextBox.Text; }
			set { maskedTextBox.Text = value; }
		}

		public ControlTextBox()
		{
			InitializeComponent();
			DangerColor = Color.Red;
			AcceptColor = Color.Green;
		}

		public ControlTextBox(Color dangerColor, Color acceptColor)
		{
			InitializeComponent();
			this.DangerColor = dangerColor;
			this.AcceptColor = acceptColor;
		}

		private void maskedTextBox_TextChanged(object sender, EventArgs e)
		{

			if (!Regex.IsMatch(maskedTextBox.Text, regex))
			{
				maskedTextBox.BackColor = DangerColor;
			}
			else
			{
				maskedTextBox.BackColor = AcceptColor;
			}
		}
	}
}
