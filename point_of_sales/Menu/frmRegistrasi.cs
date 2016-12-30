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
namespace Latihan_Pos.Menu
{
    public partial class frmRegistrasi : MetroForm
    {
        public frmRegistrasi()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in mtpBarang.Controls)
            {
                if (ctrl is TextBox && ctrl.Name != "txtId" && ctrl.Text.Trim() == "")
                {
                    MessageBox.Show("Data tidak boleh ada yang kosong.");
                    return;
                }
            }
            Barang barangBaru = new Barang();
            barangBaru.setKode(txtKode.Text);
            barangBaru.setNama(txtNamaBarang.Text);
            barangBaru.setHargaHpp(Convert.ToDecimal(txtHargaHpp.Text));
            barangBaru.setHargaJual(Convert.ToDecimal(txtHargaJual.Text));
            barangBaru.setJumlah(Convert.ToInt32(txtJumlahAwal.Text));

            try 
	        {
                barangBaru.Insert();
                MessageBox.Show("Barang dengan kode " + barangBaru.getKode() + " berhasil ditambahkan.");
	        }
	        catch (Exception ex)
	        {
		        MessageBox.Show(ex.Message);
	        }
        }

        private void mtpSimpanCustomer_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in mtpCustomer.Controls)
            {
                if (ctrl is TextBox && ctrl.Text.Trim() == "")
                {
                    MessageBox.Show("Data tidak boleh ada yang kosong.");
                    return;
                }
            }
            Customer custBaru = new Customer();
            custBaru.setNama(txtNamaCustomer.Text);
            custBaru.setAlamat(txtAlamatCustomer.Text);
            custBaru.setKodePos(txtKodePosCustomer.Text);
            custBaru.setKota(txtKotaCustomer.Text);
            custBaru.setNomorTelepon(txtTeleponCustomer.Text);
            try
            {
                custBaru.Insert();
                MessageBox.Show("Customer dengan nama " + custBaru.getNama() + " berhasil dimasukkan.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSimpanSupplier_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in mtpSupplier.Controls)
            {
                if (ctrl is TextBox && ctrl.Text.Trim() == "")
                {
                    MessageBox.Show("Data tidak boleh ada yang kosong.");
                    return;
                }
            }
            Supplier suppBaru = new Supplier();
            suppBaru.setNama(txtNamaSupplier.Text);
            suppBaru.setAlamat(txtAlamatSupplier.Text);
            suppBaru.setKodePos(txtKodePosSupplier.Text);
            suppBaru.setKota(txtKotaSupplier.Text);
            suppBaru.setNomorTelepon(txtTeleponSupplier.Text);
            try
            {
                suppBaru.Insert();
                MessageBox.Show("Supplier dengan nama " + suppBaru.getNama() + " berhasil dimasukkan.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmRegistrasi_Load(object sender, EventArgs e)
        {
            mtcRegistrasi.SelectTab(0);
        }

    }
}
