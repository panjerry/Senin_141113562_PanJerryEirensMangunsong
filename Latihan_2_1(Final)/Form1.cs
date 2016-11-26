using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1_Final_
{
    public partial class Form1 : Form
    {
        bool mousedown;
        int mouseX, mouseY;
        DateTime temp;
        String[] Month;
        public Form1()
        {
            mousedown = false;
            mouseX = 0;
            mouseY = 0;
            Month = new string[] {"Januari", "Febuari", "Maret", "April","Mei",
                                    "Juni", "Juli", "Agustus", "September", 
                                    "Oktober", "November", "Desember"};
            InitializeComponent();
        }

        private void delbutton_Click(object sender, EventArgs e)
        {
            if (calender.AnnuallyBoldedDates.Length > 0 || calender.BoldedDates.Length > 0)
            {
                for (DateTime _i = calender.SelectionRange.Start; _i <= calender.SelectionRange.End; _i = _i.AddDays(1))
                {
                    calender.RemoveAnnuallyBoldedDate(_i);
                    calender.RemoveBoldedDate(_i);
                }
                calender.UpdateBoldedDates();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int _i = 0; _i < 31; _i++) { day.Items.Add(Convert.ToString(_i + 1)); }
            for (int _i = 0; _i < 12; _i++) { month.Items.Add(Month[_i]); }
            calender.AddAnnuallyBoldedDate(new DateTime(1996, 9, 14));
            for (DateTime _i = new DateTime(2016, 1, 1); _i.Year < 2017; _i = _i.AddDays(1))
            {
                if (_i.DayOfWeek == DayOfWeek.Saturday || _i.DayOfWeek == DayOfWeek.Sunday) { calender.AddBoldedDate(_i); }
            }
            calender.UpdateBoldedDates();

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            int _month = 0;

            for (int _i = 0; _i < Month.Length; _i++)
            {
                if (Month[_i] == month.Text) _month = _i + 1;
            }
            try
            {
                temp = new DateTime(2016, _month, Convert.ToInt32(day.Text));
            }
            catch
            {
                MessageBox.Show("Invalid Date");
            }
            foreach (DateTime x in calender.BoldedDates)
            {
                if (temp == x) break;
            }
            calender.AddAnnuallyBoldedDate(temp);
            calender.UpdateBoldedDates();
        }
    }
}
