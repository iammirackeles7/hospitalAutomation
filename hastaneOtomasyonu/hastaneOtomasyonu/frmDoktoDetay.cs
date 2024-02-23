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
    public partial class frmDoktoDetay : Form
    {
        public frmDoktoDetay()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        public String TC;
        private void frmDoktoDetay_Load(object sender, EventArgs e)
        {
            lblTc.Text = TC;
            //Doktor ad soyad çekme
          
        SqlCommand komut = new SqlCommand("Select doktorAd,doktorSoyad from doktorlar where doktorTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From randevular where randevuDoktor='" + lblAdSoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt; 
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            frmBilgiDuzenle fr = new frmBilgiDuzenle();
            fr.TCNo = lblTc.Text;
            fr.Show();
        }
    }
}
