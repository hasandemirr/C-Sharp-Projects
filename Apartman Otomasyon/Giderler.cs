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

namespace Apartman_Otomasyon
{
    public partial class Giderler : Form
    {
        public Giderler()
        {
            InitializeComponent();
        }
        SqlHelper help = new SqlHelper();

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int para = Convert.ToInt32(numericUpDown1.Value);
            // numeric updown'daki değer eşitlendi
            DateTime tarih = dateTimePicker1.Value;
            // datetimepicker'ki değer eşitlendi
            string GiderTipi = "";
            foreach (Control item in groupBox1.Controls)
            //Groupbox'taki item'ların control'leri için foreach kullanıldı
            {
                if (item is CheckBox && ((CheckBox)item).Checked)
                // Eğer item checkbox ve tıklıysa
                {
                    GiderTipi +=","+ item.Text;
                    //GiderlerTipi değişkenine item'ın texti ve virgül eklendi
                }
            }
            GiderTipi = GiderTipi.Remove(0, 1);
            // İlk virgül kaldırıldı

            SqlParameter p1 = new SqlParameter("GiderTipi", GiderTipi);
            SqlParameter p2 = new SqlParameter("Para", para);
            SqlParameter p3 = new SqlParameter("Tarih", tarih);
            //Sql üzerinde oluşturulan parametreler koddaki değişkenlere eşitlendi

            help.ExecuteProc("giderlerim",p1,p2,p3);
            // Prosedür ilgili parametrelerle çalıştırılıyor
            MessageBox.Show("Gider bilgileri girildi.");




        }

        private void Giderler_Load(object sender, EventArgs e)
        {
            DataTable date = help.GetTable("select*from GiderTablosu");
            // SqlHelper içerisinde tanımladığımız GetTable'dan sorguyla gelen data dat'a eşitlendi
            foreach (DataRow x in date.Rows)
            {
                listBox1.Items.Add(x[3]).ToString();
                listBox2.Items.Add(x[1]).ToString();
                listBox3.Items.Add(x[2]).ToString();
                // Database'teki her bir veri listbox'a eklendi
            }
        }
    }
}
