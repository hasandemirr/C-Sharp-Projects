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

namespace Connected_Mimari_Ürün_Detay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True");
        //Sql bağlantısını oluşturuldu

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select*from Categories", con);
            // Categories table'ına con bağlantısı üzerinden ulaşıldı
            con.Open(); // con Bağlantısı açıldı
            SqlDataReader okuyucu = komut.ExecuteReader(); // sqlDataReader komutu ile table okundu
            comboBox1.DisplayMember = "CategoryName"; //ComboBox1'de Kategori isimleri gösterildi
            comboBox1.ValueMember = "CategoryID"; //Id'ler combobox value'lerine eşitlendi


            List<Category> liste = new List<Category>(); 
            //Sql'deki category column'larını kodda tanımlayabilmek için yeni bir liste generate edildi
            while(okuyucu.Read()) // Tamamını okumadan bitirmesi için while kullanıldı
            {
                Category cat = new Category();
                cat.CategoryID = (int)okuyucu["CategoryID"];
                cat.CategoryName = okuyucu["CategoryName"].ToString();
                liste.Add(cat);
                //Sql'den gelen veriler okuyucu ile cat listesine aktarıldı
            }
            con.Close(); // con bağlantısı kapatıldı
            comboBox1.DataSource = liste; // combobox'taki verinin kaynağı olarak liste atandı
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var secilenID = comboBox1.SelectedValue; //COmboboxtaki value değeri bir değişkene atandı
            con.Open();
            SqlCommand command = new SqlCommand("Select*from Products where CategoryID="+ secilenID,con);
            // secilenID değerini sorguya gönderebilmek için kodun tırnak dışına yazıldı
            SqlDataReader okuyucu = command.ExecuteReader(); 

            while(okuyucu.Read())
            // CategoryID kadar buton oluşturabilmek için while kullanıldı
            {
                Button btn = new Button();
                btn.Name = "b" + okuyucu["ProductID"]; //Buton adı ID olarak atandı
                btn.Height = 50; //Buton yüksekliği Ayarlandı
                btn.AutoSize = true; //Buton boyutu ayarlandı
                btn.Text = okuyucu["ProductName"].ToString(); //Buton üzerinde yazan isim atandı
                flowLayoutPanel1.Controls.Add(btn); //Butonlar panele eklendi
                btn.Click += ProductDetailGetir; //Butona her tıklandığında methodu çağırıyor

            }
            con.Close();
        }
        private void ProductDetailGetir(object tiklanan,EventArgs tikdetay)
        {
            Button tiklananButton = (Button)tiklanan;// tiklananButton adında buton tanımlandı
            var IDtxt = tiklananButton.Name.Remove(0, 1); //ID olarak atanan buton adı kaldırıldı
            con.Open();
            SqlCommand sqlcmd = new SqlCommand("select*from Products where ProductID=" +IDtxt,con);
            SqlDataReader reader = sqlcmd.ExecuteReader();
            reader.Read();
            ProductDetail detay = new ProductDetail();
            detay.lbl_prdct_name.Text = reader["ProductName"].ToString(); //Label'a ürün adı atandı
            detay.lbl_qpu.Text = reader["QuantityPerUnit"].ToString();
            detay.Show();
            con.Close();
        }
    }
}
