'Clases para ADO, para la Conexion con la DB
Imports System.Data.SqlClient
Public Class abmCustomers
    Dim ar As String
    Dim connection As New SqlConnection("data source=" & CStr(LeerHostDb(ar)) & "; initial catalog=Northwind; integrated security=true")
    Private Sub abmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscar(" CompanyName LIKE '" & tBuscar.Text & "%' ")
    End Sub
    'Para Buscar los Clientes
    Sub buscar(ByVal condicion As String)
        Dim dataAdapter As New SqlDataAdapter("SELECT TOP (100) PERCENT NCliente, ApeYNom, CUIT FROM ClientesBusqueda WHERE " & condicion & " ORDER BY ApeYNom", connection)
        Dim dataSet As New DataSet
        dataAdapter.Fill(dataSet, "clientes")
        If dataSet.Tables("clientes").Rows.Count = 0 Then

            gridClientes.Visible = False
            pCampos.Visible = False
            lIdCliente.Visible = False
        Else
            gridClientes.DataSource = dataSet.Tables("clientes")
            gridClientes.Refresh()
            gridClientes.Visible = True
            lIdCliente.Visible = True
        End If

    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        buscar(" CompanyName LIKE '" & tBuscar.Text & "%' ")
    End Sub

    Private Sub bNuevoCli_Click(sender As Object, e As EventArgs) Handles bNuevoCli.Click
        If SqlAccion("INSERT INTO Customers (CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax) VALUES ('*****', '*****','','','', '', '', '', '', '')  ") Then
            buscar(" CompanyName LIKE '****%' ")
            MsgBox("Se ha Creado un Nuevo Registro para el Cliente que Desea Ingresar, Seleccione la Línea Nueva, Cargue los Datos y Luego Confirme con el Botón 'Guardar Cambios'.", MsgBoxStyle.Information, "Nuevo Cliente")
        End If
    End Sub
    'Filtro al Hacer Click en una fila
    Private Sub gridClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridClientes.CellContentClick
        FilaClick(e)
    End Sub
    'Filtro al Dar Enter en una fila
    Private Sub gridClientes_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles gridClientes.RowEnter
        FilaClick(e)
    End Sub
    'Filtro de la Fila Seleccionada
    Sub FilaClick(ByVal e As Object)
        Dim fila As Integer = e.RowIndex
        Dim tfila As String

        If IsNothing(gridClientes.Rows(fila).Cells(0).Value) Then
            lIdCliente.Text = "0"
            pBotones.Visible = False
            pCampos.Visible = False
            Exit Sub
        Else
            tfila = gridClientes.Rows(fila).Cells(0).Value
            lIdCliente.Text = tfila.ToString()
            CargarCamposClientes()
        End If
    End Sub
    'Carga los Datos del Cliente seleccionado en los campos
    Sub CargarCamposClientes()
        If Val(lIdCliente.Text) = 0 Then
            pBotones.Visible = False
            pCampos.Visible = False
            Exit Sub
        Else
            pBotones.Visible = True
            pCampos.Visible = True
            Dim dataAdapter As New SqlDataAdapter("SELECT UPPER(LTRIM(RTRIM(ISNULL(CompanyName,'****')))) AS cliente, UPPER(LTRIM(RTRIM(ISNULL(ContactName,'****')))) AS contacto, LTRIM(RTRIM(ISNULL(ContactTitle,''))) AS cargo , LTRIM(RTRIM(ISNULL(Address,''))) AS direccion, LTRIM(RTRIM(ISNULL(City,''))) AS ciudad, LTRIM(RTRIM(ISNULL(Region,''))) AS localidad , LTRIM(RTRIM(ISNULL(PostalCode,''))) AS cp, LTRIM(RTRIM(ISNULL(Country,''))) AS pais, LTRIM(RTRIM(ISNULL(Phone,''))) AS telefono, LTRIM(RTRIM(ISNULL(Fax,''))) AS fax FROM Customers WHERE ID=" & Val(lIdCliente.Text), connection)
            Dim dataSet As New DataSet
            dataAdapter.Fill(dataSet, "clientes")
            tCliente.Text = dataSet.Tables("clientes").Rows(0)("cliente")
            tContacto.Text = dataSet.Tables("clientes").Rows(0)("contacto")
            tCargo.Text = dataSet.Tables("clientes").Rows(0)("cargo")
            tDireccion.Text = dataSet.Tables("clientes").Rows(0)("direccion")
            tLocalidad.Text = dataSet.Tables("clientes").Rows(0)("localidad")
            tCP.Text = dataSet.Tables("clientes").Rows(0)("cp")
            tCiudad.Text = dataSet.Tables("clientes").Rows(0)("ciudad")
            tPais.Text = dataSet.Tables("clientes").Rows(0)("pais")
            tTelefono.Text = dataSet.Tables("clientes").Rows(0)("telefono")
            tFax.Text = dataSet.Tables("clientes").Rows(0)("fax")
        End If
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        If MessageBox.Show("Está por ELIMINAR definitivamente el Cliente: " & tCliente.Text.Trim.ToUpper & ",. Es algo EXTREMO. Está SEGURO?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        'Ejecutamos el Delete
        If SqlAccion("DELETE FROM Customers  WHERE  ID=" & Val(lIdCliente.Text)) = False Then
            MsgBox("Hubo un Error al intentar Borrar el Cliente, Reintente, y Si el Error Persiste, Anote Todos los Datos que Quizo Ingresar y Comuníquese con el Programador (Otra Vez).", MsgBoxStyle.Information, "Eliminar Cliente")
        Else
            buscar(" id=" & Val(lIdCliente.Text))
            MsgBox("El Cliente fue ELIMINADO de la Base de Datos.")
        End If
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        'Para Guardar los Errores que Surjan
        Dim errores As String = ""
        'Guardamos el caracter del enter
        Dim enter As String = vbCrLf
        If tCliente.Text.Trim.Length < 3 Then
            errores &= "Debe completar el Cliente." & enter
        End If
        If tContacto.Text.Trim.Length < 3 Then
            errores &= "Debe Completar el o los Nombres de Contacto." & enter
        End If
        tTelefono.Text = Val(tTelefono.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "").Replace("-", ""))
        If tTelefono.Text.Trim.Length < 4 Or tTelefono.Text.IndexOf("11111") > -1 Or tTelefono.Text.IndexOf("12345") > -1 Or tTelefono.Text.IndexOf("000000") > -1 Then
            errores &= "Debe completar CORRECTAMENTE el Numero de Telefono." & enter
        End If
        tFax.Text = Val(tFax.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "").Replace("-", ""))
        If tFax.Text.Trim.Length < 4 Or tFax.Text.IndexOf("11111") > -1 Or tFax.Text.IndexOf("12345") > -1 Or tFax.Text.IndexOf("000000") > -1 Then
            errores &= "Debe completar CORRECTAMENTE el Numero de Fax." & enter
        End If
        If errores.Length > 0 Then
            MsgBox("Hubo errores, Por Favor Verifique y Corrija Antes de Intentar de Nuevo:" & enter & enter & errores)
            Exit Sub
        End If
        'Ejecutamos el Update
        If SqlAccion("UPDATE Customers SET CompanyName='" & tCliente.Text.Trim.ToUpper.Replace("'", "´") & "', ContactName='" & tContacto.Text.Trim.ToUpper.Replace("'", "´") & "', ContactTitle='" & tCargo.Text.Trim.ToUpper.Replace("'", "´") & "', Address='" & tDireccion.Text.Trim.ToUpper.Replace("'", "´") & "', City='" & tCiudad.Text.Trim.ToUpper.Replace("'", "´") & "', Region='" & tLocalidad.Text.Trim.ToUpper.Replace("'", "´") & "', PostalCode='" & tCP.Text.Trim.ToUpper.Replace("'", "´") & "', Country='" & tPais.Text.Trim.ToUpper.Replace("'", "´") & "', Phone=" & Val(tTelefono.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "")) & ", Fax=" & Val(tFax.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "")) & " WHERE ID=" & Vnum(lIdCliente.Text)) = True Then
            MsgBox("Cambios Realizados Correctamente.", MsgBoxStyle.Information, "Editar Cliente")

            buscar(" ID=" & Vnum(lIdCliente.Text))
        Else
            MsgBox("Se Produjo un Error al Querer Guardar los Datos del Cliente, Reintente, y si el Error Persiste, Anote Todos los Datos que Quizo Ingresar y Comuníquese con el Programador (Otra Vez).", MsgBoxStyle.Information, "Editar Cliente")
        End If
    End Sub

    Private Sub pCampos_Paint(sender As Object, e As PaintEventArgs) Handles pCampos.Paint

    End Sub

    Private Sub tBuscar_TextChanged(sender As Object, e As EventArgs) Handles tBuscar.TextChanged

    End Sub
End Class
