<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.pCampos = New System.Windows.Forms.Panel()
        Me.TextCodigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextCUIT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextProvincia = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextEmail = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextTelefono = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextLocalidad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextDomicilio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextDoc = New System.Windows.Forms.TextBox()
        Me.lApellido = New System.Windows.Forms.Label()
        Me.TextApellido = New System.Windows.Forms.TextBox()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.TexNombre = New System.Windows.Forms.TextBox()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bAceptar = New System.Windows.Forms.Button()
        Me.bNuevoCliente = New System.Windows.Forms.Button()
        Me.TBuscar = New System.Windows.Forms.TextBox()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.lLegajo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NProf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.pBotones = New System.Windows.Forms.Panel()
        Me.pCampos.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pCampos
        '
        Me.pCampos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.pCampos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pCampos.Controls.Add(Me.TextCodigo)
        Me.pCampos.Controls.Add(Me.Label4)
        Me.pCampos.Controls.Add(Me.TextCUIT)
        Me.pCampos.Controls.Add(Me.Label3)
        Me.pCampos.Controls.Add(Me.CheckBox1)
        Me.pCampos.Controls.Add(Me.Label2)
        Me.pCampos.Controls.Add(Me.TextProvincia)
        Me.pCampos.Controls.Add(Me.Label12)
        Me.pCampos.Controls.Add(Me.DateTimePicker1)
        Me.pCampos.Controls.Add(Me.Label11)
        Me.pCampos.Controls.Add(Me.TextEmail)
        Me.pCampos.Controls.Add(Me.Label10)
        Me.pCampos.Controls.Add(Me.TextTelefono)
        Me.pCampos.Controls.Add(Me.Label9)
        Me.pCampos.Controls.Add(Me.TextLocalidad)
        Me.pCampos.Controls.Add(Me.Label8)
        Me.pCampos.Controls.Add(Me.TextDomicilio)
        Me.pCampos.Controls.Add(Me.Label6)
        Me.pCampos.Controls.Add(Me.TextDoc)
        Me.pCampos.Controls.Add(Me.lApellido)
        Me.pCampos.Controls.Add(Me.TextApellido)
        Me.pCampos.Controls.Add(Me.LNombre)
        Me.pCampos.Controls.Add(Me.TexNombre)
        Me.pCampos.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pCampos.Location = New System.Drawing.Point(243, 6)
        Me.pCampos.Name = "pCampos"
        Me.pCampos.Size = New System.Drawing.Size(299, 315)
        Me.pCampos.TabIndex = 58
        '
        'TextCodigo
        '
        Me.TextCodigo.Location = New System.Drawing.Point(93, 141)
        Me.TextCodigo.Name = "TextCodigo"
        Me.TextCodigo.Size = New System.Drawing.Size(63, 21)
        Me.TextCodigo.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(3, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 16)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Codigo postal:"
        '
        'TextCUIT
        '
        Me.TextCUIT.Location = New System.Drawing.Point(93, 87)
        Me.TextCUIT.Name = "TextCUIT"
        Me.TextCUIT.Size = New System.Drawing.Size(100, 21)
        Me.TextCUIT.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(3, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 16)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "CUIT:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(223, 59)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(69, 20)
        Me.CheckBox1.TabIndex = 38
        Me.CheckBox1.Text = "Activo?"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Provincia:"
        '
        'TextProvincia
        '
        Me.TextProvincia.Location = New System.Drawing.Point(93, 197)
        Me.TextProvincia.MaxLength = 20
        Me.TextProvincia.Name = "TextProvincia"
        Me.TextProvincia.Size = New System.Drawing.Size(189, 21)
        Me.TextProvincia.TabIndex = 36
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(2, 255)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 16)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "F. Nacimiento:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(93, 253)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(99, 21)
        Me.DateTimePicker1.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(3, 279)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 16)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Email:"
        '
        'TextEmail
        '
        Me.TextEmail.Location = New System.Drawing.Point(93, 279)
        Me.TextEmail.MaxLength = 35
        Me.TextEmail.Name = "TextEmail"
        Me.TextEmail.Size = New System.Drawing.Size(189, 21)
        Me.TextEmail.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(3, 227)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 16)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Teléfono:"
        '
        'TextTelefono
        '
        Me.TextTelefono.Location = New System.Drawing.Point(93, 227)
        Me.TextTelefono.MaxLength = 30
        Me.TextTelefono.Name = "TextTelefono"
        Me.TextTelefono.Size = New System.Drawing.Size(189, 21)
        Me.TextTelefono.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(3, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 16)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Localidad:"
        '
        'TextLocalidad
        '
        Me.TextLocalidad.Location = New System.Drawing.Point(94, 167)
        Me.TextLocalidad.MaxLength = 10
        Me.TextLocalidad.Name = "TextLocalidad"
        Me.TextLocalidad.Size = New System.Drawing.Size(99, 21)
        Me.TextLocalidad.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Domicilio:"
        '
        'TextDomicilio
        '
        Me.TextDomicilio.Location = New System.Drawing.Point(93, 113)
        Me.TextDomicilio.MaxLength = 50
        Me.TextDomicilio.Name = "TextDomicilio"
        Me.TextDomicilio.Size = New System.Drawing.Size(189, 21)
        Me.TextDomicilio.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Doc (solo núm.)"
        '
        'TextDoc
        '
        Me.TextDoc.Location = New System.Drawing.Point(93, 59)
        Me.TextDoc.MaxLength = 8
        Me.TextDoc.Name = "TextDoc"
        Me.TextDoc.Size = New System.Drawing.Size(99, 21)
        Me.TextDoc.TabIndex = 7
        '
        'lApellido
        '
        Me.lApellido.AutoSize = True
        Me.lApellido.ForeColor = System.Drawing.Color.White
        Me.lApellido.Location = New System.Drawing.Point(3, 36)
        Me.lApellido.Name = "lApellido"
        Me.lApellido.Size = New System.Drawing.Size(54, 16)
        Me.lApellido.TabIndex = 5
        Me.lApellido.Text = "Apellido:"
        '
        'TextApellido
        '
        Me.TextApellido.Location = New System.Drawing.Point(93, 33)
        Me.TextApellido.MaxLength = 30
        Me.TextApellido.Name = "TextApellido"
        Me.TextApellido.Size = New System.Drawing.Size(189, 21)
        Me.TextApellido.TabIndex = 5
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.ForeColor = System.Drawing.Color.White
        Me.LNombre.Location = New System.Drawing.Point(3, 10)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(51, 16)
        Me.LNombre.TabIndex = 3
        Me.LNombre.Text = "Nombre"
        '
        'TexNombre
        '
        Me.TexNombre.Location = New System.Drawing.Point(93, 7)
        Me.TexNombre.MaxLength = 30
        Me.TexNombre.Name = "TexNombre"
        Me.TexNombre.Size = New System.Drawing.Size(189, 21)
        Me.TexNombre.TabIndex = 4
        '
        'bEliminar
        '
        Me.bEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bEliminar.ForeColor = System.Drawing.SystemColors.Control
        Me.bEliminar.Location = New System.Drawing.Point(445, 326)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(103, 36)
        Me.bEliminar.TabIndex = 90
        Me.bEliminar.Text = "Eliminar Cliente"
        Me.bEliminar.UseVisualStyleBackColor = False
        '
        'bAceptar
        '
        Me.bAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bAceptar.ForeColor = System.Drawing.SystemColors.Control
        Me.bAceptar.Location = New System.Drawing.Point(224, 326)
        Me.bAceptar.Name = "bAceptar"
        Me.bAceptar.Size = New System.Drawing.Size(103, 36)
        Me.bAceptar.TabIndex = 18
        Me.bAceptar.Text = "Aceptar Cambios"
        Me.bAceptar.UseVisualStyleBackColor = False
        '
        'bNuevoCliente
        '
        Me.bNuevoCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bNuevoCliente.ForeColor = System.Drawing.SystemColors.Control
        Me.bNuevoCliente.Location = New System.Drawing.Point(335, 326)
        Me.bNuevoCliente.Name = "bNuevoCliente"
        Me.bNuevoCliente.Size = New System.Drawing.Size(103, 36)
        Me.bNuevoCliente.TabIndex = 94
        Me.bNuevoCliente.Text = "Nuevo Cliente"
        Me.bNuevoCliente.UseVisualStyleBackColor = False
        '
        'TBuscar
        '
        Me.TBuscar.BackColor = System.Drawing.Color.White
        Me.TBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBuscar.Location = New System.Drawing.Point(9, 47)
        Me.TBuscar.Name = "TBuscar"
        Me.TBuscar.Size = New System.Drawing.Size(199, 22)
        Me.TBuscar.TabIndex = 96
        '
        'bBuscar
        '
        Me.bBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.bBuscar.ForeColor = System.Drawing.SystemColors.Control
        Me.bBuscar.Location = New System.Drawing.Point(60, 73)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(91, 24)
        Me.bBuscar.TabIndex = 97
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.UseVisualStyleBackColor = False
        '
        'lLegajo
        '
        Me.lLegajo.AutoSize = True
        Me.lLegajo.BackColor = System.Drawing.Color.White
        Me.lLegajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lLegajo.Location = New System.Drawing.Point(211, 110)
        Me.lLegajo.Name = "lLegajo"
        Me.lLegajo.Size = New System.Drawing.Size(15, 16)
        Me.lLegajo.TabIndex = 101
        Me.lLegajo.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(9, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 18)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Ingrese el nombre del Cliente"
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BVolver.ForeColor = System.Drawing.SystemColors.Control
        Me.BVolver.Location = New System.Drawing.Point(9, 331)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(83, 35)
        Me.BVolver.TabIndex = 104
        Me.BVolver.Text = "Cerrar"
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NProf, Me.Nombre})
        Me.DataGridView1.Location = New System.Drawing.Point(9, 110)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(197, 210)
        Me.DataGridView1.TabIndex = 105
        '
        'NProf
        '
        Me.NProf.DataPropertyName = "NCliente"
        Me.NProf.HeaderText = "N°"
        Me.NProf.MinimumWidth = 8
        Me.NProf.Name = "NProf"
        Me.NProf.Visible = False
        Me.NProf.Width = 38
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 8
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 200
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(211, 47)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(20, 19)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 98
        Me.PictureBox8.TabStop = False
        '
        'pBotones
        '
        Me.pBotones.Location = New System.Drawing.Point(215, 325)
        Me.pBotones.Margin = New System.Windows.Forms.Padding(2)
        Me.pBotones.Name = "pBotones"
        Me.pBotones.Size = New System.Drawing.Size(339, 43)
        Me.pBotones.TabIndex = 106
        '
        'Clientes
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(556, 376)
        Me.ControlBox = False
        Me.Controls.Add(Me.bAceptar)
        Me.Controls.Add(Me.bEliminar)
        Me.Controls.Add(Me.bNuevoCliente)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lLegajo)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.bBuscar)
        Me.Controls.Add(Me.TBuscar)
        Me.Controls.Add(Me.pCampos)
        Me.Controls.Add(Me.pBotones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pCampos.ResumeLayout(False)
        Me.pCampos.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pCampos As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextProvincia As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents TextEmail As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextTelefono As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextLocalidad As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextDomicilio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextDoc As TextBox
    Friend WithEvents lApellido As Label
    Friend WithEvents TextApellido As TextBox
    Friend WithEvents LNombre As Label
    Friend WithEvents TexNombre As TextBox
    Friend WithEvents bEliminar As Button
    Friend WithEvents bAceptar As Button
    Friend WithEvents bNuevoCliente As Button
    Friend WithEvents TBuscar As TextBox
    Friend WithEvents bBuscar As Button
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents lLegajo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BVolver As Button
    Friend WithEvents TextCodigo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextCUIT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NProf As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents pBotones As Panel
End Class
