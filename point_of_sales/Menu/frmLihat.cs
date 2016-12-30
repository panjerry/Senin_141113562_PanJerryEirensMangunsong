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

namespace Latihan_Pos
{
    public partial class frmLihat : MetroForm
    {
        private DataTable dtBarang;
        private DataTable dtCustomer;
        private DataTable dtSupplier;
        public frmLihat()
        {
            InitializeComponent();
        }

        private void frmLihat_Shown(object sender, EventArgs e)
        {
            mtcDaftar.SelectTab(0);
            dgvBarang.DataSource = Barang.FindAll();
            dgvBarang.Refresh();
            dgvCustomer.DataSource = Customer.FindAll();
            dgvCustomer.Refresh();
            dgvSupplier.DataSource = Supplier.FindAll();
            dgvSupplier.Refresh();

            dtBarang = (DataTable) dgvBarang.DataSource;
            dtCustomer = (DataTable) dgvCustomer.DataSource;
            dtSupplier = (DataTable) dgvCustomer.DataSource;
        }

        private void txtFilterBarang_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string filter = "";
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvBarang.DataSource;
            foreach (DataColumn dc in dtBarang.Columns)
            {
                if (i > 0)
                {
                    filter += " or ";
                }
                filter += dc.ColumnName + " like '%" + txtFilterBarang.Text + "%'";
                i++;
            }
            bs.Filter = filter;
            Console.WriteLine(bs.Filter);
            dgvBarang.DataSource = bs;
        }

        private void txtFilterSupplier_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string filter = "";
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvSupplier.DataSource;
            foreach (DataColumn dc in dtSupplier.Columns)
            {
                if (i > 0)
                {
                    filter += " or ";
                }
                filter += dc.ColumnName + " like '%" + txtFilterSupplier.Text + "%'";
                i++;
            }
            bs.Filter = filter;
            Console.WriteLine(bs.Filter);
            dgvSupplier.DataSource = bs;
        }

        private void txtFilterCustomer_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string filter = "";
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvCustomer.DataSource;
            foreach (DataColumn dc in dtCustomer.Columns)
            {
                if (i > 0)
                {
                    filter += " or ";
                }
                filter += dc.ColumnName + " like '%" + txtFilterCustomer.Text + "%'";
                i++;
            }
            bs.Filter = filter;
            Console.WriteLine(bs.Filter);
            dgvCustomer.DataSource = bs;
        }        
    }
}
