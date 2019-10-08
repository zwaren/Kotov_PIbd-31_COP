using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSharp.Markdown.Pdf;
using System.Reflection;
using System.Text.RegularExpressions;

namespace ControlLibrary
{
    public partial class PDFReporter : Component
    {
        public PDFReporter()
        {
            InitializeComponent();
        }

        public PDFReporter(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

		public enum Alignment { Vertical, Horizontal }

        /// <param name="format">Строка в Markdown разметке. Поля и свойства указываются с помощью ${...}.</param>
        /// <param name="list">Список продуктов.</param>
        /// <param name="path">Строка вида @"D:\path\to\report.pdf".</param>
        public static void CreatePDFReport<T>(Alignment alignment, string format, List<T> list, string path)
        {
            Type t = typeof(T);
			var columns = format.Split(' ');
			Dictionary<string, PropertyInfo> properties = new Dictionary<string, PropertyInfo>();
			foreach (var c in columns)
			{
				properties.Add(c, t.GetProperties().FirstOrDefault((x) => x.Name == c));
			}

			var table = new List<List<string>>();
			switch (alignment)
			{
				case Alignment.Vertical:
					table.Add(new List<string>(columns));
					foreach (var obj in list)
					{
						var row = new List<string>();
						foreach (var c in columns)
						{
							row.Add(properties[c].GetValue(obj).ToString());
						}
						table.Add(row);
					}
					break;

				case Alignment.Horizontal:
					foreach (var c in columns)
					{
						var row = new List<string>();
						row.Add(c);
						foreach (var obj in list)
						{
							row.Add(properties[c].GetValue(obj).ToString());
						}
						table.Add(row);
					}
					break;
			}

			string s = $"### {t.Name}s\n";

			for (int x = 0; x < table.Count; x++)
			{
				s += String.Join(" | ", table[x]) + "\n";
				if (x == 0)
				{
					var row = new List<string>();
					for (int y = 0; y < table[x].Count; y++)
					{
						row.Add("---");
					}
					s += String.Join(" | ", row) + "\n";
				}
			}

			MarkdownPdf.Transform(s, path);
        }
    }
}
