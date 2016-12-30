using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sql = MySql.Data.MySqlClient;

namespace Latihan_Pos.Class
{
    class Penjualan
    {
        private static string nama_tabel = "tugas_pos.penjualan";
        private int id;
        private string kode;
        private Customer customer;
        private DateTime created_at;
        private DateTime updated_at;

        public Penjualan()
        { }

        public int getId()
        {
            return this.id;
        }
        public Penjualan setId(int id)
        {
            this.id = id;
            return this;
        }
        public string getKode()
        {
            return this.kode;
        }

        public Penjualan setKode(string kode)
        {
            this.kode = kode;
            return this;
        }

        public Customer getCustomer()
        {
            return this.customer;
        }
        public Penjualan setCustomer(Customer customer)
        {
            this.customer = customer;
            return this;
        }

        public DateTime getCreatedAt()
        {
            return this.created_at;
        }

        public Penjualan setCreatedAt(DateTime created_at)
        {
            this.created_at = created_at;
            return this;
        }

        public DateTime getUpdatedAt()
        {
            return this.updated_at;
        }

        public Penjualan setUpdatedAt(DateTime updated_at)
        {
            this.updated_at = updated_at;
            return this;
        }

        public static DataTable FindAll()
        {
            Database.OpenConnection();
            string select = String.Concat("SELECT * FROM ", nama_tabel);

            Sql.MySqlDataAdapter da = new Sql.MySqlDataAdapter(select, Database.conn);

            Sql.MySqlCommandBuilder cb = new Sql.MySqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Database.CloseConnection();

            DataTable dt = ds.Tables[0].Clone();

            foreach (DataColumn dc in dt.Columns)
            {
                dc.DataType = typeof(string);
            }

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                dt.ImportRow(row);
            }
            return dt;
        }
        public static Penjualan FindOneById(int id)
        {
            Database.OpenConnection();
            string select = String.Concat("SELECT * FROM ", nama_tabel, " WHERE id = @id");

            Sql.MySqlDataAdapter da = new Sql.MySqlDataAdapter();

            da.SelectCommand = new Sql.MySqlCommand(select, Database.conn);
            da.SelectCommand.Parameters.AddWithValue("@id", id);

            Sql.MySqlCommandBuilder cb = new Sql.MySqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Database.CloseConnection();

            Penjualan penjualan = new Penjualan();

            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                penjualan.setId(Convert.ToInt32(dr["id"]));
                penjualan.setKode(dr["kode"].ToString());
                penjualan.setCustomer(Customer.FindOneById(Convert.ToInt16(dr["id_customer"])));
                penjualan.setCreatedAt(Convert.ToDateTime(dr["created_at"]));
                penjualan.setUpdatedAt(Convert.ToDateTime(dr["updated_at"]));

                return penjualan;
            }
            return null;
        }
        public static Penjualan FindOneByKode(string kode)
        {
            Database.OpenConnection();
            string select = String.Concat("SELECT * FROM ", nama_tabel, " WHERE kode = @kode");

            Sql.MySqlDataAdapter da = new Sql.MySqlDataAdapter();

            da.SelectCommand = new Sql.MySqlCommand(select, Database.conn);
            da.SelectCommand.Parameters.AddWithValue("@kode", kode);

            Sql.MySqlCommandBuilder cb = new Sql.MySqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Database.CloseConnection();

            Penjualan penjualan = new Penjualan();

            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                penjualan.setId(Convert.ToInt32(dr["id"]));
                penjualan.setKode(dr["kode"].ToString());
                penjualan.setCustomer(Customer.FindOneById(Convert.ToInt16(dr["id_customer"])));
                penjualan.setCreatedAt(Convert.ToDateTime(dr["created_at"]));
                penjualan.setUpdatedAt(Convert.ToDateTime(dr["updated_at"]));

                return penjualan;
            }
            return null;
        }

        public void Insert()
        {
            Sql.MySqlCommand cmd = Database.conn.CreateCommand();
            string cmdText = String.Concat("INSERT INTO ", nama_tabel, "(id_customer ,");
            cmdText += " kode, created_at, updated_at) ";
            cmdText += " VALUES (@id_customer, @kode, @created_at, @updated_at)";
            cmd.Parameters.AddWithValue("@id_customer", this.customer.getId());
            cmd.Parameters.AddWithValue("@kode", this.kode);
            cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
            cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);

            cmd.CommandText = cmdText;
            try
            {
                Database.OpenConnection();
                cmd.ExecuteNonQuery();
                Database.CloseConnection();
            }
            catch (Exception ex)
            {
                Database.CloseConnection();
                throw new Exception(ex.Message);
            }
        }

        public void Update()
        {
            Sql.MySqlCommand cmd = Database.conn.CreateCommand();
            string cmdText = "UPDATE " + nama_tabel + " SET ";
            cmdText += "id_customer = @id_customer, kode = @kode";
            cmdText += ", updated_at = @updated_at WHERE id = @id";

            cmd.Parameters.AddWithValue("@id_customer", this.customer.getId());
            cmd.Parameters.AddWithValue("@kode", this.kode);
            cmd.Parameters.AddWithValue("@id", this.id);
            cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
            cmd.CommandText = cmdText;
            try
            {
                Database.OpenConnection();
                cmd.ExecuteNonQuery();
                Database.CloseConnection();
            }
            catch (Exception ex)
            {
                Database.CloseConnection();
                throw new Exception(ex.Message);
            }
        }

        public void Delete()
        {
            Sql.MySqlCommand cmd = Database.conn.CreateCommand();
            string cmdText = "DELETE FROM " + nama_tabel + " WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", this.id);
            cmd.CommandText = cmdText;
            try
            {
                Database.OpenConnection();
                cmd.ExecuteNonQuery();
                Database.CloseConnection();
            }
            catch (Exception ex)
            {
                Database.CloseConnection();
                throw new Exception(ex.Message);
            }
        }
    }
}
