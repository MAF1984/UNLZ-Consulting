<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pCampos = New System.Windows.Forms.Panel()
        Me.tContraseña = New System.Windows.Forms.TextBox()
        Me.lContraseña = New System.Windows.Forms.Label()
        Me.tContraseñaRepite = New System.Windows.Forms.TextBox()
        Me.lRepitePass = New System.Windows.Forms.Label()
        Me.lApellido = New System.Windows.Forms.Label()
        Me.tApellido = New System.Windows.Forms.TextBox()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.tNombre = New System.Windows.Forms.TextBox()
        Me.TBuscar = New System.Windows.Forms.TextBox()
        Me.lLegajo = New System.Windows.Forms.Label()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.pBotones = New System.Windows.Forms.Panel()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bAceptar = New System.Windows.Forms.Button()
        Me.bNuevoCliente = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lEmail = New System.Windows.Forms.Label()
        Me.tEmail = New System.Windows.Forms.TextBox()
        Me.lUsuario = New System.Windows.Forms.Label()
        Me.tUsuario = New System.Windows.Forms.TextBox()
        Me.pCampos.SuspendLayout()
        Me.pBotones.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pCampos
        '
        Me.pCampos.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pCampos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pCampos.Controls.Add(Me.tUsuario)
        Me.pCampos.Controls.Add(Me.lUsuario)
        Me.pCampos.Controls.Add(Me.tEmail)
        Me.pCampos.Controls.Add(Me.lEmail)
        Me.pCampos.Controls.Add(Me.tContraseña)
        Me.pCampos.Controls.Add(Me.lContraseña)
        Me.pCampos.Controls.Add(Me.tContraseñaRepite)
        Me.pCampos.Controls.Add(Me.lRepitePass)
        Me.pCampos.Controls.Add(Me.lApellido)
        Me.pCampos.Controls.Add(Me.tApellido)
        Me.pCampos.Controls.Add(Me.LNombre)
        Me.pCampos.Controls.Add(Me.tNombre)
        Me.pCampos.Location = New System.Drawing.Point(414, 151)
        Me.pCampos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pCampos.Name = "pCampos"
        Me.pCampos.Size = New System.Drawing.Size(494, 363)
        Me.pCampos.TabIndex = 59
        '
        'tContraseña
        '
        Me.tContraseña.Location = New System.Drawing.Point(146, 122)
        Me.tContraseña.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tContraseña.MaxLength = 30
        Me.tContraseña.Name = "tContraseña"
        Me.tContraseña.Size = New System.Drawing.Size(346, 26)
        Me.tContraseña.TabIndex = 44
        Me.tContraseña.UseSystemPasswordChar = True
        '
        'lContraseña
        '
        Me.lContraseña.AutoSize = True
        Me.lContraseña.ForeColor = System.Drawing.SystemColors.Control
        Me.lContraseña.Location = New System.Drawing.Point(4, 128)
        Me.lContraseña.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lContraseña.Name = "lContraseña"
        Me.lContraseña.Size = New System.Drawing.Size(91, 20)
        Me.lContraseña.TabIndex = 43
        Me.lContraseña.Text = "Contaseña:"
        '
        'tContraseñaRepite
        '
        Me.tContraseñaRepite.Location = New System.Drawing.Point(170, 168)
        Me.tContraseñaRepite.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tContraseñaRepite.Name = "tContraseñaRepite"
        Me.tContraseñaRepite.Size = New System.Drawing.Size(322, 26)
        Me.tContraseñaRepite.TabIndex = 40
        '
        'lRepitePass
        '
        Me.lRepitePass.AutoSize = True
        Me.lRepitePass.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lRepitePass.Location = New System.Drawing.Point(2, 174)
        Me.lRepitePass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lRepitePass.Name = "lRepitePass"
        Me.lRepitePass.Size = New System.Drawing.Size(152, 20)
        Me.lRepitePass.TabIndex = 39
        Me.lRepitePass.Text = "Repetir Contraseña:"
        '
        'lApellido
        '
        Me.lApellido.AutoSize = True
        Me.lApellido.ForeColor = System.Drawing.Color.White
        Me.lApellido.Location = New System.Drawing.Point(4, 55)
        Me.lApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lApellido.Name = "lApellido"
        Me.lApellido.Size = New System.Drawing.Size(69, 20)
        Me.lApellido.TabIndex = 5
        Me.lApellido.Text = "Apellido:"
        '
        'tApellido
        '
        Me.tApellido.Location = New System.Drawing.Point(140, 51)
        Me.tApellido.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tApellido.MaxLength = 30
        Me.tApellido.Name = "tApellido"
        Me.tApellido.Size = New System.Drawing.Size(346, 26)
        Me.tApellido.TabIndex = 5
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.ForeColor = System.Drawing.Color.White
        Me.LNombre.Location = New System.Drawing.Point(4, 15)
        Me.LNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(65, 20)
        Me.LNombre.TabIndex = 3
        Me.LNombre.Text = "Nombre"
        '
        'tNombre
        '
        Me.tNombre.Location = New System.Drawing.Point(140, 11)
        Me.tNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tNombre.MaxLength = 30
        Me.tNombre.Name = "tNombre"
        Me.tNombre.Size = New System.Drawing.Size(346, 26)
        Me.tNombre.TabIndex = 4
        '
        'TBuscar
        '
        Me.TBuscar.BackColor = System.Drawing.Color.White
        Me.TBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBuscar.Location = New System.Drawing.Point(466, 29)
        Me.TBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TBuscar.Name = "TBuscar"
        Me.TBuscar.Size = New System.Drawing.Size(330, 35)
        Me.TBuscar.TabIndex = 107
        '
        'lLegajo
        '
        Me.lLegajo.AutoSize = True
        Me.lLegajo.BackColor = System.Drawing.Color.White
        Me.lLegajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lLegajo.Location = New System.Drawing.Point(882, 117)
        Me.lLegajo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lLegajo.Name = "lLegajo"
        Me.lLegajo.Size = New System.Drawing.Size(23, 25)
        Me.lLegajo.TabIndex = 109
        Me.lLegajo.Text = "0"
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BVolver.Location = New System.Drawing.Point(96, 712)
        Me.BVolver.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(124, 60)
        Me.BVolver.TabIndex = 112
        Me.BVolver.Text = "Volver"
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'pBotones
        '
        Me.pBotones.BackColor = System.Drawing.Color.Transparent
        Me.pBotones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pBotones.Controls.Add(Me.bEliminar)
        Me.pBotones.Controls.Add(Me.bAceptar)
        Me.pBotones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pBotones.Location = New System.Drawing.Point(414, 706)
        Me.pBotones.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pBotones.Name = "pBotones"
        Me.pBotones.Size = New System.Drawing.Size(494, 87)
        Me.pBotones.TabIndex = 113
        '
        'bEliminar
        '
        Me.bEliminar.BackColor = System.Drawing.Color.Red
        Me.bEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEliminar.Location = New System.Drawing.Point(338, 8)
        Me.bEliminar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(154, 55)
        Me.bEliminar.TabIndex = 90
        Me.bEliminar.Text = "Eliminar Usuario"
        Me.bEliminar.UseVisualStyleBackColor = False
        '
        'bAceptar
        '
        Me.bAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAceptar.Location = New System.Drawing.Point(3, 8)
        Me.bAceptar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bAceptar.Name = "bAceptar"
        Me.bAceptar.Size = New System.Drawing.Size(154, 55)
        Me.bAceptar.TabIndex = 18
        Me.bAceptar.Text = "Aceptar"
        Me.bAceptar.UseVisualStyleBackColor = False
        '
        'bNuevoCliente
        '
        Me.bNuevoCliente.BackColor = System.Drawing.Color.Cyan
        Me.bNuevoCliente.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bNuevoCliente.ForeColor = System.Drawing.Color.Black
        Me.bNuevoCliente.Location = New System.Drawing.Point(586, 717)
        Me.bNuevoCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bNuevoCliente.Name = "bNuevoCliente"
        Me.bNuevoCliente.Size = New System.Drawing.Size(162, 55)
        Me.bNuevoCliente.TabIndex = 114
        Me.bNuevoCliente.Text = "Nuevo Usuario"
        Me.bNuevoCliente.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NUsuario, Me.Nombre})
        Me.DataGridView1.Location = New System.Drawing.Point(10, 151)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(400, 526)
        Me.DataGridView1.TabIndex = 117
        '
        'NUsuario
        '
        Me.NUsuario.DataPropertyName = "NUsuario"
        Me.NUsuario.HeaderText = "N°"
        Me.NUsuario.MinimumWidth = 8
        Me.NUsuario.Name = "NUsuario"
        Me.NUsuario.Visible = False
        Me.NUsuario.Width = 38
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 8
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 200
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(18, 6)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 135)
        Me.PictureBox1.TabIndex = 116
        Me.PictureBox1.TabStop = False
        '
        'bBuscar
        '
        Me.bBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bBuscar.Location = New System.Drawing.Point(807, 14)
        Me.bBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(96, 66)
        Me.bBuscar.TabIndex = 115
        Me.bBuscar.UseVisualStyleBackColor = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Location = New System.Drawing.Point(420, 34)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(27, 35)
        Me.PictureBox8.TabIndex = 108
        Me.PictureBox8.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(184, 29)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(233, 58)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "Ingrese el nombre " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del usuario"
        '
        'lEmail
        '
        Me.lEmail.AutoSize = True
        Me.lEmail.ForeColor = System.Drawing.SystemColors.Control
        Me.lEmail.Location = New System.Drawing.Point(4, 217)
        Me.lEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lEmail.Name = "lEmail"
        Me.lEmail.Size = New System.Drawing.Size(52, 20)
        Me.lEmail.TabIndex = 45
        Me.lEmail.Text = "Email:"
        '
        'tEmail
        '
        Me.tEmail.Location = New System.Drawing.Point(170, 214)
        Me.tEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tEmail.Name = "tEmail"
        Me.tEmail.Size = New System.Drawing.Size(322, 26)
        Me.tEmail.TabIndex = 46
        '
        'lUsuario
        '
        Me.lUsuario.AutoSize = True
        Me.lUsuario.ForeColor = System.Drawing.Color.White
        Me.lUsuario.Location = New System.Drawing.Point(4, 96)
        Me.lUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lUsuario.Name = "lUsuario"
        Me.lUsuario.Size = New System.Drawing.Size(68, 20)
        Me.lUsuario.TabIndex = 47
        Me.lUsuario.Text = "Usuario:"
        '
        'tUsuario
        '
        Me.tUsuario.Location = New System.Drawing.Point(146, 87)
        Me.tUsuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tUsuario.MaxLength = 30
        Me.tUsuario.Name = "tUsuario"
        Me.tUsuario.Size = New System.Drawing.Size(346, 26)
        Me.tUsuario.TabIndex = 48
        Me.tUsuario.UseSystemPasswordChar = True
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(921, 814)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.bNuevoCliente)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bBuscar)
        Me.Controls.Add(Me.pBotones)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.lLegajo)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.TBuscar)
        Me.Controls.Add(Me.pCampos)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        Me.pCampos.ResumeLayout(False)
        Me.pCampos.PerformLayout()
        Me.pBotones.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pCampos As Panel
    Friend WithEvents tContraseñaRepite As TextBox
    Friend WithEvents lRepitePass As Label
    Friend WithEvents lApellido As Label
    Friend WithEvents tApellido As TextBox
    Friend WithEvents LNombre As Label
    Friend WithEvents tNombre As TextBox
    Friend WithEvents TBuscar As TextBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents lLegajo As Label
    Friend WithEvents BVolver As Button
    Friend WithEvents pBotones As Panel
    Friend WithEvents bEliminar As Button
    Friend WithEvents bAceptar As Button
    Friend WithEvents bNuevoCliente As Button
    Friend WithEvents bBuscar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NUsuario As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents tContraseña As TextBox
    Friend WithEvents lContraseña As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tEmail As TextBox
    Friend WithEvents lEmail As Label
    Friend WithEvents tUsuario As TextBox
    Friend WithEvents lUsuario As Label
End Class
