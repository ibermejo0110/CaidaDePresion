using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
namespace DataAccess
{
    public abstract class Data
    {     
        protected MySqlCommand? Command { get; set; }
        protected MySqlDataAdapter? DataAdapter { get; set; }        
        private string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["caidapresion"].ConnectionString;
            }
        }
        private MySqlConnection _conection;
        protected MySqlConnection Connection
        {
            get
            {
                _conection = new() { ConnectionString = ConnectionString };
                return _conection;
            }
        }
        public abstract void Save(Dictionary<string, object> colection, ref int id);
        public abstract DataTable GetDataTable();
        public abstract DataTable GetDataTable(int id);
        public abstract void Update(Dictionary<string, object> colection, int id);
        public abstract void Delete(int id);
        public abstract void Delete();
        protected void Abrir()
        {
            Connection.Open();
        }
        protected DataTable GetTableCommand(MySqlCommand command)
        {
            DataTable dt = new();
            DataAdapter = new () { SelectCommand = command };
            DataAdapter.Fill(dt);
            return dt;
        }
        protected MySqlCommand GetCommand(string sql, CommandType type)
        {
            MySqlCommand command = new ()
            {
                Connection = Connection,
                CommandType = type,
                CommandText = sql
            };
            return command;
        }  
        protected void Cerrar()
        {
            Connection.Close();
        }
    }
}
