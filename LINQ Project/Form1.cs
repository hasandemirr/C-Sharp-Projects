using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_Project
{
    public partial class Siparis_hepsi : Form
    {
        List<int> sayilar = new List<int>();  
        List<string> isimler = new List<string>();
        public Siparis_hepsi()
        {

            isimler.Add("Müslüm");
            isimler.Add("Orhan");
            isimler.Add("David");
            isimler.Add("Rihanna");
            isimler.Add("Tarkan");
            isimler.Add("Göksel");
            sayilar.Add(-9);
            sayilar.Add(-5);
            sayilar.Add(-6);
            sayilar.Add(3);
            sayilar.Add(8);
            sayilar.Add(12);
            sayilar.Add(25);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sayilar_hepsi_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null; // Listbox'a veri yüklenmeden önce temizlendi
            listBox1.DataSource = sayilar.ToList(); // sayilar liste olarak gönderildi
        }

        private void Negatif_Click(object sender, EventArgs e)
        {
            // => lambda expression foreach benzeri bir interface

            IEnumerable<int> n = sayilar.Where(x => x < 0); // Bu işlem foreach ile aynı işi yapıyor
            listBox1.DataSource = null;
            listBox1.DataSource = n.ToList();
        }

        private void Pozitif_Click(object sender, EventArgs e)
        {
            IEnumerable<int> n = sayilar.Where(x => x > 0); 
            listBox1.DataSource = null;
            listBox1.DataSource = n.ToList();

        }

        private void cift_Click(object sender, EventArgs e)
        {
            IEnumerable<int> n = sayilar.Where(x => x % 2==0);
            listBox1.DataSource = null;
            listBox1.DataSource = n.ToList();

        }

        private void Tek_Click(object sender, EventArgs e)
        {
            IEnumerable<int> n = sayilar.Where(x => x % 2 == 1|| x % 2 == -1);
            listBox1.DataSource = null;
            listBox1.DataSource = n.ToList();
        }

        private void En_buyuk_Click(object sender, EventArgs e)
        {
            int enBuyuk = sayilar.Max();
            MessageBox.Show(enBuyuk.ToString());
        }

        private void En_kucuk_Click(object sender, EventArgs e)
        {
            int enkucuk = sayilar.Min();
            MessageBox.Show(enkucuk.ToString());
        }

        private void eleman_sys_Click(object sender, EventArgs e)
        {
            int elmnsys = sayilar.Count;
            
            MessageBox.Show(elmnsys.ToString());
        }

        private void ekle_Click(object sender, EventArgs e)
        {           

            sayilar.Add( Convert.ToInt32(textBox1.Text));
            listBox1.DataSource = null;
            listBox1.DataSource = sayilar.ToList();
        }

        private void alfabetik_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.OrderBy(x => x).ToList();
            // Lamda isimlerdeki her bir elemanı kontrol etmesini sağlıyor
        }

        private void Tersten_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.OrderByDescending(x => x).ToList();

        }

        private void isimler_Hepsi_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.ToList();
        }

        private void elmnsys_isimler_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.Select(x => x.Length).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isimler.Add((textBox1.Text));
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.ToList();
        }

        private void harf_iceren_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.Where(x => x.Contains(textBox1.Text)).ToList();
        }

        private void SiparislerHepsi(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders(); // Data'daki verileri çekiyor
            var gorunen = orders.Select(x => new //veriler bir variable'a atanıyor
            {
                SiparişNo=x.OrderID,
                Tarih=x.OrderDate,
                Musteri=x.Customer.ContactName
            });
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gorunen.ToList();
        }

        private void TarihGetir_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            dataGridView1.DataSource = null;
            
            dataGridView1.DataSource = orders.Select(x => x.OrderDate).ToList();
        }

        private void Top5_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = orders.Take(5).ToList();
        }

        private void Son5_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = orders.OrderByDescending(x => x.OrderID).Take(5).
                Select(x => new
                {
                    SiparişNo = x.OrderID,
                    Tarih = x.OrderDate,
                    Musteri = x.Customer.ContactName
                }).ToList();
        }

        private void Musteriye_göre_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            dataGridView1.DataSource = null;
            var filtre = orders.Where(x => x.Customer.ContactName.Contains(textBox1.Text)).ToList();
            dataGridView1.DataSource = filtre.ToList();
        }

        private void Siparis_sayisi_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            int sayi = orders.Count;
            MessageBox.Show(sayi.ToString());
        }
    }
}
