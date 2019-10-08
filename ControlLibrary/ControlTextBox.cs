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
        public string Text
        {
            get => (textBox.Text != "") ? textBox.Text : null;
            set => textBox.Text = value;
        }

		public ControlTextBox()
		{
			InitializeComponent();
		}

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                textBox.BackColor = Color.Green;
            }
            else
            {
                textBox.BackColor = Color.Red;
            }
        }
    }
}
