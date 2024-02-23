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
    public partial class frmBilgiDuzenle : Form
    {
        public frmBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string TCNo;
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void frmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskTC.Text = TCNo;
            SqlCommand komut = new SqlCommand("Select * From hastalar where hastaTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                mskTel.Text = dr[4].ToString();
                txtSifre.Text = dr[5].ToString();
                cmbCinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update hastalar set hastaAd=@p1, hastaSoyad=@p2, hastaTelefon=@p3, hastaSifre=@p4, hastaCinsiyet=@p5 where hastaTc=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtAd.Text);
            komut2.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", mskTel.Text);
            komut2.Parameters.AddWithValue("@p4", txtSifre.Text);
            komut2.Parameters.AddWithValue("@p5", cmbCinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", mskTC.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
