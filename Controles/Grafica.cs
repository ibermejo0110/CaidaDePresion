using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Controles
{
    public abstract class Grafica
    {
        static void SetGraphicProperty(Chart grafica, string[] cols)
        {
            grafica.ChartAreas[0].BorderColor = Color.White;
            grafica.ChartAreas[0].BackColor = Color.FromArgb(42, 46, 50);
            grafica.ChartAreas[0].AxisY.LineColor = Color.White;
            grafica.ChartAreas[0].AxisX.LineColor = Color.White;
            grafica.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            grafica.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            grafica.ChartAreas[0].AxisX.TitleForeColor = Color.White;
            grafica.ChartAreas[0].AxisY.TitleForeColor = Color.White;
            grafica.ChartAreas[0].AxisX.Title = cols[0];
            grafica.ChartAreas[0].AxisY.Title = cols[1];
        }
        public static void FillArray(Chart grafica, DataTable table, ref string[] arr)
        {
            int i = 0;
            foreach (DataRow row in table.Rows)
            {
                string serie ="Jg(cm/s) => "+ row["jg(cm/s)"].ToString();
                bool enc =grafica.Series.ToList().Exists(x => x.Name == serie);                
                if (!enc)
                {
                    i++;
                    grafica.Series.Add(serie);
                    Array.Resize(ref arr, i);
                    arr[i - 1] = serie;
                }
            }
        }
        static void GetGraphic(Chart grafica, string TipoGrafica, string serie, string[] cols, DataTable table)
        {
            grafica.Series[serie].ChartType = Enum.Parse<SeriesChartType>(TipoGrafica);
            SetGraphicProperty(grafica, cols);
            foreach (DataRow row in table.Rows)
            {
                double x = double.Parse(row[cols[0]].ToString());
                double y = double.Parse(row[cols[1]].ToString());
                grafica.Series[serie].Points.AddXY(x, y);
            }
        }
        public static void LoadGraphic( DataTable table, string[] arr , Chart grafica,string[] cols,string tipoGrafica ) 
        {
            for (int j = 0; j <= arr.Length - 1; j++)
            {
                string valor = arr[j].Replace("Jg(cm/s) => ", "");
                var search = Table.Busqueda("Jg(cm/s)",valor, table);
                GetGraphic(grafica, tipoGrafica, arr[j], cols, search);
            }
        }
        public static void LoadGraphic( string serie,Chart grafica,DataTable table , string[] cols,string tipoGrafica )
        {
            grafica.Series.Add(serie);
            GetGraphic(grafica, tipoGrafica, serie, cols, table);
        }


    }
}
