
namespace hastaneOtomasyonu
{
    partial class frmBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBilgiDuzenle));
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.guncelle = new System.Windows.Forms.Button();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.ItemHeight = 28;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek",
            "Diğer"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(217, 240);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(158, 36);
            this.cmbCinsiyet.TabIndex = 32;
            // 
            // guncelle
            // 
            this.guncelle.BackColor = System.Drawing.Color.LightGreen;
            this.guncelle.ForeColor = System.Drawing.Color.Black;
            this.guncelle.Location = new System.Drawing.Point(217, 282);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(159, 42);
            this.guncelle.TabIndex = 31;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = false;
            this.guncelle.Click += new System.EventHandler(this.button1_Click);
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(217, 156);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(160, 36);
            this.mskTel.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 29);
            this.label6.TabIndex = 29;
            this.label6.Text = "Telefon Numarası:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 29);
            this.label5.TabIndex = 28;
            this.label5.Text = "Cinsiyet:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(217, 198);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(159, 36);
            this.txtSifre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Şifre:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(217, 71);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(159, 36);
            this.txtSoyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(217, 29);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(159, 36);
            this.txtAd.TabIndex = 1;
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(217, 113);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(160, 36);
            this.mskTC.TabIndex = 3;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "TC. Kimlik No:";
            // 
            // frmBilgiDuzenle
            // 
            this.AcceptButton = this.guncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(414, 363);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.guncelle);
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
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmBilgiDuzenle";
            this.Text = "Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.frmBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}