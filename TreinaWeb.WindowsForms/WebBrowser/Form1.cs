using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            try
            {
                string url = VerificarUrl();
                if (!String.IsNullOrEmpty(url)) wbrBrowser.Navigate(new Uri(VerificarUrl()));
            }
            catch (UriFormatException)
            {
                return;
            }
        }

        private string VerificarUrl()
        {
            string url = txtUrl.Text;
            if (String.IsNullOrEmpty(url)) return "";
            if (url.Equals("about:blank")) return "";
            if (!url.StartsWith("http://") &&
                !url.StartsWith("https://"))
            {
                return "http://" + url;
            }
            else return url;
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            wbrBrowser.Stop();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            wbrBrowser.Refresh();
        }

        private void wbrBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txtUrl.Text = wbrBrowser.Url.AbsoluteUri;
        }
    }
}
