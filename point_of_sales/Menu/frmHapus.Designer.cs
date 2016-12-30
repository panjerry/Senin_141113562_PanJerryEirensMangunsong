namespace Latihan_Pos.Menu
{
    partial class frmHapus
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.mtpBarang = new MetroFramework.Controls.MetroTabPage();
            this.btnHapusBarang = new MetroFramework.Controls.MetroButton();
            this.btnBrowseBarang = new MetroFramework.Controls.MetroButton();
            this.txtIdBarang = new System.Windows.Forms.TextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.txtHargaHpp = new System.Windows.Forms.TextBox();
            this.txtHargaJual = new System.Windows.Forms.TextBox();
            this.txtJumlahAwal = new System.Windows.Forms.TextBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.mtpSupplier = new MetroFramework.Controls.MetroTabPage();
            this.btnBrowseSupplier = new MetroFramework.Controls.MetroButton();
            this.txtIdSupplier = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnHapusSupplier = new MetroFramework.Controls.MetroButton();
            this.txtTeleponSupplier = new System.Windows.Forms.TextBox();
            this.txtAlamatSupplier = new System.Windows.Forms.TextBox();
            this.txtNamaSupplier = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.mtpCustomer = new MetroFramework.Controls.MetroTabPage();
            this.btnBrowseCustomer = new MetroFramework.Controls.MetroButton();
            this.txtIdCustomer = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnHapusCustomer = new MetroFramework.Controls.MetroButton();
            this.txtTeleponCustomer = new System.Windows.Forms.TextBox();
            this.txtAlamatCustomer = new System.Windows.Forms.TextBox();
            this.txtNamaCustomer = new System.Windows.Forms.TextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl2.SuspendLayout();
            this.mtpBarang.SuspendLayout();
            this.mtpSupplier.SuspendLayout();
            this.mtpCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Location = new System.Drawing.Point(256, 103);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.Size = new System.Drawing.Size(200, 100);
            this.metroTabControl1.TabIndex = 0;
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.mtpBarang);
            this.metroTabControl2.Controls.Add(this.mtpCustomer);
            this.metroTabControl2.Controls.Add(this.mtpSupplier);
            this.metroTabControl2.Location = new System.Drawing.Point(24, 55);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 0;
            this.metroTabControl2.Size = new System.Drawing.Size(505, 314);
            this.metroTabControl2.TabIndex = 1;
            // 
            // mtpBarang
            // 
            this.mtpBarang.Controls.Add(this.btnHapusBarang);
            this.mtpBarang.Controls.Add(this.btnBrowseBarang);
            this.mtpBarang.Controls.Add(this.txtIdBarang);
            this.mtpBarang.Controls.Add(this.metroLabel14);
            this.mtpBarang.Controls.Add(this.txtHargaHpp);
            this.mtpBarang.Controls.Add(this.txtHargaJual);
            this.mtpBarang.Controls.Add(this.txtJumlahAwal);
            this.mtpBarang.Controls.Add(this.txtNamaBarang);
            this.mtpBarang.Controls.Add(this.txtKode);
            this.mtpBarang.Controls.Add(this.metroLabel9);
            this.mtpBarang.Controls.Add(this.metroLabel10);
            this.mtpBarang.Controls.Add(this.metroLabel11);
            this.mtpBarang.Controls.Add(this.metroLabel12);
            this.mtpBarang.Controls.Add(this.metroLabel13);
            this.mtpBarang.HorizontalScrollbarBarColor = true;
            this.mtpBarang.Location = new System.Drawing.Point(4, 35);
            this.mtpBarang.Name = "mtpBarang";
            this.mtpBarang.Size = new System.Drawing.Size(497, 275);
            this.mtpBarang.TabIndex = 0;
            this.mtpBarang.Text = "Barang";
            this.mtpBarang.VerticalScrollbarBarColor = true;
            // 
            // btnHapusBarang
            // 
            this.btnHapusBarang.Location = new System.Drawing.Point(385, 221);
            this.btnHapusBarang.Name = "btnHapusBarang";
            this.btnHapusBarang.Size = new System.Drawing.Size(75, 23);
            this.btnHapusBarang.TabIndex = 40;
            this.btnHapusBarang.Text = "Hapus";
            this.btnHapusBarang.Click += new System.EventHandler(this.btnHapusBarang_Click);
            // 
            // btnBrowseBarang
            // 
            this.btnBrowseBarang.Location = new System.Drawing.Point(370, 32);
            this.btnBrowseBarang.Name = "btnBrowseBarang";
            this.btnBrowseBarang.Size = new System.Drawing.Size(90, 23);
            this.btnBrowseBarang.TabIndex = 39;
            this.btnBrowseBarang.Text = "Browse";
            this.btnBrowseBarang.Click += new System.EventHandler(this.btnBrowseBarang_Click);
            // 
            // txtIdBarang
            // 
            this.txtIdBarang.Enabled = false;
            this.txtIdBarang.Location = new System.Drawing.Point(154, 32);
            this.txtIdBarang.Name = "txtIdBarang";
            this.txtIdBarang.Size = new System.Drawing.Size(210, 20);
            this.txtIdBarang.TabIndex = 38;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(117, 30);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(30, 25);
            this.metroLabel14.TabIndex = 37;
            this.metroLabel14.Text = "ID";
            // 
            // txtHargaHpp
            // 
            this.txtHargaHpp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHargaHpp.Location = new System.Drawing.Point(154, 162);
            this.txtHargaHpp.Name = "txtHargaHpp";
            this.txtHargaHpp.Size = new System.Drawing.Size(306, 20);
            this.txtHargaHpp.TabIndex = 35;
            // 
            // txtHargaJual
            // 
            this.txtHargaJual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHargaJual.Location = new System.Drawing.Point(154, 195);
            this.txtHargaJual.Name = "txtHargaJual";
            this.txtHargaJual.Size = new System.Drawing.Size(306, 20);
            this.txtHargaJual.TabIndex = 36;
            // 
            // txtJumlahAwal
            // 
            this.txtJumlahAwal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJumlahAwal.Location = new System.Drawing.Point(154, 130);
            this.txtJumlahAwal.Name = "txtJumlahAwal";
            this.txtJumlahAwal.Size = new System.Drawing.Size(306, 20);
            this.txtJumlahAwal.TabIndex = 34;
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNamaBarang.Location = new System.Drawing.Point(154, 101);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(306, 20);
            this.txtNamaBarang.TabIndex = 33;
            // 
            // txtKode
            // 
            this.txtKode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKode.Location = new System.Drawing.Point(154, 68);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(306, 20);
            this.txtKode.TabIndex = 32;
            // 
            // metroLabel9
            // 
            this.metroLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(93, 68);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(53, 25);
            this.metroLabel9.TabIndex = 27;
            this.metroLabel9.Text = "Kode";
            // 
            // metroLabel10
            // 
            this.metroLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(87, 96);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(59, 25);
            this.metroLabel10.TabIndex = 28;
            this.metroLabel10.Text = "Nama";
            // 
            // metroLabel11
            // 
            this.metroLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(52, 190);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(94, 25);
            this.metroLabel11.TabIndex = 29;
            this.metroLabel11.Text = "Harga Jual";
            // 
            // metroLabel12
            // 
            this.metroLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(46, 162);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(100, 25);
            this.metroLabel12.TabIndex = 31;
            this.metroLabel12.Text = "Harga Hpp";
            // 
            // metroLabel13
            // 
            this.metroLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(36, 129);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(110, 25);
            this.metroLabel13.TabIndex = 30;
            this.metroLabel13.Text = "Jumlah Awal";
            // 
            // mtpSupplier
            // 
            this.mtpSupplier.Controls.Add(this.btnBrowseSupplier);
            this.mtpSupplier.Controls.Add(this.txtIdSupplier);
            this.mtpSupplier.Controls.Add(this.metroLabel3);
            this.mtpSupplier.Controls.Add(this.btnHapusSupplier);
            this.mtpSupplier.Controls.Add(this.txtTeleponSupplier);
            this.mtpSupplier.Controls.Add(this.txtAlamatSupplier);
            this.mtpSupplier.Controls.Add(this.txtNamaSupplier);
            this.mtpSupplier.Controls.Add(this.metroLabel4);
            this.mtpSupplier.Controls.Add(this.metroLabel5);
            this.mtpSupplier.Controls.Add(this.metroLabel6);
            this.mtpSupplier.HorizontalScrollbarBarColor = true;
            this.mtpSupplier.Location = new System.Drawing.Point(4, 35);
            this.mtpSupplier.Name = "mtpSupplier";
            this.mtpSupplier.Size = new System.Drawing.Size(497, 275);
            this.mtpSupplier.TabIndex = 3;
            this.mtpSupplier.Text = "Supplier";
            this.mtpSupplier.VerticalScrollbarBarColor = true;
            // 
            // btnBrowseSupplier
            // 
            this.btnBrowseSupplier.Location = new System.Drawing.Point(348, 51);
            this.btnBrowseSupplier.Name = "btnBrowseSupplier";
            this.btnBrowseSupplier.Size = new System.Drawing.Size(90, 23);
            this.btnBrowseSupplier.TabIndex = 38;
            this.btnBrowseSupplier.Text = "Browse";
            this.btnBrowseSupplier.Click += new System.EventHandler(this.btnBrowseSupplier_Click);
            // 
            // txtIdSupplier
            // 
            this.txtIdSupplier.Enabled = false;
            this.txtIdSupplier.Location = new System.Drawing.Point(132, 51);
            this.txtIdSupplier.Name = "txtIdSupplier";
            this.txtIdSupplier.Size = new System.Drawing.Size(210, 20);
            this.txtIdSupplier.TabIndex = 37;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(95, 51);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(30, 25);
            this.metroLabel3.TabIndex = 36;
            this.metroLabel3.Text = "ID";
            // 
            // btnHapusSupplier
            // 
            this.btnHapusSupplier.Location = new System.Drawing.Point(363, 199);
            this.btnHapusSupplier.Name = "btnHapusSupplier";
            this.btnHapusSupplier.Size = new System.Drawing.Size(75, 23);
            this.btnHapusSupplier.TabIndex = 35;
            this.btnHapusSupplier.Text = "Hapus";
            this.btnHapusSupplier.Click += new System.EventHandler(this.btnHapusSupplier_Click);
            // 
            // txtTeleponSupplier
            // 
            this.txtTeleponSupplier.Location = new System.Drawing.Point(131, 173);
            this.txtTeleponSupplier.Name = "txtTeleponSupplier";
            this.txtTeleponSupplier.Size = new System.Drawing.Size(307, 20);
            this.txtTeleponSupplier.TabIndex = 34;
            // 
            // txtAlamatSupplier
            // 
            this.txtAlamatSupplier.Location = new System.Drawing.Point(131, 131);
            this.txtAlamatSupplier.Name = "txtAlamatSupplier";
            this.txtAlamatSupplier.Size = new System.Drawing.Size(307, 20);
            this.txtAlamatSupplier.TabIndex = 33;
            // 
            // txtNamaSupplier
            // 
            this.txtNamaSupplier.Location = new System.Drawing.Point(131, 89);
            this.txtNamaSupplier.Name = "txtNamaSupplier";
            this.txtNamaSupplier.Size = new System.Drawing.Size(307, 20);
            this.txtNamaSupplier.TabIndex = 32;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(23, 168);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(102, 25);
            this.metroLabel4.TabIndex = 31;
            this.metroLabel4.Text = "No Telepon";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(57, 126);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(68, 25);
            this.metroLabel5.TabIndex = 30;
            this.metroLabel5.Text = "Alamat";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(66, 84);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(59, 25);
            this.metroLabel6.TabIndex = 29;
            this.metroLabel6.Text = "Nama";
            // 
            // mtpCustomer
            // 
            this.mtpCustomer.Controls.Add(this.btnBrowseCustomer);
            this.mtpCustomer.Controls.Add(this.txtIdCustomer);
            this.mtpCustomer.Controls.Add(this.metroLabel2);
            this.mtpCustomer.Controls.Add(this.btnHapusCustomer);
            this.mtpCustomer.Controls.Add(this.txtTeleponCustomer);
            this.mtpCustomer.Controls.Add(this.txtAlamatCustomer);
            this.mtpCustomer.Controls.Add(this.txtNamaCustomer);
            this.mtpCustomer.Controls.Add(this.metroLabel8);
            this.mtpCustomer.Controls.Add(this.metroLabel7);
            this.mtpCustomer.Controls.Add(this.metroLabel1);
            this.mtpCustomer.HorizontalScrollbarBarColor = true;
            this.mtpCustomer.Location = new System.Drawing.Point(4, 35);
            this.mtpCustomer.Name = "mtpCustomer";
            this.mtpCustomer.Size = new System.Drawing.Size(497, 275);
            this.mtpCustomer.TabIndex = 1;
            this.mtpCustomer.Text = "Customer";
            this.mtpCustomer.VerticalScrollbarBarColor = true;
            // 
            // btnBrowseCustomer
            // 
            this.btnBrowseCustomer.Location = new System.Drawing.Point(354, 52);
            this.btnBrowseCustomer.Name = "btnBrowseCustomer";
            this.btnBrowseCustomer.Size = new System.Drawing.Size(90, 23);
            this.btnBrowseCustomer.TabIndex = 28;
            this.btnBrowseCustomer.Text = "Browse";
            this.btnBrowseCustomer.Click += new System.EventHandler(this.btnBrowseCustomer_Click);
            // 
            // txtIdCustomer
            // 
            this.txtIdCustomer.Enabled = false;
            this.txtIdCustomer.Location = new System.Drawing.Point(138, 52);
            this.txtIdCustomer.Name = "txtIdCustomer";
            this.txtIdCustomer.Size = new System.Drawing.Size(210, 20);
            this.txtIdCustomer.TabIndex = 27;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(101, 52);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(30, 25);
            this.metroLabel2.TabIndex = 26;
            this.metroLabel2.Text = "ID";
            // 
            // btnHapusCustomer
            // 
            this.btnHapusCustomer.Location = new System.Drawing.Point(369, 200);
            this.btnHapusCustomer.Name = "btnHapusCustomer";
            this.btnHapusCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnHapusCustomer.TabIndex = 25;
            this.btnHapusCustomer.Text = "Hapus";
            this.btnHapusCustomer.Click += new System.EventHandler(this.btnHapusCustomer_Click);
            // 
            // txtTeleponCustomer
            // 
            this.txtTeleponCustomer.Location = new System.Drawing.Point(137, 174);
            this.txtTeleponCustomer.Name = "txtTeleponCustomer";
            this.txtTeleponCustomer.Size = new System.Drawing.Size(307, 20);
            this.txtTeleponCustomer.TabIndex = 24;
            // 
            // txtAlamatCustomer
            // 
            this.txtAlamatCustomer.Location = new System.Drawing.Point(137, 132);
            this.txtAlamatCustomer.Name = "txtAlamatCustomer";
            this.txtAlamatCustomer.Size = new System.Drawing.Size(307, 20);
            this.txtAlamatCustomer.TabIndex = 23;
            // 
            // txtNamaCustomer
            // 
            this.txtNamaCustomer.Location = new System.Drawing.Point(137, 90);
            this.txtNamaCustomer.Name = "txtNamaCustomer";
            this.txtNamaCustomer.Size = new System.Drawing.Size(307, 20);
            this.txtNamaCustomer.TabIndex = 22;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(29, 169);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(102, 25);
            this.metroLabel8.TabIndex = 21;
            this.metroLabel8.Text = "No Telepon";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(63, 127);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(68, 25);
            this.metroLabel7.TabIndex = 20;
            this.metroLabel7.Text = "Alamat";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(72, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 25);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Nama";
            // 
            // frmHapus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 392);
            this.Controls.Add(this.metroTabControl2);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "frmHapus";
            this.Resizable = false;
            this.Text = "Hapus";
            this.metroTabControl2.ResumeLayout(false);
            this.mtpBarang.ResumeLayout(false);
            this.mtpBarang.PerformLayout();
            this.mtpSupplier.ResumeLayout(false);
            this.mtpSupplier.PerformLayout();
            this.mtpCustomer.ResumeLayout(false);
            this.mtpCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage mtpBarang;
        private MetroFramework.Controls.MetroTabPage mtpCustomer;
        private MetroFramework.Controls.MetroTabPage mtpSupplier;
        private MetroFramework.Controls.MetroButton btnHapusBarang;
        private MetroFramework.Controls.MetroButton btnBrowseBarang;
        private System.Windows.Forms.TextBox txtIdBarang;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private System.Windows.Forms.TextBox txtHargaHpp;
        private System.Windows.Forms.TextBox txtHargaJual;
        private System.Windows.Forms.TextBox txtJumlahAwal;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.TextBox txtKode;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroButton btnBrowseCustomer;
        private System.Windows.Forms.TextBox txtIdCustomer;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnHapusCustomer;
        private System.Windows.Forms.TextBox txtTeleponCustomer;
        private System.Windows.Forms.TextBox txtAlamatCustomer;
        private System.Windows.Forms.TextBox txtNamaCustomer;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnBrowseSupplier;
        private System.Windows.Forms.TextBox txtIdSupplier;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnHapusSupplier;
        private System.Windows.Forms.TextBox txtTeleponSupplier;
        private System.Windows.Forms.TextBox txtAlamatSupplier;
        private System.Windows.Forms.TextBox txtNamaSupplier;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}