using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_Uygulaması
{
    public partial class Form1 : Form
    {
        Bitmap bmp = new Bitmap(1024, 768); // Image Dosyası oluşturduk
        Pen p = new Pen(Color.Black, 5);
        bool drawing = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void saveASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if(drawing)
            {
                drawing = false;               
            }
            else
            {
                drawing = true;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(drawing)
            {
                Graphics g = Graphics.FromImage(bmp); // Image graphics kütüphanesine atandı
                g.DrawEllipse(p, e.X, e.Y, 3, 1); // Kalemin özellikleri ayarlandı
                pictureBox1.Image= bmp; // çizilen image picturebox1 ile eşitlendi
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            p.Color = Color.Red;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            p.Color = Color.Blue;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            p.Color = Color.Green;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            p.Color = Color.Purple;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            p.Color = Color.Yellow;
        }

        private void saveAsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image *.bmp|";
            // Jpeg olanlar filtrelendi
            saveFileDialog1.Title = "Save File";
            saveFileDialog1.ShowDialog();
            if(saveFileDialog1.FileName!="")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Dosya ile ilgili işlemler için Filestream kullanılır
                switch(saveFileDialog1.FilterIndex)
                {
                    case 1:
                        this.pictureBox1.Image.Save(fs,System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 2:
                        this.pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                        break;

                }
            }

        }
    }
}
