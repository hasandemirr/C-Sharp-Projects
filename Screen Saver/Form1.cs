using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Screen_Saver
{
    public partial class ScrnSvr : Form
    {
        List<Image> BGImages = new List<Image>(); // Image'ları tutuyor
        List<BritPic> BritPics = new List<BritPic>(); // Image'ların konumunu tutuyor
        Random rand = new Random();

        class BritPic
        {
            public int Picnum; // Tutulan foto sayısı
            public float X;
            public float Y;
            public float Speed;

        }

        public ScrnSvr()
        {
            InitializeComponent();
        }

        private void ScrnSvr_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }

        private void ScrnSvr_Load(object sender, EventArgs e)
        {
            string[] images = Directory.GetFiles("Photos"); //Dosya konumundan fotoları çekiyor
            foreach (String image in images)
            {
                BGImages.Add(new Bitmap(image)); //BGImages listesine fotolar ekleniyor
            }
            for (int i = 0; i < 1000; i++)
            {
                BritPic mp = new BritPic();
                mp.Picnum = i % BGImages.Count;
                mp.X = rand.Next(0, Width); // Image dosyasının konumunu ekranın yüksekliği ile sınırlandırıyor
                mp.Y = rand.Next(0, Height);

                BritPics.Add(mp);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void ScrnSvr_Paint(object sender, PaintEventArgs e)
        {
            foreach (BritPic bp in BritPics)
            {
                e.Graphics.DrawImage(BGImages[bp.Picnum], bp.X, bp.Y); // Seçili fotoyu seçili koordinatlara kadar çiziyor
                bp.X -= 20;
                if(bp.X<-250)
                {
                    bp.X = Width + rand.Next(20, 100);
                }
            }
        }
    }
}
