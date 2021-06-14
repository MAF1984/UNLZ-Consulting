Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        WebBrowser1.Navigate(New Uri("http://www.google.com.ar/search?sxsrf=ALeKk008WtCMJQ30Fh9B3k-XMtBeGDQLvA%3A1586010186706&source=hp&ei=SpiIXvyaKbnZ5OUPqImMoA8&q=" & tBuscar.Text & "&oq=" & tBuscar.Text & "&gs_lcp=CgZwc3ktYWIQAzIHCAAQgwEQQzICCAAyAggAMgIIADIFCAAQgwEyAggAMgIIADICCAAyAggAMgIIADoECCMQJzoGCCMQJxATOgQIABBDShMIFxIPMGcxNTVnMTQ0ZzUtMjc3Sg0IGBIJMGcxZzFnNS0xUKoLWIYRYOEUaABwAHgCgAHyBIgBmQySAQswLjIuMS4wLjEuMZgBAKABAaoBB2d3cy13aXo&sclient=psy-ab&ved=0ahUKEwj856Wu_M7oAhW5LLkGHagEA_QQ4dUDCAY&uact=5"))
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bIr_Click(sender As Object, e As EventArgs) Handles bIr.Click
        If (String.IsNullOrEmpty(tBuscar.Text)) Then
            Return
        End If
        If (tBuscar.Equals("about:blank")) Then
            Return
        End If
        If (Not tBuscar.Text.StartsWith("http://") And Not tBuscar.Text.StartsWith("https://")) Then
            tBuscar.Text = "http://" + tBuscar.Text
        End If
        Try
            WebBrowser1.Navigate(New Uri(tBuscar.Text))
        Catch
            MessageBox.Show("Se produjo un error.")
        End Try
    End Sub

    Private Sub bRojo_Click(sender As Object, e As EventArgs) Handles bRojo.Click
        Me.BackColor = Color.Red
    End Sub

    Private Sub bVerde_Click(sender As Object, e As EventArgs) Handles bVerde.Click
        Me.BackColor = Color.Green
    End Sub

    Private Sub bAzul_Click(sender As Object, e As EventArgs) Handles bAzul.Click
        Me.BackColor = Color.Blue
    End Sub

    Private Sub bVer_Click(sender As Object, e As EventArgs) Handles bVer.Click
        bBuscar.Visible = Not bBuscar.Visible
        bIr.Visible = Not bIr.Visible
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class