namespace VolleyBall_Problem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scorea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.scoreb = new System.Windows.Forms.TextBox();
            this.Btnresult = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rslt2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Volley Ball Match Problem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Score A";
            // 
            // scorea
            // 
            this.scorea.Location = new System.Drawing.Point(63, 61);
            this.scorea.Name = "scorea";
            this.scorea.Size = new System.Drawing.Size(120, 20);
            this.scorea.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Score B";
            // 
            // scoreb
            // 
            this.scoreb.Location = new System.Drawing.Point(63, 100);
            this.scoreb.Name = "scoreb";
            this.scoreb.Size = new System.Drawing.Size(120, 20);
            this.scoreb.TabIndex = 4;
            // 
            // Btnresult
            // 
            this.Btnresult.BackColor = System.Drawing.Color.Black;
            this.Btnresult.ForeColor = System.Drawing.Color.White;
            this.Btnresult.Location = new System.Drawing.Point(74, 137);
            this.Btnresult.Name = "Btnresult";
            this.Btnresult.Size = new System.Drawing.Size(75, 23);
            this.Btnresult.TabIndex = 5;
            this.Btnresult.Text = "Result";
            this.Btnresult.UseVisualStyleBackColor = false;
            this.Btnresult.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(203, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 16);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rslt2
            // 
            this.rslt2.BackColor = System.Drawing.Color.Black;
            this.rslt2.ForeColor = System.Drawing.Color.White;
            this.rslt2.Location = new System.Drawing.Point(63, 182);
            this.rslt2.Name = "rslt2";
            this.rslt2.Size = new System.Drawing.Size(100, 20);
            this.rslt2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(235, 213);
            this.ControlBox = false;
            this.Controls.Add(this.rslt2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btnresult);
            this.Controls.Add(this.scoreb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scorea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox scorea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox scoreb;
        private System.Windows.Forms.Button Btnresult;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox rslt2;
    }
}

