Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Public Class login
    Dim ar As String
    Dim connection As New SqlConnection("" & LeerConfig(ar) & "")
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
    Private Sub pTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles pTitulo.MouseDown
        If e.Button = MouseButtons.Left Then
            moverForm()
        End If
    End Sub
    'Para Realizar el Login
    Sub iniciarSesion()
        tUsuario.Text = tUsuario.Text.Replace("'", "").Replace(" ", "").Replace("""", "").ToUpper()
        Dim dataAdapter As New SqlDataAdapter("SELECT UsuarioCliente, ClaveCliente  FROM Clientes WHERE UsuarioCliente ='" & tUsuario.Text & "' AND ClaveCliente='" & tClave.Text & "'", connection)
        Dim dataSet As New DataSet
        dataAdapter.Fill(dataSet, "clientes")
        If dataSet.Tables("clientes").Rows.Count = 1 Then
            Dim inicio As New inicio
            inicio.Show()
            Me.Close()
        Else
            MsgBox("El Usuario o Contraseña no son Correctos.Intentelo de Nuevo.", MsgBoxStyle.Information, "Iniciar Sesión")
        End If

    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Para Guardar los Errores que Surjan
        Dim errores As String = ""
        'Guardamos el caracter del enter
        Dim enter As String = vbCrLf
        If tUsuario.Text.Trim.Length < 3 Then
            errores &= "Debe Igresar un Usuario." & enter
        End If
        If tClave.Text.Trim.Length < 6 Then
            errores &= "Debe Igresar una Contraseña." & enter
        End If
        If errores.Length > 0 Then
            MsgBox("Hubo errores, Por Favor Verifique y Corrija Antes de Intentar de Nuevo:" & enter & enter & errores, MsgBoxStyle.Information, "Errores")
            Exit Sub
        Else
            iniciarSesion()
        End If
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.ExitThread()
    End Sub

    Private Sub lLogin_Click(sender As Object, e As EventArgs) Handles lLogin.Click

    End Sub
End Class