using IronXL;
using StoreDAL.BMs;
using StoreDAL.Is;
using StoreDAL.VMs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ProductPurchase
{
    public partial class Form1 : Form
    {
        IProductService pService;
        ICategoryService cService;

        private string FieldType = "Name Count";


        public Form1(IProductService pService, ICategoryService cService)
        {
            InitializeComponent();
            this.pService = pService;
            this.cService = cService;
            DialogResult = DialogResult.OK;
        }

        public void CreateExcelReport<T>(List<T> toReport, string path)
        {
            WorkBook xlsxWorkbook = WorkBook.Create(ExcelFileFormat.XLSX);
            WorkSheet xlsSheet = xlsxWorkbook.CreateWorkSheet("main_sheet");

            var props = typeof(T).GetProperties().Where((x) => FieldType.Split(' ').Contains(x.Name)).ToList();

            int propsLength = props.Capacity;
            string[] cells = { "A", "B", "C", "D", "E", "F", "G" };
            int j = 0;
            string cell;
            foreach (var p in toReport)
            {
                for (int i = 1; i < propsLength; i++)
                {
                    cell = cells[i - 1];
                    cell += j + 1;
                    xlsSheet[cell].Value = props[i - 1].GetValue(p).ToString();
                }
                j++;
            }
            xlsxWorkbook.SaveAs(path + ".xlsx");
        }

        private void PrintExcelReport(string path)
        {
            Excel.Application excelApp = new Excel.Application();

            Excel.Workbook wb = excelApp.Workbooks.Open(
                path,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets[1];

            var printers = System.Drawing.Printing.PrinterSettings.InstalledPrinters;

            int printerIndex = 0;

            foreach (String s in printers)
            {
                if (s.Equals("Name of Printer"))
                {
                    break;
                }
                printerIndex++;
            }

            ws.PrintOut(1, 2, 1, false, printers[printerIndex], true, false, Type.Missing);
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            SaveFileDialog path = new SaveFileDialog();
            if (path.ShowDialog() == DialogResult.OK)
            {
                CreateExcelReport(pService.GetList(), path.FileName);
            }
        }

        private void bPrint_Click(object sender, EventArgs e)
        {
            SaveFileDialog path = new SaveFileDialog();
            if (path.ShowDialog() == DialogResult.OK)
            {
                PrintExcelReport(path.FileName);
            }
        }
    }
}
