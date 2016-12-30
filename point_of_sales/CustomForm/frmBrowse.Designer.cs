namespace Latihan_Pos.CustomForm
{
    partial class frmBrowse
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
            this.dgvBrowse = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrowse)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBrowse
            // 
            this.dgvBrowse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrowse.Location = new System.Drawing.Point(24, 107);
            this.dgvBrowse.Name = "dgvBrowse";
            this.dgvBrowse.ReadOnly = true;
            this.dgvBrowse.Size = new System.Drawing.Size(530, 274);
            this.dgvBrowse.TabIndex = 0;
            this.dgvBrowse.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBrowseClick);
            this.dgvBrowse.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBrowseClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(24, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Filter";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(78, 65);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(475, 20);
            this.txtFilter.TabIndex = 2;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // frmBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 404);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dgvBrowse);
            this.Name = "frmBrowse";
            this.Resizable = false;
            this.Text = "Browse";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrowse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBrowse;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox txtFilter;
    }
}