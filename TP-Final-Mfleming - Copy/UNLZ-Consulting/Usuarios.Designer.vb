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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuarios))
        Me.pCampos = New System.Windows.Forms.Panel()
        Me.tUsuario = New System.Windows.Forms.TextBox()
        Me.lUsuario = New System.Windows.Forms.Label()
        Me.tEmail = New System.Windows.Forms.TextBox()
        Me.lEmail = New System.Windows.Forms.Label()
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
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pCampos.SuspendLayout()
        Me.pBotones.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pCampos
        '
        Me.pCampos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
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
        Me.pCampos.Location = New System.Drawing.Point(369, 19)
        Me.pCampos.Name = "pCampos"
        Me.pCampos.Size = New System.Drawing.Size(360, 261)
        Me.pCampos.TabIndex = 59
        '
        'tUsuario
        '
        Me.tUsuario.Location = New System.Drawing.Point(109, 78)
        Me.tUsuario.MaxLength = 30
        Me.tUsuario.Name = "tUsuario"
        Me.tUsuario.Size = New System.Drawing.Size(216, 20)
        Me.tUsuario.TabIndex = 48
        Me.tUsuario.UseSystemPasswordChar = True
        '
        'lUsuario
        '
        Me.lUsuario.AutoSize = True
        Me.lUsuario.ForeColor = System.Drawing.Color.White
        Me.lUsuario.Location = New System.Drawing.Point(3, 81)
        Me.lUsuario.Name = "lUsuario"
        Me.lUsuario.Size = New System.Drawing.Size(46, 13)
        Me.lUsuario.TabIndex = 47
        Me.lUsuario.Text = "Usuario:"
        '
        'tEmail
        '
        Me.tEmail.Location = New System.Drawing.Point(109, 192)
        Me.tEmail.Name = "tEmail"
        Me.tEmail.Size = New System.Drawing.Size(216, 20)
        Me.tEmail.TabIndex = 46
        '
        'lEmail
        '
        Me.lEmail.AutoSize = True
        Me.lEmail.ForeColor = System.Drawing.SystemColors.Control
        Me.lEmail.Location = New System.Drawing.Point(3, 195)
        Me.lEmail.Name = "lEmail"
        Me.lEmail.Size = New System.Drawing.Size(35, 13)
        Me.lEmail.TabIndex = 45
        Me.lEmail.Text = "Email:"
        '
        'tContraseña
        '
        Me.tContraseña.Location = New System.Drawing.Point(109, 117)
        Me.tContraseña.MaxLength = 30
        Me.tContraseña.Name = "tContraseña"
        Me.tContraseña.Size = New System.Drawing.Size(216, 20)
        Me.tContraseña.TabIndex = 44
        Me.tContraseña.UseSystemPasswordChar = True
        '
        'lContraseña
        '
        Me.lContraseña.AutoSize = True
        Me.lContraseña.ForeColor = System.Drawing.SystemColors.Control
        Me.lContraseña.Location = New System.Drawing.Point(3, 120)
        Me.lContraseña.Name = "lContraseña"
        Me.lContraseña.Size = New System.Drawing.Size(61, 13)
        Me.lContraseña.TabIndex = 43
        Me.lContraseña.Text = "Contaseña:"
        '
        'tContraseñaRepite
        '
        Me.tContraseñaRepite.Location = New System.Drawing.Point(109, 152)
        Me.tContraseñaRepite.Name = "tContraseñaRepite"
        Me.tContraseñaRepite.Size = New System.Drawing.Size(216, 20)
        Me.tContraseñaRepite.TabIndex = 40
        '
        'lRepitePass
        '
        Me.lRepitePass.AutoSize = True
        Me.lRepitePass.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lRepitePass.Location = New System.Drawing.Point(3, 155)
        Me.lRepitePass.Name = "lRepitePass"
        Me.lRepitePass.Size = New System.Drawing.Size(101, 13)
        Me.lRepitePass.TabIndex = 39
        Me.lRepitePass.Text = "Repetir Contraseña:"
        '
        'lApellido
        '
        Me.lApellido.AutoSize = True
        Me.lApellido.ForeColor = System.Drawing.Color.White
        Me.lApellido.Location = New System.Drawing.Point(3, 43)
        Me.lApellido.Name = "lApellido"
        Me.lApellido.Size = New System.Drawing.Size(47, 13)
        Me.lApellido.TabIndex = 5
        Me.lApellido.Text = "Apellido:"
        '
        'tApellido
        '
        Me.tApellido.Location = New System.Drawing.Point(109, 40)
        Me.tApellido.MaxLength = 30
        Me.tApellido.Name = "tApellido"
        Me.tApellido.Size = New System.Drawing.Size(216, 20)
        Me.tApellido.TabIndex = 5
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.ForeColor = System.Drawing.Color.White
        Me.LNombre.Location = New System.Drawing.Point(3, 10)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(44, 13)
        Me.LNombre.TabIndex = 3
        Me.LNombre.Text = "Nombre"
        '
        'tNombre
        '
        Me.tNombre.Location = New System.Drawing.Point(109, 7)
        Me.tNombre.MaxLength = 30
        Me.tNombre.Name = "tNombre"
        Me.tNombre.Size = New System.Drawing.Size(216, 20)
        Me.tNombre.TabIndex = 4
        '
        'TBuscar
        '
        Me.TBuscar.BackColor = System.Drawing.Color.White
        Me.TBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBuscar.Location = New System.Drawing.Point(12, 31)
        Me.TBuscar.Name = "TBuscar"
        Me.TBuscar.Size = New System.Drawing.Size(221, 26)
        Me.TBuscar.TabIndex = 107
        '
        'lLegajo
        '
        Me.lLegajo.AutoSize = True
        Me.lLegajo.BackColor = System.Drawing.Color.White
        Me.lLegajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lLegajo.Location = New System.Drawing.Point(283, 103)
        Me.lLegajo.Name = "lLegajo"
        Me.lLegajo.Size = New System.Drawing.Size(15, 16)
        Me.lLegajo.TabIndex = 109
        Me.lLegajo.Text = "0"
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BVolver.Location = New System.Drawing.Point(10, 360)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(83, 39)
        Me.BVolver.TabIndex = 112
        Me.BVolver.Text = "Cerrar"
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'pBotones
        '
        Me.pBotones.BackColor = System.Drawing.Color.Transparent
        Me.pBotones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pBotones.Controls.Add(Me.bEliminar)
        Me.pBotones.Controls.Add(Me.bAceptar)
        Me.pBotones.Controls.Add(Me.bNuevoCliente)
        Me.pBotones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pBotones.Location = New System.Drawing.Point(377, 286)
        Me.pBotones.Name = "pBotones"
        Me.pBotones.Size = New System.Drawing.Size(335, 58)
        Me.pBotones.TabIndex = 113
        '
        'bEliminar
        '
        Me.bEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.bEliminar.ForeColor = System.Drawing.SystemColors.Control
        Me.bEliminar.Location = New System.Drawing.Point(225, 5)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(103, 36)
        Me.bEliminar.TabIndex = 90
        Me.bEliminar.Text = "Eliminar Usuario"
        Me.bEliminar.UseVisualStyleBackColor = False
        '
        'bAceptar
        '
        Me.bAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.bAceptar.ForeColor = System.Drawing.SystemColors.Control
        Me.bAceptar.Location = New System.Drawing.Point(2, 5)
        Me.bAceptar.Name = "bAceptar"
        Me.bAceptar.Size = New System.Drawing.Size(103, 36)
        Me.bAceptar.TabIndex = 18
        Me.bAceptar.Text = "Aceptar"
        Me.bAceptar.UseVisualStyleBackColor = False
        '
        'bNuevoCliente
        '
        Me.bNuevoCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bNuevoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.bNuevoCliente.ForeColor = System.Drawing.SystemColors.Control
        Me.bNuevoCliente.Location = New System.Drawing.Point(111, 6)
        Me.bNuevoCliente.Name = "bNuevoCliente"
        Me.bNuevoCliente.Size = New System.Drawing.Size(108, 36)
        Me.bNuevoCliente.TabIndex = 114
        Me.bNuevoCliente.Text = "Nuevo Usuario"
        Me.bNuevoCliente.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Nombre})
        Me.DataGridView1.Location = New System.Drawing.Point(10, 103)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(267, 241)
        Me.DataGridView1.TabIndex = 117
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "N°"
        Me.Id.MinimumWidth = 8
        Me.Id.Name = "Id"
        Me.Id.Visible = False
        Me.Id.Width = 38
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 8
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 200
        '
        'bBuscar
        '
        Me.bBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bBuscar.ForeColor = System.Drawing.SystemColors.Control
        Me.bBuscar.Location = New System.Drawing.Point(71, 63)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(94, 34)
        Me.bBuscar.TabIndex = 115
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.UseVisualStyleBackColor = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(239, 34)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(18, 23)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 108
        Me.PictureBox8.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(231, 18)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "Ingrese el nombre del usuario"
        '
        'Usuarios
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(769, 409)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.bBuscar)
        Me.Controls.Add(Me.pBotones)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.lLegajo)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.TBuscar)
        Me.Controls.Add(Me.pCampos)
        Me.Name = "Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pCampos.ResumeLayout(False)
        Me.pCampos.PerformLayout()
        Me.pBotones.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tContraseña As TextBox
    Friend WithEvents lContraseña As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tEmail As TextBox
    Friend WithEvents lEmail As Label
    Friend WithEvents tUsuario As TextBox
    Friend WithEvents lUsuario As Label
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
End Class
