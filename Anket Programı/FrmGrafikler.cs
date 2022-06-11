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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Oylama_Projesi_Database;Integrated Security=True");
        // Grafik formu için yeni bağlantı oluşturuldu

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select İLÇE from Tabloİlce",baglanti);
            // Sorgu ile ilçe adları çağırıldı

            SqlDataReader dr = komut.ExecuteReader();
            // Çağırılan veriler okundu

            while(dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
                // Combobox'a 0 index li kolon çağırıldı
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(A),sum(B),sum(C),sum(D),sum(E),sum(F) from Tabloİlce",baglanti);
            // Sorgu ile verilerin toplamı çağırıldı

            SqlDataReader dr2 = komut2.ExecuteReader();
            //Çağırılan veriler okundu

            while(dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A", dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("B", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("C", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("D", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("E", dr2[4]);
                chart1.Series["Partiler"].Points.AddXY("F", dr2[5]);
            }
            baglanti.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tabloİlce where İLÇE=@P1",baglanti);
            komut.Parameters.AddWithValue("@P1", comboBox1.Text);
            // Sorgu ile ilçe seçildi ve ilgili text çağırıldı
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                progressBar1.Value = int.Parse(dr[2].ToString());
                progressBar2.Value = int.Parse(dr[3].ToString());
                progressBar3.Value = int.Parse(dr[4].ToString());
                progressBar4.Value = int.Parse(dr[5].ToString());
                progressBar5.Value = int.Parse(dr[6].ToString());
                progressBar6.Value = int.Parse(dr[7].ToString());
                // Buradaki dr[] komutu kolonu belirtir.

                lbl_oy_A.Text = dr[2].ToString();
                lbl_oy_B.Text = dr[3].ToString();
                lbl_oy_C.Text = dr[4].ToString();
                lbl_oy_D.Text = dr[5].ToString();
                lbl_oy_E.Text = dr[6].ToString();
                lbl_oy_F.Text = dr[7].ToString();
            }
            baglanti.Close();


        }
    }
}
