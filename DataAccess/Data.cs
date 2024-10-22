using MySql.Data.MySqlClient;
using System.Data;
namespace DataAccess
{
    public abstract class Data
    {
        protected MySqlConnection Connection { get; set; }
        protected MySqlCommand? Command { get; set; }
        protected MySqlDataAdapter? DataAdapter { get; set; }
        public Data(string server = "127.0.0.1", string uid = " root", string pwd = "", string database = "caidapresion")
        {
            Connection = new () { ConnectionString = "server=" + server + ";uid=" + uid + ";pwd=" + pwd + ";database=" + database };
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
        
      
        protected  void Cerrar( )
        {
            Connection.Close();
        }
    }
}
