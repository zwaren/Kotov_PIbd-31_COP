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
	public partial class ControlCheckedListBox : UserControl
	{
		/// <summary>
		/// Порядковый номер выбранного элемента
		/// </summary>
		private int _selectedIndex;

		/// <summary>
		/// Событие выбора элемента из списка
		/// </summary>
		private event EventHandler _checkedListBoxSelectedElementChange;

		/// <summary>
		/// Порядковый номер выбранного элемента
		/// </summary>
		[Category("Спецификация"), Description("Порядковый номер выбранного элемента")]
		public int SelectedIndex
		{
			get { return _selectedIndex; }
			set {
				if (value > -2 && value < checkedListBox.Items.Count) { _selectedIndex = value; checkedListBox.SelectedIndex = _selectedIndex; } }
		}

		/// <summary>
		/// Текст выбранной записи
		/// </summary>

		[Category("Спецификация"), Description("Текст выбранной записи")]

		public string SelectedText
		{
			get { return checkedListBox.Text; }
		}

		/// <summary>
		/// Событие выбора элемента из списка
		/// </summary>

		[Category("Спецификация"), Description("Событие выбора элемента из списка")]

		public event EventHandler ComboBoxSelectedElementChange
		{
			add { _checkedListBoxSelectedElementChange += value; }
			remove { _checkedListBoxSelectedElementChange -= value; }
		}

		/// <summary>
		/// Конструктор
		/// </summary>

		public ControlCheckedListBox()
		{
			InitializeComponent();
			checkedListBox.SelectedIndexChanged += (sender, e) => {
				_checkedListBoxSelectedElementChange?.Invoke(sender, e);
			};
		}

		/// <summary>
		/// Заполнение списка значениями из справочника
		/// </summary>
		/// <param name="type">тип-справочник</param>

		public void LoadEnumeration(Type type)
		{
			foreach (var elem in Enum.GetValues(type))
			{
				checkedListBox.Items.Add(elem.ToString());
			}
		}
	}
}
