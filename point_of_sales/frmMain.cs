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
using Latihan_Pos.Menu;

namespace Latihan_Pos
{
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void metroTile1_Click(object sender, EventArgs e)
        {
            frmLihat lihatForm = new frmLihat();
            lihatForm.ShowDialog();
            lihatForm.Dispose();
        }
        private void mtRegistrasi_Click(object sender, EventArgs e)
        {
            frmRegistrasi registrasiForm = new frmRegistrasi();
            registrasiForm.ShowDialog();
            registrasiForm.Dispose();
        }

        private void mtEdit_Click(object sender, EventArgs e)
        {
            frmEdit editForm = new frmEdit();
            editForm.ShowDialog();
            editForm.Dispose();
        }

        private void mtHapus_Click(object sender, EventArgs e)
        {
            frmHapus hapusForm = new frmHapus();
            hapusForm.ShowDialog();
            hapusForm.Dispose();
        }

        private void mtTambahTransaksi_Click(object sender, EventArgs e)
        {
            frmKelolaTransaksi kelolaTransaksiForm = new frmKelolaTransaksi();
            kelolaTransaksiForm.ShowDialog();
            kelolaTransaksiForm.Dispose();
        }

        private void mtLihatTransaksi_Click(object sender, EventArgs e)
        {
            frmLihatTransaksi lihatTransaksiForm = new frmLihatTransaksi();
            lihatTransaksiForm.ShowDialog();
            lihatTransaksiForm.Dispose();
        }
    }
}
