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
    public partial class frmDoktorBilgiGuncelle : Form
    {
        public frmDoktorBilgiGuncelle()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        public string tcNo;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
        }

        private void frmDoktorBilgiGuncelle_Load(object sender, EventArgs e)
        {
            
        }
    }
}
