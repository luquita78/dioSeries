using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace dioSeries
{
    public class Database
    {


        private MySqlConnection conn;
        private DataTable data;
        private MySqlDataAdapter da;
        private MySqlDataReader dr;
        private MySqlCommandBuilder cb;


        public static String server = "127.0.0.1";
        public static String user = "root";
        public static String password = "*P4percut45";
        public static String database = "dbSeriesDIO";



        public void Conectar()
        {
            if (conn != null)
                conn.Close();


            string connStr = String.Format("Server={0};user id={1};password={2}; database={3};pooling=false", server, user, password, database);


            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }


        }


        public long ExecutarComandoSQL(string comandoSql, bool ReturnLastInsertedId = false)
        {
            MySqlCommand comando = new MySqlCommand(comandoSql, conn);
            comando.ExecuteNonQuery();
            long id = comando.LastInsertedId;
            conn.Close();
            if (ReturnLastInsertedId == true)
            {
                return id;
            }
            else
            {
                return 0;
            }
        }


        public DataTable RetDataTable(string sql)
        {
            data = new DataTable();
            da = new MySqlDataAdapter(sql, conn);
            cb = new MySqlCommandBuilder(da);
            da.Fill(data);


            return data;
        }


        public MySqlDataReader RetDataReader(string sql)
        {
            MySqlCommand comando = new MySqlCommand(sql, conn);
            MySqlDataReader dr = comando.ExecuteReader();
            return dr;
        }
    }
}