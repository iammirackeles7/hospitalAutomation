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
    public partial class frmSekreterGiris : Form
    {
        public frmSekreterGiris()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void girisButon_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From sekreter where sekreterTc=@p1 and sekreterSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tcNo.Text);
            komut.Parameters.AddWithValue("@p2", sekreterSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmSekreterDetay frs = new frmSekreterDetay();
                frs.TCNumara = tcNo.Text;
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC kimlik numaranız veya şifreniz hatalı");
            }
            bgl.baglanti().Close();

        }

        private void frmSekreterGiris_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
