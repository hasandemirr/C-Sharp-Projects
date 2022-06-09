using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kur_Çevirici
{
    public partial class Currency : Form
    {
        public Currency()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com.ar/search?q=1+usd+to+ars");//navigate metodu url'e gider
        }
    }
}
