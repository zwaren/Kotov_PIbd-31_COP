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

        /// <param name="format">Строка в Markdown разметке. Поля и свойства указываются с помощью ${...}.</param>
        /// <param name="list">Список продуктов.</param>
        /// <param name="path">Строка вида @"D:\path\to\report.pdf".</param>
        public static void CreatePDFReport<T>(string format, List<T> list, string path)
        {
            Type t = typeof(T);
            var fields = t.GetFields();
            var properties = t.GetProperties();

            string s = $"# List of {t.Name}s\n";
            foreach (T obj in list)
            {
                string row = format;
                foreach (Match match in new Regex(@"\${[a-zA-Z_0-9]+?}").Matches(format))
                {
                    string fpName = match.Value.Substring(2, match.Value.Length - 3);

                    object field = fields.FirstOrDefault((x) => x.Name == fpName).GetValue(obj);
                    object property = properties.FirstOrDefault((x) => x.Name == fpName).GetValue(obj);
                    string value = (field != null) ? field.ToString() : property.ToString();

                    row = row.Replace(match.Value, value);
                }
                s += row;
            }
            MarkdownPdf.Transform(s, path);
        }
    }
}
