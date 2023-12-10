using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zh3ujra1.Models;

using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace zh3ujra1
{
    public partial class ExcelUC : UserControl
    {
        TelefonContext telefonContext = new TelefonContext();
        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;
        public ExcelUC()
        {
            InitializeComponent();
        }

        private void excelbttn_Click(object sender, EventArgs e)
        {
            try
            {
                xlApp = new Excel.Application();
                xlWB = xlApp.Workbooks.Add(Missing.Value);
                xlSheet = xlWB.ActiveSheet;
                TáblaKészítés();
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }
        private void TáblaKészítés()
        {
            string[] fejlécek = new string[]
            {
                "Név",
                "Szülidő",
                "Telszám",
                "Email",
                "CsomaID",
                "BővíthetőE"
            };
            for (int i = 0; i < fejlécek.Length; i++)
            {
                xlSheet.Cells[1, i + 1] = fejlécek[i];
            }

            var adatok = telefonContext.Ügyfeleks.ToList();

            object[,] adatTömb = new object[adatok.Count(), fejlécek.Count()];
            for (int i = 0; i < adatok.Count(); i++)
            {
                adatTömb[i, 0] = adatok[i].Név;
                adatTömb[i, 1] = adatok[i].SzülIdő;
                adatTömb[i, 2] = adatok[i].TelSzám;
                adatTömb[i, 3] = adatok[i].Email;
                adatTömb[i, 4] = adatok[i].CsomagId;
                adatTömb[i, 5] = adatok[i].BővíthetőE;

            }
            int sorokSzáma = adatTömb.GetLength(0);
            int oszlopokSzáma = adatTömb.GetLength(1);

            Excel.Range adatRange = xlSheet.get_Range("A2", Type.Missing).get_Resize(sorokSzáma, oszlopokSzáma);
            adatRange.Value2 = adatTömb;

            adatRange.Columns.AutoFit();

            Excel.Range fejllécRange = xlSheet.get_Range("A1", Type.Missing).get_Resize(1, 6);
            fejllécRange.Font.Bold = true;

        }

        private void diagrambttn_Click(object sender, EventArgs e)
        {
            var excelApp = new Excel.Application();
            excelApp.Visible = true;

            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

            worksheet.Cells[1, "A"] = "Data Set";
            worksheet.Cells[2, "A"] = "Point 1";
            worksheet.Cells[3, "A"] = "Point 2";
            worksheet.Cells[4, "A"] = "Point 3";
            worksheet.Cells[5, "A"] = "Point 4";

            worksheet.Cells[1, "B"] = "Value";
            worksheet.Cells[2, "B"] = 10;
            worksheet.Cells[3, "B"] = 20;
            worksheet.Cells[4, "B"] = 30;
            worksheet.Cells[5, "B"] = 40;

            Excel.Range chartRange = worksheet.get_Range("A1", "B5");

            Excel.ChartObjects xlCharts = (Excel.ChartObjects)worksheet.ChartObjects(Type.Missing);
            Excel.ChartObject myChart = xlCharts.Add(10, 80, 300, 250);
            Excel.Chart chartPage = myChart.Chart;

            chartPage.SetSourceData(chartRange);

            chartPage.ChartType = Excel.XlChartType.xlLine;
            chartPage.ChartWizard(Source: chartRange,
                Title: "Example Chart",
                CategoryTitle: "Data Set",
                ValueTitle: "Value");
        }
    }
}
