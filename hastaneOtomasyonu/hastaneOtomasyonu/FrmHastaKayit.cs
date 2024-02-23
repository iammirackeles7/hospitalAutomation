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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into hastalar (hastaAd, hastaSoyad,hastaTc, hastaTelefon, hastaSifre, hastaCinsiyet) values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTC.Text);
            komut.Parameters.AddWithValue("@p4", mskTel.Text);
            komut.Parameters.AddWithValue("@p5", txtSifre.Text);
            komut.Parameters.AddWithValue("@p6", cmbCinsiyet.Text);
            komut.ExecuteNonQuery(); //sorguyu çalıştırmak için kullandık
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Başarıyla Gerçekleşmiştir. Şifreniz: " + txtSifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
