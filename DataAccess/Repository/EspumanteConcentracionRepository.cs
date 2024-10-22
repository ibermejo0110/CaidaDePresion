using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class EspumanteConcentracionRepository : Data
    {
        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override DataTable GetDataTable()
        {
            throw new NotImplementedException();
        }

        public override DataTable GetDataTable(int id)
        {
            throw new NotImplementedException();
        }

        public override void Save(Dictionary<string, object> colection, ref int id)
        {
            try
            {
                Abrir();
                Command = GetCommand("insertar_espumante_concentracion", CommandType.StoredProcedure);
                Command.Parameters.Add("_espumante_id", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = int.Parse(colection["espumante_id"].ToString());
                Command.Parameters.Add("_concentracion_id", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = int.Parse(colection["concentracion_id"].ToString());
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

        public override void Update(Dictionary<string, object> colection, int id)
        {
            throw new NotImplementedException();
        }
    }
}
