namespace _13._02._2024._1473._2
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTelofon = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.nCorba = new System.Windows.Forms.NumericUpDown();
            this.nSalata = new System.Windows.Forms.NumericUpDown();
            this.nAnaYemek = new System.Windows.Forms.NumericUpDown();
            this.nTatli = new System.Windows.Forms.NumericUpDown();
            this.txtBilgi = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCorba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSalata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAnaYemek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTatli)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(77, 69);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(582, 325);
            this.tabControl2.TabIndex = 1;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtAdres);
            this.tabPage1.Controls.Add(this.txtTelofon);
            this.tabPage1.Controls.Add(this.txtAdSoyad);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(574, 299);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "müşteri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.txtBilgi);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(574, 299);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "hesap";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ad soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "adres";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(116, 57);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(210, 20);
            this.txtAdSoyad.TabIndex = 3;
            // 
            // txtTelofon
            // 
            this.txtTelofon.Location = new System.Drawing.Point(116, 100);
            this.txtTelofon.Name = "txtTelofon";
            this.txtTelofon.Size = new System.Drawing.Size(210, 20);
            this.txtTelofon.TabIndex = 4;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(116, 143);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(210, 101);
            this.txtAdres.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "çorba";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "salata";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "ana yemek";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "tatlı";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.nTatli);
            this.tabPage3.Controls.Add(this.nAnaYemek);
            this.tabPage3.Controls.Add(this.nSalata);
            this.tabPage3.Controls.Add(this.nCorba);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(574, 299);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "sipariş";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // nCorba
            // 
            this.nCorba.Location = new System.Drawing.Point(127, 53);
            this.nCorba.Name = "nCorba";
            this.nCorba.Size = new System.Drawing.Size(120, 20);
            this.nCorba.TabIndex = 4;
            // 
            // nSalata
            // 
            this.nSalata.Location = new System.Drawing.Point(127, 101);
            this.nSalata.Name = "nSalata";
            this.nSalata.Size = new System.Drawing.Size(120, 20);
            this.nSalata.TabIndex = 5;
            // 
            // nAnaYemek
            // 
            this.nAnaYemek.Location = new System.Drawing.Point(127, 156);
            this.nAnaYemek.Name = "nAnaYemek";
            this.nAnaYemek.Size = new System.Drawing.Size(120, 20);
            this.nAnaYemek.TabIndex = 6;
            // 
            // nTatli
            // 
            this.nTatli.Location = new System.Drawing.Point(127, 204);
            this.nTatli.Name = "nTatli";
            this.nTatli.Size = new System.Drawing.Size(120, 20);
            this.nTatli.TabIndex = 7;
            // 
            // txtBilgi
            // 
            this.txtBilgi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBilgi.Location = new System.Drawing.Point(3, 3);
            this.txtBilgi.Multiline = true;
            this.txtBilgi.Name = "txtBilgi";
            this.txtBilgi.Size = new System.Drawing.Size(568, 293);
            this.txtBilgi.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(568, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCorba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSalata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAnaYemek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTatli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelofon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.NumericUpDown nTatli;
        private System.Windows.Forms.NumericUpDown nAnaYemek;
        private System.Windows.Forms.NumericUpDown nSalata;
        private System.Windows.Forms.NumericUpDown nCorba;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtBilgi;
        private System.Windows.Forms.TextBox textBox1;
    }
}

