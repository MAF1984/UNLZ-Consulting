Imports System.Runtime.InteropServices
Public Class inicio

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pCerrar.Click
        Application.ExitThread()
    End Sub

    Private Sub pMaxi_Click(sender As Object, e As EventArgs) Handles pMaxi.Click
        Me.WindowState = FormWindowState.Maximized
        pMaxi.Visible = False
        pRestaurar.Visible = True
    End Sub
    Private Sub pMini_Click(sender As Object, e As EventArgs) Handles pMini.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pRestaurar_Click(sender As Object, e As EventArgs) Handles pRestaurar.Click
        Me.WindowState = FormWindowState.Normal
        pRestaurar.Visible = False
        pMaxi.Visible = True
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim login As New login
        login.Show()
        Me.Close()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim abmClientes As New clientes
        abmClientes.Show()
        Me.Close()
    End Sub

    Private Sub btnProvvedores_Click(sender As Object, e As EventArgs) Handles btnProvvedores.Click
        Dim abmProveedores As New proveedores
        abmProveedores.Show()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub lblSistema_Click(sender As Object, e As EventArgs) Handles lblSistema.Click

    End Sub

    Private Sub pnlMenu_Paint(sender As Object, e As PaintEventArgs) Handles pnlMenu.Paint

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
