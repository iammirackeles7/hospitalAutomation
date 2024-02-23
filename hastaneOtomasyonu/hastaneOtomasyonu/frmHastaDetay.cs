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
    public partial class frmHastaDetay : Form
    {
        public frmHastaDetay()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        public string tc;
        private void frmHastaDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = tc;

            //Ad ve soyadı çekme
            SqlCommand komut = new SqlCommand("Select hastaAd,hastaSoyad From hastalar where hastaTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] +" "+ dr[1];
            }
            bgl.baglanti().Close();
            //randevu geçmişi 
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From randevular where hastaTc=" + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //branşları çekme
            SqlCommand komut2 = new SqlCommand("Select bransAd From brans",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
                
           

        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select doktorAd,doktorSoyad From doktorlar where doktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoktor.Items.Add(dr3[0] + "" + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da= new SqlDataAdapter ("Select * From randevular where randevuBrans= '" + cmbBrans.Text + "'" , bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void lnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBilgiDuzenle fr = new frmBilgiDuzenle();
            fr.TCNo = lblTC.Text;
            fr.Show();

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
