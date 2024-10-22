using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
namespace CaidaPresion.Utilities
{
    public abstract class Table
    {
        public static DataTable GetDataTable(string[] columns)
        {
            DataTable dt = new DataTable();
            for (int i = 0; i <= columns.Length - 1; i++)
            {
                dt.Columns.Add(columns[i]);
            }
            return dt;
        }
        public static void SetRow(DataTable dt, string[] column, string[] values)
        {
            DataRow row = dt.NewRow();
            row[column[0]] = values[0];
            row[column[1]] = values[1];
            dt.Rows.Add(row);
        }
        public static DataTable getTerminos(string termino, double[] valores)
        {
            string[] columns = { "Valores " + termino, "Resultado" };
            DataTable dt = GetDataTable(columns);
            double[] datos = valores != null ? valores : new double[] { };
            for (int i = 0; i <= datos.Length - 1; i++)
            {
                int c = i + 1;
                DataRow row = dt.NewRow();
                row[columns[0]] = "valor " + c.ToString();
                row[columns[1]] = datos[i];
                dt.Rows.Add(row);

            }
            return dt;
        }
    }
}
