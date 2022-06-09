using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong_Oyunu
{
    public partial class Form1 : Form
    {
        public int speed_left = 4;
        public int speed_top = 4;
        public int points = 0;

        public Form1()
        {

            InitializeComponent();

            Cursor.Hide(); // İmleç gizlendi
            timer1.Enabled = true; // Kronomotre aktifleşti
            this.FormBorderStyle = FormBorderStyle.None; // Uygulamanın çerçevesini kaldırıyor.
            this.TopMost = true; // Uygulama en üstte görünür.
            this.Bounds = Screen.PrimaryScreen.Bounds; // Tüm ekranı kaplatıyor.

            brick.Top = playGround.Bottom - (playGround.Bottom / 20); //Raketin konumunu alta sabitliyor.

            gameover_lbl.Left = ((playGround.Width / 2) - (gameover_lbl.Width / 2)); //Bitiş ekranını yatay olarak ortalıyor
            gameover_lbl.Top = ((playGround.Height / 2) - (gameover_lbl.Height / 2)); //Bitiş ekranını dikey olarak ortalıyor
            gameover_lbl.Visible = false; // Bitiş ekranını görünmez yapıyor.


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            brick.Left = Cursor.Position.X - (brick.Width / 2); // Raketin orta noktası mousun x eksenindeki konumuna eşitlendi
            ball.Left += speed_left;
            ball.Top += speed_top;

            if (ball.Left <= playGround.Left)
            {
                speed_left = -speed_left;
            }
            if (ball.Right >= playGround.Right)
            {
                speed_left = -speed_left;
            }
            if (ball.Top <= playGround.Top)
            {
                speed_top = -speed_top;
            }
            if (ball.Bottom >= playGround.Bottom)
            {
                gameover_lbl.Visible = true;
                timer1.Enabled = false;
            }

            if (ball.Bottom >= brick.Top && ball.Bottom <= brick.Bottom && ball.Left >= brick.Left && ball.Right <= brick.Right)
                //topla raketin birbiriyle temas ettiğini kontrol eden sorgu
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                
                points += 1;
                point_lbl.Text = points.ToString();

                Random r = new Random();
                playGround.BackColor = Color.FromArgb(r.Next(155, 255), r.Next(155, 255), r.Next(155, 255));

                // her temastan sonra topun rengi değişiyor, hızı ve score artıyor
            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode ==Keys.Escape)
            {
                this.Close();
            }
            if(e.KeyCode==Keys.F1)
            {
                ball.Top = 50;
                ball.Left = 50;
                point_lbl.Text = "0";
                timer1.Enabled = true;
                gameover_lbl.Visible = false;
                playGround.BackColor = Color.White;
            }
        }
    }
}
