
namespace hastaneOtomasyonu
{
    partial class frmDoktoDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoktoDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(985, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgi";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(131, 80);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(98, 29);
            this.lblAdSoyad.TabIndex = 3;
            this.lblAdSoyad.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad Soyad:";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(131, 51);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(145, 29);
            this.lblTc.TabIndex = 1;
            this.lblTc.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(986, 399);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(974, 358);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmDoktoDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1010, 597);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDoktoDetay";
            this.Text = "Doktor Detay";
            this.Load += new System.EventHandler(this.frmDoktoDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}