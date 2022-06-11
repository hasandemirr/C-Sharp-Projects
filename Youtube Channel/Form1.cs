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

namespace Youtube_Channel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Youtube_Channel;Integrated Security=True");
        //Sql Bağlantısı oluşturuldu

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Table_Youtube(Ad,Kategori,Link) values (@P1,@P2,@P3)",baglanti);
            // Yeni bir komut tanımlandı
            // Yeni Komut tablodaki yerlere atama yapıyor.

            komut.Parameters.AddWithValue("@P1", textBoxVideoAdı.Text);
            komut.Parameters.AddWithValue("@P2", textBoxKategori.Text);
            komut.Parameters.AddWithValue("@P3", textBoxLink.Text);
            //İlgili Textboxlardaki veriler çekildi

            komut.ExecuteNonQuery();
            //Komut execute edildi

            baglanti.Close();

            MessageBox.Show("Yeni Video Kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        void videolar()
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from Table_Youtube",baglanti);
            // Tablodaki verilerin tamamını çekildi

            DataTable dt = new DataTable();
            // dt isimli bir tablo datası üretildi

            da.Fill(dt);
            // Sorgudan gelen veriler dt ye eklendi

            dataGridView1.DataSource = dt;
            // dt gride eşitlendi

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            videolar();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            // Gridde secilen hücrenin satır bilgisini alıyor

            string link = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            // Satır bilgisindeki link değeri alınıyor

            webBrowser1.Navigate(link);
            //Link Webbrowser da açılıyor

        }
    }
}
