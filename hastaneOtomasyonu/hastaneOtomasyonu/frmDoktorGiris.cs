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
    public partial class frmDoktorGiris : Form
    {
        public frmDoktorGiris()
        {
            InitializeComponent();
        }
        
        private void frmDoktorGiris_Load(object sender, EventArgs e)
        {
            

        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void girisButon_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From doktorlar where doktorTc=@p1 and doktorSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tcNo.Text);
            komut.Parameters.AddWithValue("@p2", textBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmDoktoDetay fr = new frmDoktoDetay();
                fr.TC = tcNo.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre");
            }
            bgl.baglanti().Close();
        }
    }
}
