Imports System.IO
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class pLogin

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
    Private Sub moverForm()
        ReleaseCapture()
        SendMessage(Me.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0)
    End Sub

    Dim ar As String
    Dim connection As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=UNLZConsultingABM; integrated security=true")
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Activated

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TUsuario_TextChanged(sender As Object, e As EventArgs) Handles TUsuario.TextChanged

    End Sub

    Private Sub TContraseña_TextChanged(sender As Object, e As EventArgs) Handles TContraseña.TextChanged

    End Sub

    Private Sub bAceptar_Click(sender As Object, e As EventArgs) Handles bAceptar.Click
        Dim errores As String = ""
        Dim enter As String = vbCrLf
        'si es menor de 5 muestra error
        If TUsuario.Text.Trim.Length < 5 Then
            errores &= "Debe Igresar un Usuario de al menos 5 caracteres." & enter

        End If
        If TContraseña.Text.Trim.Length < 6 Then
            errores &= "Debe Igresar una Contraseña de al menos 6 caracteres.." & enter
        End If
        If errores.Length > 0 Then

            MsgBox("Hubo errores, Por Favor Verifique y Corrija Antes de Intentar de Nuevo:" & enter & enter & errores, MsgBoxStyle.Information, "Errores")

            Exit Sub

        Else
            IniciarSecion()

        End If

    End Sub

    Sub IniciarSecion()
        TUsuario.Text = TUsuario.Text.Replace("'", "").Replace(" ", "").Replace("""", "").ToUpper()
        'COMPRUEBA SI EXISTE ALGUN USUARIO CON CONTRASEÑA EN LA BASE DE DATOS
        TContraseña.Text = TContraseña.Text.Replace("'", "").Replace(" ", "").Replace("""", "").ToUpper()
        Dim dataAdapter As New SqlDataAdapter("SELECT Usuario, Clave,  Nombre, Apellido FROM idm WHERE Usuario ='" & TUsuario.Text & "' AND Clave='" & TContraseña.Text & "'", connection)

        Dim dataSet As New DataSet



        dataAdapter.Fill(dataSet, "idm")
        ape = dataSet.Tables("idm").Rows(0)("Apellido")
        nom = dataSet.Tables("idm").Rows(0)("Nombre")
        If dataSet.Tables("idm").Rows.Count > 0 Then

            Dim inicio As New Menu()
            Dim cli As New Clientes()


            'PONE NOMBRE Y APELLIDO EN EL TITULO DEL MENU
            inicio.LNombr.Text = TUsuario.Text

            inicio.Text = " USUARIO:  " & nom & " " & ape
            inicio.LMenu.Text = "MENU | " & nom & " " & ape



            inicio.LNombr.Refresh()
            Me.Visible = False
            inicio.ShowDialog()
            Me.Close()








        Else
            MsgBox("El Usuario o Contraseña no son Correctos. Intentelo de Nuevo.", MsgBoxStyle.Information, "Iniciar Sesión")
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TUsuario_Enter(sender As Object, e As EventArgs) Handles TUsuario.Enter
        If (TUsuario.Text = "Usuario") Then
            TUsuario.Text = ""
            TUsuario.ForeColor = Color.LightGray
        End If

    End Sub

    Private Sub TUsuario_Leave(sender As Object, e As EventArgs) Handles TUsuario.Leave
        If (TUsuario.Text = "") Then
            TUsuario.Text = "Usuario"
            TUsuario.ForeColor = Color.DimGray
        End If


    End Sub

    Private Sub TContraseña_Enter(sender As Object, e As EventArgs) Handles TContraseña.Enter
        If (TContraseña.Text = "Contraseña") Then
            TContraseña.Text = ""
            TContraseña.ForeColor = Color.LightGray
            TContraseña.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub TContraseña_Leave(sender As Object, e As EventArgs) Handles TContraseña.Leave
        If (TContraseña.Text = "") Then
            TContraseña.Text = "Contraseña"
            TContraseña.ForeColor = Color.DimGray
            TContraseña.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub bCerrar_Click(sender As Object, e As EventArgs) Handles bCerrar.Click
        Application.ExitThread()
    End Sub

    Private Sub bMinimizar_Click(sender As Object, e As EventArgs) Handles bMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            moverForm()
        End If
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            moverForm()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub
End Class
