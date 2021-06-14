using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void proveedorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form proveedor = new Proveedores();
            proveedor.BackColor = Color.Green;
            proveedor.ShowDialog();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro que deseas salir?", "Salir del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bClientes_Click(object sender, EventArgs e)
        {
            Form cliente = new Clientes();
            cliente.BackColor = Color.Red;
            cliente.ShowDialog();
        }

        private void bProveedores_Click(object sender, EventArgs e)
        {
            Form proveedor = new Proveedores();
            proveedor.BackColor = Color.Green;
            proveedor.ShowDialog();
        }

        private void bListados_Click(object sender, EventArgs e)
        {
            Form listado = new Listados();
            listado.BackColor = Color.Blue;
            listado.ShowDialog();
        }

        private void listadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form listado = new Listados();
            listado.BackColor = Color.Blue;
            listado.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cliente = new Clientes();
            cliente.BackColor = Color.Red;
            cliente.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
