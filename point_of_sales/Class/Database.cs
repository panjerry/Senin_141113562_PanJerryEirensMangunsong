
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sql = MySql.Data.MySqlClient;
namespace Latihan_Pos.Class
{
    class Database
    {
        private static string connectionString = "Server=localhost;Uid=root;Pwd=xCJxNr2U5xan9U6Z;";
        public static Sql.MySqlConnection conn = new Sql.MySqlConnection();
        public static void OpenConnection()
        {
            try
            {
                conn.ConnectionString = connectionString;
                conn.Open();
            }
            catch (Sql.MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void CloseConnection()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }
    }
}
