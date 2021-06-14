using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(new Uri("https://www.google.com.ar/search?sxsrf=ALeKk008WtCMJQ30Fh9B3k-XMtBeGDQLvA%3A1586010186706&source=hp&ei=SpiIXvyaKbnZ5OUPqImMoA8&q=" + tBuscar.Text + "&oq=" + tBuscar.Text + "&gs_lcp=CgZwc3ktYWIQAzIHCAAQgwEQQzICCAAyAggAMgIIADIFCAAQgwEyAggAMgIIADICCAAyAggAMgIIADoECCMQJzoGCCMQJxATOgQIABBDShMIFxIPMGcxNTVnMTQ0ZzUtMjc3Sg0IGBIJMGcxZzFnNS0xUKoLWIYRYOEUaABwAHgCgAHyBIgBmQySAQswLjIuMS4wLjEuMZgBAKABAaoBB2d3cy13aXo&sclient=psy-ab&ved=0ahUKEwj856Wu_M7oAhW5LLkGHagEA_QQ4dUDCAY&uact=5"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bBuscar.Visible = !bBuscar.Visible;
            bIr.Visible = !bIr.Visible;
        }

        private void bAzul_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void bVerde_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void bRojo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void bIr_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tBuscar.Text)) return;
            if (tBuscar.Equals("about:blank")) return;
            if (!tBuscar.Text.StartsWith("http://") && !tBuscar.Text.StartsWith("https://"))
            {
                tBuscar.Text = "http://" + tBuscar.Text;
            }
            try
            {
                webBrowser1.Navigate(new Uri(tBuscar.Text));
            }
            catch
            {
                MessageBox.Show("Se produjo un error.");
            }
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }
    }
}