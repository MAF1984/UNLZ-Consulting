Imports System.Runtime.InteropServices
'Clases para ADO, para la Conexion con la DB
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class clientes
    Dim ar As String
    Dim connection As New SqlConnection("" & LeerConfig(ar) & "")
    Private Sub pCerrar_Click(sender As Object, e As EventArgs) Handles pCerrar.Click
        Application.ExitThread()
    End Sub

    Private Sub pRestaurar_Click(sender As Object, e As EventArgs) Handles pRestaurar.Click
        Me.WindowState = FormWindowState.Normal
        pRestaurar.Visible = False
        pMaxi.Visible = True
    End Sub

    Private Sub pMaxi_Click(sender As Object, e As EventArgs) Handles pMaxi.Click
        Me.WindowState = FormWindowState.Maximized
        pMaxi.Visible = False
        pRestaurar.Visible = True
    End Sub

    Private Sub pMini_Click(sender As Object, e As EventArgs) Handles pMini.Click
        WindowState = FormWindowState.Minimized
    End Sub
    'Funciones para mover la ventana sin la barra de titulo
    Private Const WM_SYSCOMMAND As Integer = &H112&
    Private Const MOUSE_MOVE As Integer = &HF012&

    <System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    '
    <System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(
        ByVal hWnd As System.IntPtr, ByVal wMsg As Integer,
        ByVal wParam As Integer, ByVal lParam As Integer
        )
    End Sub

    'función privada usada para mover el formulario actual
    Private Sub moverForm()
        ReleaseCapture()
        SendMessage(Me.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0)
    End Sub
    Private Sub pTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTitulo.MouseDown
        If e.Button = MouseButtons.Left Then
            moverForm()
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim login As New login
        login.Show()
        Me.Close()
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        Dim inicio As New inicio
        inicio.Show()
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscar(" ApeYNom LIKE '" & tBuscar.Text & "%' ")
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
            btnGuardar.Visible = False
            btnBorrar.Visible = False
            Panel1.Visible = False
            Panel3.Visible = False
        Else
            gridClientes.DataSource = dataSet.Tables("clientes")
            gridClientes.Refresh()
            gridClientes.Visible = True
            lIdCliente.Visible = True
            btnGuardar.Visible = True
            btnBorrar.Visible = True
            Panel1.Visible = True
            Panel3.Visible = True
        End If

    End Sub

    Private Sub clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscar(" ApeYNom LIKE '" & tBuscar.Text & "%' ")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If SqlAccion("INSERT INTO Clientes (ApellidoCliente ,NombreCliente ,DocumentoCliente ,CuitCliente ,UsuarioCliente ,ClaveCliente ,DomicilioCliente ,PostalCliente ,LocalidadCliente ,ProvinciaCliente ,TelefonoCliente ,FechaNacimientoCliente ,ComentariosCliente ,EMailCliente ,Estado) VALUES ('*****', '*****','','','', '', '', '', '', '','', getdate(), '', '', 1)  ") Then
            buscar(" ApeYNom LIKE '****%' ")
            MsgBox("Se ha Creado un Nuevo Registro para el Cliente que Desea Ingresar, Seleccione la Línea Nueva, Cargue los Datos y Luego Confirme con el Botón 'Guardar Cambios'.", MsgBoxStyle.Information, "Nuevo Cliente")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If MessageBox.Show("Está por ELIMINAR definitivamente el Cliente: " & tApellido.Text.Trim.ToUpper & " " & tNombre.Text.Trim.ToUpper & ",. Es algo EXTREMO. Está SEGURO?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        'Ejecutamos el Delete
        If SqlAccion("DELETE FROM Clientes  WHERE  NCliente=" & Val(lIdCliente.Text)) = False Then
            MsgBox("Hubo un Error al intentar Borrar el Cliente, Reintente, y Si el Error Persiste, Anote Todos los Datos que Quizo Ingresar y Comuníquese con el Programador (Otra Vez).", MsgBoxStyle.Information, "Eliminar Cliente")
        Else
            buscar(" NCliente=" & Val(lIdCliente.Text))
            MsgBox("El Cliente fue ELIMINADO de la Base de Datos.", MsgBoxStyle.Information, "Eliminar Cliente")
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
            btnGuardar.Visible = False
            btnBorrar.Visible = False
            btnNuevo.Visible = False
            pCampos.Visible = False
            Panel1.Visible = False
            Panel2.Visible = False
            Panel3.Visible = False
            Exit Sub
        Else
            tfila = gridClientes.Rows(fila).Cells(0).Value
            lIdCliente.Text = tfila.ToString()
            btnGuardar.Visible = True
            btnBorrar.Visible = True
            btnNuevo.Visible = True
            pCampos.Visible = True
            Panel1.Visible = True
            Panel2.Visible = True
            Panel3.Visible = True
            CargarCamposClientes()
        End If
    End Sub
    'Carga los Datos del Cliente seleccionado en los campos
    Sub CargarCamposClientes()
        If Val(lIdCliente.Text) = 0 Then
            pCampos.Visible = False
            Exit Sub
        Else
            pCampos.Visible = True
            Dim dataAdapter As New SqlDataAdapter("SELECT UPPER(LTRIM(RTRIM(ISNULL(ApellidoCliente,'****')))) AS ApellidoCliente, 
		                                                  UPPER(LTRIM(RTRIM(ISNULL(NombreCliente,'****')))) AS NombreCliente, 
		                                                    LTRIM(RTRIM(ISNULL(DocumentoCliente,''))) AS DocumentoCliente, 
		                                                    LTRIM(RTRIM(ISNULL(CuitCliente,''))) AS CuitCliente, 
		                                                    LTRIM(RTRIM(ISNULL(UsuarioCliente,''))) AS UsuarioCliente, 
		                                                    LTRIM(RTRIM(ISNULL(ClaveCliente,''))) AS ClaveCliente, 
		                                                    LTRIM(RTRIM(ISNULL(DomicilioCliente,''))) AS DomicilioCliente, 
		                                                    LTRIM(RTRIM(ISNULL(PostalCliente,''))) AS PostalCliente, 
		                                                    LTRIM(RTRIM(ISNULL(LocalidadCliente,''))) AS LocalidadCliente, 
		                                                    LTRIM(RTRIM(ISNULL(ProvinciaCliente,''))) AS ProvinciaCliente, 
		                                                    LTRIM(RTRIM(ISNULL(TelefonoCliente,''))) TelefonoCliente, 
		                                                    FechaNacimientoCliente, 
		                                                    LTRIM(RTRIM(ISNULL(ComentariosCliente,''))) AS ComentariosCliente, 
		                                                    LTRIM(RTRIM(ISNULL(EMailCliente,''))) AS EMailCliente, 
		                                                    isnull(Estado,0) AS Estado
                                                     FROM Clientes WHERE NCliente=" & Val(lIdCliente.Text), connection)
            Dim dataSet As New DataSet
            dataAdapter.Fill(dataSet, "clientes")
            tApellido.Text = dataSet.Tables("clientes").Rows(0)("ApellidoCliente")
            tNombre.Text = dataSet.Tables("clientes").Rows(0)("NombreCliente")
            tDNI.Text = dataSet.Tables("clientes").Rows(0)("DocumentoCliente")
            DateTimePicker1.Value = dataSet.Tables("clientes").Rows(0)("FechaNacimientoCliente")
            CheckBox1.Checked = IIf(dataSet.Tables("clientes").Rows(0)("Estado") = 0, False, True)
            tCUIT.Text = dataSet.Tables("clientes").Rows(0)("CuitCliente")
            tUsuario.Text = dataSet.Tables("clientes").Rows(0)("UsuarioCliente")
            tClave.Text = dataSet.Tables("clientes").Rows(0)("ClaveCliente")
            tDireccion.Text = dataSet.Tables("clientes").Rows(0)("DomicilioCliente")
            tLocalidad.Text = dataSet.Tables("clientes").Rows(0)("LocalidadCliente")
            tCP.Text = dataSet.Tables("clientes").Rows(0)("PostalCliente")
            tProvincia.Text = dataSet.Tables("clientes").Rows(0)("ProvinciaCliente")
            tTelefono.Text = dataSet.Tables("clientes").Rows(0)("TelefonoCliente")
            tEmail.Text = dataSet.Tables("clientes").Rows(0)("EMailCliente")
            tComentario.Text = dataSet.Tables("clientes").Rows(0)("ComentariosCliente")
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Para Guardar los Errores que Surjan
        Dim errores As String = ""
        'Guardamos el caracter del enter
        Dim enter As String = vbCrLf
        If tApellido.Text.Trim.Length < 3 Then
            errores &= "Debe Completar el o los Apellido del Cliente." & enter
        End If
        If tNombre.Text.Trim.Length < 3 Then
            errores &= "Debe Completar el o los Nombre del Cliente." & enter
        End If
        If tUsuario.Text.Trim.Length < 3 Then
            errores &= "Debe Completar el Usuario." & enter
        End If
        If tClave.Text.Trim.Length < 6 Then
            errores &= "Debe Completar la Clave." & enter
        End If
        tDNI.Text = Val(tDNI.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "").Replace("-", ""))
        If tDNI.Text.Trim.Length < 4 Or tDNI.Text.IndexOf("11111") > -1 Or tCUIT.Text.IndexOf("12345") > -1 Or tDNI.Text.IndexOf("000000") > -1 Then
            errores &= "Debe completar CORRECTAMENTE el Numero de DNI." & enter
        End If
        tCUIT.Text = Val(tCUIT.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "").Replace("-", ""))
        If tCUIT.Text.Trim.Length < 4 Or tCUIT.Text.IndexOf("11111") > -1 Or tCUIT.Text.IndexOf("12345") > -1 Or tCUIT.Text.IndexOf("000000") > -1 Then
            errores &= "Debe completar CORRECTAMENTE el Numero de CUIT." & enter
        End If
        If errores.Length > 0 Then
            MsgBox("Hubo errores, Por Favor Verifique y Corrija Antes de Intentar de Nuevo:" & enter & enter & errores, MsgBoxStyle.Information, "Errores")
            Exit Sub
        End If
        'Ejecutamos el Update
        If SqlAccion("UPDATE Clientes SET ClaveCliente ='" & tClave.Text & "' , Estado =" & IIf(CheckBox1.Checked, 1, 0) & ", ApellidoCliente='" & tApellido.Text.Trim.ToUpper.Replace("'", "´") & "' , NombreCliente='" & tNombre.Text.Trim.ToUpper.Replace("'", "´") & "', DocumentoCliente=" & Val(tDNI.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "")) & ", CuitCliente =" & Val(tCUIT.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "")) & ", UsuarioCliente='" & tUsuario.Text.Trim.ToUpper.Replace("'", "´") & "', DomicilioCliente='" & tDireccion.Text.Trim.ToUpper.Replace("'", "´") & "', ProvinciaCliente='" & tProvincia.Text.Trim.ToUpper.Replace("'", "´") & "', LocalidadCliente='" & tLocalidad.Text.Trim.ToUpper.Replace("'", "´") & "', PostalCliente='" & tCP.Text.Trim.ToUpper.Replace("'", "´") & "', EMailCliente='" & tEmail.Text.Trim.ToUpper.Replace("'", "´") & "', FechaNacimientoCliente=" & FechaSql(DateTimePicker1.Value) & ", TelefonoCliente=" & Val(tTelefono.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "")) & ", ComentariosCliente='" & tComentario.Text.Trim.ToUpper.Replace("'", "´") & "' WHERE NCliente=" & Vnum(lIdCliente.Text)) = True Then
            MsgBox("Cambios Realizados Correctamente.", MsgBoxStyle.Information, "Editar Cliente")
            buscar(" NCliente=" & Vnum(lIdCliente.Text))
        Else
            MsgBox("Se Produjo un Error al Querer Guardar los Datos del Cliente, Reintente, y si el Error Persiste, Anote Todos los Datos que Quizo Ingresar y Comuníquese con el Programador (Otra Vez).", MsgBoxStyle.Information, "Editar Cliente")
        End If
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Dim ambProveedores As New proveedores
        ambProveedores.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim inicio As New inicio
        inicio.Show()
        Me.Close()
    End Sub

    Private Sub lblSistema_Click(sender As Object, e As EventArgs) Handles lblSistema.Click
        Dim inicio As New inicio
        inicio.Show()
        Me.Close()
    End Sub
End Class