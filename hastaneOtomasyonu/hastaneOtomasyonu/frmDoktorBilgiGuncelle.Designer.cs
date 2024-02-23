
namespace hastaneOtomasyonu
{
    partial class frmDoktorBilgiGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoktorBilgiGuncelle));
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Red;
            this.btnGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btnGuncelle.Location = new System.Drawing.Point(196, 257);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(159, 42);
            this.btnGuncelle.TabIndex = 44;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(195, 208);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(159, 36);
            this.txtSifre.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 29);
            this.label4.TabIndex = 39;
            this.label4.Text = "Şifre:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(195, 82);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(159, 36);
            this.txtSoyad.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 37;
            this.label1.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(195, 40);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(159, 36);
            this.txtAd.TabIndex = 36;
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(195, 124);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(160, 36);
            this.mskTC.TabIndex = 35;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 29);
            this.label3.TabIndex = 34;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "TC. Kimlik No:";
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(195, 166);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(160, 36);
            this.cmbBrans.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 29);
            this.label5.TabIndex = 46;
            this.label5.Text = "Branş:";
            // 
            // frmDoktorBilgiGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(411, 342);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.btnGuncelle);
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
            this.Name = "frmDoktorBilgiGuncelle";
            this.Text = "frmDoktorBilgiGuncelle";
            this.Load += new System.EventHandler(this.frmDoktorBilgiGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Label label5;
    }
}