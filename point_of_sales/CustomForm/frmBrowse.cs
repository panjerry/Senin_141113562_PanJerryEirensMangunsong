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

namespace Latihan_Pos.CustomForm
{
    public partial class frmBrowse : MetroForm  
    {
        private string tabel;
        private Dictionary<string, string> data;
        private DataTable dt;
        public frmBrowse(string tabel)
        {
            InitializeComponent();
            this.tabel = tabel;
            if (tabel == "barang")
            {
                dgvBrowse.DataSource = Barang.FindAll();
            }
            else if (tabel == "customer")
            {
                dgvBrowse.DataSource = Customer.FindAll();
            }
            else if (tabel == "supplier")
            {
                dgvBrowse.DataSource = Supplier.FindAll();
            }
            else if (tabel == "penjualan")
            {
                dgvBrowse.DataSource = Penjualan.FindAll();
            }
            else if (tabel == "pembelian")
            {
                dgvBrowse.DataSource = Pembelian.FindAll();
            }
            dgvBrowse.Refresh();
            data = new Dictionary<string, string> { };
            dt = (DataTable)dgvBrowse.DataSource;
        }

        public Dictionary<string, string> getData()
        {
            return this.data;
        }

        private void dgvBrowseClick(object sender, DataGridViewCellEventArgs e)
        {
            data = new Dictionary<string, string> { };
            foreach (DataGridViewColumn col in dgvBrowse.Columns)
            {
                data.Add(col.Name, dgvBrowse[col.Index, e.RowIndex].Value.ToString());
            }
            Close();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string filter = "";
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvBrowse.DataSource;
            foreach (DataColumn dc in dt.Columns)
            {
                if (i > 0)
                {
                    filter += " or ";
                }
                filter += dc.ColumnName + " like '%" + txtFilter.Text + "%'";
                i++;
            }
            bs.Filter = filter;
            Console.WriteLine(bs.Filter);
            dgvBrowse.DataSource = bs;
        }
    }
}
