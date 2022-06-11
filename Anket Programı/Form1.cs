using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anket_Programı
{
    public partial class FrmOylama : Form
    {
        public FrmOylama()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Oylama_Projesi_Database;Integrated Security=True");
        // Sql Database bağlantısı oluşturuldu
        // Burada Sql connection başına @ koyulmazsa utf16 hatası veriyor.

        private void btn_Oylama_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            // Bağlantı her işlemden önce açılmalı ve her işlemden sonra kapatılmalı.

            SqlCommand komut = new SqlCommand("insert into Tabloİlce (İLÇE,A,B,C,D,E,F) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7)", baglanti);
            // Sql'deki tabloya değer atanıyor

            komut.Parameters.AddWithValue("@P1", txt_ilce.Text);
            komut.Parameters.AddWithValue("@P2", txt_a.Text);
            komut.Parameters.AddWithValue("@P3", txt_b.Text);
            komut.Parameters.AddWithValue("@P4", txt_c.Text);
            komut.Parameters.AddWithValue("@P5", txt_d.Text);
            komut.Parameters.AddWithValue("@P6", txt_e.Text);
            komut.Parameters.AddWithValue("@P7", txt_f.Text);
            //Forma girilen değerlerle Sql'deki ilgili yerleri dolduruldu

            komut.ExecuteNonQuery();
            //Verilen komutlar execute edildi

            MessageBox.Show("İşlem Başarılı");
            baglanti.Close();


        }

        private void btn_Grafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler frmGraf = new FrmGrafikler(); 
            frmGraf.Show();
            //Grafik Formuna instance newlendi ve gösterilmesi sağlandı

        }

        private void btn_Cıkıs_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Cıkıs_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }
    }
}
