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
        Me.pCampos.Location = New System.Drawing.Point(364, 9)
        Me.pCampos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pCampos.Name = "pCampos"
        Me.pCampos.Size = New System.Drawing.Size(447, 483)
        Me.pCampos.TabIndex = 58
        '
        'TextCodigo
        '
        Me.TextCodigo.Location = New System.Drawing.Point(140, 217)
        Me.TextCodigo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextCodigo.Name = "TextCodigo"
        Me.TextCodigo.Size = New System.Drawing.Size(92, 27)
        Me.TextCodigo.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(4, 217)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 21)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Codigo postal:"
        '
        'TextCUIT
        '
        Me.TextCUIT.Location = New System.Drawing.Point(140, 134)
        Me.TextCUIT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextCUIT.Name = "TextCUIT"
        Me.TextCUIT.Size = New System.Drawing.Size(148, 27)
        Me.TextCUIT.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(4, 132)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 21)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "CUIT:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(335, 91)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(98, 25)
        Me.CheckBox1.TabIndex = 38
        Me.CheckBox1.Text = "Activo?"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(4, 308)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 21)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Provincia:"
        '
        'TextProvincia
        '
        Me.TextProvincia.Location = New System.Drawing.Point(140, 303)
        Me.TextProvincia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextProvincia.MaxLength = 20
        Me.TextProvincia.Name = "TextProvincia"
        Me.TextProvincia.Size = New System.Drawing.Size(282, 27)
        Me.TextProvincia.TabIndex = 36
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(3, 392)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 21)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "F. Nacimiento:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(140, 389)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(146, 27)
        Me.DateTimePicker1.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(4, 429)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 21)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Email:"
        '
        'TextEmail
        '
        Me.TextEmail.Location = New System.Drawing.Point(140, 429)
        Me.TextEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextEmail.MaxLength = 35
        Me.TextEmail.Name = "TextEmail"
        Me.TextEmail.Size = New System.Drawing.Size(282, 27)
        Me.TextEmail.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(4, 349)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 21)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Teléfono:"
        '
        'TextTelefono
        '
        Me.TextTelefono.Location = New System.Drawing.Point(140, 349)
        Me.TextTelefono.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextTelefono.MaxLength = 30
        Me.TextTelefono.Name = "TextTelefono"
        Me.TextTelefono.Size = New System.Drawing.Size(282, 27)
        Me.TextTelefono.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(4, 263)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 21)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Localidad:"
        '
        'TextLocalidad
        '
        Me.TextLocalidad.Location = New System.Drawing.Point(141, 257)
        Me.TextLocalidad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextLocalidad.MaxLength = 10
        Me.TextLocalidad.Name = "TextLocalidad"
        Me.TextLocalidad.Size = New System.Drawing.Size(146, 27)
        Me.TextLocalidad.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(4, 174)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 21)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Domicilio:"
        '
        'TextDomicilio
        '
        Me.TextDomicilio.Location = New System.Drawing.Point(140, 174)
        Me.TextDomicilio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextDomicilio.MaxLength = 50
        Me.TextDomicilio.Name = "TextDomicilio"
        Me.TextDomicilio.Size = New System.Drawing.Size(282, 27)
        Me.TextDomicilio.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(4, 95)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 21)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Doc (solo núm.)"
        '
        'TextDoc
        '
        Me.TextDoc.Location = New System.Drawing.Point(140, 91)
        Me.TextDoc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextDoc.MaxLength = 8
        Me.TextDoc.Name = "TextDoc"
        Me.TextDoc.Size = New System.Drawing.Size(146, 27)
        Me.TextDoc.TabIndex = 7
        '
        'lApellido
        '
        Me.lApellido.AutoSize = True
        Me.lApellido.ForeColor = System.Drawing.Color.White
        Me.lApellido.Location = New System.Drawing.Point(4, 55)
        Me.lApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lApellido.Name = "lApellido"
        Me.lApellido.Size = New System.Drawing.Size(78, 21)
        Me.lApellido.TabIndex = 5
        Me.lApellido.Text = "Apellido:"
        '
        'TextApellido
        '
        Me.TextApellido.Location = New System.Drawing.Point(140, 51)
        Me.TextApellido.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextApellido.MaxLength = 30
        Me.TextApellido.Name = "TextApellido"
        Me.TextApellido.Size = New System.Drawing.Size(282, 27)
        Me.TextApellido.TabIndex = 5
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.ForeColor = System.Drawing.Color.White
        Me.LNombre.Location = New System.Drawing.Point(4, 15)
        Me.LNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(73, 21)
        Me.LNombre.TabIndex = 3
        Me.LNombre.Text = "Nombre"
        '
        'TexNombre
        '
        Me.TexNombre.Location = New System.Drawing.Point(140, 11)
        Me.TexNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TexNombre.MaxLength = 30
        Me.TexNombre.Name = "TexNombre"
        Me.TexNombre.Size = New System.Drawing.Size(282, 27)
        Me.TexNombre.TabIndex = 4
        '
        'bEliminar
        '
        Me.bEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bEliminar.ForeColor = System.Drawing.SystemColors.Control
        Me.bEliminar.Location = New System.Drawing.Point(668, 502)
        Me.bEliminar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(154, 55)
        Me.bEliminar.TabIndex = 90
        Me.bEliminar.Text = "Eliminar Cliente"
        Me.bEliminar.UseVisualStyleBackColor = False
        '
        'bAceptar
        '
        Me.bAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bAceptar.ForeColor = System.Drawing.SystemColors.Control
        Me.bAceptar.Location = New System.Drawing.Point(336, 502)
        Me.bAceptar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bAceptar.Name = "bAceptar"
        Me.bAceptar.Size = New System.Drawing.Size(154, 55)
        Me.bAceptar.TabIndex = 18
        Me.bAceptar.Text = "Aceptar Cambios"
        Me.bAceptar.UseVisualStyleBackColor = False
        '
        'bNuevoCliente
        '
        Me.bNuevoCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bNuevoCliente.ForeColor = System.Drawing.SystemColors.Control
        Me.bNuevoCliente.Location = New System.Drawing.Point(502, 502)
        Me.bNuevoCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bNuevoCliente.Name = "bNuevoCliente"
        Me.bNuevoCliente.Size = New System.Drawing.Size(154, 55)
        Me.bNuevoCliente.TabIndex = 94
        Me.bNuevoCliente.Text = "Nuevo Cliente"
        Me.bNuevoCliente.UseVisualStyleBackColor = False
        '
        'TBuscar
        '
        Me.TBuscar.BackColor = System.Drawing.Color.White
        Me.TBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBuscar.Location = New System.Drawing.Point(13, 72)
        Me.TBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TBuscar.Name = "TBuscar"
        Me.TBuscar.Size = New System.Drawing.Size(296, 30)
        Me.TBuscar.TabIndex = 96
        '
        'bBuscar
        '
        Me.bBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.bBuscar.ForeColor = System.Drawing.SystemColors.Control
        Me.bBuscar.Location = New System.Drawing.Point(90, 112)
        Me.bBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(136, 37)
        Me.bBuscar.TabIndex = 97
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.UseVisualStyleBackColor = False
        '
        'lLegajo
        '
        Me.lLegajo.AutoSize = True
        Me.lLegajo.BackColor = System.Drawing.Color.White
        Me.lLegajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lLegajo.Location = New System.Drawing.Point(317, 169)
        Me.lLegajo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lLegajo.Name = "lLegajo"
        Me.lLegajo.Size = New System.Drawing.Size(23, 25)
        Me.lLegajo.TabIndex = 101
        Me.lLegajo.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 26)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Ingrese el nombre del Cliente"
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BVolver.ForeColor = System.Drawing.SystemColors.Control
        Me.BVolver.Location = New System.Drawing.Point(13, 510)
        Me.BVolver.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(124, 54)
        Me.BVolver.TabIndex = 104
        Me.BVolver.Text = "Cerrar"
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NProf, Me.Nombre})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 169)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(296, 323)
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
        Me.PictureBox8.Location = New System.Drawing.Point(317, 72)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 98
        Me.PictureBox8.TabStop = False
        '
        'pBotones
        '
        Me.pBotones.Location = New System.Drawing.Point(322, 500)
        Me.pBotones.Name = "pBotones"
        Me.pBotones.Size = New System.Drawing.Size(509, 66)
        Me.pBotones.TabIndex = 106
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(834, 578)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
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
