using System.Data;
namespace DataAccess.Repository
{
    public class ConcentracionRepository : Data
    {
        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override DataTable GetDataTable()
        {
            try
            {
                Abrir();
                Command = GetCommand("select id,nombre from concentracion" , CommandType.Text);
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
            try
            {
                Abrir();
                Command = GetCommand("select concentracion_id,concentracion from view_espumante_concentracion where espumante_id=" + id, CommandType.Text);
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

        public override void Save(Dictionary<string, object> colection,ref int id)
        {
           
        }

        public override void Update(Dictionary<string, object> colection, int id)
        {
            throw new NotImplementedException();
        }
    }
}
