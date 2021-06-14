using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Clases para ADO, para la Conexion con la DB
using System.Data.SqlClient;
//Clases de VisualBasic
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;


namespace AMB
{

    public partial class abmCustomers : Form
    {
        Routines routines = new Routines();
        
        public abmCustomers()
        {
            InitializeComponent();
        }
        //Para Buscar los Clientes
        public void buscar(string condicion)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT TOP (100) PERCENT ID As id, CompanyName AS cliente, ContactName AS contacto FROM Customers WHERE " + condicion + " ORDER BY cliente", routines.Conectar());
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "clientes");
            if (dataSet.Tables["clientes"].Rows.Count == 0)
            {
                gridClientes.Visible = false;
                pBotones.Visible = false;
                pCampos.Visible = false;
                lIdCliente.Visible = false;
            }
            else
            {
                gridClientes.DataSource = dataSet.Tables["clientes"];
                gridClientes.Refresh();
                gridClientes.Visible = true;
                lIdCliente.Visible = true;
            }
        }
        private void abmCustomers_Load(object sender, EventArgs e)
        {
           buscar(" CompanyName LIKE '" + tBuscar.Text + "%' ");
        }
        private void bBuscar_Click(object sender, EventArgs e)
        {
            buscar(" CompanyName LIKE '" + tBuscar.Text + "%' ");
        }
        /**Para Obtener el numero de la fila seleccionada al Hacer Click*/
        private void gridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FilaClick(e.RowIndex);
        }
        /**Para Obtener el numero de la fila seleccionada al ir pasando con las flechas*/
        private void gridClientes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            FilaClick(e.RowIndex);
        }
        //Filtro de la Fila Seleccionada
        public void FilaClick(int fila)
        {
            string tfila;
            if (Information.IsNothing(gridClientes.Rows[fila].Cells[0].Value))
            {
                lIdCliente.Text = "0";
                pBotones.Visible = false;
                pCampos.Visible = false;
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
                pBotones.Visible = false;
                pCampos.Visible = false;
                return;
            }
            else
            {
                pBotones.Visible = true;
                pCampos.Visible = true;
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT UPPER(LTRIM(RTRIM(ISNULL(CompanyName,'****')))) AS cliente, UPPER(LTRIM(RTRIM(ISNULL(ContactName,'****')))) AS contacto, LTRIM(RTRIM(ISNULL(ContactTitle,''))) AS cargo , LTRIM(RTRIM(ISNULL(Address,''))) AS direccion, LTRIM(RTRIM(ISNULL(City,''))) AS ciudad, LTRIM(RTRIM(ISNULL(Region,''))) AS localidad , LTRIM(RTRIM(ISNULL(PostalCode,''))) AS cp, LTRIM(RTRIM(ISNULL(Country,''))) AS pais, LTRIM(RTRIM(ISNULL(Phone,''))) AS telefono, LTRIM(RTRIM(ISNULL(Fax,''))) AS fax FROM Customers WHERE ID=" + Conversion.Val(lIdCliente.Text), routines.Conectar());
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "clientes");
                tCliente.Text = dataSet.Tables["clientes"].Rows[0]["cliente"].ToString();
                tContacto.Text = dataSet.Tables["clientes"].Rows[0]["contacto"].ToString();
                tCargo.Text = dataSet.Tables["clientes"].Rows[0]["cargo"].ToString();
                tDireccion.Text = dataSet.Tables["clientes"].Rows[0]["direccion"].ToString();
                tLocalidad.Text = dataSet.Tables["clientes"].Rows[0]["localidad"].ToString();
                tCP.Text = dataSet.Tables["clientes"].Rows[0]["cp"].ToString();
                tCiudad.Text = dataSet.Tables["clientes"].Rows[0]["ciudad"].ToString();
                tPais.Text = dataSet.Tables["clientes"].Rows[0]["pais"].ToString();
                tTelefono.Text = dataSet.Tables["clientes"].Rows[0]["telefono"].ToString();
                tFax.Text = dataSet.Tables["clientes"].Rows[0]["fax"].ToString();
                CargarFacturas();
            }
        }
        /**Para Cargar los Datos de las Facturas*/
        public void CargarFacturas()
        {
            if (Conversion.Val(lIdCliente.Text) == 0)
            {
                pBotones.Visible = false;
                pCampos.Visible = false;
                return;
            }
            else
            {
                pBotones.Visible = true;
                pCampos.Visible = true;
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT  nfact, ffac, Total FROM   dbo.FacturaCompleta WHERE ncli =" + Conversion.Val(lIdCliente.Text) +" GROUP BY nfact, ffac, Total ORDER BY nfact", routines.Conectar());
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "facturas");
                gridFacturas.DataSource = dataSet.Tables["facturas"];
                gridFacturas.Visible = true;
            }
        }
        /**Para dar de Alta un Nuevo Cliente*/
        private void bNuevoCli_Click(object sender, EventArgs e)
        {
            if (routines.SqlAccion("INSERT INTO Customers (CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax) VALUES ('*****', '*****','','','', '', '', '', '', '')  "))
            {
                buscar(" CompanyName LIKE '****%' ");
                MessageBox.Show("Se ha Creado un Nuevo Registro para el Cliente que Desea Ingresar, Seleccione la Línea Nueva, Cargue los Datos y Luego Confirme con el Botón 'Guardar Cambios'.", "Nuevo Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            // Para Guardar los Errores que Surjan
            string errores = "";
            // Guardamos el caracter del enter
            string enter = Constants.vbCrLf;
            if (tCliente.Text.Trim().Length < 3)
            {
                errores += "Debe completar el Cliente." + enter;
            }

            if (tContacto.Text.Trim().Length < 3)
            {
                errores += "Debe Completar el o los Nombres de Contacto." + enter;
            }

            tTelefono.Text = tTelefono.Text.Trim().Replace(".", "").Replace(" ", "").Replace(",", "").Replace("-", "");
            if (tTelefono.Text.Trim().Length < 4 | tTelefono.Text.IndexOf("11111") > -1 | tTelefono.Text.IndexOf("12345") > -1 | tTelefono.Text.IndexOf("000000") > -1)
            {
                errores += "Debe completar CORRECTAMENTE el Numero de Telefono." + enter;
            }

            tFax.Text = tFax.Text.Trim().Replace(".", "").Replace(" ", "").Replace(",", "").Replace("-", "");
            if (tFax.Text.Trim().Length < 4 | tFax.Text.IndexOf("11111") > -1 | tFax.Text.IndexOf("12345") > -1 | tFax.Text.IndexOf("000000") > -1)
            {
                errores += "Debe completar CORRECTAMENTE el Numero de Fax." + enter;
            }

            if (errores.Length > 0)
            {
                MessageBox.Show("Hubo errores, Por Favor Verifique y Corrija Antes de Intentar de Nuevo:" + enter + enter + errores);
                return;
            }
            // Ejecutamos el Update
            if (routines.SqlAccion("UPDATE Customers SET CompanyName='" + tCliente.Text.Trim().ToUpper().Replace("'", "´") + "', ContactName='" + tContacto.Text.Trim().ToUpper().Replace("'", "´") + "', ContactTitle='" + tCargo.Text.Trim().ToUpper().Replace("'", "´") + "', Address='" + tDireccion.Text.Trim().ToUpper().Replace("'", "´") + "', City='" + tCiudad.Text.Trim().ToUpper().Replace("'", "´") + "', Region='" + tLocalidad.Text.Trim().ToUpper().Replace("'", "´") + "', PostalCode='" + tCP.Text.Trim().ToUpper().Replace("'", "´") + "', Country='" + tPais.Text.Trim().ToUpper().Replace("'", "´") + "', Phone=" + Conversion.Val(tTelefono.Text.Trim().Replace(".", "").Replace(" ", "").Replace(",", "")) + ", Fax=" + Conversion.Val(tFax.Text.Trim().Replace(".", "").Replace(" ", "").Replace(",", "")) + " WHERE ID=" + routines.Vnum(lIdCliente.Text)) == true)
            {
                MessageBox.Show("Cambios Realizados Correctamente.", "Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buscar(" ID=" + routines.Vnum(lIdCliente.Text));
            }
            else
            {
                MessageBox.Show("Se Produjo un Error al Querer Guardar los Datos del Cliente, Reintente, y si el Error Persiste, Anote Todos los Datos que Quizo Ingresar y Comuníquese con el Programador (Otra Vez).", "Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está por ELIMINAR definitivamente el Cliente: " + tCliente.Text.Trim().ToUpper() + ",. Es algo EXTREMO. Está SEGURO?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                return;
            // Ejecutamos el Delete
            if (routines.SqlAccion("DELETE FROM Customers  WHERE  ID=" + Conversion.Val(lIdCliente.Text)) == false)
            {
                MessageBox.Show("Hubo un Error al intentar Borrar el Cliente, Reintente, y Si el Error Persiste, Anote Todos los Datos que Quizo Ingresar y Comuníquese con el Programador (Otra Vez).", "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                buscar(" id=" + Conversion.Val(lIdCliente.Text));
                MessageBox.Show("El Cliente fue ELIMINADO de la Base de Datos.");
            }
        }

        private void gridFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FilaClickFacturas(e.RowIndex);
        }
        private void gridFacturas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            FilaClickFacturas(e.RowIndex);
        }
        //Filtro de la Fila Seleccionada Para Cargar el Grid de los Detalles
        public void FilaClickFacturas(int fila)
        {
            string tfila;
            if (Information.IsNothing(gridClientes.Rows[fila].Cells[0].Value))
            {
                lnfact.Text = "0";
                gridDetalles.Visible = false;
                return;
            }
            else
            {
                tfila = gridFacturas.Rows[fila].Cells[1].Value.ToString();
                lnfact.Text = tfila.ToString();
                CargarDetalles();
            }
        }
        /**Para Cargar los Datos de las Facturas*/
        public void CargarDetalles()
        {
            if (Conversion.Val(lnfact.Text) == 0)
            {
                gridDetalles.Visible = false;
                return;
            }
            else
            {
                pBotones.Visible = true;
                pCampos.Visible = true;
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT producto, precio, iva, pconiva, cant, subtotal, total from facturacompleta where nfact = " + Conversion.Val(lnfact.Text), routines.Conectar());
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "detalles");
                gridDetalles.DataSource = dataSet.Tables["detalles"];
                if (dataSet.Tables["detalles"].Rows.Count > 0)
                {
                    gridDetalles.Visible = true;
                }
                else
                {
                    gridDetalles.Visible = false;
                }
            }
        }
    }

}
