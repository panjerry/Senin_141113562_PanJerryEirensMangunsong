using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sql = MySql.Data.MySqlClient;

namespace Latihan_Pos.Class
{
    class PenjualanDetail
    {
        private static string nama_tabel = "tugas_pos.penjualan_detail";
        private int id;
        private Penjualan penjualan;
        private Barang barang;
        private decimal harga_barang;
        private int kuantitas;
        private DateTime created_at;
        private DateTime updated_at;

        public PenjualanDetail()
        { }

        public int getId()
        {
            return this.id;
        }
        public PenjualanDetail setId(int id)
        {
            this.id = id;
            return this;
        }

        public Penjualan getPenjualan()
        {
            return this.penjualan;
        }
        public PenjualanDetail setPenjualan(Penjualan penjualan)
        {
            this.penjualan = penjualan;
            return this;
        }

        public Barang getBarang()
        {
            return this.barang;
        }
        public PenjualanDetail setBarang(Barang barang)
        {
            this.barang = barang;
            return this;
        }

        public int getKuantitas()
        {
            return this.kuantitas;
        }
        public PenjualanDetail setKuantitas(int kuantitas)
        {
            this.kuantitas = kuantitas;
            return this;
        }

        public decimal getHargaBarang()
        {
            return this.harga_barang;
        }

        public PenjualanDetail setHargaBarang(decimal harga_barang)
        {
            this.harga_barang = harga_barang;
            return this;
        }

        public DateTime getCreatedAt()
        {
            return this.created_at;
        }

        public PenjualanDetail setCreatedAt(DateTime created_at)
        {
            this.created_at = created_at;
            return this;
        }

        public DateTime getUpdatedAt()
        {
            return this.updated_at;
        }

        public PenjualanDetail setUpdatedAt(DateTime updated_at)
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

        public static DataTable FindByIdPenjualan(int id_penjualan)
        {
            Database.OpenConnection();
            string select = String.Concat("SELECT * FROM ", nama_tabel, " WHERE id_penjualan = @id_penjualan");

            Sql.MySqlDataAdapter da = new Sql.MySqlDataAdapter();

            da.SelectCommand = new Sql.MySqlCommand(select, Database.conn);
            da.SelectCommand.Parameters.AddWithValue("@id_penjualan", id_penjualan);

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

        public static PenjualanDetail FindOneById(int id)
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

            PenjualanDetail penjualanDetail = new PenjualanDetail();
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                penjualanDetail.setId(Convert.ToInt32(dr["id"]));
                penjualanDetail.setBarang(Barang.FindOneById(Convert.ToInt32(dr["id_barang"])));
                penjualanDetail.setPenjualan(Penjualan.FindOneById(Convert.ToInt32(dr["id_penjualan"])));
                penjualanDetail.setKuantitas(Convert.ToInt32(dr["kuantitas"]));
                penjualanDetail.setHargaBarang(Convert.ToDecimal(dr["harga_barang"]));
                penjualanDetail.setCreatedAt(Convert.ToDateTime(dr["created_at"]));
                penjualanDetail.setUpdatedAt(Convert.ToDateTime(dr["updated_at"]));

                return penjualanDetail;
            }

            return null;
        }

        public static PenjualanDetail FindOneByIdBarangAndIdPenjualan(int id_barang, int id_penjualan)
        {
            Database.OpenConnection();
            string select = String.Concat("SELECT * FROM ", nama_tabel, " WHERE id_barang = @id_barang " +
                                          "AND id_penjualan = @id_penjualan");

            Sql.MySqlDataAdapter da = new Sql.MySqlDataAdapter();

            da.SelectCommand = new Sql.MySqlCommand(select, Database.conn);
            da.SelectCommand.Parameters.AddWithValue("@id_barang", id_barang);
            da.SelectCommand.Parameters.AddWithValue("@id_penjualan", id_penjualan);

            Sql.MySqlCommandBuilder cb = new Sql.MySqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Database.CloseConnection();

            PenjualanDetail penjualanDetail = new PenjualanDetail();
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                penjualanDetail.setId(Convert.ToInt32(dr["id"]));
                penjualanDetail.setBarang(Barang.FindOneById(Convert.ToInt32(dr["id_barang"])));
                penjualanDetail.setPenjualan(Penjualan.FindOneById(Convert.ToInt32(dr["id_penjualan"])));
                penjualanDetail.setKuantitas(Convert.ToInt32(dr["kuantitas"]));
                penjualanDetail.setHargaBarang(Convert.ToDecimal(dr["harga_barang"]));
                penjualanDetail.setCreatedAt(Convert.ToDateTime(dr["created_at"]));
                penjualanDetail.setUpdatedAt(Convert.ToDateTime(dr["updated_at"]));

                return penjualanDetail;
            }

            return null;
        }

        public void Insert()
        {
            Sql.MySqlCommand cmd = Database.conn.CreateCommand();
            string cmdText = String.Concat("INSERT INTO ", nama_tabel, "(");
            cmdText += " id_penjualan, id_barang, harga_barang, kuantitas, created_at, updated_at) ";
            cmdText += " VALUES (@id_penjualan, @id_barang, @harga_barang, @kuantitas, @created_at, @updated_at)";

            cmd.Parameters.AddWithValue("@id_penjualan", this.penjualan.getId());
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
            cmdText += "id_penjualan = @id_penjualan, id_barang = @id_barang, harga_barang = @harga_barang";
            cmdText += ", kuantitas = @kuantitas, updated_at = @updated_at WHERE id = @id";

            cmd.Parameters.AddWithValue("@id_penjualan", this.penjualan.getId());
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
