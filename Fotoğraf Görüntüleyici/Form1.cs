using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fotoğraf_Görüntüleyici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void ClsButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BckgrndBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
                // Arkaplanı değiştiriyor
            }
        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            // picturebox'taki görüntüyü temizliyor
        }

        private void ShwBtn_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK) //  Tamam tuşuna basıldığında koşulun içine giriyor
            {
                pictureBox1.Load(openFileDialog1.FileName);
                // Dosya picturebox a yükleniyor
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }
    }
}
