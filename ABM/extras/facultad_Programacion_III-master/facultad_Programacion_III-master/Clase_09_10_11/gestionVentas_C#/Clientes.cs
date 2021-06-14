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
//Clases para ADO, para la Conexion con la DB
using System.Data.SqlClient;
//Clases de VisualBasic
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
namespace sistema
{
    public partial class Clientes : Form
    {
        /**Objetos Necesarios*/
        private Routines routines;
        public Clientes()
        {
            InitializeComponent();
            /**Creamos el Objeto*/
            routines = new Routines();
            Routines.checkSave = true;
        }
        #region Metodos Necesarios para el Funcinamiento del ABM
        /**Para Buscar los Clientes*/
        public void buscar(string condicion)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT TOP (100) PERCENT NCliente, ApeYNom, CUIT FROM ClientesBusqueda WHERE " + condicion + " ORDER BY ApeYNom", routines.Conectar());
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "clientes");
            if (dataSet.Tables["clientes"].Rows.Count == 0)
            {
                gridClientes.Visible = false;
                lIdCliente.Visible = false;
                btnBorrar.Visible = false;
                pnlBordeBorrar.Visible = false;
                btnEditar.Visible = false;
                pnlBordeEditar.Visible = false;
            }
            else
            {
                gridClientes.DataSource = dataSet.Tables["clientes"];
                gridClientes.Refresh();
                gridClientes.Visible = true;
                lIdCliente.Visible = true;
                btnBorrar.Visible = true;
                pnlBordeBorrar.Visible = true;
                btnEditar.Visible = true;
                pnlBordeEditar.Visible = false;
            }
        }
        /**Filtro de la Fila Seleccionada*/
        public void FilaClick(int fila)
        {
            string tfila;
            if (Information.IsNothing(gridClientes.Rows[fila].Cells[0].Value))
            {
                lIdCliente.Text = "0";
                btnBorrar.Visible = false;
                pnlBordeBorrar.Visible = false;
                btnEditar.Visible = false;
                pnlBordeEditar.Visible = false;
                return;
            }
            else
            {
                tfila = gridClientes.Rows[fila].Cells[0].Value.ToString();
                lIdCliente.Text = tfila.ToString();
                CargarCamposClientes();
            }
        }
        /**Carga los Datos del Cliente seleccionado en los campos*/
        public void CargarCamposClientes()
        {
            if (Conversion.Val(lIdCliente.Text) == 0)
            {
                //gridClientes.Visible = false;
                lIdCliente.Visible = false;
                btnBorrar.Visible = false;
                pnlBordeBorrar.Visible = false;
                btnEditar.Visible = false;
                pnlBordeEditar.Visible = false;
                return;
            }
            else
            {
                lIdCliente.Visible = true;
                btnBorrar.Visible = true;
                pnlBordeBorrar.Visible = true;
                btnEditar.Visible = true;
                pnlBordeEditar.Visible = true;
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT UPPER(LTRIM(RTRIM(ISNULL(ApellidoCliente,'****')))) AS ApellidoCliente, UPPER(LTRIM(RTRIM(ISNULL(NombreCliente, '****')))) AS NombreCliente, LTRIM(RTRIM(ISNULL(DocumentoCliente, ''))) AS DocumentoCliente, LTRIM(RTRIM(ISNULL(CuitCliente, ''))) AS CuitCliente,LTRIM(RTRIM(ISNULL(UsuarioCliente, ''))) AS UsuarioCliente,LTRIM(RTRIM(ISNULL(ClaveCliente, ''))) AS ClaveCliente,LTRIM(RTRIM(ISNULL(DomicilioCliente, ''))) AS DomicilioCliente,LTRIM(RTRIM(ISNULL(PostalCliente, ''))) AS PostalCliente,LTRIM(RTRIM(ISNULL(LocalidadCliente, ''))) AS LocalidadCliente,LTRIM(RTRIM(ISNULL(ProvinciaCliente, ''))) AS ProvinciaCliente,LTRIM(RTRIM(ISNULL(TelefonoCliente, ''))) TelefonoCliente,FechaNacimientoCliente,LTRIM(RTRIM(ISNULL(ComentariosCliente, ''))) AS ComentariosCliente,LTRIM(RTRIM(ISNULL(EMailCliente, ''))) AS EMailCliente,isnull(Estado, 0) AS Estado FROM Clientes WHERE NCliente = " + Conversion.Val(lIdCliente.Text), routines.Conectar());
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "clientes");
                tApellido.Text = dataSet.Tables["clientes"].Rows[0]["ApellidoCliente"].ToString();
                tNombre.Text = dataSet.Tables["clientes"].Rows[0]["NombreCliente"].ToString();
                tDNI.Text = dataSet.Tables["clientes"].Rows[0]["DocumentoCliente"].ToString();
                DateTimePicker1.Value = (DateTime)dataSet.Tables["clientes"].Rows[0]["FechaNacimientoCliente"];
                CheckBox1.Checked = Conversion.Val(dataSet.Tables["clientes"].Rows[0]["Estado"]) == 0 ? false : true;
                tCUIT.Text = dataSet.Tables["clientes"].Rows[0]["CuitCliente"].ToString();
                tUsuario.Text = dataSet.Tables["clientes"].Rows[0]["UsuarioCliente"].ToString();
                tClave.Text = dataSet.Tables["clientes"].Rows[0]["ClaveCliente"].ToString();
                tDireccion.Text = dataSet.Tables["clientes"].Rows[0]["DomicilioCliente"].ToString();
                tLocalidad.Text = dataSet.Tables["clientes"].Rows[0]["LocalidadCliente"].ToString();
                tCP.Text = dataSet.Tables["clientes"].Rows[0]["PostalCliente"].ToString();
                tProvincia.Text = dataSet.Tables["clientes"].Rows[0]["ProvinciaCliente"].ToString();
                tTelefono.Text = dataSet.Tables["clientes"].Rows[0]["TelefonoCliente"].ToString();
                tEmail.Text = dataSet.Tables["clientes"].Rows[0]["EMailCliente"].ToString();
                tComentario.Text = dataSet.Tables["clientes"].Rows[0]["ComentariosCliente"].ToString();
            }
        }

        #endregion Metodos Necesarios para el Funcinamiento del ABM
        #region Botones
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Routines.checkSave)
            {
                buscar(" ApeYNom LIKE '" + tBuscar.Text + "%' ");
            }
            else
            {
                MessageBox.Show("Debe Guardar los Cambios del Nuevo Cliente Creado o Eliminarlo en su Defecto Antes de Buscar.", "Buscar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            buscar(" ApeYNom LIKE '" + tBuscar.Text + "%' ");
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (Routines.checkSave)
            {
                if (routines.SqlAccion("INSERT INTO Clientes (ApellidoCliente ,NombreCliente ,DocumentoCliente ,CuitCliente ,UsuarioCliente ,ClaveCliente ,DomicilioCliente ,PostalCliente ,LocalidadCliente ,ProvinciaCliente ,TelefonoCliente ,FechaNacimientoCliente ,ComentariosCliente ,EMailCliente ,Estado) VALUES ('*****', '*****','','','', '', '', '', '', '','', getdate(), '', '', 1)  "))
                {
                    /**Cambiamos el Estado de la Validacion*/
                    Routines.checkSave = false;
                    buscar(" ApeYNom LIKE '****%' ");
                    MessageBox.Show("Se ha Creado un Nuevo Registro para el Cliente que Desea Ingresar, Seleccione la Línea Nueva, Cargue los Datos y Luego Confirme con el Botón 'Guardar'.", "Nuevo Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe Guardar los Cambios del Nuevo Cliente Creado Antes Volver a Agregar un Nuevo Cliente.", "Nuevo Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está por ELIMINAR definitivamente el Cliente: " + tNombre.Text.Trim().ToUpper() +", " + tApellido.Text.Trim().ToUpper() + ". Es algo EXTREMO. ¿Está SEGURO?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                return;
            // Ejecutamos el Delete
            if (routines.SqlAccion("DELETE FROM Clientes  WHERE  NCliente=" + Conversion.Val(lIdCliente.Text)) == false)
            {
                MessageBox.Show("Hubo un Error al intentar Borrar el Cliente, Reintente, y Si el Error Persiste, Anote Todos los Datos que Quizo Ingresar y Comuníquese con el Programador (Otra Vez).", "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!Routines.checkSave)
                {
                    Routines.checkSave = true;
                }
                buscar(" NCliente=" + Conversion.Val(lIdCliente.Text));
                MessageBox.Show("El Cliente fue ELIMINADO de la Base de Datos.", "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            /**Para Guardar los Errores que Surjan*/
            string errores = "";
            /**Guardamos el caracter del enter*/
            string enter = Constants.vbCrLf;
            if (tApellido.Text.Trim().Length < 3)
            {
                errores += "Debe Completar el o los Apellido del Cliente." + enter;
            }

            if (tNombre.Text.Trim().Length < 3)
            {
                errores += "Debe Completar el o los Nombre del Cliente." + enter;
            }
            if (tUsuario.Text.Trim().Length < 3)
            {
                errores += "Debe Completar el Usuario." + enter;

            }
            if (routines.YaExisteSql("SELECT UsuarioCliente FROM Clientes WHERE UsuarioCliente='"+ tUsuario.Text.Trim().ToUpper()+ "' AND NCliente != "+ lIdCliente.Text))
            {
                errores += "El Usuario Elegido Ya Existe, Intente con Otro." + enter;
            }
            if (tClave.Text.Trim().Length < 6)
            {
                errores += "Debe Completar la Clave." + enter;

            }
            tDNI.Text = tDNI.Text.Trim().Replace(".", "").Replace(" ", "").Replace(",", "").Replace("-", "");
            if (tDNI.Text.Trim().Length < 4 | tDNI.Text.IndexOf("11111") > -1 | tDNI.Text.IndexOf("12345") > -1 | tDNI.Text.IndexOf("000000") > -1)
            {
                errores += "Debe completar CORRECTAMENTE el Numero de DNI." + enter;
            }
            if (routines.YaExisteSql("SELECT DocumentoCliente FROM Clientes WHERE DocumentoCliente =" + routines.Vnum(tDNI.Text.Trim().Replace(".", "").Replace(" ", "").Replace(",", "")) + "AND NCliente != " + routines.Vnum(lIdCliente.Text)) == true)
            {
                errores += "El DNI Ingresado ya Existe." + enter;
            }
            tCUIT.Text = tCUIT.Text.Trim().Replace(".", "").Replace(" ", "").Replace(",", "").Replace("-", "");
            if (tCUIT.Text.Trim().Length < 4 | tCUIT.Text.IndexOf("11111") > -1 | tCUIT.Text.IndexOf("12345") > -1 | tCUIT.Text.IndexOf("000000") > -1)
            {
                errores += "Debe completar CORRECTAMENTE el Numero de CUIT." + enter;
            }
            if (routines.YaExisteSql("SELECT CuitCliente FROM Clientes WHERE CuitCliente ='" + routines.Vnum(tCUIT.Text.Trim().Replace(".", "").Replace(" ", "").Replace(",", "")) + "'AND NCliente != " + routines.Vnum(lIdCliente.Text)) == true)
            {
                errores += "El CUIT Ingresado ya Existe." + enter;
            }
            if (errores.Length > 0)
            {
                MessageBox.Show("Hubo errores, Por Favor Verifique y Corrija Antes de Intentar de Nuevo:" + enter + enter + errores , "Errores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            /**Ejecutamos el Update*/
            if (routines.SqlAccion("UPDATE Clientes SET ClaveCliente ='" + tClave.Text + "' , Estado =" + (CheckBox1.Checked ? 1 : 0) + ", ApellidoCliente='" + tApellido.Text.Trim().ToUpper().Replace("'", "´") + "' , NombreCliente='" + tNombre.Text.Trim().ToUpper().Replace("'", "´") + "', DocumentoCliente=" + Conversion.Val(tDNI.Text.Trim().Replace(".", "").Replace(" ", "").Replace(",", "")) + ", CuitCliente =" + Conversion.Val(tCUIT.Text.Trim().Replace(".", "").Replace(" ", "").Replace(",", "")) + ", UsuarioCliente='" + tUsuario.Text.Trim().ToUpper().Replace("'", "´") + "', DomicilioCliente='" + tDireccion.Text.Trim().ToUpper().Replace("'", "´") + "', ProvinciaCliente='" + tProvincia.Text.Trim().ToUpper().Replace("'", "´") + "', LocalidadCliente='" + tLocalidad.Text.Trim().ToUpper().Replace("'", "´") + "', PostalCliente='" + tCP.Text.Trim().ToUpper().Replace("'", "´") + "', EMailCliente='" + tEmail.Text.Trim().ToUpper().Replace("'", "´") + "', FechaNacimientoCliente=" + routines.FechaSql(DateTimePicker1.Value) + ", TelefonoCliente=" + Conversion.Val(tTelefono.Text.Trim().Replace(".", "").Replace(" ", "").Replace(",", "")) + ", ComentariosCliente='" + tComentario.Text.Trim().ToUpper().Replace("'", "´") + "' WHERE NCliente=" + routines.Vnum(lIdCliente.Text)) == true)
            {
                MessageBox.Show("Cambios Realizados Correctamente.", "Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buscar(" NCliente=" + routines.Vnum(lIdCliente.Text));
            }
            else
            {
                MessageBox.Show("Se Produjo un Error al Querer Guardar los Datos del Cliente, Reintente, y si el Error Persiste, Anote Todos los Datos que Quizo Ingresar y Comuníquese con el Programador (Otra Vez).", "Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion Botones

        #region Eventos
        private void gridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FilaClick(e.RowIndex);
        }

        private void gridClientes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            FilaClick(e.RowIndex);
        }
        #endregion Eventos

    }
}
