using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace ControlLibrary
{
    public partial class WordDiagramCreater : Component
    {
        public WordDiagramCreater()
        {
            InitializeComponent();
        }

        public WordDiagramCreater(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        /// <typeparam name="T"></typeparam>
        /// <param name="prods">Список продуктов.</param>
        /// <param name="name">Название свойства содержащего имя продукта.</param>
        /// <param name="count">Название свойства содержащего количество продукта.</param>
        /// <param name="path">Строка вида @"D:\path\to\diagram.docx".</param>
        public static void CreateDiagram<T>(List<T> prods, string name, string count, string path)
        {
            DocX doc = DocX.Create(path);

            BarChart barChart = new BarChart();
            barChart.AddLegend(ChartLegendPosition.Top, false);

            Series series = new Series("Products");
            series.Bind(prods, name, count);
            barChart.AddSeries(series);

            doc.InsertChart(barChart);

            doc.Save();
        }
    }
}
