using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class ControlListBox : UserControl
    {
        object[] elems;

        public delegate void ListBoxEventHandler(int index, object selected);

        public event ListBoxEventHandler SelectedIndexChanged;

        public object Selected
        {
            get => (listBox.SelectedIndex >= 0) ? elems[listBox.SelectedIndex] : null;
        }

        public ControlListBox()
        {
            InitializeComponent();
        }

        public void SetList(Type type)
        {
            elems = Enum.GetValues(type).Cast<object>().ToArray();
            listBox.Items.AddRange(elems);
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndexChanged.Invoke(listBox.SelectedIndex, Selected);
        }
    }
}
