using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hastaneOtomasyonu
{
    public partial class frmDoktorPaneli : Form
    {
        public frmDoktorPaneli()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
        

        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void frmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;


            //Branşları comboBox'a aktarma 
            SqlCommand komut2 = new SqlCommand("Select bransAd From Brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into doktorlar (doktorAd,doktorSoyad,doktorBrans,doktorTc,doktorSifre) values (@d1, @d2, @d3, @d4, @d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txtAd.Text);
            komut.Parameters.AddWithValue("@d2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@d4", mskTC.Text);
            komut.Parameters.AddWithValue("@d5", txtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from doktorlar where doktorTc = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update doktorlar set doktorAd =@d1, doktorSoyad=@d2, doktorBrans = @d3, doktorSifre = @d5 where doktorTc=@d4", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txtAd.Text);
            komut.Parameters.AddWithValue("@d2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@d4", mskTC.Text);
            komut.Parameters.AddWithValue("@d5", txtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
