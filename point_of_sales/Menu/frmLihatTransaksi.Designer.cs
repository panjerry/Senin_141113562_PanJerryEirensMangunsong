namespace Latihan_Pos.Menu
{
    partial class frmLihatTransaksi
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
            this.mtcDaftarTransaksi = new MetroFramework.Controls.MetroTabControl();
            this.mtpPembelian = new MetroFramework.Controls.MetroTabPage();
            this.txtFilterPembelian = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dgvPembelian = new System.Windows.Forms.DataGridView();
            this.mtpPenjualan = new MetroFramework.Controls.MetroTabPage();
            this.txtFilterPenjualan = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dgvPenjualan = new System.Windows.Forms.DataGridView();
            this.mtpPenjualanDetail = new MetroFramework.Controls.MetroTabPage();
            this.txtFilterPenjualanDetail = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dgvPenjualanDetail = new System.Windows.Forms.DataGridView();
            this.mtpPembelianDetail = new MetroFramework.Controls.MetroTabPage();
            this.txtFilterPembelianDetail = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgvPembelianDetail = new System.Windows.Forms.DataGridView();
            this.mtcDaftarTransaksi.SuspendLayout();
            this.mtpPembelian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembelian)).BeginInit();
            this.mtpPenjualan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenjualan)).BeginInit();
            this.mtpPenjualanDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenjualanDetail)).BeginInit();
            this.mtpPembelianDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembelianDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // mtcDaftarTransaksi
            // 
            this.mtcDaftarTransaksi.Controls.Add(this.mtpPembelian);
            this.mtcDaftarTransaksi.Controls.Add(this.mtpPembelianDetail);
            this.mtcDaftarTransaksi.Controls.Add(this.mtpPenjualan);
            this.mtcDaftarTransaksi.Controls.Add(this.mtpPenjualanDetail);
            this.mtcDaftarTransaksi.Location = new System.Drawing.Point(24, 64);
            this.mtcDaftarTransaksi.Name = "mtcDaftarTransaksi";
            this.mtcDaftarTransaksi.SelectedIndex = 3;
            this.mtcDaftarTransaksi.Size = new System.Drawing.Size(621, 339);
            this.mtcDaftarTransaksi.TabIndex = 0;
            // 
            // mtpPembelian
            // 
            this.mtpPembelian.Controls.Add(this.txtFilterPembelian);
            this.mtpPembelian.Controls.Add(this.metroLabel3);
            this.mtpPembelian.Controls.Add(this.dgvPembelian);
            this.mtpPembelian.HorizontalScrollbarBarColor = true;
            this.mtpPembelian.Location = new System.Drawing.Point(4, 35);
            this.mtpPembelian.Name = "mtpPembelian";
            this.mtpPembelian.Size = new System.Drawing.Size(613, 300);
            this.mtpPembelian.TabIndex = 0;
            this.mtpPembelian.Text = "Pembelian";
            this.mtpPembelian.VerticalScrollbarBarColor = true;
            // 
            // txtFilterPembelian
            // 
            this.txtFilterPembelian.Location = new System.Drawing.Point(53, 14);
            this.txtFilterPembelian.Name = "txtFilterPembelian";
            this.txtFilterPembelian.Size = new System.Drawing.Size(556, 20);
            this.txtFilterPembelian.TabIndex = 7;
            this.txtFilterPembelian.TextChanged += new System.EventHandler(this.txtFilterPembelian_TextChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(-1, 9);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 25);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Filter";
            // 
            // dgvPembelian
            // 
            this.dgvPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPembelian.Location = new System.Drawing.Point(0, 49);
            this.dgvPembelian.Name = "dgvPembelian";
            this.dgvPembelian.Size = new System.Drawing.Size(609, 249);
            this.dgvPembelian.TabIndex = 5;
            // 
            // mtpPenjualan
            // 
            this.mtpPenjualan.Controls.Add(this.txtFilterPenjualan);
            this.mtpPenjualan.Controls.Add(this.metroLabel2);
            this.mtpPenjualan.Controls.Add(this.dgvPenjualan);
            this.mtpPenjualan.HorizontalScrollbarBarColor = true;
            this.mtpPenjualan.Location = new System.Drawing.Point(4, 35);
            this.mtpPenjualan.Name = "mtpPenjualan";
            this.mtpPenjualan.Size = new System.Drawing.Size(613, 300);
            this.mtpPenjualan.TabIndex = 2;
            this.mtpPenjualan.Text = "Penjualan";
            this.mtpPenjualan.VerticalScrollbarBarColor = true;
            // 
            // txtFilterPenjualan
            // 
            this.txtFilterPenjualan.Location = new System.Drawing.Point(55, 11);
            this.txtFilterPenjualan.Name = "txtFilterPenjualan";
            this.txtFilterPenjualan.Size = new System.Drawing.Size(556, 20);
            this.txtFilterPenjualan.TabIndex = 10;
            this.txtFilterPenjualan.TextChanged += new System.EventHandler(this.txtFilterPenjualan_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(1, 6);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 25);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Filter";
            // 
            // dgvPenjualan
            // 
            this.dgvPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPenjualan.Location = new System.Drawing.Point(2, 46);
            this.dgvPenjualan.Name = "dgvPenjualan";
            this.dgvPenjualan.Size = new System.Drawing.Size(609, 249);
            this.dgvPenjualan.TabIndex = 8;
            // 
            // mtpPenjualanDetail
            // 
            this.mtpPenjualanDetail.Controls.Add(this.txtFilterPenjualanDetail);
            this.mtpPenjualanDetail.Controls.Add(this.metroLabel4);
            this.mtpPenjualanDetail.Controls.Add(this.dgvPenjualanDetail);
            this.mtpPenjualanDetail.HorizontalScrollbarBarColor = true;
            this.mtpPenjualanDetail.Location = new System.Drawing.Point(4, 35);
            this.mtpPenjualanDetail.Name = "mtpPenjualanDetail";
            this.mtpPenjualanDetail.Size = new System.Drawing.Size(613, 300);
            this.mtpPenjualanDetail.TabIndex = 3;
            this.mtpPenjualanDetail.Text = "Penjualan Detail";
            this.mtpPenjualanDetail.VerticalScrollbarBarColor = true;
            // 
            // txtFilterPenjualanDetail
            // 
            this.txtFilterPenjualanDetail.Location = new System.Drawing.Point(55, 11);
            this.txtFilterPenjualanDetail.Name = "txtFilterPenjualanDetail";
            this.txtFilterPenjualanDetail.Size = new System.Drawing.Size(556, 20);
            this.txtFilterPenjualanDetail.TabIndex = 10;
            this.txtFilterPenjualanDetail.TextChanged += new System.EventHandler(this.txtFilterPenjualanDetail_TextChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(1, 6);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(48, 25);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Filter";
            // 
            // dgvPenjualanDetail
            // 
            this.dgvPenjualanDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPenjualanDetail.Location = new System.Drawing.Point(2, 46);
            this.dgvPenjualanDetail.Name = "dgvPenjualanDetail";
            this.dgvPenjualanDetail.Size = new System.Drawing.Size(609, 249);
            this.dgvPenjualanDetail.TabIndex = 8;
            // 
            // mtpPembelianDetail
            // 
            this.mtpPembelianDetail.Controls.Add(this.txtFilterPembelianDetail);
            this.mtpPembelianDetail.Controls.Add(this.metroLabel1);
            this.mtpPembelianDetail.Controls.Add(this.dgvPembelianDetail);
            this.mtpPembelianDetail.HorizontalScrollbarBarColor = true;
            this.mtpPembelianDetail.Location = new System.Drawing.Point(4, 35);
            this.mtpPembelianDetail.Name = "mtpPembelianDetail";
            this.mtpPembelianDetail.Size = new System.Drawing.Size(613, 300);
            this.mtpPembelianDetail.TabIndex = 1;
            this.mtpPembelianDetail.Text = "Pembelian Detail";
            this.mtpPembelianDetail.VerticalScrollbarBarColor = true;
            // 
            // txtFilterPembelianDetail
            // 
            this.txtFilterPembelianDetail.Location = new System.Drawing.Point(55, 11);
            this.txtFilterPembelianDetail.Name = "txtFilterPembelianDetail";
            this.txtFilterPembelianDetail.Size = new System.Drawing.Size(556, 20);
            this.txtFilterPembelianDetail.TabIndex = 10;
            this.txtFilterPembelianDetail.TextChanged += new System.EventHandler(this.txtFilterPembelianDetail_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(1, 6);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 25);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Filter";
            // 
            // dgvPembelianDetail
            // 
            this.dgvPembelianDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPembelianDetail.Location = new System.Drawing.Point(2, 46);
            this.dgvPembelianDetail.Name = "dgvPembelianDetail";
            this.dgvPembelianDetail.Size = new System.Drawing.Size(609, 249);
            this.dgvPembelianDetail.TabIndex = 8;
            // 
            // frmLihatTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 419);
            this.Controls.Add(this.mtcDaftarTransaksi);
            this.Name = "frmLihatTransaksi";
            this.Resizable = false;
            this.Text = "Daftar Transaksi";
            this.Shown += new System.EventHandler(this.frmLihatTransaksi_Shown);
            this.mtcDaftarTransaksi.ResumeLayout(false);
            this.mtpPembelian.ResumeLayout(false);
            this.mtpPembelian.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembelian)).EndInit();
            this.mtpPenjualan.ResumeLayout(false);
            this.mtpPenjualan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenjualan)).EndInit();
            this.mtpPenjualanDetail.ResumeLayout(false);
            this.mtpPenjualanDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenjualanDetail)).EndInit();
            this.mtpPembelianDetail.ResumeLayout(false);
            this.mtpPembelianDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembelianDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtcDaftarTransaksi;
        private MetroFramework.Controls.MetroTabPage mtpPembelian;
        private System.Windows.Forms.TextBox txtFilterPembelian;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DataGridView dgvPembelian;
        private MetroFramework.Controls.MetroTabPage mtpPembelianDetail;
        private MetroFramework.Controls.MetroTabPage mtpPenjualan;
        private MetroFramework.Controls.MetroTabPage mtpPenjualanDetail;
        private System.Windows.Forms.TextBox txtFilterPembelianDetail;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dgvPembelianDetail;
        private System.Windows.Forms.TextBox txtFilterPenjualan;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridView dgvPenjualan;
        private System.Windows.Forms.TextBox txtFilterPenjualanDetail;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DataGridView dgvPenjualanDetail;
    }
}