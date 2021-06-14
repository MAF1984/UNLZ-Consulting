<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Cubilete = New System.Windows.Forms.PictureBox()
        Me.Dado1 = New System.Windows.Forms.PictureBox()
        Me.Dado2 = New System.Windows.Forms.PictureBox()
        Me.Dado3 = New System.Windows.Forms.PictureBox()
        Me.Dado4 = New System.Windows.Forms.PictureBox()
        Me.Dado5 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lTurno = New System.Windows.Forms.Label()
        Me.lNombreJugador = New System.Windows.Forms.Label()
        CType(Me.Cubilete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dado1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dado2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dado3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dado4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dado5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cubilete
        '
        Me.Cubilete.BackColor = System.Drawing.Color.Transparent
        Me.Cubilete.Location = New System.Drawing.Point(464, 12)
        Me.Cubilete.Name = "Cubilete"
        Me.Cubilete.Size = New System.Drawing.Size(319, 272)
        Me.Cubilete.TabIndex = 1
        Me.Cubilete.TabStop = False
        '
        'Dado1
        '
        Me.Dado1.BackgroundImage = Global.DadosVB.My.Resources.Resources.dado6
        Me.Dado1.Location = New System.Drawing.Point(114, 81)
        Me.Dado1.Name = "Dado1"
        Me.Dado1.Size = New System.Drawing.Size(94, 95)
        Me.Dado1.TabIndex = 2
        Me.Dado1.TabStop = False
        '
        'Dado2
        '
        Me.Dado2.BackgroundImage = Global.DadosVB.My.Resources.Resources.dado6
        Me.Dado2.Location = New System.Drawing.Point(114, 216)
        Me.Dado2.Name = "Dado2"
        Me.Dado2.Size = New System.Drawing.Size(94, 95)
        Me.Dado2.TabIndex = 3
        Me.Dado2.TabStop = False
        '
        'Dado3
        '
        Me.Dado3.BackgroundImage = Global.DadosVB.My.Resources.Resources.dado6
        Me.Dado3.Location = New System.Drawing.Point(114, 355)
        Me.Dado3.Name = "Dado3"
        Me.Dado3.Size = New System.Drawing.Size(94, 95)
        Me.Dado3.TabIndex = 4
        Me.Dado3.TabStop = False
        '
        'Dado4
        '
        Me.Dado4.BackgroundImage = Global.DadosVB.My.Resources.Resources.dado6
        Me.Dado4.Location = New System.Drawing.Point(258, 156)
        Me.Dado4.Name = "Dado4"
        Me.Dado4.Size = New System.Drawing.Size(94, 95)
        Me.Dado4.TabIndex = 5
        Me.Dado4.TabStop = False
        '
        'Dado5
        '
        Me.Dado5.BackgroundImage = Global.DadosVB.My.Resources.Resources.dado6
        Me.Dado5.Location = New System.Drawing.Point(258, 292)
        Me.Dado5.Name = "Dado5"
        Me.Dado5.Size = New System.Drawing.Size(94, 95)
        Me.Dado5.TabIndex = 6
        Me.Dado5.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(1, 1)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(77, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "&Opciones"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'lTurno
        '
        Me.lTurno.AutoSize = True
        Me.lTurno.BackColor = System.Drawing.Color.Black
        Me.lTurno.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTurno.ForeColor = System.Drawing.Color.DarkOrange
        Me.lTurno.Location = New System.Drawing.Point(10, 36)
        Me.lTurno.Name = "lTurno"
        Me.lTurno.Size = New System.Drawing.Size(140, 22)
        Me.lTurno.TabIndex = 8
        Me.lTurno.Text = "Esta tirando:"
        '
        'lNombreJugador
        '
        Me.lNombreJugador.AutoSize = True
        Me.lNombreJugador.BackColor = System.Drawing.Color.Transparent
        Me.lNombreJugador.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNombreJugador.ForeColor = System.Drawing.Color.White
        Me.lNombreJugador.Location = New System.Drawing.Point(156, 36)
        Me.lNombreJugador.Name = "lNombreJugador"
        Me.lNombreJugador.Size = New System.Drawing.Size(0, 27)
        Me.lNombreJugador.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DadosVB.My.Resources.Resources.mesa
        Me.ClientSize = New System.Drawing.Size(784, 503)
        Me.ControlBox = False
        Me.Controls.Add(Me.lNombreJugador)
        Me.Controls.Add(Me.lTurno)
        Me.Controls.Add(Me.Dado5)
        Me.Controls.Add(Me.Dado4)
        Me.Controls.Add(Me.Dado3)
        Me.Controls.Add(Me.Dado2)
        Me.Controls.Add(Me.Dado1)
        Me.Controls.Add(Me.Cubilete)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Generala | Juego en curso"
        CType(Me.Cubilete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dado1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dado2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dado3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dado4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dado5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cubilete As PictureBox
    Friend WithEvents Dado1 As PictureBox
    Friend WithEvents Dado2 As PictureBox
    Friend WithEvents Dado3 As PictureBox
    Friend WithEvents Dado4 As PictureBox
    Friend WithEvents Dado5 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lTurno As Label
    Friend WithEvents lNombreJugador As Label
End Class
