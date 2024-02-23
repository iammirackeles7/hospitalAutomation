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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from hastalar Where hastaTc=@p1 and hastaSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tcNo.Text);
            komut.Parameters.AddWithValue("@p2", hastaSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmHastaDetay fr = new frmHastaDetay();
                fr.tc = tcNo.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC kimlik numaranız veya şifreniz yanlıştır.");
            }
            bgl.baglanti().Close();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void linkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit fr = new FrmHastaKayit();
            fr.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
