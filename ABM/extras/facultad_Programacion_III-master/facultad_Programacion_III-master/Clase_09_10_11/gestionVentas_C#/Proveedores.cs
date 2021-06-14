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
    public partial class Proveedores : Form
    {
        /**Objetos Necesarios*/
        private Routines routines;
        public Proveedores()
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
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT TOP (100) PERCENT NProveedor, ApeYNom, CUIT FROM ProveedoresBusqueda WHERE " + condicion + " ORDER BY ApeYNom", routines.Conectar());
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "proveedores");
            if (dataSet.Tables["proveedores"].Rows.Count == 0)
            {
                gridProveedores.Visible = false;
                lIdProveedor.Visible = false;
                btnBorrar.Visible = false;
                pnlBordeBorrar.Visible = false;
                btnEditar.Visible = false;
                pnlBordeEditar.Visible = false;
            }
            else
            {
                gridProveedores.DataSource = dataSet.Tables["proveedores"];
                gridProveedores.Refresh();
                gridProveedores.Visible = true;
                lIdProveedor.Visible = true;
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
            if (Information.IsNothing(gridProveedores.Rows[fila].Cells[0].Value))
            {
                lIdProveedor.Text = "0";
                btnBorrar.Visible = false;
                pnlBordeBorrar.Visible = false;
                btnEditar.Visible = false;
                pnlBordeEditar.Visible = false;
                return;
            }
            else
            {
                tfila = gridProveedores.Rows[fila].Cells[0].Value.ToString();
                lIdProveedor.Text = tfila.ToString();
                CargarCamposClientes();
            }
        }
        /**Carga los Datos del Cliente seleccionado en los campos*/
        public void CargarCamposClientes()
        {
            if (Conversion.Val(lIdProveedor.Text) == 0)
            {
                //gridClientes.Visible = false;
                lIdProveedor.Visible = false;
                btnBorrar.Visible = false;
                pnlBordeBorrar.Visible = false;
                btnEditar.Visible = false;
                pnlBordeEditar.Visible = false;
                return;
            }
            else
            {
                lIdProveedor.Visible = true;
                btnBorrar.Visible = true;
                pnlBordeBorrar.Visible = true;
                btnEditar.Visible = true;
                pnlBordeEditar.Visible = true;
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT UPPER(LTRIM(RTRIM(ISNULL(ApellidoProveedor,'****')))) AS ApellidoProveedor, UPPER(LTRIM(RTRIM(ISNULL(NombreProveedor, '****')))) AS NombreProveedor, LTRIM(RTRIM(ISNULL(DocumentoProveedor, ''))) AS DocumentoProveedor, LTRIM(RTRIM(ISNULL(CuitProveedor, ''))) AS CuitProveedor,LTRIM(RTRIM(ISNULL(DomicilioProveedor, ''))) AS DomicilioProveedor,LTRIM(RTRIM(ISNULL(PostalProveedor, ''))) AS PostalProveedor,LTRIM(RTRIM(ISNULL(LocalidadProveedor, ''))) AS LocalidadProveedor,LTRIM(RTRIM(ISNULL(ProvinciaProveedor, ''))) AS ProvinciaProveedor,LTRIM(RTRIM(ISNULL(TelefonoProveedor, ''))) TelefonoProveedor,FechaNacimientoProveedor,LTRIM(RTRIM(ISNULL(ComentariosProveedor, ''))) AS ComentariosProveedor,LTRIM(RTRIM(ISNULL(EMailProveedor, ''))) AS EMailProveedor,isnull(Estado, 0) AS Estado FROM Proveedores WHERE NProveedor = " + Conversion.Val(lIdProveedor.Text), routines.Conectar());
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "proveedores");
                tApellido.Text = dataSet.Tables["proveedores"].Rows[0]["ApellidoProveedor"].ToString();
                tNombre.Text = dataSet.Tables["proveedores"].Rows[0]["NombreProveedor"].ToString();
                tDNI.Text = dataSet.Tables["proveedores"].Rows[0]["DocumentoProveedor"].ToString();
                DateTimePicker1.Value = (DateTime)dataSet.Tables["proveedores"].Rows[0]["FechaNacimientoProveedor"];
                CheckBox1.Checked = Conversion.Val(dataSet.Tables["proveedores"].Rows[0]["Estado"]) == 0 ? false : true;
                tCUIT.Text = dataSet.Tables["proveedores"].Rows[0]["CuitProveedor"].ToString();
                tDireccion.Text = dataSet.Tables["proveedores"].Rows[0]["DomicilioProveedor"].ToString();
                tLocalidad.Text = dataSet.Tables["proveedores"].Rows[0]["LocalidadProveedor"].ToString();
                tCP.Text = dataSet.Tables["proveedores"].Rows[0]["PostalProveedor"].ToString();
                tProvincia.Text = dataSet.Tables["proveedores"].Rows[0]["ProvinciaProveedor"].ToString();
                tTelefono.Text = dataSet.Tables["proveedores"].Rows[0]["TelefonoProveedor"].ToString();
                tEmail.Text = dataSet.Tables["proveedores"].Rows[0]["EMailProveedor"].ToString();
                tComentario.Text = dataSet.Tables["proveedores"].Rows[0]["ComentariosProveedor"].ToString();
            }
        }

        #endregion Metodos Necesarios para el Funcinamiento del ABM
        #region Botones
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (Routines.checkSave)
            {
                if (routines.SqlAccion("INSERT INTO Proveedores (ApellidoProveedor ,NombreProveedor ,DocumentoProveedor ,CuitProveedor,DomicilioProveedor ,PostalProveedor ,LocalidadProveedor ,ProvinciaProveedor ,TelefonoProveedor ,FechaNacimientoProveedor ,ComentariosProveedor ,EMailProveedor ,Estado) VALUES ('*****', '*****','','','','', '', '','', getdate(), '', '', 1)  "))
                {
                    /**Cambiamos el Estado de la Validacion*/
                    Routines.checkSave = false;
                    buscar(" ApeYNom LIKE '****%' ");
                    MessageBox.Show("Se ha Creado un Nuevo Registro para el Proveedor que Desea Ingresar, Seleccione la Línea Nueva, Cargue los Datos y Luego Confirme con el Botón 'Guardar'.", "Nuevo Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe Guardar los Cambios del Nuevo Proveedor Creado Antes Agregar un Nuevo Proveedor.", "Nuevo Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                errores += "Debe Completar el o los Apellido del Proveedor." + enter;
            }

            if (tNombre.Text.Trim().Length < 3)
            {
                errores += "Debe Completar el o los Nombre del Proveedor." + enter;
            }
            tDNI.Text = tDNI.Text.Trim().Replace(".", "").Replace(" ", "").Replace(",", "").Replace("-", "");
            if (tDNI.Text.Trim().Length < 4 | tDNI.Text.IndexOf("11111") > -1 | tDNI.Text.IndexOf("12345") > -1 | tDNI.Text.IndexOf("000000") > -1)
            {
                errores += "Debe completar CORRECTAMENTE el Numero de DNI." + enter;
            }
            if (routines.YaExisteSql("SELECT DocumentoProveedor FROM Proveedores WHERE DocumentoProveedor =" + routines.Vnum(tDNI.Text.Trim().Replace(".", "").Replace(" ", "").Replace(",", "")) + "AND NProveedor != " + routines.Vnum(lIdProveedor.Text)) == true)
            {
                errores += "El DNI Ingresado ya Existe." + enter;
            }
            tCUIT.Text = tCUIT.Text.Trim().Replace(".", "").Replace(" ", "").Replace(",", "").Replace("-", "");
            if (tCUIT.Text.Trim().Length < 4 | tCUIT.Text.IndexOf("11111") > -1 | tCUIT.Text.IndexOf("12345") > -1 | tCUIT.Text.IndexOf("000000") > -1)
            {
                errores += "Debe completar CORRECTAMENTE el Numero de CUIT." + enter;
            }
            if (routines.YaExisteSql("SELECT CuitProveedor FROM Proveedores WHERE CuitProveedor ='" + routines.Vnum(tCUIT.Text.Trim().Replace(".", "").Replace(" ", "").Replace(",", "")) + "'AND NProveedor != " + routines.Vnum(lIdProveedor.Text)) == true)
            {
                errores += "El CUIT Ingresado ya Existe." + enter;
            }
            if (errores.Length > 0)
            {
                MessageBox.Show("Hubo errores, Por Favor Verifique y Corrija Antes de Intentar de Nuevo:" + enter + enter + errores, "Errores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            /**Ejecutamos el Update*/
            if (routines.SqlAccion("UPDATE Proveedores SET Estado =" + (CheckBox1.Checked ? 1 : 0) + ", ApellidoProveedor='" + tApellido.Text.Trim().ToUpper().Replace("'", "´") + "' , NombreProveedor='" + tNombre.Text.Trim().ToUpper().Replace("'", "´") + "', DocumentoProveedor=" + Conversion.Val(tDNI.Text.Trim().Replace(".", "").Replace(" ", "").Replace(",", "")) + ", CuitProveedor =" + Conversion.Val(tCUIT.Text.Trim().Replace(".", "").Replace(" ", "").Replace(",", "")) + ", DomicilioProveedor='" + tDireccion.Text.Trim().ToUpper().Replace("'", "´") + "', ProvinciaProveedor='" + tProvincia.Text.Trim().ToUpper().Replace("'", "´") + "', LocalidadProveedor='" + tLocalidad.Text.Trim().ToUpper().Replace("'", "´") + "', PostalProveedor='" + tCP.Text.Trim().ToUpper().Replace("'", "´") + "', EMailProveedor='" + tEmail.Text.Trim().ToUpper().Replace("'", "´") + "', FechaNacimientoProveedor=" + routines.FechaSql(DateTimePicker1.Value) + ", TelefonoProveedor=" + Conversion.Val(tTelefono.Text.Trim().Replace(".", "").Replace(" ", "").Replace(",", "")) + ", ComentariosProveedor='" + tComentario.Text.Trim().ToUpper().Replace("'", "´") + "' WHERE NProveedor=" + routines.Vnum(lIdProveedor.Text)) == true)
            {
                MessageBox.Show("Cambios Realizados Correctamente.", "Editar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buscar(" NProveedor=" + routines.Vnum(lIdProveedor.Text));
                /**Cambiamos el Estado del checkSave*/
                Routines.checkSave = true;
            }
            else
            {
                MessageBox.Show("Se Produjo un Error al Querer Guardar los Datos del Proveedor, Reintente, y si el Error Persiste, Anote Todos los Datos que Quizo Ingresar y Comuníquese con el Programador (Otra Vez).", "Editar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está por ELIMINAR definitivamente el Proveedor: " + tNombre.Text.Trim().ToUpper() + ", " + tApellido.Text.Trim().ToUpper() + ". Es algo EXTREMO. ¿Está SEGURO?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                return;
            // Ejecutamos el Delete
            if (routines.SqlAccion("DELETE FROM Proveedores  WHERE  NProveedor=" + Conversion.Val(lIdProveedor.Text)) == false)
            {
                MessageBox.Show("Hubo un Error al intentar Borrar el Proveedor, Reintente, y Si el Error Persiste, Anote Todos los Datos que Quizo Ingresar y Comuníquese con el Programador (Otra Vez).", "Eliminar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!Routines.checkSave)
                {
                    Routines.checkSave = true;
                }
                buscar(" NProveedor=" + Conversion.Val(lIdProveedor.Text));
                MessageBox.Show("El Proveedor fue ELIMINADO de la Base de Datos.", "Eliminar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Routines.checkSave)
            {
              buscar(" ApeYNom LIKE '" + tBuscar.Text + "%' ");
            }
            else
            {
                MessageBox.Show("Debe Guardar los Cambios del Nuevo Proveedor Creado o Eliminarlo en su Defecto Antes de Buscar.", "Buscar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion Botones

        #region Eventos
        private void gridProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FilaClick(e.RowIndex);
        }
        private void gridProveedores_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            FilaClick(e.RowIndex);
        }

        #endregion Eventos

        private void Proveedores_Load(object sender, EventArgs e)
        {
            buscar(" ApeYNom LIKE '" + tBuscar.Text + "%' ");
        }
    }
}
