using System.Data;
namespace Controles
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

        public static DataTable GetTerminos(string termino, double[] valores)
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
        public static DataTable GetInitialValues()
        {
            string[] columns = { "Variable", "Resultado" };
            DataTable dt = GetDataTable(columns);
            string[] values = { "Densidad de la particula (kg/m3)",CaidaDePresion. rop.ToString() };
            SetRow(dt, columns, values);
            string[] values2 = { "Densidad del slurry (kg/m^3)",CaidaDePresion. rosl.ToString() };
            SetRow(dt, columns, values2);
            string[] values3 = { "Densidad del aire (kg/m^3)",CaidaDePresion. rog.ToString() };
            SetRow(dt, columns, values3);
            string[] value4 = { "Viscosidad del slurry (kg/m-s)",CaidaDePresion. miusl.ToString() };
            SetRow(dt, columns, value4);
            string[] values5 = { "m", CaidaDePresion.m.ToString() };
            SetRow(dt, columns, values5);
            string[] values6 = { "Densidad de la particula (kg/m3)", CaidaDePresion.rog.ToString() };
            SetRow(dt, columns, values6);
            string[] values7 = { "Presion de entrada (atm)", CaidaDePresion.pent.ToString() };
            SetRow(dt, columns, values7);
            string[] values8 = { "Densidad del agua (kg/m3)", CaidaDePresion.row.ToString() };
            SetRow(dt, columns, values8);
            string[] values9 = { "Porcentaje p/p del slurry (%p/p)", CaidaDePresion. Cs1.ToString() };
            SetRow(dt, columns, values9);
            string[] values10 = { "Deltha de L, medicion del holdup (m)", CaidaDePresion.dl.ToString() };
            SetRow(dt, columns, values10);
            string[] values11 = { "Temperatura (K)", CaidaDePresion.T.ToString() };
            SetRow(dt, columns, values11);
            string[] values12 = { "Viscosidad del agua(Kg/ms", CaidaDePresion.miuw.ToString() };
            SetRow(dt, columns, values12);
            string[] values13 = { "Peso molecular del gas (kg/kmol)", CaidaDePresion.pmg.ToString() };
            SetRow(dt, columns, values13);
            string[] values14 = { "gravedad (kg/m^2)", CaidaDePresion.g.ToString() };
            SetRow(dt, columns, values14);
            string[] values15 = { "Diametro de la particula (m)", CaidaDePresion.dp.ToString() };
            SetRow(dt, columns, values15);
            return dt;
        }
        
        static DataColumn[] GetColumns(DataTable tabla )
        { 
            DataColumn[] columns=new DataColumn [tabla.Columns.Count ];
            tabla.Columns.CopyTo(columns, 0);      
            return columns;
        }
        public static DataTable Busqueda(string filtro, string valor, DataTable Tabla)
        {
            try
            {
                DataTable TablaDatos=new();
                DataColumn[] columns = GetColumns(Tabla);                
                DataColumn column = columns.ToList().Where(x => x.ColumnName == filtro).FirstOrDefault();
                string tipo  = column != null ? column.DataType.Name : ""; 
                switch (tipo)
                {
                    case "Decimal":
                        {
                            var query = (from tab in Tabla.AsEnumerable()
                                         where tab.Field<decimal>(filtro) == decimal.Parse(valor)
                                         select tab);
                            TablaDatos = query.ToList().Count != 0 ? query.CopyToDataTable() : Tabla;
                            break;
                        }
                    case "String":
                        {
                            var query = (from tab in Tabla.AsEnumerable()
                                         where tab.Field<string>(filtro).Contains(valor)
                                         select tab);
                            TablaDatos = query.ToList().Count != 0 ? query.CopyToDataTable() : Tabla;
                            break ;
                        }
                }
                return TablaDatos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
