namespace Latihan_2_1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudTanggal = new System.Windows.Forms.NumericUpDown();
            this.nudBulan = new System.Windows.Forms.NumericUpDown();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.nudTanggal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBulan)).BeginInit();
            this.SuspendLayout();
            // 
            // nudTanggal
            // 
            this.nudTanggal.Location = new System.Drawing.Point(198, 45);
            this.nudTanggal.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudTanggal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTanggal.Name = "nudTanggal";
            this.nudTanggal.Size = new System.Drawing.Size(51, 20);
            this.nudTanggal.TabIndex = 0;
            this.nudTanggal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudBulan
            // 
            this.nudBulan.Location = new System.Drawing.Point(255, 45);
            this.nudBulan.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudBulan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBulan.Name = "nudBulan";
            this.nudBulan.Size = new System.Drawing.Size(120, 20);
            this.nudBulan.TabIndex = 1;
            this.nudBulan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBulan.ValueChanged += new System.EventHandler(this.nudBulan_ValueChanged);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(381, 42);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 2;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(462, 42);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.BoldedDates = new System.DateTime[] {
        new System.DateTime(2016, 7, 24, 0, 0, 0, 0)};
            this.monthCalendar.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.monthCalendar.Location = new System.Drawing.Point(141, 77);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ScrollChange = 4;
            this.monthCalendar.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 437);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.nudBulan);
            this.Controls.Add(this.nudTanggal);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTanggal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBulan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudTanggal;
        private System.Windows.Forms.NumericUpDown nudBulan;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.MonthCalendar monthCalendar;
    }
}

