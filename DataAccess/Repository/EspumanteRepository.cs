using MySql.Data.MySqlClient;
using System.Data;
namespace DataAccess.Repository
{
    public class EspumanteRepository : Data
    {
        public override void Delete()
        {
            throw new NotImplementedException();
        }
        public override void Delete(int id)
        {
            try
            {
                Command = GetCommand("delete from espumante where id=" + id, CommandType.Text);
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
                Command = GetCommand("select id ,nombre,descripcion from espumante", CommandType.Text);
                DataTable table = GetTableCommand(Command);
                return table;
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

        public override DataTable GetDataTable(int id)
        {
            throw new NotImplementedException();
        }

        public override void Save(Dictionary<string, object> colection, ref int id)
        {
            try
            {
                Command = GetCommand("Insertar_espumante", CommandType.StoredProcedure);
                Command.Parameters.Add("_nombre", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = colection["nombre"].ToString();
                Command.Parameters.Add("_descripcion", MySql.Data.MySqlClient.MySqlDbType.LongText).Value = colection["descripcion"].ToString();
                Command.Parameters.Add("_id_espumante", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                Command.ExecuteNonQuery();
                int.TryParse(Command.Parameters["_id_espumante"].Value.ToString(), out id);
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

        public override void Update(Dictionary<string, object> colection, int id)
        {
            try
            {
                Command = GetCommand("Actualizar_espumante", CommandType.StoredProcedure);
                Command.Parameters.Add("_nombre", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = colection["nombre"].ToString();
                Command.Parameters.Add("_descripcion", MySql.Data.MySqlClient.MySqlDbType.LongText).Value = colection["descripcion"].ToString();
                Command.Parameters.Add("_id", MySqlDbType.Int32).Value = id;
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
    }
}
