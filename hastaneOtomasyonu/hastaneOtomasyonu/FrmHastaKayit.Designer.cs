
namespace hastaneOtomasyonu
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            this.txtAd = new System.Windows.Forms.TextBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.btnKayitYap = new System.Windows.Forms.Button();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(209, 39);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(159, 36);
            this.txtAd.TabIndex = 1;
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(209, 123);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(160, 36);
            this.mskTC.TabIndex = 3;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "TC. Kimlik No:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(209, 81);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(159, 36);
            this.txtSoyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Soyad:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(209, 208);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(159, 36);
            this.txtSifre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Şifre:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cinsiyet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Telefon Numarası:";
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(209, 166);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(160, 36);
            this.mskTel.TabIndex = 4;
            // 
            // btnKayitYap
            // 
            this.btnKayitYap.BackColor = System.Drawing.Color.SpringGreen;
            this.btnKayitYap.ForeColor = System.Drawing.Color.Black;
            this.btnKayitYap.Location = new System.Drawing.Point(209, 292);
            this.btnKayitYap.Name = "btnKayitYap";
            this.btnKayitYap.Size = new System.Drawing.Size(159, 42);
            this.btnKayitYap.TabIndex = 18;
            this.btnKayitYap.Text = "Kayıt Ol";
            this.btnKayitYap.UseVisualStyleBackColor = false;
            this.btnKayitYap.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek",
            "Diğer"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(209, 250);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(158, 36);
            this.cmbCinsiyet.TabIndex = 6;
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.btnKayitYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(419, 375);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.btnKayitYap);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayit";
            this.Text = "Hasta Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.Button btnKayitYap;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
    }
}