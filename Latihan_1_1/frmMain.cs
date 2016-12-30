using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            txtRange.Text = (vsbMinimum.Maximum - vsbMinimum.Value).ToString() + " -> " +
                            (vsbMaximum.Maximum - vsbMaximum.Value).ToString();

            dtpTanggalLahir.MaxDate = now.AddYears(vsbMinimum.Value - vsbMinimum.Maximum);
            dtpTanggalLahir.MinDate = now.AddYears(vsbMaximum.Value - vsbMaximum.Maximum);
        }

        private void vsbMaximum_Scroll(object sender, ScrollEventArgs e)
        {
            DateTime now = DateTime.Now;
            if (vsbMaximum.Value > vsbMinimum.Value)
            {
                vsbMinimum.Value = vsbMaximum.Value;
            }
            txtRange.Text = (vsbMinimum.Maximum - vsbMinimum.Value).ToString() + " -> " +
                            (vsbMaximum.Maximum - vsbMaximum.Value).ToString();

            dtpTanggalLahir.MaxDate = now.AddYears(vsbMinimum.Value - vsbMinimum.Maximum).Date;
            dtpTanggalLahir.MinDate = now.AddYears(vsbMaximum.Value - vsbMaximum.Maximum).Date;
        }

        private void vsbMinimum_Scroll(object sender, ScrollEventArgs e)
        {
            DateTime now = DateTime.Now;
            if (vsbMaximum.Value > vsbMinimum.Value)
            {
                vsbMaximum.Value = vsbMinimum.Value;
            }
            txtRange.Text = (vsbMinimum.Maximum - vsbMinimum.Value).ToString() + " -> " +
                            (vsbMaximum.Maximum - vsbMaximum.Value).ToString();

            dtpTanggalLahir.MinDate = now.AddYears(vsbMaximum.Value - vsbMaximum.Maximum).Date;
            dtpTanggalLahir.MaxDate = now.AddYears(vsbMinimum.Value - vsbMinimum.Maximum).Date;
        }

    }
}
