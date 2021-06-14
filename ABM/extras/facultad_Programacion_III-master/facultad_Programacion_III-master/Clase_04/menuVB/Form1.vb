Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        If MessageBox.Show("¿Seguro que deseas salir?", "Salir del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then End
    End Sub

    Private Sub bClientes_Click(sender As Object, e As EventArgs) Handles bClientes.Click
        Dim cliente As New Clientes
        cliente.BackColor = Color.Red
        cliente.ShowDialog()
    End Sub

    Private Sub SistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SistemaToolStripMenuItem.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MessageBox.Show("¿Seguro que deseas salir?", "Salir del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then End
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim cliente As New Clientes
        cliente.BackColor = Color.Red
        cliente.ShowDialog()
    End Sub

    Private Sub bProveedores_Click(sender As Object, e As EventArgs) Handles bProveedores.Click
        Dim proveedor As New Proveedores
        proveedor.BackColor = Color.Green
        proveedor.ShowDialog()
    End Sub

    Private Sub bListados_Click(sender As Object, e As EventArgs) Handles bListados.Click
        Dim listado As New Listados
        listado.BackColor = Color.Blue
        listado.ShowDialog()
    End Sub

    Private Sub ListadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadosToolStripMenuItem.Click
        Dim listado As New Listados
        listado.BackColor = Color.Blue
        listado.ShowDialog()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Dim proveedor As New Proveedores
        proveedor.BackColor = Color.Green
        proveedor.ShowDialog()
    End Sub
End Class
