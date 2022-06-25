using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Öğrenci_Takip_Uygulaması
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void kydt_Click(object sender, EventArgs e)
        {
            string dosyaIcerik = icerikal();
            string dosyaYolu = dosyaAdiAl();
            File.WriteAllText("Öğrenciler/"+dosyaYolu,dosyaIcerik);
            MessageBox.Show("Kaydedildi");
            listBox1.Items.Add(txt_ad.Text+" "+txt_soyad.Text);
        }

        private string dosyaAdiAl()
        {
            string[] dosyalar = Directory.GetFiles("Öğrenciler"); // Öğrenciler Dosyası değişkene atandı
            if (dosyalar.Length==0) //Öğrenciler isminde dosya yoksa "1.txt" isminde dosya oluşturulacak
            {
                return "1.txt";
            }
            else
            {
                return (KactaKaldik(dosyalar)+1)+".txt"; 
                // Eğer dosya varsa ismini +1leyerek yenisini oluştaracak
            }

        }

        private int KactaKaldik(string[] dosyalar)
        {
            int enBuyukSayi = 0;
            foreach (var item in dosyalar)
            {
                //item: C:\Users\...\...\...\.txt

                string sonuncu = sonuncuyuAl(item); 
                //2.txt veya 3.txt şeklinde bir string geldi
                int sonSayi = Convert.ToInt32(sonuncu.Replace(".txt", ""));
                // gelen string'in ".txt" uzantısı "" ile replace edildi kalan sayı sonSayi'ya atandı
                if (sonSayi>enBuyukSayi)
                {
                    enBuyukSayi = sonSayi;
                }
            }
            return enBuyukSayi;
        }

        private string sonuncuyuAl(string yol)
        {
            string[] parcalar = yol.Split('\\'); 
            //dosya yolu '\\' üzerinden parçalanarak bir diziye atandı
            return parcalar[parcalar.Length - 1];
            //Dizinin son elemanı return edildi
        }

        private string icerikal()
        {
            string dosyacontent = txt_ad.Text; // Dosya bilgilerini tutabilmek için strin tanımlandı
            dosyacontent += Environment.NewLine; // Alt satıra geçildi
            dosyacontent += txt_soyad.Text; 
            dosyacontent += Environment.NewLine;
            dosyacontent += cmb_sınıf.Text;
            dosyacontent += Environment.NewLine;
            dosyacontent += DateTime.Today.ToShortDateString(); // Tarih bilgileri alındı
            return dosyacontent;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenAdSoyad = (string)listBox1.SelectedItem;
            // Listbox'ta seçilen değer değişkene atandı
            string[] tumOgrenciler = Directory.GetFiles("Öğrenciler");
            // Öğrenciler dosyasındaki veriler string diziye atandı
            foreach (var item in tumOgrenciler)
            {
                string[] satirlar = File.ReadAllLines(item);//Item okundu
                if (satirlar[0]+" "+satirlar[1]==secilenAdSoyad)
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    lbl_ad.Text = satirlar[0];
                    lbl_soyad.Text = satirlar[1];
                    lbl_sınıf.Text = satirlar[2];
                    break;
                }
            }
        }

        private void btn_ogrencisi_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem==null)
            {
                MessageBox.Show("Hata");
            }
            else
            {
                string secilenAdSoyad = (string)listBox1.SelectedItem;
                string[] tumOgrenciler = Directory.GetFiles("Öğrenciler");
                foreach (var item in tumOgrenciler)
                {
                    string[] satirlar = File.ReadAllLines(item);//Item okundu
                    if (satirlar[0] + " " + satirlar[1] == secilenAdSoyad)
                    {
                        listBox1.Items.Remove(secilenAdSoyad);
                        File.Delete(item);
                        lbl_ad.Text = null;
                        lbl_soyad.Text = null;
                        lbl_sınıf.Text = null;
                        break;
                    }
                }

            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            lbl_ad.Text = "";
            lbl_soyad.Text = "";
            lbl_sınıf.Text = "";

            string[] tumOgrenciler = Directory.GetFiles("Öğrenciler");
            foreach (var item in tumOgrenciler)
            {
                string[] satirlar = File.ReadAllLines(item);
                string ad = satirlar[0];
                string soyad = satirlar[1];
                listBox1.Items.Add(ad + " " + soyad);
            }
        }

        private void tmz_Click(object sender, EventArgs e)
        {
            txt_ad.Clear();
            txt_soyad.Clear();
            cmb_sınıf.Text = "";
        }
    }
}
