using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles
{
    public class Excel
    {
        Microsoft.Office.Interop.Excel.Application ExcelApp;
        string hoja = "Hoja";

        public Excel() 
        {
        }
        Microsoft.Office.Interop.Excel.Worksheet GetSheet(System.Data.DataTable table, Microsoft.Office.Interop.Excel.Application ExcelApp, string hoja)
        {
            Microsoft.Office.Interop.Excel.Worksheet WorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelApp.Sheets[hoja];
            WorkSheet.Name = table.TableName;
            WorkSheet.Cells[1, 1] = table.TableName;
            WorkSheet.Range["A1:H1"].MergeCells = true;   // MERGE CELLS OF THE HEADER.
            return WorkSheet;
        }
        void SetColumnSheet(DataTable table, Microsoft.Office.Interop.Excel.Worksheet WorkSheet)
        {
            int iRowCnt = 2;
            int col = 1;
            foreach (DataColumn column in table.Columns)
            {
                WorkSheet.Cells[iRowCnt, col] = column.ColumnName;
                col += 1;
            }
        }
        void SetRowsSheet(DataTable table, Microsoft.Office.Interop.Excel.Worksheet WorkSheet)
        {
            int iRowCnt = 3;
            foreach (DataRow row in table.Rows)
            {
                int col = 1;
                foreach (DataColumn column in table.Columns)
                {
                    WorkSheet.Cells[iRowCnt, col] = row[column];
                    col += 1;
                }
                iRowCnt += 1;
            }
        }
        public void ExportarDatos(DataSet db)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Worksheet WorkSheet;
                ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Workbooks.Add();
                int cont = 1;
                foreach (DataTable table in db.Tables)
                {
                    WorkSheet = GetSheet(table, ExcelApp, hoja + cont.ToString());
                    SetColumnSheet(table, WorkSheet);
                    SetRowsSheet(table, WorkSheet);  
                    ExcelApp.Sheets.Add();
                    cont += 1;
                }
                WorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelApp.Sheets[hoja + cont.ToString()];
                WorkSheet.Delete();
                ExcelApp.Visible = true;
                ExcelApp = null; 
                WorkSheet = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
