using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Öğrenci_Takip_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_User.Text=="admin"&&txt_Sifre.Text=="123")
            {
                new Dashboard().Show();
            }
            // Kullanıcı bilgileri doğru girildiği taktirde Dashboard açılacak
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre","Hatalı Giriş",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
