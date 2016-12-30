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
using System.Threading;

namespace Latihan_Pos.Menu
{
    public partial class frmLihatTransaksi : MetroForm
    {
        private DataTable dtPembelian;
        private DataTable dtPembelianDetail;
        private DataTable dtPenjualan;
        private DataTable dtPenjualanDetail;
        public frmLihatTransaksi()
        {
            InitializeComponent();
        }

        private void frmLihatTransaksi_Shown(object sender, EventArgs e)
        {
            mtcDaftarTransaksi.SelectTab(0);
            dgvPembelian.DataSource = Pembelian.FindAll();
            dgvPembelian.Refresh();
            dgvPembelianDetail.DataSource = PembelianDetail.FindAll();
            dgvPembelianDetail.Refresh();
            dgvPenjualan.DataSource = Penjualan.FindAll();
            dgvPenjualan.Refresh();
            dgvPenjualanDetail.DataSource = PenjualanDetail.FindAll();
            dgvPenjualanDetail.Refresh();

            dtPembelian = (DataTable)dgvPembelian.DataSource;
            dtPembelianDetail = (DataTable)dgvPembelianDetail.DataSource;
            dtPenjualan = (DataTable)dgvPenjualan.DataSource;
            dtPenjualanDetail = (DataTable)dgvPenjualanDetail.DataSource;
        }

        private void txtFilterPembelian_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string filter = "";
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvPembelian.DataSource;
            foreach (DataColumn dc in dtPembelian.Columns)
            {
                if (i > 0)
                {
                    filter += " or ";
                }
                filter += dc.ColumnName + " like '%" + txtFilterPembelian.Text + "%'";
                i++;
            }
            bs.Filter = filter;
            Console.WriteLine(bs.Filter);
            dgvPembelian.DataSource = bs;
        }

        private void txtFilterPenjualan_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string filter = "";
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvPenjualan.DataSource;
            foreach (DataColumn dc in dtPenjualan.Columns)
            {
                if (i > 0)
                {
                    filter += " or ";
                }
                filter += dc.ColumnName + " like '%" + txtFilterPenjualan.Text + "%'";
                i++;
            }
            bs.Filter = filter;
            Console.WriteLine(bs.Filter);
            dgvPenjualan.DataSource = bs;
        }

        private void txtFilterPenjualanDetail_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string filter = "";
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvPenjualanDetail.DataSource;
            foreach (DataColumn dc in dtPenjualanDetail.Columns)
            {
                if (i > 0)
                {
                    filter += " or ";
                }
                filter += dc.ColumnName + " like '%" + txtFilterPenjualanDetail.Text + "%'";
                i++;
            }
            bs.Filter = filter;
            Console.WriteLine(bs.Filter);
            dgvPenjualanDetail.DataSource = bs;
        }

        private void txtFilterPembelianDetail_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string filter = "";
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvPembelianDetail.DataSource;
            foreach (DataColumn dc in dtPembelianDetail.Columns)
            {
                if (i > 0)
                {
                    filter += " or ";
                }
                filter += dc.ColumnName + " like '%" + txtFilterPembelianDetail.Text + "%'";
                i++;
            }
            bs.Filter = filter;
            Console.WriteLine(bs.Filter);
            dgvPembelianDetail.DataSource = bs;
        }

        
    }
}
