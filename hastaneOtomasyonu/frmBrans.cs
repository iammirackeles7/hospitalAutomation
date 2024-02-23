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
    public partial class frmBrans : Form
    {
        public frmBrans()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void frmBrans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From brans", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into brans (bransAd) values (@b1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", txtSoyad.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete From brans where bransId=@b1", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", txtAd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silindi"); 
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("update brans set bransId=@p1 where bransAd=@p2", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", txtAd.Text);
            komut1.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Güncellendi");

        }
    }
}
