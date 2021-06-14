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
namespace sistema
{
    public partial class Inicio : Form
    {
        /**Campos para las Opciones de los Botones*/
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        /**Para Mostrar los Fomularios en el Panel*/
        private Form activeFormChild;

        public Inicio()
        {
            InitializeComponent();
            /**Incializamos las Opciiones de los Botones*/
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            /**Agrgamos el Panel a la Izquierda de los Botones*/
            pnlMenu.Controls.Add(leftBorderBtn);
            /**Desactivamos los Controles y los titulos de la Vnetana del FORM*/
            this.Text = string.Empty;
            this.ControlBox = false;
            /**dOBLE Buffer para Evitar el Parpadeo*/
            this.DoubleBuffered = true;
            /**Para que Ocupe solo el Area de Trabajo al Maximizar*/
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            Routines.checkSave = true;
        }
        /**Estructura para los Colores*/
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(138, 253, 114);
            public static Color color2 = Color.FromArgb(255, 192, 0);
            public static Color color3 = Color.FromArgb(255, 255, 0);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(46, 84, 38);
            public static Color color6 = Color.FromArgb(211, 16, 34);
        }
        #region Metodos Para los Estilos del Formulario
        /**Metodos para Resaltar los Botones*/
        private void ActivateButton(object senderBtn, Color color)
        {
            /**Preguntamos si el Boton es Distinto a Null*/
            if (senderBtn != null)
            {
                /**Llamamos al Metodo Antes de Resaktarlo asi desactivamos el anterior*/
                DisableButton();
                /**Opcines del Boton*/
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(61, 86, 109);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                /**Border Izquierdo Boton*/
                leftBorderBtn.BackColor = color;
                /**Ubicacion actual del Boton*/
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                /**Traemos al Frente*/
                leftBorderBtn.BringToFront();
                /**Icono de Formulario Hijo el que se esta mostrando en el pnlContenedor*/
                iconFromActive.IconChar = currentBtn.IconChar;
                iconFromActive.IconColor = color;
            }
        }
        /**Metodos para Desactivar el Resaltado los Botones*/
        private void DisableButton()
        {
            /**Preguntamos si el Boton es Distinto al Actual*/
            if (currentBtn != null)
            {
                /**Volvemos las Configuracioin del Boton al por Defecto*/
                currentBtn.BackColor = Color.FromArgb(26, 32, 40);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        /**Para Reiniciar Todos Los botones*/
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconFromActive.IconChar = IconChar.Home;
            iconFromActive.IconColor = Color.White;
            lTitleFormActive.Text = "Inicio";
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
        /**Para Abrir los Fromularios dentro del Panel Contenedor*/
        private void OpenFormChild(Form formChild)
        {
            /**Abrir un solo FORM*/
            if (activeFormChild != null)
            {
                activeFormChild.Close();
            }
            activeFormChild = formChild;
            /**Abrir el FORM y que no de Nivel Superior*/
            formChild.TopLevel = false;
            /**Sacamos los Bordes*/
            formChild.FormBorderStyle = FormBorderStyle.None;
            /**Para que Abarque todo el Contenedor*/
            formChild.Dock = DockStyle.Fill;
            /**Agreganos el los Controles*/
            pnlContent.Controls.Add(formChild);
            pnlContent.Tag = formChild;
            /**Traemso al Frente el FORM*/
            formChild.BringToFront();
            /**Mostramos el FORM*/
            formChild.Show();
            /**Mostramos el Titulo del FORM Activo*/
            lTitleFormActive.Text = formChild.Text;
        }
        /**Botones de Minimizar Restaurar y Maximizar*/
        private void bntClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea salir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void ntnMaximize_Click(object sender, EventArgs e)
        {
            /**Si el Tamaño es Nomar lo Maximizamos sino lo Restauramos */
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (Routines.checkSave)
            {
                ActivateButton(sender, RGBColors.color1);
                /**Abrimos el FORM*/
                OpenFormChild(new Clientes());
            }
            else
            {
                MessageBox.Show("Debe Guardar los Cambios del Registro Creado Antes de Continuar o en su Defecto Eliminelo .", "Cambiar de ABM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /**Eliminamos los Bordes Transparentes Cuando Esta Maximizado*/
        private void Inicio_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }
        #endregion
        #region Botones de Opciones de Menu
        /**Botones del Menu*/
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            if (Routines.checkSave)
            {
                ActivateButton(sender, RGBColors.color2);
                /**Abrimos el FORM*/
                OpenFormChild(new Proveedores());
            }
            else
            {
               MessageBox.Show("Debe Guardar los Cambios del Registro Creado Antes de Continuar o en su Defecto Eliminelo .", "Cambiar de ABM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (Routines.checkSave)
            {
                ActivateButton(sender, RGBColors.color6);
                /**Mostramos el Titulo*/
                lTitleFormActive.Text = "Salir";
                if (MessageBox.Show("¿Está Seguro de Cerrar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Login login = new Login();
                    login.Show();
                    this.Close();
                }
                else
                {
                    if (activeFormChild != null)
                    {
                        activeFormChild.Close();
                    }
                    Reset();
                }
            }
            else
            {
                MessageBox.Show("Debe Guardar los Cambios del Registro Creado Antes de Continuar o en su Defecto Eliminelo .", "Cambiar de ABM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pLogoTipo_Click(object sender, EventArgs e)
        {
            /**Cerramos el FORM Hijo es decir el Activo*/
            if (activeFormChild != null)
            {
                activeFormChild.Close();
            }
            Reset();
        }

        private void lGestion_Click(object sender, EventArgs e)
        {
            /**Cerramos el FORM Hijo es decir el Activo*/
            if (activeFormChild != null)
            {
                activeFormChild.Close();
            }
            Reset();
        }
        #endregion
        #region Metodo para Expandir y Contraer Menu
        /**Metodo para Expandir o Contraer Menu Vertical*/
        private void btnMenu_Click(object sender, EventArgs e)
        {
            /**Para Generar el Efecto*/
            if (pnlMenu.Width == 220)
            {
                this.tmContraerMenu.Start();
            }
            else if (pnlMenu.Width == 96)
            {
                this.tmExpandirMenu.Start();
            }

            /**Para Hacerlo si el Efecto*/
            /*if (pnlMenu.Width == 55)
            {
                pnlMenu.Width = 220;
            }
            else

                pnlMenu.Width = 55;*/

        }

        private void tmExpandirMenu_Tick(object sender, EventArgs e)
        {
            if (pnlMenu.Width >= 220)
                this.tmExpandirMenu.Stop();
            else
                pnlMenu.Width = pnlMenu.Width + 4;
        }

        private void tmContraerMenu_Tick(object sender, EventArgs e)
        {
            if (pnlMenu.Width <= 96)
                this.tmContraerMenu.Stop();
            else
                pnlMenu.Width = pnlMenu.Width - 4;
        }
        #endregion
        /**Para Motrar Fecha y Hora*/
        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lFecha.Text = DateTime.Now.ToLongDateString();
            lHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            lNameUser.Text = Routines.nameUser;
            lLastNameUser.Text = Routines.lastNameUser;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lNameUser_Click(object sender, EventArgs e)
        {

        }
    }
}
