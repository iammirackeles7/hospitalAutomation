using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace hastaneOtomasyonu
{
    class sqlBaglantisi
    {
        public SqlConnection baglanti()
        {
           SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-QV3S5H4\\SQLEXPRESS;Initial Catalog=hastaneProje;Integrated Security=True");
           baglan.Open();
           return baglan;
           
        }
    }
}

