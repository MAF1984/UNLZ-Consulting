'Importamos el Cliente de SQLSERVER
Imports System.Data.SqlClient
Public Class Form1
    'Creamos la Conexion a la DB
    Dim conn As New SqlConnection("data source=DESKTOP-SB0M5S9\SQLEXPRESS; initial catalog=Northwind; integrated security=true")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub Buscar()
        'Armamos la Consulta
        Dim da As New SqlDataAdapter("SELECT * FROM factura WHERE nfact=" & CStr(Int(Val(NFact.Text))).Trim, conn)
        'Instanciamos el DataSet
        Dim ds As New DataSet
        da.Fill(ds, "Facturas")
        'Le pasomos los resultado a la Grilla
        Grilla.DataSource = ds.Tables("Facturas")
        'Refrescasmos la Grilla
        Grilla.Refresh()
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        'Lamamos a Buscar al hacer click
        Buscar()
    End Sub
End Class
