using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**Libreria para los Iconos*/
using FontAwesome.Sharp;
/**Clase Para Activar la Interpolacion mover sin la barra de Titulo*/
using System.Runtime.InteropServices;
//Clases para ADO, para la Conexion con la DB
using System.Data.SqlClient;
//Clases de VisualBasic
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
namespace sistema
{
    public partial class Login : Form
    {
        /**Objetos Necesarios*/
        private Routines routines;
        public Login()
        {
            InitializeComponent();
            /**Desactivamos los Controles y los titulos de la Vnetana del FORM*/
            this.Text = string.Empty;
            this.ControlBox = false;
            /**dOBLE Buffer para Evitar el Parpadeo*/
            this.DoubleBuffered = true;
            /**Creamos el Objeto*/
            routines = new Routines();
        }
        #region Metodos Para Iniciar Sesion
        /**Para Realizar el Login*/
        public void iniciarSesion()
        {
            txtUsuario.Text = txtUsuario.Text.Replace("'", "").Replace(" ", "").Replace("\"", "").ToUpper();
            if (txtUsuario.Text=="ROOT" && txtClave.Text == "administrador")
            {
                /**Guardamos el Usuario*/
                Routines.nameUser = "Usuario Admin";
                Routines.lastNameUser = "root";
                /**Vamos al Inicio*/
                Inicio inicio = new Inicio();
                inicio.Show();
                this.Close();
            }
            else
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT UsuarioCliente, ClaveCliente, NombreCliente, ApellidoCliente  FROM Clientes WHERE UsuarioCliente ='" + txtUsuario.Text + "' AND ClaveCliente='" + txtClave.Text + "'", routines.Conectar());
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "clientes");
                if (dataSet.Tables["clientes"].Rows.Count == 1)
                {
                    /**Guardamos el Usuario*/
                    Routines.nameUser = dataSet.Tables["clientes"].Rows[0]["NombreCliente"].ToString();
                    Routines.lastNameUser = dataSet.Tables["clientes"].Rows[0]["ApellidoCliente"].ToString();
                    /**Vamos al Inicio*/
                    Inicio inicio = new Inicio();
                    inicio.Show();
                    this.Close();
                }
                else
                {
                    Interaction.MsgBox("Usuario o contraseña inorrectos, intentelo de nuevo, por favor.", MsgBoxStyle.Information, "Iniciar sesión");
                }
            }
        }

        #endregion Metodos Para Iniciar Sesion
        #region Botones y Metodos para el Movimiento del Formulario
        private void bntClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea salir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        /**Metodos para el Movimiento de la Ventana*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /** Para Guardar los Errores que Surjan*/
            string errores = "";
            // Guardamos el caracter del enter
            string enter = Constants.vbCrLf;
            if (txtUsuario.Text.Trim().Length < 3)
                errores += "Debe ingresar un usuario." + enter;
            if (txtClave.Text.Length < 6)
                errores += "Debe ingresar una contraseña." + enter;
            if (errores.Length > 0)
            {
                MessageBox.Show("Error, por Favor verifique y corrija antes de intentar de nuevo:" + enter + enter + errores, "Errores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
                iniciarSesion();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea salir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion Botones y Metodos para el Movimiento del Formulario

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
