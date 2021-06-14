Public Class Incio
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub bIniciar_Click(sender As Object, e As EventArgs) Handles bIniciar.Click
        If (tJugador1.Text <> "" And tJugador2.Text <> "") Then
            'Asignamos los Valores a las Variables de los Nombres de los Jugadores
            nombreJugadores.Jugador1Nombre = tJugador1.Text
            nombreJugadores.Jugador2Nombre = tJugador2.Text
            'Iniciamos el Formulario Principal
            Dim mesa As New Form1
            mesa.Show()
            Me.Close()
        Else
            MessageBox.Show("Es requisito ingresar a los jugadores.")
        End If
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MessageBox.Show("¿Seguro que deseas salir?", "Salir del Juego", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then Me.Close()
    End Sub
End Class