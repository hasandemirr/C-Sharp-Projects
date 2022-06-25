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


namespace Apartman_Otomasyon
{
    public partial class Gelirler : Form
    {
        public Gelirler()
        {
            InitializeComponent();
        }
        SqlHelper help = new SqlHelper();
        // SqlHelper'da oluşturulan bağşantı ve parametreleri kullanmak için new'ledik

        private void button1_Click(object sender, EventArgs e)
        {
            int daireno = Convert.ToInt32(comboBox1.Text);
            // combobox'taki değer daireno'ya eşitlendi
            int para = Convert.ToInt32(numericUpDown1.Value);
            // numeric updown'daki değer eşitlendi
            DateTime tarih = dateTimePicker1.Value;
            // datetimepicker'ki değer eşitlendi

            SqlParameter p1 = new SqlParameter("@Daireno",daireno);
            // Sql üzerinde oluşturduğumuz parametre daireno'ya eşitlendi
            SqlParameter p2 = new SqlParameter("@Para", para);
            // Sql üzerinde oluşturduğumuz parametre para'ya eşitlendi
            SqlParameter p3 = new SqlParameter("@Tarih", tarih);
            // Sql üzerinde oluşturduğumuz parametre tarih'e eşitlendi

            help.ExecuteProc("odeme_al",p1,p2,p3);
            // ExecuteProc komutu prosedürü çalıştırıyor
            MessageBox.Show("Ödeme Alındı.");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Gelirler_Load(object sender, EventArgs e)
        {
            DataTable dat = help.GetTable("select*from Aidat_Ödemesi");
            // SqlHelper içerisinde tanımladığımız GetTable'dan sorguyla gelen data dat'a eşitlendi
            foreach (DataRow x in dat.Rows)
            // dat'ın her bir satırı için foreach kullanıldı
            {
                listBox1.Items.Add(x["DaireNo"]).ToString();
                //database'teki DaireNo altındaki her satır listbox1'e eklendi
                listBox2.Items.Add(x["Para"]).ToString();
                //database'teki Para altındaki her satır listbox1'e eklendi
                listBox3.Items.Add(x["Tarih"]).ToString();


            }
        }
    }
}
