using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DateTime awalTahun = new DateTime(2016, 1, 1);
            DateTime akhirTahun = new DateTime(2016, 12, 31);
            for (int i = 1; i <= akhirTahun.DayOfYear; i++)
            {
                if (awalTahun.DayOfWeek.ToString() == "Saturday" || awalTahun.DayOfWeek.ToString() == "Sunday")
                {
                    monthCalendar.AddBoldedDate(awalTahun);
                }
                awalTahun = awalTahun.AddDays(1);
            }
            nudTanggal.Maximum = DateTime.DaysInMonth(2016, (int) nudBulan.Value);
            monthCalendar.UpdateBoldedDates();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            DateTime tanggalDipilih = new DateTime(2016, (int)nudBulan.Value, (int)nudTanggal.Value);
            monthCalendar.AddAnnuallyBoldedDate(tanggalDipilih);
            monthCalendar.UpdateBoldedDates();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            for (DateTime i = monthCalendar.SelectionRange.Start; i <= monthCalendar.SelectionRange.End; i = i.AddDays(1))
            {
                if (i.DayOfWeek.ToString() != "Saturday" && 
                    i.DayOfWeek.ToString() != "Sunday" &&
                    i.Day != 24 && i.Month != 7) 
                {
                     monthCalendar.RemoveAnnuallyBoldedDate(i);
                }
            }
            monthCalendar.UpdateBoldedDates();
        }

        private void nudBulan_ValueChanged(object sender, EventArgs e)
        {
            nudTanggal.Maximum = DateTime.DaysInMonth(2016, (int) nudBulan.Value);
        } 
    }
}
