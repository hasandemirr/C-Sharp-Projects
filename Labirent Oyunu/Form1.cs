using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Labirent_Oyunu
{
    public partial class Form1 : Form
    {
        SoundPlayer startSoundPlayer = new SoundPlayer(@"C:\Windows\Media\chord.wav"); // Duvarlara değme sesi
        SoundPlayer finishSoundPlayer = new SoundPlayer(@"C:\Windows\Media\tada.wav"); // Finish sesi
        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void label54_Click(object sender, EventArgs e)
        {
            finishSoundPlayer.Play();
            MessageBox.Show("Tebrikler");

            Close();
        }

        private void finishlabel_MouseEnter(object sender, EventArgs e)
        {
            finishSoundPlayer.Play();
            MessageBox.Show("Tebrikler");
            Close();
        }
        private void MoveToStart()
        {
            startSoundPlayer.Play();
            Point startingPoint = panel1.Location; // Point komutu ile başlangıçta durulacak yer belirleniyor
            startingPoint.Offset(10, 30); // konum tam olarak belirleniyor.
            Cursor.Position = PointToScreen(startingPoint); // imlecin konumu belirlenen konuma eşitleniyor


        }

        private void wall(object sender, EventArgs e)
        {
            
            MoveToStart();


        }
    }
}
