using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Json_Emoji
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Category> GetEmojiList()
        {
            JavaScriptSerializer tercuman = new JavaScriptSerializer();
            // Komutun çalışması için gerekli olan System.Web.Extensions references'ten eklenmeli
            // Json dosyasını istediğimiz biçimde okuyabilmek için JavaScriptSerializer instance'landı

            string path = @"C:\Users\metha\Desktop\C# Lessons\Projects\Json Emoji\smiley_content.json";
            string jsonContent = File.ReadAllText(path);
            // json dosyasını okuyor


            return tercuman.Deserialize<List<Category>>(jsonContent);
            // Category sınıfındaki listeyi json dosyasından alarak return ediyor

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var list = GetEmojiList();
            DisplayEmojiList(list); // Kategoriler için yeni bir metod oluşturuldu

        }

        private void DisplayEmojiList(List<Category> list)
        {
            foreach(Category c in list) // Her bir Kategori ismini döndürmek için foreach kullanılır
            {
                Label tabela = new Label() { Text = c.category };
                tabela.AutoSize = false;
                tabela.Width = this.ClientSize.Width;
                tabela.Font = new Font(FontFamily.GenericMonospace, 20);
                tabela.TextAlign = ContentAlignment.MiddleCenter;
                // Yazıyı ortalıyor
                tabela.Margin = new Padding(0,20,0,20);
                // Dört köşesinden verilecek boşlukları ayarlıyor
                flowLayoutPanel1.SetFlowBreak(tabela, true);
                flowLayoutPanel1.Controls.Add(tabela);
                // Ayarlar panele eklendi

                DisplayItems(c); // Itemler için yeni bir metod oluşturuldu

            }
        }

        private void DisplayItems(Category c)
        {
            
            foreach (Item minitem in c.items) // Kategorideki her bir itemi için foreach kullanılıyor
            {
                Button tus = new Button();
                tus.Text = minitem.art + Environment.NewLine + minitem.name;
                //Item'ın adını + bir satır aşağı + Item'ın Artı
                tus.Font = new Font(FontFamily.GenericMonospace, 14);
                tus.Padding = new Padding(5);
                tus.Width = flowLayoutPanel1.ClientSize.Width / 2 - 10;
                tus.Height = 80;
                tus.Click += tusClick;
                flowLayoutPanel1.Controls.Add(tus);

            }
        }

        private void tusClick(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            string[] infos = clickedBtn.Text.Split('\n');
            //Butona tıklandığındaki veri ikiye bölündü emoji olan kısmı infos a atandı
            Clipboard.SetText(infos[0]);
            // infos kopyalandı
            MessageBox.Show(clickedBtn.Text + "has copied to Clipboard");

        }
    }
}
