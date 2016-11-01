namespace Latihan_1_1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblMaximum2 = new System.Windows.Forms.Label();
            this.lblMaximum1 = new System.Windows.Forms.Label();
            this.lblMinimum2 = new System.Windows.Forms.Label();
            this.lblMinimum1 = new System.Windows.Forms.Label();
            this.txtRange = new System.Windows.Forms.TextBox();
            this.lblRange = new System.Windows.Forms.Label();
            this.vsbMaximum = new System.Windows.Forms.VScrollBar();
            this.vsbMinimum = new System.Windows.Forms.VScrollBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(432, 297);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblMaximum2);
            this.tabPage1.Controls.Add(this.lblMaximum1);
            this.tabPage1.Controls.Add(this.lblMinimum2);
            this.tabPage1.Controls.Add(this.lblMinimum1);
            this.tabPage1.Controls.Add(this.txtRange);
            this.tabPage1.Controls.Add(this.lblRange);
            this.tabPage1.Controls.Add(this.vsbMaximum);
            this.tabPage1.Controls.Add(this.vsbMinimum);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(424, 270);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblMaximum2
            // 
            this.lblMaximum2.AutoSize = true;
            this.lblMaximum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximum2.Location = new System.Drawing.Point(263, 12);
            this.lblMaximum2.Name = "lblMaximum2";
            this.lblMaximum2.Size = new System.Drawing.Size(30, 24);
            this.lblMaximum2.TabIndex = 7;
            this.lblMaximum2.Text = "10";
            // 
            // lblMaximum1
            // 
            this.lblMaximum1.AutoSize = true;
            this.lblMaximum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximum1.Location = new System.Drawing.Point(139, 12);
            this.lblMaximum1.Name = "lblMaximum1";
            this.lblMaximum1.Size = new System.Drawing.Size(30, 24);
            this.lblMaximum1.TabIndex = 6;
            this.lblMaximum1.Text = "10";
            // 
            // lblMinimum2
            // 
            this.lblMinimum2.AutoSize = true;
            this.lblMinimum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimum2.Location = new System.Drawing.Point(269, 165);
            this.lblMinimum2.Name = "lblMinimum2";
            this.lblMinimum2.Size = new System.Drawing.Size(20, 24);
            this.lblMinimum2.TabIndex = 5;
            this.lblMinimum2.Text = "1";
            // 
            // lblMinimum1
            // 
            this.lblMinimum1.AutoSize = true;
            this.lblMinimum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimum1.Location = new System.Drawing.Point(145, 165);
            this.lblMinimum1.Name = "lblMinimum1";
            this.lblMinimum1.Size = new System.Drawing.Size(20, 24);
            this.lblMinimum1.TabIndex = 4;
            this.lblMinimum1.Text = "1";
            // 
            // txtRange
            // 
            this.txtRange.Enabled = false;
            this.txtRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRange.Location = new System.Drawing.Point(149, 192);
            this.txtRange.Name = "txtRange";
            this.txtRange.Size = new System.Drawing.Size(143, 24);
            this.txtRange.TabIndex = 3;
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRange.Location = new System.Drawing.Point(92, 195);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(51, 18);
            this.lblRange.TabIndex = 2;
            this.lblRange.Text = "Range";
            // 
            // vsbMaximum
            // 
            this.vsbMaximum.LargeChange = 1;
            this.vsbMaximum.Location = new System.Drawing.Point(270, 36);
            this.vsbMaximum.Maximum = 10;
            this.vsbMaximum.Name = "vsbMaximum";
            this.vsbMaximum.Size = new System.Drawing.Size(19, 129);
            this.vsbMaximum.TabIndex = 1;
            this.vsbMaximum.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbMaximum_Scroll);
            // 
            // vsbMinimum
            // 
            this.vsbMinimum.Cursor = System.Windows.Forms.Cursors.Default;
            this.vsbMinimum.LargeChange = 1;
            this.vsbMinimum.Location = new System.Drawing.Point(146, 36);
            this.vsbMinimum.Maximum = 10;
            this.vsbMinimum.Name = "vsbMinimum";
            this.vsbMinimum.Size = new System.Drawing.Size(19, 129);
            this.vsbMinimum.TabIndex = 0;
            this.vsbMinimum.Value = 10;
            this.vsbMinimum.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbMinimum_Scroll);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtpTanggalLahir);
            this.tabPage2.ImageKey = "logo.jpg";
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(424, 270);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "logo.jpg");
            this.imageList1.Images.SetKeyName(1, "SansationLight-thumb.png");
            // 
            // dtpTanggalLahir
            // 
            this.dtpTanggalLahir.Location = new System.Drawing.Point(94, 69);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(199, 20);
            this.dtpTanggalLahir.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 323);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtRange;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.VScrollBar vsbMaximum;
        private System.Windows.Forms.VScrollBar vsbMinimum;
        private System.Windows.Forms.Label lblMaximum2;
        private System.Windows.Forms.Label lblMaximum1;
        private System.Windows.Forms.Label lblMinimum2;
        private System.Windows.Forms.Label lblMinimum1;
        private System.Windows.Forms.DateTimePicker dtpTanggalLahir;
    }
}

