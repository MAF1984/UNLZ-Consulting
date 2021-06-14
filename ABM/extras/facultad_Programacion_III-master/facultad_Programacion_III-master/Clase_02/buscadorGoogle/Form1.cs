using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buscadorGoogle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?sxsrf=ALeKk03KIdJ0PFhqnFEsf3keRtMERvT02A%3A1586220695851&source=hp&ei=l86LXrLWMYbD5OUPp_SV0A8&q=" + textBox1.Text + "&oq=" + textBox1.Text + "&gs_lcp=CgZwc3ktYWIQAzICCAAyAggAMgIIADICCAAyBwgAEAoQywEyAggAMgQIABAKMgQIABAKMgIIADIFCAAQywE6BQgAEIMBShgIFxIUMGc5NWc5M2c5N2c4NGcxMTFnODVKEQgYEg0wZzFnMWcxZzFnMWcxULkNWOgVYPgWaAFwAHgAgAFZiAGwA5IBATaYAQCgAQGqAQdnd3Mtd2l6&sclient=psy-ab&ved=0ahUKEwjy_e_IjNXoAhWGIbkGHSd6BfoQ4dUDCAY&uact=5");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
