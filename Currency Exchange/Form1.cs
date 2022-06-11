using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Currency_Exchange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDosya = new XmlDocument();
            xmlDosya.Load(bugun);
            //XmlDocument olarak ilgili adres eklendi

            string dolaralis = xmlDosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            // Dolar alış fiyatı Sayfanın xml kaynağından elde edilen verilerden çekildi

            labelDolarAlDeger.Text = dolaralis;
            //Dolar alış fiyatı labele atandı

            string dolarsatis = xmlDosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            labelDolarSatDeger.Text = dolarsatis;
            string eurosatis = xmlDosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            labelEuroSatDeger.Text = eurosatis;
            string euroalis = xmlDosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            labelEuroAlDeger.Text = euroalis;


        }

        private void buttonDlrAl_Click(object sender, EventArgs e)
        {
            textBoxKur.Text = labelDolarAlDeger.Text;
        }
        // Al sat butonlarındaki değerler kur textbox'una atandı

        private void buttonDlrSat_Click(object sender, EventArgs e)
        {
            textBoxKur.Text = labelDolarSatDeger.Text;
        }

        private void buttonEurAl_Click(object sender, EventArgs e)
        {
            textBoxKur.Text = labelEuroAlDeger.Text;
        }

        private void buttonEurSat_Click(object sender, EventArgs e)
        {
            textBoxKur.Text = labelEuroSatDeger.Text;
        }

        private void buttonDvzAl_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar;
            kur = Convert.ToDouble(textBoxKur.Text);;
            miktar = Convert.ToDouble(textBoxMiktar.Text);
            tutar = kur * miktar;
            tutar = tutar / 10000;

            textBoxTutar.Text = tutar.ToString();
        }

        private void buttonPrnKdrAl_Click(object sender, EventArgs e)
        {

            double kur, miktar, tutar;
            kur = Convert.ToDouble(textBoxKur.Text);
            miktar = Convert.ToDouble(textBoxMiktar.Text);
            tutar = miktar / kur;
            tutar = tutar * 10000;
            textBoxTutar.Text = tutar.ToString();

        }
    }
}
