
namespace hastaneOtomasyonu
{
    partial class frmDoktorGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoktorGiris));
            this.tcNo = new System.Windows.Forms.MaskedTextBox();
            this.girisButon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hastaSifre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcNo
            // 
            this.tcNo.Location = new System.Drawing.Point(201, 141);
            this.tcNo.Mask = "00000000000";
            this.tcNo.Name = "tcNo";
            this.tcNo.Size = new System.Drawing.Size(160, 36);
            this.tcNo.TabIndex = 11;
            this.tcNo.ValidatingType = typeof(int);
            // 
            // girisButon
            // 
            this.girisButon.Location = new System.Drawing.Point(202, 251);
            this.girisButon.Name = "girisButon";
            this.girisButon.Size = new System.Drawing.Size(159, 44);
            this.girisButon.TabIndex = 10;
            this.girisButon.Text = "Giriş";
            this.girisButon.UseVisualStyleBackColor = true;
            this.girisButon.Click += new System.EventHandler(this.girisButon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "TC. Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 49);
            this.label1.TabIndex = 7;
            this.label1.Text = "Doktor Giriş Paneli";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(399, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // hastaSifre
            // 
            this.hastaSifre.Location = new System.Drawing.Point(202, 198);
            this.hastaSifre.Name = "hastaSifre";
            this.hastaSifre.Size = new System.Drawing.Size(159, 36);
            this.hastaSifre.TabIndex = 12;
            this.hastaSifre.UseSystemPasswordChar = true;
            // 
            // frmDoktorGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(621, 313);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hastaSifre);
            this.Controls.Add(this.tcNo);
            this.Controls.Add(this.girisButon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDoktorGiris";
            this.Text = "Doktor Giriş";
            this.Load += new System.EventHandler(this.frmDoktorGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox tcNo;
        private System.Windows.Forms.Button girisButon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox hastaSifre;
    }
}