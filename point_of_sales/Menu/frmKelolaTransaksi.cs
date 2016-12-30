using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Latihan_Pos.Class;
using Latihan_Pos.CustomForm;

namespace Latihan_Pos.Menu
{
    public partial class frmKelolaTransaksi : MetroForm
    {
        private int id_barang_penjualan;
        private int id_barang_pembelian;
        private int id_customer;
        private int id_supplier;
        public frmKelolaTransaksi()
        {
            InitializeComponent();

            mtcTambahTransaksi.SelectTab(0);
        }

        private void btnBrowseCustomer_Click(object sender, EventArgs e)
        {
            frmBrowse browse = new frmBrowse("customer");
            browse.ShowDialog();
            Dictionary<string, string> datas = browse.getData();

            if (datas.Count > 0)
            {
                id_customer = Convert.ToInt32(datas["id"]);
                txtCustomer.Text = String.Concat(datas["nama"]);
            }
        }

        private void btnSimpanPenjualan_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in mtpPenjualan.Controls)
            {
                if (ctrl is TextBox && ctrl.Text.Trim() == "" && ctrl.Name != "txtTotalHarga")
                {
                    MessageBox.Show("Data tidak boleh ada yang kosong.");
                    return;
                }
            }

            Penjualan penjualan = Penjualan.FindOneByKode(txtKodePenjualan.Text);
            Penjualan penjualanBaru = new Penjualan();
            if (penjualan == null)
            {
                penjualanBaru.setCustomer(Customer.FindOneById(id_customer));
                penjualanBaru.setKode(txtKodePenjualan.Text);
                try
                {
                    penjualanBaru.Insert();
                    penjualan = Penjualan.FindOneByKode(penjualanBaru.getKode());
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }

            PenjualanDetail penjualanDetail = PenjualanDetail.
                FindOneByIdBarangAndIdPenjualan(id_barang_penjualan, penjualan.getId());

            if (penjualanDetail == null)
            {
                PenjualanDetail penjualanDetailBaru = new PenjualanDetail();
                penjualanDetailBaru.setBarang(Barang.FindOneById(id_barang_penjualan));

                Barang barang = penjualanDetailBaru.getBarang();
                int kuantitas = Convert.ToInt32(txtKuantitasPenjualan.Text);

                penjualanDetailBaru.setKuantitas(kuantitas);
                penjualanDetailBaru.setHargaBarang(Convert.ToDecimal(txtHargaBarangPenjualan.Text));
                penjualanDetailBaru.setPenjualan(penjualan);

                if (kuantitas > barang.getJumlah())
                {
                    MessageBox.Show("Jumlah barang yang dipesan tidak mencukupi.");
                }
                else if (kuantitas < 0)
                {
                    MessageBox.Show("Kuantitas tidak valid.");
                }
                else
                {
                    try
                    {
                        penjualanDetailBaru.Insert(); 
                        barang.setJumlah(barang.getJumlah() - kuantitas);
                        barang.Update();
                        MessageBox.Show("Barang dengan kode " + penjualanDetailBaru.getBarang().getKode() +
                                        " berhasil dimasukkan pada faktur dengan kode " + penjualan.getKode());
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
            else
            {
                Barang barang = penjualanDetail.getBarang();
                int kuantitas = Convert.ToInt32(txtKuantitasPenjualan.Text);
                int kuantitasLama = penjualanDetail.getKuantitas();
                penjualanDetail.setKuantitas(kuantitas);
                penjualanDetail.setHargaBarang(Convert.ToDecimal(txtHargaBarangPenjualan.Text));

                if ( kuantitas > barang.getJumlah() + kuantitasLama)
                {
                    MessageBox.Show("Jumlah barang yang dipesan tidak mencukupi.");
                }
                else if (kuantitas < 0)
                {
                    MessageBox.Show("Kuantitas tidak valid.");
                }
                else
                {
                    try
                    {
                        penjualanDetail.Update();
                        barang.setJumlah(barang.getJumlah() - kuantitas + kuantitasLama);
                        barang.Update();
                        MessageBox.Show("Barang dengan kode " + penjualanDetail.getBarang().getKode() +
                                        " pada faktur dengan kode " + penjualan.getKode());
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }

            DataTable dt = PenjualanDetail.FindByIdPenjualan(penjualan.getId());
            dgvPenjualanDetail.DataSource = dt;
            dgvPenjualanDetail.Refresh();

            decimal sum = 0;
            foreach (DataRow dr in dt.Rows)
            {
                sum += Convert.ToDecimal(dr["harga_barang"]) * Convert.ToInt32(dr["kuantitas"]);
            }
            txtTotalHarga.Text = sum.ToString();
        }

        private void btnBrowseKode_Click(object sender, EventArgs e)
        {
            frmBrowse browse = new frmBrowse("penjualan");
            browse.ShowDialog();
            Dictionary<string, string> datas = browse.getData();

            if (datas.Count > 0)
            {
                Customer customer = Customer.FindOneById(Convert.ToInt32(datas["id_customer"]));
                id_customer = customer.getId();
                txtKodePenjualan.Text = datas["kode"];
                txtCustomer.Text = customer.getNama();
                DataTable dt = PenjualanDetail.FindByIdPenjualan(Convert.ToInt32(datas["id"]));
                dgvPenjualanDetail.DataSource = dt;
                dgvPenjualanDetail.Refresh();

                decimal sum = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    sum += Convert.ToDecimal(dr["harga_barang"]) * Convert.ToInt32(dr["kuantitas"]);
                }
                txtTotalHarga.Text = sum.ToString();
            }
        }

        private void btnBrowseBarang_Click(object sender, EventArgs e)
        {
            frmBrowse browse = new frmBrowse("barang");
            browse.ShowDialog();
            Dictionary<string, string> datas = browse.getData();

            if (datas.Count > 0)
            {
                id_barang_penjualan = Convert.ToInt32(datas["id"]);
                txtBarangPenjualan.Text = String.Concat(datas["kode"], " - ", datas["nama"]);
                txtHargaBarangPenjualan.Text = datas["harga_jual"];
            }
        }

        private void txtHargaBarangPenjualan_TextChanged(object sender, EventArgs e)
        {
            decimal hargaBarang = (txtHargaBarangPenjualan.Text.Trim() != "") ? 
                Convert.ToDecimal(txtHargaBarangPenjualan.Text) : 0;
            int kuantitas = (txtKuantitasPenjualan.Text.Trim() != "") ? 
                Convert.ToInt32(txtKuantitasPenjualan.Text) : 0;

            txtSubTotalHargaPenjualan.Text = (hargaBarang * kuantitas).ToString();
        }

        private void txtKuantitasPenjualan_TextChanged(object sender, EventArgs e)
        {
            decimal hargaBarang = (txtHargaBarangPenjualan.Text.Trim() != "") ?
                Convert.ToDecimal(txtHargaBarangPenjualan.Text) : 0;
            int kuantitas = (txtKuantitasPenjualan.Text.Trim() != "") ?
                Convert.ToInt32(txtKuantitasPenjualan.Text) : 0;

            txtSubTotalHargaPenjualan.Text = (hargaBarang * kuantitas).ToString();
        }

        private void btnBrowseKodePembelian_Click(object sender, EventArgs e)
        {
            frmBrowse browse = new frmBrowse("pembelian");
            browse.ShowDialog();
            Dictionary<string, string> datas = browse.getData();

            if (datas.Count > 0)
            {
                Supplier supplier = Supplier.FindOneById(Convert.ToInt32(datas["id_supplier"]));
                id_supplier = supplier.getId();
                txtKodePembelian.Text = datas["kode"];
                txtSupplier.Text = supplier.getNama();
                DataTable dt = PembelianDetail.FindByIdPembelian(Convert.ToInt32(datas["id"]));
                dgvPembelianDetail.DataSource = dt;
                dgvPembelianDetail.Refresh();

                decimal sum = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    sum += Convert.ToDecimal(dr["harga_barang"]) * Convert.ToInt32(dr["kuantitas"]);
                }
                txtTotalHargaPembelian.Text = sum.ToString();
            }
        }

        private void btnBrowseSupplier_Click(object sender, EventArgs e)
        {
            frmBrowse browse = new frmBrowse("supplier");
            browse.ShowDialog();
            Dictionary<string, string> datas = browse.getData();

            if (datas.Count > 0)
            {
                id_supplier = Convert.ToInt32(datas["id"]);
                txtSupplier.Text = String.Concat(datas["nama"]);
            }
        }

        private void btnBrowseBarangPembelian_Click(object sender, EventArgs e)
        {
            frmBrowse browse = new frmBrowse("barang");
            browse.ShowDialog();
            Dictionary<string, string> datas = browse.getData();

            if (datas.Count > 0)
            {
                id_barang_pembelian = Convert.ToInt32(datas["id"]);
                txtBarangPembelian.Text = String.Concat(datas["kode"], " - ", datas["nama"]);
                txtHargaBarangPembelian.Text = datas["harga_jual"];
            }
        }

        private void txtHargaBarangPembelian_TextChanged(object sender, EventArgs e)
        {
            decimal hargaBarang = (txtHargaBarangPembelian.Text.Trim() != "") ?
                Convert.ToDecimal(txtHargaBarangPembelian.Text) : 0;
            int kuantitas = (txtKuantitasPembelian.Text.Trim() != "") ?
                Convert.ToInt32(txtKuantitasPembelian.Text) : 0;

            txtSubTotalHargaPembelian.Text = (hargaBarang * kuantitas).ToString();
        }

        private void txtKuantitasPembelian_TextChanged(object sender, EventArgs e)
        {
            decimal hargaBarang = (txtHargaBarangPembelian.Text.Trim() != "") ?
                Convert.ToDecimal(txtHargaBarangPembelian.Text) : 0;
            int kuantitas = (txtKuantitasPembelian.Text.Trim() != "") ?
                Convert.ToInt32(txtKuantitasPembelian.Text) : 0;

            txtSubTotalHargaPembelian.Text = (hargaBarang * kuantitas).ToString();
        }

        private void btnTambahPembelian_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in mtpPembelian.Controls)
            {
                if (ctrl is TextBox && ctrl.Text.Trim() == "" && ctrl.Name != "txtTotalHargaPembelian")
                {
                    MessageBox.Show("Data tidak boleh ada yang kosong.");
                    return;
                }
            }

            Pembelian pembelian = Pembelian.FindOneByKode(txtKodePembelian.Text);
            Pembelian pembelianBaru = new Pembelian();
            if (pembelian == null)
            {
                pembelianBaru.setSupplier(Supplier.FindOneById(id_supplier));
                pembelianBaru.setKode(txtKodePembelian.Text);
                try
                {
                    pembelianBaru.Insert();
                    pembelian = Pembelian.FindOneByKode(pembelianBaru.getKode());
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }

            PembelianDetail pembelianDetail = PembelianDetail.
                FindOneByIdBarangAndIdPembelian(id_barang_pembelian, pembelian.getId());

            if (pembelianDetail == null)
            {
                PembelianDetail pembelianDetailBaru = new PembelianDetail();
                pembelianDetailBaru.setBarang(Barang.FindOneById(id_barang_pembelian));

                Barang barang = pembelianDetailBaru.getBarang();

                int kuantitas = Convert.ToInt32(txtKuantitasPembelian.Text);

                pembelianDetailBaru.setKuantitas(kuantitas);
                pembelianDetailBaru.setHargaBarang(Convert.ToDecimal(txtHargaBarangPembelian.Text));
                pembelianDetailBaru.setPembelian(pembelian);

                try
                {
                    pembelianDetailBaru.Insert();
                    barang.setJumlah(barang.getJumlah() + kuantitas);
                    barang.setHargaHpp(pembelianDetailBaru.getHargaBarang());
                    barang.Update();
                    MessageBox.Show("Barang dengan kode " + pembelianDetailBaru.getBarang().getKode() +
                                    " berhasil dimasukkan pada faktur dengan kode " + pembelian.getKode());
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                Barang barang = pembelianDetail.getBarang();
                int kuantitas = Convert.ToInt32(txtKuantitasPembelian.Text);
                int kuantitasLama = pembelianDetail.getKuantitas();
                pembelianDetail.setKuantitas(kuantitas);
                pembelianDetail.setHargaBarang(Convert.ToDecimal(txtHargaBarangPembelian.Text));

                if (kuantitas < 0)
                {
                    MessageBox.Show("Kuantitas tidak valid.");
                }
                else
                {
                    try
                    {
                        pembelianDetail.Update();
                        barang.setJumlah(barang.getJumlah() + kuantitas - kuantitasLama);
                        barang.setHargaHpp(pembelianDetail.getHargaBarang());
                        barang.Update();
                        MessageBox.Show("Barang dengan kode " + pembelianDetail.getBarang().getKode() +
                                        " pada faktur dengan kode " + pembelian.getKode());
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }

            DataTable dt = PembelianDetail.FindByIdPembelian(pembelian.getId());
            dgvPembelianDetail.DataSource = dt;
            dgvPembelianDetail.Refresh();

            decimal sum = 0;
            foreach (DataRow dr in dt.Rows)
            {
                sum += Convert.ToDecimal(dr["harga_barang"]) * Convert.ToInt32(dr["kuantitas"]);
            }
            txtTotalHargaPembelian.Text = sum.ToString();
        }
    }
}
