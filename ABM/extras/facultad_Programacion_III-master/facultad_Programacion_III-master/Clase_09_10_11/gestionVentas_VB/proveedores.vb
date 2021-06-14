Imports System.Runtime.InteropServices
'Clases para ADO, para la Conexion con la DB
Imports System.Data.SqlClient
Public Class proveedores
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
    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim inicio As New inicio
        inicio.Show()
        Me.Close()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim ambClientes As New clientes
        ambClientes.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Application.ExitThread()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub InicioToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        Dim inicio As New inicio
        inicio.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        Dim login As New login
        login.Show()
        Me.Close()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        Dim ambClientes As New clientes
        ambClientes.Show()
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscar(" ApeYNom LIKE '" & tBuscar.Text & "%' ")
    End Sub
    'Para Buscar los Clientes
    Sub buscar(ByVal condicion As String)
        Dim dataAdapter As New SqlDataAdapter("SELECT TOP (100) PERCENT NProveedor, ApeYNom, CUIT FROM ProveedoresBusqueda WHERE " & condicion & " ORDER BY ApeYNom", connection)
        Dim dataSet As New DataSet
        dataAdapter.Fill(dataSet, "proveedores")
        If dataSet.Tables("proveedores").Rows.Count = 0 Then

            gridProveedores.Visible = False
            pCampos.Visible = False
            lIdProveedor.Visible = False
            btnGuardar.Visible = False
            btnBorrar.Visible = False
        Else
            gridProveedores.DataSource = dataSet.Tables("proveedores")
            gridProveedores.Refresh()
            gridProveedores.Visible = True
            lIdProveedor.Visible = True
            btnGuardar.Visible = True
            btnBorrar.Visible = True
        End If

    End Sub
    Private Sub proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscar(" ApeYNom LIKE '" & tBuscar.Text & "%' ")
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If SqlAccion("INSERT INTO Proveedores (ApellidoProveedor ,NombreProveedor ,DocumentoProveedor ,CuitProveedor ,DomicilioProveedor ,PostalProveedor ,LocalidadProveedor ,ProvinciaProveedor ,TelefonoProveedor ,FechaNacimientoProveedor ,ComentariosProveedor ,EMailProveedor ,Estado) VALUES ('*****', '*****','','','', '', '', '', '', getdate(), '', '', 1) ") Then
            buscar(" ApeYNom LIKE '****%' ")
            MsgBox("Se ha Creado un Nuevo Registro para el Proveedor que Desea Ingresar, Seleccione la Línea Nueva, Cargue los Datos y Luego Confirme con el Botón 'Guardar Cambios'.", MsgBoxStyle.Information, "Nuevo Proveedor")
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If MessageBox.Show("Está por ELIMINAR definitivamente el Proveedor: " & tApellido.Text.Trim.ToUpper & " " & tNombre.Text.Trim.ToUpper & ",. Es algo EXTREMO. Está SEGURO?", "Eliminar Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        'Ejecutamos el Delete
        If SqlAccion("DELETE FROM Proveedores  WHERE  NProveedor=" & Val(lIdProveedor.Text)) = False Then
            MsgBox("Hubo un Error al intentar Borrar el Cliente, Reintente, y Si el Error Persiste, Anote Todos los Datos que Quizo Ingresar y Comuníquese con el Programador (Otra Vez).", MsgBoxStyle.Information, "Eliminar Cliente")
        Else
            buscar(" NProveedor=" & Val(lIdProveedor.Text))
            MsgBox("El Proveedor fue ELIMINADO de la Base de Datos.", MsgBoxStyle.Information, "Eliminar Proveedor")
        End If
    End Sub
    'Filtro al Hacer Click en una fila
    Private Sub gridProveedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridProveedores.CellContentClick
        FilaClick(e)
    End Sub
    'Filtro al Dar Enter en una fila
    Private Sub gridProveedores_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles gridProveedores.RowEnter
        FilaClick(e)
    End Sub
    'Filtro de la Fila Seleccionada
    Sub FilaClick(ByVal e As Object)
        Dim fila As Integer = e.RowIndex
        Dim tfila As String
        If IsNothing(gridProveedores.Rows(fila).Cells(0).Value) Then
            lIdProveedor.Text = "0"
            btnGuardar.Visible = False
            btnBorrar.Visible = False
            btnNuevo.Visible = False
            pCampos.Visible = False
            Exit Sub
        Else
            tfila = gridProveedores.Rows(fila).Cells(0).Value
            lIdProveedor.Text = tfila.ToString()
            btnGuardar.Visible = True
            btnBorrar.Visible = True
            btnNuevo.Visible = True
            pCampos.Visible = True
            CargarCamposClientes()
        End If
    End Sub
    'Carga los Datos del Cliente seleccionado en los campos
    Sub CargarCamposClientes()
        If Val(lIdProveedor.Text) = 0 Then
            pCampos.Visible = False
            Exit Sub
        Else
            pCampos.Visible = True
            Dim dataAdapter As New SqlDataAdapter("SELECT UPPER(LTRIM(RTRIM(ISNULL(ApellidoProveedor,'****')))) AS ApellidoProveedor,
                                                        UPPER(LTRIM(RTRIM(ISNULL(NombreProveedor,'****')))) AS NombreProveedor,
                                                        LTRIM(RTRIM(ISNULL(DocumentoProveedor,''))) AS DocumentoProveedor,
                                                        LTRIM(RTRIM(ISNULL(CuitProveedor,''))) AS CuitProveedor,
                                                        LTRIM(RTRIM(ISNULL(DomicilioProveedor,''))) AS DomicilioProveedor,
                                                        LTRIM(RTRIM(ISNULL(PostalProveedor,''))) AS PostalProveedor,
                                                        LTRIM(RTRIM(ISNULL(LocalidadProveedor,''))) AS LocalidadProveedor,
                                                        LTRIM(RTRIM(ISNULL(ProvinciaProveedor,''))) AS ProvinciaProveedor,
                                                        LTRIM(RTRIM(ISNULL(TelefonoProveedor,''))) TelefonoProveedor,
                                                        FechaNacimientoProveedor,
                                                        LTRIM(RTRIM(ISNULL(ComentariosProveedor,''))) AS ComentariosProveedor,
                                                        LTRIM(RTRIM(ISNULL(EMailProveedor,''))) AS EMailProveedor,
                                                        isnull(Estado,0) AS Estado
                                                    FROM Proveedores
                                                    WHERE NProveedor=" & Val(lIdProveedor.Text), connection)
            Dim dataSet As New DataSet
            dataAdapter.Fill(dataSet, "proveedores")
            tApellido.Text = dataSet.Tables("proveedores").Rows(0)("ApellidoProveedor")
            tNombre.Text = dataSet.Tables("proveedores").Rows(0)("NombreProveedor")
            tDNI.Text = dataSet.Tables("proveedores").Rows(0)("DocumentoProveedor")
            DateTimePicker1.Value = dataSet.Tables("proveedores").Rows(0)("FechaNacimientoProveedor")
            CheckBox1.Checked = IIf(dataSet.Tables("proveedores").Rows(0)("Estado") = 0, False, True)
            tCUIT.Text = dataSet.Tables("proveedores").Rows(0)("CuitProveedor")
            tDireccion.Text = dataSet.Tables("proveedores").Rows(0)("DomicilioProveedor")
            tLocalidad.Text = dataSet.Tables("proveedores").Rows(0)("LocalidadProveedor")
            tCP.Text = dataSet.Tables("proveedores").Rows(0)("PostalProveedor")
            tProvincia.Text = dataSet.Tables("proveedores").Rows(0)("ProvinciaProveedor")
            tTelefono.Text = dataSet.Tables("proveedores").Rows(0)("TelefonoProveedor")
            tEmail.Text = dataSet.Tables("proveedores").Rows(0)("EMailProveedor")
            tComentario.Text = dataSet.Tables("proveedores").Rows(0)("ComentariosProveedor")
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Para Guardar los Errores que Surjan
        Dim errores As String = ""
        'Guardamos el caracter del enter
        Dim enter As String = vbCrLf
        If tApellido.Text.Trim.Length < 3 Then
            errores &= "Debe Completar el o los Apellido del Proveedor." & enter
        End If
        If tNombre.Text.Trim.Length < 3 Then
            errores &= "Debe Completar el o los Nombre del Proveedor." & enter
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
        If SqlAccion("UPDATE Proveedores SET Estado =" & IIf(CheckBox1.Checked, 1, 0) & ", ApellidoProveedor='" & tApellido.Text.Trim.ToUpper.Replace("'", "´") & "' , NombreProveedor='" & tNombre.Text.Trim.ToUpper.Replace("'", "´") & "', DocumentoProveedor=" & Val(tDNI.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "")) & ", CuitProveedor =" & Val(tCUIT.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "")) & ", DomicilioProveedor='" & tDireccion.Text.Trim.ToUpper.Replace("'", "´") & "', ProvinciaProveedor='" & tProvincia.Text.Trim.ToUpper.Replace("'", "´") & "', LocalidadProveedor='" & tLocalidad.Text.Trim.ToUpper.Replace("'", "´") & "', PostalProveedor='" & tCP.Text.Trim.ToUpper.Replace("'", "´") & "', EMailProveedor='" & tEmail.Text.Trim.ToUpper.Replace("'", "´") & "', FechaNacimientoProveedor=" & FechaSql(DateTimePicker1.Value) & ", TelefonoProveedor=" & Val(tTelefono.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "")) & ", ComentariosProveedor='" & tComentario.Text.Trim.ToUpper.Replace("'", "´") & "' WHERE NProveedor=" & Vnum(lIdProveedor.Text)) = True Then
            MsgBox("Cambios Realizados Correctamente.", MsgBoxStyle.Information, "Editar Proveedor")
            buscar(" NProveedor=" & Vnum(lIdProveedor.Text))
        Else
            MsgBox("Se Produjo un Error al Querer Guardar los Datos del Proveedor, Reintente, y si el Error Persiste, Anote Todos los Datos que Quizo Ingresar y Comuníquese con el Programador (Otra Vez).", MsgBoxStyle.Information, "Editar Proveedor")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Dim inicio As New inicio
        inicio.Show()
        Me.Close()
    End Sub

    Private Sub lblSistema_Click(sender As Object, e As EventArgs)
        Dim inicio As New inicio
        inicio.Show()
        Me.Close()
    End Sub

    Private Sub pnlContenido_Paint(sender As Object, e As PaintEventArgs) Handles pnlContenido.Paint

    End Sub
End Class