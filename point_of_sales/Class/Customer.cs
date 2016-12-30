using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sql = MySql.Data.MySqlClient;

namespace Latihan_Pos.Class
{
    class Customer
    {
        private static string nama_tabel = "tugas_pos.customer";
        private int id;
        private string nama;
        private string alamat;
        private string kota;
        private string kode_pos;
        private string nomor_telepon;
        private DateTime created_at;
        private DateTime updated_at;

        public Customer()
        { }
        public int getId()
        {
            return this.id;
        }
        public Customer setId(int id)
        {
            this.id = id;
            return this;
        }

        public string getNama()
        {
            return this.nama;
        }
        public Customer setNama(string nama)
        {
            this.nama = nama;
            return this;
        }

        public Customer setAlamat(string alamat)
        {
            this.alamat = alamat;
            return this;
        }

        public string getAlamat()
        {
            return this.alamat;
        }

        public Customer setKota(string kota)
        {
            this.kota = kota;
            return this;
        }

        public string getKota()
        {
            return this.kota;
        }

        public Customer setKodePos(string kode_pos)
        {
            this.kode_pos = kode_pos;
            return this;
        }

        public string getKodePos()
        {
            return this.kode_pos;
        }

        public Customer setNomorTelepon(string nomor_telepon)
        {
            this.nomor_telepon = nomor_telepon;
            return this;
        }

        public string getNomorTelepon()
        {
            return this.nomor_telepon;
        }

        public DateTime getCreatedAt()
        {
            return this.created_at;
        }

        public Customer setCreatedAt(DateTime created_at)
        {
            this.created_at = created_at;
            return this;
        }

        public DateTime getUpdatedAt()
        {
            return this.updated_at;
        }

        public Customer setUpdatedAt(DateTime updated_at)
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

        public static Customer FindOneById(int id)
        {
            Database.OpenConnection();
            string select = String.Concat("SELECT * FROM ", nama_tabel," WHERE id = @id");

            Sql.MySqlDataAdapter da = new Sql.MySqlDataAdapter();

            da.SelectCommand = new Sql.MySqlCommand(select, Database.conn);
            da.SelectCommand.Parameters.AddWithValue("@id", id);

            Sql.MySqlCommandBuilder cb = new Sql.MySqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Database.CloseConnection();

            Customer cust = new Customer();
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                cust.setId(Convert.ToInt32(dr["id"]));
                cust.setNama(dr["nama"].ToString());
                cust.setAlamat(dr["alamat"].ToString());
                cust.setNomorTelepon(dr["nomor_telepon"].ToString());
                cust.setKodePos(dr["kode_pos"].ToString());
                cust.setKota(dr["kota"].ToString());
                cust.setCreatedAt(Convert.ToDateTime(dr["created_at"]));
                cust.setUpdatedAt(Convert.ToDateTime(dr["updated_at"]));

                return cust;
            }

            return null;
        }

        public void Insert()
        {
            Sql.MySqlCommand cmd = Database.conn.CreateCommand();
            string cmdText = String.Concat("INSERT INTO ", nama_tabel, "(nama ,");
            cmdText += " kota, alamat, kode_pos, nomor_telepon, created_at, updated_at) ";
            cmdText += " VALUES (@nama, @alamat, @kota, @kode_pos, @nomor_telepon, @created_at, @updated_at)";

            cmd.Parameters.AddWithValue("@nama", this.nama);
            cmd.Parameters.AddWithValue("@alamat", this.alamat);
            cmd.Parameters.AddWithValue("@kota", this.kota);
            cmd.Parameters.AddWithValue("@kode_pos", this.kode_pos);
            cmd.Parameters.AddWithValue("@nomor_telepon", this.nomor_telepon);
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
            cmdText += "alamat = @alamat, nama = @nama, kota = @kota, kode_pos = @kode_pos";
            cmdText += ", nomor_telepon = @nomor_telepon, updated_at = @updated_at WHERE id = @id";

            cmd.Parameters.AddWithValue("@id", this.id);
            cmd.Parameters.AddWithValue("@nama", this.nama);
            cmd.Parameters.AddWithValue("@alamat", this.alamat);
            cmd.Parameters.AddWithValue("@kota", this.kota);
            cmd.Parameters.AddWithValue("@kode_pos", this.kode_pos);
            cmd.Parameters.AddWithValue("@nomor_telepon", this.nomor_telepon);
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
