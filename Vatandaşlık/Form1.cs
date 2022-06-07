using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vatandaşlık
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            insan insan1 = new insan();
            insan1.AdSoyad = "Hasan Demir";
            insan1.CanliMi = false;

            insan insan2 = new insan();
            insan2.AdSoyad = "Duygunur Özdemir";
            insan2.CanliMi = true;

            insan insan3 = new insan();
            insan3.AdSoyad = "Furkan Baki Heddas";
            insan3.CanliMi = true;

            MessageBox.Show(insan3.AdiniSoyle());
            MessageBox.Show(insan.SelamVer());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TCVatandas vat1 = new TCVatandas();
            vat1.Dogum = Convert.ToDateTime("1999-05-05");
            MessageBox.Show(vat1.VizeAl());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbdVatandas abd1 = new AbdVatandas();
            abd1.AdSoyad = "Johnny Boy";
            abd1.Dil = "English";
            abd1.Dogum = Convert.ToDateTime("1992-01-08");
            MessageBox.Show(abd1.Yas.ToString());
        }
    }
}
