namespace Latihan_Pos
{
    partial class frmLihat
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
            this.mtcDaftar = new MetroFramework.Controls.MetroTabControl();
            this.mtpBarang = new MetroFramework.Controls.MetroTabPage();
            this.dgvBarang = new System.Windows.Forms.DataGridView();
            this.mtpSupplier = new MetroFramework.Controls.MetroTabPage();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.mtpCustomer = new MetroFramework.Controls.MetroTabPage();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.txtFilterBarang = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtFilterSupplier = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtFilterCustomer = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtcDaftar.SuspendLayout();
            this.mtpBarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            this.mtpSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.mtpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // mtcDaftar
            // 
            this.mtcDaftar.Controls.Add(this.mtpBarang);
            this.mtcDaftar.Controls.Add(this.mtpSupplier);
            this.mtcDaftar.Controls.Add(this.mtpCustomer);
            this.mtcDaftar.Location = new System.Drawing.Point(24, 64);
            this.mtcDaftar.Name = "mtcDaftar";
            this.mtcDaftar.SelectedIndex = 2;
            this.mtcDaftar.Size = new System.Drawing.Size(617, 336);
            this.mtcDaftar.TabIndex = 0;
            // 
            // mtpBarang
            // 
            this.mtpBarang.Controls.Add(this.txtFilterBarang);
            this.mtpBarang.Controls.Add(this.metroLabel1);
            this.mtpBarang.Controls.Add(this.dgvBarang);
            this.mtpBarang.HorizontalScrollbarBarColor = true;
            this.mtpBarang.Location = new System.Drawing.Point(4, 35);
            this.mtpBarang.Name = "mtpBarang";
            this.mtpBarang.Size = new System.Drawing.Size(609, 297);
            this.mtpBarang.TabIndex = 0;
            this.mtpBarang.Text = "Barang";
            this.mtpBarang.VerticalScrollbarBarColor = true;
            // 
            // dgvBarang
            // 
            this.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarang.Location = new System.Drawing.Point(0, 51);
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.Size = new System.Drawing.Size(609, 250);
            this.dgvBarang.TabIndex = 2;
            // 
            // mtpSupplier
            // 
            this.mtpSupplier.Controls.Add(this.txtFilterSupplier);
            this.mtpSupplier.Controls.Add(this.metroLabel2);
            this.mtpSupplier.Controls.Add(this.dgvSupplier);
            this.mtpSupplier.HorizontalScrollbarBarColor = true;
            this.mtpSupplier.Location = new System.Drawing.Point(4, 35);
            this.mtpSupplier.Name = "mtpSupplier";
            this.mtpSupplier.Size = new System.Drawing.Size(609, 297);
            this.mtpSupplier.TabIndex = 2;
            this.mtpSupplier.Text = "Supplier";
            this.mtpSupplier.VerticalScrollbarBarColor = true;
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Location = new System.Drawing.Point(0, 50);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.Size = new System.Drawing.Size(609, 247);
            this.dgvSupplier.TabIndex = 3;
            // 
            // mtpCustomer
            // 
            this.mtpCustomer.Controls.Add(this.txtFilterCustomer);
            this.mtpCustomer.Controls.Add(this.metroLabel3);
            this.mtpCustomer.Controls.Add(this.dgvCustomer);
            this.mtpCustomer.HorizontalScrollbarBarColor = true;
            this.mtpCustomer.Location = new System.Drawing.Point(4, 35);
            this.mtpCustomer.Name = "mtpCustomer";
            this.mtpCustomer.Size = new System.Drawing.Size(609, 297);
            this.mtpCustomer.TabIndex = 1;
            this.mtpCustomer.Text = "Customer";
            this.mtpCustomer.VerticalScrollbarBarColor = true;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 52);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.Size = new System.Drawing.Size(609, 249);
            this.dgvCustomer.TabIndex = 2;
            // 
            // txtFilterBarang
            // 
            this.txtFilterBarang.Location = new System.Drawing.Point(53, 16);
            this.txtFilterBarang.Name = "txtFilterBarang";
            this.txtFilterBarang.Size = new System.Drawing.Size(556, 20);
            this.txtFilterBarang.TabIndex = 4;
            this.txtFilterBarang.TextChanged += new System.EventHandler(this.txtFilterBarang_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(-1, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Filter";
            // 
            // txtFilterSupplier
            // 
            this.txtFilterSupplier.Location = new System.Drawing.Point(53, 14);
            this.txtFilterSupplier.Name = "txtFilterSupplier";
            this.txtFilterSupplier.Size = new System.Drawing.Size(553, 20);
            this.txtFilterSupplier.TabIndex = 5;
            this.txtFilterSupplier.TextChanged += new System.EventHandler(this.txtFilterSupplier_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(-1, 9);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 25);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Filter";
            // 
            // txtFilterCustomer
            // 
            this.txtFilterCustomer.Location = new System.Drawing.Point(53, 17);
            this.txtFilterCustomer.Name = "txtFilterCustomer";
            this.txtFilterCustomer.Size = new System.Drawing.Size(556, 20);
            this.txtFilterCustomer.TabIndex = 4;
            this.txtFilterCustomer.TextChanged += new System.EventHandler(this.txtFilterCustomer_TextChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(-1, 12);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 25);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Filter";
            // 
            // frmLihat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 423);
            this.Controls.Add(this.mtcDaftar);
            this.Name = "frmLihat";
            this.Resizable = false;
            this.Text = "Daftar Data";
            this.Shown += new System.EventHandler(this.frmLihat_Shown);
            this.mtcDaftar.ResumeLayout(false);
            this.mtpBarang.ResumeLayout(false);
            this.mtpBarang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            this.mtpSupplier.ResumeLayout(false);
            this.mtpSupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.mtpCustomer.ResumeLayout(false);
            this.mtpCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtcDaftar;
        private MetroFramework.Controls.MetroTabPage mtpBarang;
        private System.Windows.Forms.DataGridView dgvBarang;
        private MetroFramework.Controls.MetroTabPage mtpCustomer;
        private MetroFramework.Controls.MetroTabPage mtpSupplier;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.TextBox txtFilterBarang;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox txtFilterSupplier;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox txtFilterCustomer;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}