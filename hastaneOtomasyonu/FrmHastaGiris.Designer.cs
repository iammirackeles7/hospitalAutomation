
namespace hastaneOtomasyonu
{
    partial class FrmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.girisButon = new System.Windows.Forms.Button();
            this.tcNo = new System.Windows.Forms.MaskedTextBox();
            this.hastaSifre = new System.Windows.Forms.TextBox();
            this.linkUyeOl = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(180, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giriş Paneli";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC. Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // girisButon
            // 
            this.girisButon.Location = new System.Drawing.Point(179, 235);
            this.girisButon.Name = "girisButon";
            this.girisButon.Size = new System.Drawing.Size(159, 44);
            this.girisButon.TabIndex = 3;
            this.girisButon.Text = "Giriş";
            this.girisButon.UseVisualStyleBackColor = true;
            this.girisButon.Click += new System.EventHandler(this.button1_Click);
            // 
            // tcNo
            // 
            this.tcNo.Location = new System.Drawing.Point(178, 125);
            this.tcNo.Mask = "00000000000";
            this.tcNo.Name = "tcNo";
            this.tcNo.Size = new System.Drawing.Size(160, 36);
            this.tcNo.TabIndex = 4;
            this.tcNo.ValidatingType = typeof(int);
            // 
            // hastaSifre
            // 
            this.hastaSifre.Location = new System.Drawing.Point(179, 182);
            this.hastaSifre.Name = "hastaSifre";
            this.hastaSifre.Size = new System.Drawing.Size(159, 36);
            this.hastaSifre.TabIndex = 5;
            this.hastaSifre.UseSystemPasswordChar = true;
            // 
            // linkUyeOl
            // 
            this.linkUyeOl.AutoSize = true;
            this.linkUyeOl.BackColor = System.Drawing.Color.Silver;
            this.linkUyeOl.LinkColor = System.Drawing.Color.Black;
            this.linkUyeOl.Location = new System.Drawing.Point(248, 288);
            this.linkUyeOl.Name = "linkUyeOl";
            this.linkUyeOl.Size = new System.Drawing.Size(90, 29);
            this.linkUyeOl.TabIndex = 6;
            this.linkUyeOl.TabStop = true;
            this.linkUyeOl.Text = "Kayıt Ol";
            this.linkUyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUyeOl_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(395, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FrmHastaGiris
            // 
            this.AcceptButton = this.girisButon;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(701, 354);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkUyeOl);
            this.Controls.Add(this.hastaSifre);
            this.Controls.Add(this.tcNo);
            this.Controls.Add(this.girisButon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Italic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "FrmHastaGiris";
            this.Text = "Hasta Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button girisButon;
        private System.Windows.Forms.MaskedTextBox tcNo;
        private System.Windows.Forms.TextBox hastaSifre;
        private System.Windows.Forms.LinkLabel linkUyeOl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}