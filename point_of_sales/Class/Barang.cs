using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sql = MySql.Data.MySqlClient;

namespace Latihan_Pos.Class
{
    class Barang
    {
        private static string nama_tabel = "tugas_pos.barang";
        private int id;
        private string kode;
        private string nama;
        private int jumlah;
        private decimal harga_hpp;
        private decimal harga_jual;
        private DateTime created_at;
        private DateTime updated_at;

        public Barang()
        { }

        public int getId()
        {
            return this.id;
        }
        public Barang setId(int id)
        {
            this.id = id;
            return this;
        }

        public string getKode()
        {
            return this.kode;
        }
        
        public Barang setKode(string kode)
        {
            this.kode = kode;
            return this;
        }

        public string getNama()
        {
            return this.nama;
        }

        public Barang setNama(string nama)
        {
            this.nama = nama;
            return this;
        }

        public int getJumlah()
        {
            return this.jumlah;
        }
        public Barang setJumlah(int jumlah)
        {
            this.jumlah = jumlah;
            return this;
        }

        public decimal getHargaHpp()
        {
            return this.harga_hpp;
        }

        public Barang setHargaHpp(decimal harga_hpp)
        {
            this.harga_hpp = harga_hpp;
            return this;
        }

        public decimal getHargaJual()
        {
            return this.harga_jual;
        }

        public Barang setHargaJual(decimal harga_jual)
        {
            this.harga_jual = harga_jual;
            return this;
        }

        public DateTime getCreatedAt()
        {
            return this.created_at;
        }

        public Barang setCreatedAt(DateTime created_at)
        {
            this.created_at = created_at;
            return this;
        }

        public DateTime getUpdatedAt()
        {
            return this.updated_at;
        }

        public Barang setUpdatedAt(DateTime updated_at)
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

        public static Barang FindOneById(int id)
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

            Barang barang = new Barang();
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                barang.setId(Convert.ToInt32(dr["id"]));
                barang.setNama(dr["nama"].ToString());
                barang.setKode(dr["kode"].ToString());
                barang.setJumlah(Convert.ToInt32(dr["jumlah"]));
                barang.setHargaHpp(Convert.ToDecimal(dr["harga_hpp"]));
                barang.setHargaJual(Convert.ToDecimal(dr["harga_jual"]));
                barang.setCreatedAt(Convert.ToDateTime(dr["created_at"]));
                barang.setUpdatedAt(Convert.ToDateTime(dr["updated_at"]));

                return barang;
            }

            return null;
        }

        public void Insert()
        {
            Sql.MySqlCommand cmd = Database.conn.CreateCommand();
            string cmdText = String.Concat("INSERT INTO ", nama_tabel, "(nama ,");
            cmdText += " kode, jumlah, harga_hpp, harga_jual, created_at, updated_at) ";
            cmdText += " VALUES (@nama, @kode, @jumlah, @harga_hpp, @harga_jual, @created_at, @updated_at)";

            cmd.Parameters.AddWithValue("@nama", this.nama);
            cmd.Parameters.AddWithValue("@kode", this.kode);
            cmd.Parameters.AddWithValue("@jumlah", this.jumlah);
            cmd.Parameters.AddWithValue("@harga_hpp", this.harga_hpp);
            cmd.Parameters.AddWithValue("@harga_jual", this.harga_jual);
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
            cmdText += "kode = @kode, nama = @nama, jumlah = @jumlah, harga_hpp = @harga_hpp";
            cmdText += ", harga_jual = @harga_jual, updated_at = @updated_at WHERE id = @id";

            cmd.Parameters.AddWithValue("@nama", this.nama);
            cmd.Parameters.AddWithValue("@kode", this.kode);
            cmd.Parameters.AddWithValue("@jumlah", this.jumlah);
            cmd.Parameters.AddWithValue("@harga_hpp", this.harga_hpp);
            cmd.Parameters.AddWithValue("@harga_jual", this.harga_jual);
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
