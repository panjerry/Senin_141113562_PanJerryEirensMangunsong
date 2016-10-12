namespace TugasCSharpLanjutan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LblAkhir2 = new System.Windows.Forms.Label();
            this.LblMax = new System.Windows.Forms.Label();
            this.LblMin = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LblJrk = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.vScrollBarAkhir = new System.Windows.Forms.VScrollBar();
            this.vScrollBarAwal = new System.Windows.Forms.VScrollBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(375, 276);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.LblAkhir2);
            this.tabPage1.Controls.Add(this.LblMax);
            this.tabPage1.Controls.Add(this.LblMin);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.LblJrk);
            this.tabPage1.Controls.Add(this.txtBox);
            this.tabPage1.Controls.Add(this.vScrollBarAkhir);
            this.tabPage1.Controls.Add(this.vScrollBarAwal);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(367, 249);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TabTugas1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LblAkhir2
            // 
            this.LblAkhir2.AutoSize = true;
            this.LblAkhir2.Location = new System.Drawing.Point(76, 205);
            this.LblAkhir2.Name = "LblAkhir2";
            this.LblAkhir2.Size = new System.Drawing.Size(57, 13);
            this.LblAkhir2.TabIndex = 6;
            this.LblAkhir2.Text = "Nilai Sama";
            // 
            // LblMax
            // 
            this.LblMax.AutoSize = true;
            this.LblMax.Location = new System.Drawing.Point(76, 33);
            this.LblMax.Name = "LblMax";
            this.LblMax.Size = new System.Drawing.Size(54, 13);
            this.LblMax.TabIndex = 5;
            this.LblMax.Text = "Nilai Akhir";
            // 
            // LblMin
            // 
            this.LblMin.AutoSize = true;
            this.LblMin.Location = new System.Drawing.Point(6, 33);
            this.LblMin.Name = "LblMin";
            this.LblMin.Size = new System.Drawing.Size(53, 13);
            this.LblMin.TabIndex = 1;
            this.LblMin.Text = "Nilai Awal";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 87);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // LblJrk
            // 
            this.LblJrk.AutoSize = true;
            this.LblJrk.Location = new System.Drawing.Point(152, 15);
            this.LblJrk.Name = "LblJrk";
            this.LblJrk.Size = new System.Drawing.Size(36, 13);
            this.LblJrk.TabIndex = 3;
            this.LblJrk.Text = "Jarak ";
            // 
            // txtBox
            // 
            this.txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox.Enabled = false;
            this.txtBox.Location = new System.Drawing.Point(153, 31);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(100, 20);
            this.txtBox.TabIndex = 2;
            this.txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vScrollBarAkhir
            // 
            this.vScrollBarAkhir.LargeChange = 1;
            this.vScrollBarAkhir.Location = new System.Drawing.Point(89, 71);
            this.vScrollBarAkhir.Maximum = 50;
            this.vScrollBarAkhir.Name = "vScrollBarAkhir";
            this.vScrollBarAkhir.Size = new System.Drawing.Size(17, 122);
            this.vScrollBarAkhir.TabIndex = 1;
            this.vScrollBarAkhir.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar2_Akhir);
            // 
            // vScrollBarAwal
            // 
            this.vScrollBarAwal.AllowDrop = true;
            this.vScrollBarAwal.LargeChange = 1;
            this.vScrollBarAwal.Location = new System.Drawing.Point(19, 71);
            this.vScrollBarAwal.Maximum = 50;
            this.vScrollBarAwal.Name = "vScrollBarAwal";
            this.vScrollBarAwal.Size = new System.Drawing.Size(17, 122);
            this.vScrollBarAwal.TabIndex = 0;
            this.vScrollBarAwal.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Awal);
            // 
            // tabPage2
            // 
            this.tabPage2.ImageIndex = 0;
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(367, 249);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TabTugasKedua";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Icon.ico");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 278);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tugas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LblJrk;
        private System.Windows.Forms.VScrollBar vScrollBarAkhir;
        private System.Windows.Forms.VScrollBar vScrollBarAwal;
        private System.Windows.Forms.Label LblMax;
        private System.Windows.Forms.Label LblMin;
        private System.Windows.Forms.Label LblAkhir2;
        private System.Windows.Forms.TextBox txtBox;
    }
}

