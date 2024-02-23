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
    public partial class frmSekreterDetay : Form
    {
        public frmSekreterDetay()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into duyurular (duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", rchDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu");
        }
        public string TCNumara;
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void frmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TCNumara; //sekreter tcsini sekreter detaya gönderme

            //Ad Soyad 
            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad From sekreter where sekreterTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblAdSoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            //Branşları datagride aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select bransAd from brans", bgl.baglanti());
            da.Fill(dt1);
            dataGridView2.DataSource = dt1;

            //Doktorları listeye aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (doktorAd + ' ' + doktorSoyad) as 'Doktorlar',doktorBrans From doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView3.DataSource = dt2;


            //branşı comboBox'a aktarma
            SqlCommand komut2 = new SqlCommand("Select bransAd From brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutKaydet = new SqlCommand("insert into randevular (randevuTarih,randevuSaat,randevuBrans,randevuDoktor)values(@r1,@r2,@r3,@r4)",bgl.baglanti());
            komutKaydet.Parameters.AddWithValue("@r1", mskTarih.Text);
            komutKaydet.Parameters.AddWithValue("@r2", mskSaat.Text);
            komutKaydet.Parameters.AddWithValue("@r3", cmbBrans.Text);
            komutKaydet.Parameters.AddWithValue("@r4", cmbDoktor.Text);
            komutKaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Başarıyla Oluşturuldu.");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("Select doktorAd, doktorSoyad From doktorlar where doktorBrans =@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void btnDoktorPanel_Click(object sender, EventArgs e)
        {
            frmDoktorPaneli drp = new frmDoktorPaneli();
            drp.Show();
        }

        private void btnBransPanel_Click(object sender, EventArgs e)
        {
            frmBrans frb = new frmBrans();
            frb.Show();
        }

        private void btnRandevuListe_Click(object sender, EventArgs e)
        {
            frmRandevuListesi frl = new frmRandevuListesi();
            frl.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmDuyurular fr = new frmDuyurular();
            fr.Show();
        }
    }
}
