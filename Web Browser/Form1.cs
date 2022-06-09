using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void cbolocation_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                webBrowser1.Navigate(cbolocation.Text);
            } // Enter tuşuna basıldığında navigate ile ilgili adrese gider.
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
            // Geriye gider.
        }

        private void buttonforward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void buttongo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(cbolocation.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Text = "Web Browser-" + webBrowser1.Document.Title;
        }
    }
}
