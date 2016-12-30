using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sql = MySql.Data.MySqlClient;
using MetroFramework.Forms;
using Latihan_Pos.Class;
using Latihan_Pos.CustomForm;

namespace Latihan_Pos.Menu
{
    public partial class frmEdit : MetroForm
    {
        public frmEdit()
        {
            InitializeComponent();
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowseCustomer_Click(object sender, EventArgs e)
        {
            frmBrowse browse = new frmBrowse("customer");
            browse.ShowDialog();
            Dictionary<string, string> datas = browse.getData();

            if (datas.Count > 0)
            {
                txtIdCustomer.Text = datas["id"];
                txtNamaCustomer.Text = datas["nama"];
                txtAlamatCustomer.Text = datas["alamat"];
                txtTeleponCustomer.Text = datas["nomor_telepon"];
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in mtpCustomer.Controls)
            {
                if (ctrl is TextBox && ctrl.Text.Trim() == "")
                {
                    MessageBox.Show("Data tidak boleh ada yang kosong.");
                    return;
                }
            }

            Customer customer = new Customer();
            customer.setId(Convert.ToInt32(txtIdCustomer.Text));
            customer.setAlamat(txtAlamatCustomer.Text);
            customer.setNama(txtNamaCustomer.Text);
            customer.setKodePos(txtKodePosCustomer.Text);
            customer.setKota(txtKotaCustomer.Text);
            customer.setNomorTelepon(txtTeleponCustomer.Text);
            customer.Update();
            MessageBox.Show("Customer dengan nama " + customer.getNama() + " berhasil diupdate.");
        }

        private void btnBrowseSupplier_Click(object sender, EventArgs e)
        {
            frmBrowse browse = new frmBrowse("supplier");
            browse.ShowDialog();
            Dictionary<string, string> datas = browse.getData();

            if (datas.Count > 0)
            {
                txtIdSupplier.Text = datas["id"];
                txtNamaSupplier.Text = datas["nama"];
                txtAlamatSupplier.Text = datas["alamat"];
                txtTeleponSupplier.Text = datas["nomor_telepon"];
            }
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in mtpSupplier.Controls)
            {
                if (ctrl is TextBox && ctrl.Text.Trim() == "")
                {
                    MessageBox.Show("Data tidak boleh ada yang kosong.");
                    return;
                }
            }

            Supplier supplier = new Supplier();
            supplier.setId(Convert.ToInt32(txtIdSupplier.Text));
            supplier.setAlamat(txtAlamatSupplier.Text);
            supplier.setNama(txtNamaSupplier.Text);
            supplier.setKodePos(txtKodePosSupplier.Text);
            supplier.setKota(txtKotaSupplier.Text);
            supplier.setNomorTelepon(txtTeleponSupplier.Text);
            supplier.Update();
            MessageBox.Show("Supplier dengan nama " + supplier.getNama() + " berhasil diupdate.");
        }

        private void btnBrowseBarang_Click(object sender, EventArgs e)
        {
            frmBrowse browse = new frmBrowse("barang");
            browse.ShowDialog();
            Dictionary<string, string> datas = browse.getData();

            if (datas.Count > 0)
            {
                txtIdBarang.Text = datas["id"];
                txtKode.Text = datas["kode"];
                txtNamaBarang.Text = datas["nama"];
                txtJumlahAwal.Text = datas["jumlah"];
                txtHargaHpp.Text = datas["harga_hpp"];
                txtHargaJual.Text = datas["harga_jual"];
            }
        }

        private void btnEditBarang_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in mtpBarang.Controls)
            {
                if (ctrl is TextBox && ctrl.Text.Trim() == "")
                {
                    MessageBox.Show("Data tidak boleh ada yang kosong.");
                    return;
                }
            }

            Barang barang = new Barang();
            barang.setId(Convert.ToInt32(txtIdBarang.Text));
            barang.setKode(txtKode.Text);
            barang.setNama(txtNamaBarang.Text);
            barang.setHargaHpp(Convert.ToDecimal(txtHargaHpp.Text));
            barang.setHargaJual(Convert.ToDecimal(txtHargaJual.Text));
            barang.setJumlah(Convert.ToInt32(txtJumlahAwal.Text));
            barang.Update();
            MessageBox.Show("Barang dengan kode " + barang.getKode() + " berhasil diupdate.");
        }
    }
}
