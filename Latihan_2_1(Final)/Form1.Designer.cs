namespace Latihan_2_1_Final_
{
    partial class Form1
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
            this.day = new System.Windows.Forms.DomainUpDown();
            this.month = new System.Windows.Forms.DomainUpDown();
            this.addbutton = new System.Windows.Forms.Button();
            this.delbutton = new System.Windows.Forms.Button();
            this.calender = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(42, 28);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(78, 20);
            this.day.TabIndex = 7;
            this.day.Text = "Hari";
            this.day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(156, 28);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(88, 20);
            this.month.TabIndex = 8;
            this.month.Text = "Bulan";
            this.month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(392, 28);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(70, 23);
            this.addbutton.TabIndex = 9;
            this.addbutton.Text = "Tambah";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // delbutton
            // 
            this.delbutton.Location = new System.Drawing.Point(487, 28);
            this.delbutton.Name = "delbutton";
            this.delbutton.Size = new System.Drawing.Size(61, 23);
            this.delbutton.TabIndex = 10;
            this.delbutton.Text = "Hapus";
            this.delbutton.UseVisualStyleBackColor = true;
            this.delbutton.Click += new System.EventHandler(this.delbutton_Click);
            // 
            // calender
            // 
            this.calender.BackColor = System.Drawing.SystemColors.Info;
            this.calender.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.calender.Location = new System.Drawing.Point(42, 63);
            this.calender.Name = "calender";
            this.calender.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 431);
            this.Controls.Add(this.calender);
            this.Controls.Add(this.delbutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.month);
            this.Controls.Add(this.day);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DomainUpDown day;
        private System.Windows.Forms.DomainUpDown month;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button delbutton;
        private System.Windows.Forms.MonthCalendar calender;
    }
}

