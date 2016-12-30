namespace Latihan_Pos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mtRegistrasi = new MetroFramework.Controls.MetroTile();
            this.mtDaftar = new MetroFramework.Controls.MetroTile();
            this.mtEdit = new MetroFramework.Controls.MetroTile();
            this.mtHapus = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mtTambahTransaksi = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtRegistrasi
            // 
            this.mtRegistrasi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtRegistrasi.Location = new System.Drawing.Point(485, 232);
            this.mtRegistrasi.Margin = new System.Windows.Forms.Padding(20);
            this.mtRegistrasi.Name = "mtRegistrasi";
            this.mtRegistrasi.Size = new System.Drawing.Size(175, 175);
            this.mtRegistrasi.TabIndex = 1;
            this.mtRegistrasi.Text = "Registrasi Data";
            this.mtRegistrasi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtRegistrasi.TileImage = ((System.Drawing.Image)(resources.GetObject("mtRegistrasi.TileImage")));
            this.mtRegistrasi.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtRegistrasi.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtRegistrasi.UseTileImage = true;
            this.mtRegistrasi.Click += new System.EventHandler(this.mtRegistrasi_Click);
            // 
            // mtDaftar
            // 
            this.mtDaftar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtDaftar.Location = new System.Drawing.Point(270, 232);
            this.mtDaftar.Margin = new System.Windows.Forms.Padding(20);
            this.mtDaftar.Name = "mtDaftar";
            this.mtDaftar.Size = new System.Drawing.Size(175, 175);
            this.mtDaftar.TabIndex = 0;
            this.mtDaftar.Text = "Daftar Data";
            this.mtDaftar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtDaftar.TileImage = ((System.Drawing.Image)(resources.GetObject("mtDaftar.TileImage")));
            this.mtDaftar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtDaftar.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtDaftar.UseMnemonic = false;
            this.mtDaftar.UseTileImage = true;
            this.mtDaftar.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // mtEdit
            // 
            this.mtEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtEdit.Location = new System.Drawing.Point(700, 232);
            this.mtEdit.Margin = new System.Windows.Forms.Padding(20);
            this.mtEdit.Name = "mtEdit";
            this.mtEdit.Size = new System.Drawing.Size(175, 175);
            this.mtEdit.TabIndex = 2;
            this.mtEdit.Text = "Edit Data";
            this.mtEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtEdit.TileImage = ((System.Drawing.Image)(resources.GetObject("mtEdit.TileImage")));
            this.mtEdit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtEdit.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtEdit.UseTileImage = true;
            this.mtEdit.Click += new System.EventHandler(this.mtEdit_Click);
            // 
            // mtHapus
            // 
            this.mtHapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtHapus.Location = new System.Drawing.Point(915, 232);
            this.mtHapus.Margin = new System.Windows.Forms.Padding(20);
            this.mtHapus.Name = "mtHapus";
            this.mtHapus.Size = new System.Drawing.Size(175, 175);
            this.mtHapus.TabIndex = 3;
            this.mtHapus.Text = "Hapus Data";
            this.mtHapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtHapus.TileImage = ((System.Drawing.Image)(resources.GetObject("mtHapus.TileImage")));
            this.mtHapus.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtHapus.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtHapus.UseTileImage = true;
            this.mtHapus.Click += new System.EventHandler(this.mtHapus_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile1.Location = new System.Drawing.Point(270, 447);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(20);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(175, 175);
            this.metroTile1.TabIndex = 4;
            this.metroTile1.Text = "Daftar Transaksi";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.mtLihatTransaksi_Click);
            // 
            // mtTambahTransaksi
            // 
            this.mtTambahTransaksi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtTambahTransaksi.Location = new System.Drawing.Point(485, 447);
            this.mtTambahTransaksi.Margin = new System.Windows.Forms.Padding(20);
            this.mtTambahTransaksi.Name = "mtTambahTransaksi";
            this.mtTambahTransaksi.Size = new System.Drawing.Size(175, 175);
            this.mtTambahTransaksi.TabIndex = 5;
            this.mtTambahTransaksi.Text = "Kelola Transaksi";
            this.mtTambahTransaksi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtTambahTransaksi.TileImage = ((System.Drawing.Image)(resources.GetObject("mtTambahTransaksi.TileImage")));
            this.mtTambahTransaksi.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtTambahTransaksi.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtTambahTransaksi.UseTileImage = true;
            this.mtTambahTransaksi.Click += new System.EventHandler(this.mtTambahTransaksi_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 728);
            this.Controls.Add(this.mtTambahTransaksi);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mtHapus);
            this.Controls.Add(this.mtEdit);
            this.Controls.Add(this.mtDaftar);
            this.Controls.Add(this.mtRegistrasi);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(250, 80, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Text = "Xanxiver P.O.S";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtRegistrasi;
        private MetroFramework.Controls.MetroTile mtDaftar;
        private MetroFramework.Controls.MetroTile mtEdit;
        private MetroFramework.Controls.MetroTile mtHapus;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile mtTambahTransaksi;


    }
}

