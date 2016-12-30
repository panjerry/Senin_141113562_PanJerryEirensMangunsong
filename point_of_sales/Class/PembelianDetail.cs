using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sql = MySql.Data.MySqlClient;

namespace Latihan_Pos.Class
{
    class PembelianDetail
    {
        private static string nama_tabel = "tugas_pos.pembelian_detail";
        private int id;
        private Pembelian pembelian;
        private Barang barang;
        private decimal harga_barang;
        private int kuantitas;
        private DateTime created_at;
        private DateTime updated_at;

        public PembelianDetail()
        { }

        public int getId()
        {
            return this.id;
        }
        public PembelianDetail setId(int id)
        {
            this.id = id;
            return this;
        }

        public Pembelian getPembelian()
        {
            return this.pembelian;
        }
        public PembelianDetail setPembelian(Pembelian pembelian)
        {
            this.pembelian = pembelian;
            return this;
        }

        public Barang getBarang()
        {
            return this.barang;
        }
        public PembelianDetail setBarang(Barang barang)
        {
            this.barang = barang;
            return this;
        }

        public int getKuantitas()
        {
            return this.kuantitas;
        }
        public PembelianDetail setKuantitas(int kuantitas)
        {
            this.kuantitas = kuantitas;
            return this;
        }

        public decimal getHargaBarang()
        {
            return this.harga_barang;
        }

        public PembelianDetail setHargaBarang(decimal harga_barang)
        {
            this.harga_barang = harga_barang;
            return this;
        }

        public DateTime getCreatedAt()
        {
            return this.created_at;
        }

        public PembelianDetail setCreatedAt(DateTime created_at)
        {
            this.created_at = created_at;
            return this;
        }

        public DateTime getUpdatedAt()
        {
            return this.updated_at;
        }

        public PembelianDetail setUpdatedAt(DateTime updated_at)
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

        public static DataTable FindByIdPembelian(int id_pembelian)
        {
            Database.OpenConnection();
            string select = String.Concat("SELECT * FROM ", nama_tabel, " WHERE id_pembelian = @id_pembelian");

            Sql.MySqlDataAdapter da = new Sql.MySqlDataAdapter();

            da.SelectCommand = new Sql.MySqlCommand(select, Database.conn);
            da.SelectCommand.Parameters.AddWithValue("@id_pembelian", id_pembelian);

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

        public static PembelianDetail FindOneById(int id)
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

            PembelianDetail pembelianDetail = new PembelianDetail();
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                pembelianDetail.setId(Convert.ToInt32(dr["id"]));
                pembelianDetail.setBarang(Barang.FindOneById(Convert.ToInt32(dr["id_barang"])));
                pembelianDetail.setPembelian(Pembelian.FindOneById(Convert.ToInt32(dr["id_pembelian"])));
                pembelianDetail.setKuantitas(Convert.ToInt32(dr["kuantitas"]));
                pembelianDetail.setHargaBarang(Convert.ToDecimal(dr["harga_barang"]));
                pembelianDetail.setCreatedAt(Convert.ToDateTime(dr["created_at"]));
                pembelianDetail.setUpdatedAt(Convert.ToDateTime(dr["updated_at"]));

                return pembelianDetail;
            }

            return null;
        }

        public static PembelianDetail FindOneByIdBarangAndIdPembelian(int id_barang, int id_pembelian)
        {
            Database.OpenConnection();
            string select = String.Concat("SELECT * FROM ", nama_tabel, " WHERE id_barang = @id_barang " +
                                          "AND id_pembelian = @id_pembelian");

            Sql.MySqlDataAdapter da = new Sql.MySqlDataAdapter();

            da.SelectCommand = new Sql.MySqlCommand(select, Database.conn);
            da.SelectCommand.Parameters.AddWithValue("@id_barang", id_barang);
            da.SelectCommand.Parameters.AddWithValue("@id_pembelian", id_pembelian);

            Sql.MySqlCommandBuilder cb = new Sql.MySqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Database.CloseConnection();

            PembelianDetail pembelianDetail = new PembelianDetail();
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                pembelianDetail.setId(Convert.ToInt32(dr["id"]));
                pembelianDetail.setBarang(Barang.FindOneById(Convert.ToInt32(dr["id_barang"])));
                pembelianDetail.setPembelian(Pembelian.FindOneById(Convert.ToInt32(dr["id_pembelian"])));
                pembelianDetail.setKuantitas(Convert.ToInt32(dr["kuantitas"]));
                pembelianDetail.setHargaBarang(Convert.ToDecimal(dr["harga_barang"]));
                pembelianDetail.setCreatedAt(Convert.ToDateTime(dr["created_at"]));
                pembelianDetail.setUpdatedAt(Convert.ToDateTime(dr["updated_at"]));

                return pembelianDetail;
            }

            return null;
        }

        public void Insert()
        {
            Sql.MySqlCommand cmd = Database.conn.CreateCommand();
            string cmdText = String.Concat("INSERT INTO ", nama_tabel, "(");
            cmdText += " id_pembelian, id_barang, harga_barang, kuantitas, created_at, updated_at) ";
            cmdText += " VALUES (@id_pembelian, @id_barang, @harga_barang, @kuantitas, @created_at, @updated_at)";

            cmd.Parameters.AddWithValue("@id_pembelian", this.pembelian.getId());
            cmd.Parameters.AddWithValue("@id_barang", this.barang.getId());
            cmd.Parameters.AddWithValue("@harga_barang", this.harga_barang);
            cmd.Parameters.AddWithValue("@kuantitas", this.kuantitas);
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
            cmdText += "id_pembelian = @id_pembelian, id_barang = @id_barang, harga_barang = @harga_barang";
            cmdText += ", kuantitas = @kuantitas, updated_at = @updated_at WHERE id = @id";

            cmd.Parameters.AddWithValue("@id_pembelian", this.pembelian.getId());
            cmd.Parameters.AddWithValue("@id_barang", this.barang.getId());
            cmd.Parameters.AddWithValue("@harga_barang", this.harga_barang);
            cmd.Parameters.AddWithValue("@kuantitas", this.kuantitas);
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
