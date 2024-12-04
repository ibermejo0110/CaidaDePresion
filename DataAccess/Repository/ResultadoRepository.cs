using MySql.Data.MySqlClient;
using System.Data;
namespace DataAccess.Repository
{
    public class ResultadoRepository : Data
    {
        public override void Delete()
        {
            try
            {
                Command = GetCommand("delete from resultados", CommandType.Text);
                Command.ExecuteNonQuery();                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Cerrar();
            }
        }
        public override DataTable GetDataTable()
        {
            try
            {
                Command = GetCommand("SELECT id, `Jg(cm/s)`, `DeltaP(Psi)`, `Jsl(cm/s)`, `%Holdup`,`Db(mm)`,`Ub(cm/s)`,`Usg(m/s)`," +
                                     "`Reynold de burbuja`, concentracion_id,`Concentración(ppm)`,  espumante_id,  espumante FROM view_resultados", CommandType.Text);
                DataTable dt = GetTableCommand(Command);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                Cerrar();
            }
        }

        public  DataTable GetDataTableEspumateConcentracion(int espumante,int concentracion)
        {
            try
            {
                Command = GetCommand("select id, `Jg(cm/s)`, `DeltaP(Psi)`, `Jsl(cm/s)`, `%Holdup`,`Db(mm)`," +
                                     "`Ub(cm/s)`,`Usg(m/s)`,`Reynold de burbuja`, concentracion_id,`Concentración(ppm)`," +
                                     "espumante_id,  espumante from view_resultados where espumante_id="
                                     +espumante+" and " +"concentracion_id="+concentracion, CommandType.Text);
                DataTable dt = GetTableCommand(Command);
                return dt;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                Cerrar();
            }
        }
        public override void Save(Dictionary<string, object> colection, ref int id)
        {
            try
            {
                double deltap = Math.Round(double.Parse( colection["deltap"].ToString()),5);
                double jsl =Math.Round(double.Parse( colection["jsl"].ToString()),5);
                double holdup =Math.Round(double.Parse( colection["holdup"].ToString()),5);
                double db = Math.Round(double.Parse( colection["db"].ToString()), 5);   
                double ub =Math.Round (double.Parse( colection["ub"].ToString()),5);
                double reb =Math.Round(double.Parse( colection["reb"].ToString()),5);
                double usg =Math.Round(double.Parse( colection["usg"].ToString()),5);
                double jg =Math.Round(double.Parse( colection["jg"].ToString()),5);
                int.TryParse( colection["concentracion_id"].ToString(),out int concentracion_id);
                int.TryParse(colection["espumante_id"].ToString(),out int espumante_id);                
                Command = GetCommand("Insertar_resultados", CommandType.StoredProcedure);
                Command.Parameters.Add("_deltap", MySqlDbType.Decimal).Value = deltap;
                Command.Parameters.Add("_jsl", MySqlDbType.Decimal).Value =jsl;
                Command.Parameters.Add("_holdup", MySqlDbType.Decimal).Value =holdup;
                Command.Parameters.Add("_db", MySqlDbType.Decimal).Value = db;
                Command.Parameters.Add("_ub", MySqlDbType.Decimal).Value = ub;
                Command.Parameters.Add("_reb", MySqlDbType.Decimal).Value = reb;
                Command.Parameters.Add("_usg", MySqlDbType.Decimal).Value = usg;
                Command.Parameters.Add("_jg", MySqlDbType.Decimal).Value =jg;
                Command.Parameters.Add("_concentracion_id", MySqlDbType.Int32).Value = concentracion_id ;
                Command.Parameters.Add("_espumante_id",MySqlDbType.Int32 ).Value = espumante_id ;
                Command.Parameters.Add("_id_resultado", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                Command.ExecuteNonQuery();
                int.TryParse(Command.Parameters["_id_resultado"].Value.ToString(), out id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Cerrar();
            }
        }
        public DataTable AirHoldupVsJg(int concentracion ,int espumante)
        {
            try
            {
                Command = GetCommand("SELECT `%Holdup`, `Jg(cm/s)` FROM view_resultados where concentracion_id=" + concentracion + " and espumante_id=" + espumante , CommandType.Text);
                DataTable dt = GetTableCommand(Command);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Cerrar();
            }
        }
        public DataTable UsgVsAirHoldup(int concentracion ,int espumante)
        {
            try
            {
                Command = GetCommand("select `%Holdup`,`Usg(m/s)` from view_resultados where concentracion_id=" + concentracion+" and espumante_id="+espumante, CommandType.Text);
                DataTable dt = GetTableCommand(Command);
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Cerrar();
            }
        }
        public DataTable DiámetroBurbujaVsJg( int concentracion ,int espumante )
        {
            try
            {

                Command = GetCommand("select `Db(mm)`,`Jg(cm/s)` from view_resultados where concentracion_id=" + concentracion + " and espumante_id=" + espumante, CommandType.Text);
                DataTable dt = GetTableCommand(Command);
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Cerrar();
            }        
        }
        public DataTable DiámetroBurbujaVsConcentracion( int espumante)
        {
            try
            {
                Command = GetCommand("SELECT `Jg(cm/s)`,`Db(mm)`,`Concentración(ppm)` FROM view_resultados where espumante_id  =" + espumante, CommandType.Text);
                DataTable dt = GetTableCommand(Command);
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Cerrar();
            }
        }
        public override DataTable GetDataTable(int id)
        {
            throw new NotImplementedException();
        }
        public override void Update(Dictionary<string, object> colection, int id)
        {
            throw new NotImplementedException();
        }
        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
