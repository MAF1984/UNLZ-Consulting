<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Proveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proveedores))
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.TBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bAceptar = New System.Windows.Forms.Button()
        Me.bNuevoProveedor = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NPro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lLegajo = New System.Windows.Forms.Label()
        Me.pCampos = New System.Windows.Forms.Panel()
        Me.TextComentarios = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.TextRazonSocial = New System.Windows.Forms.TextBox()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.TexNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.pBotones = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pCampos.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'bSalir
        '
        Me.bSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.bSalir.ForeColor = System.Drawing.SystemColors.Control
        Me.bSalir.Location = New System.Drawing.Point(10, 513)
        Me.bSalir.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(124, 54)
        Me.bSalir.TabIndex = 0
        Me.bSalir.Text = "Cerrar"
        Me.bSalir.UseVisualStyleBackColor = False
        '
        'bBuscar
        '
        Me.bBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.bBuscar.ForeColor = System.Drawing.SystemColors.Control
        Me.bBuscar.Location = New System.Drawing.Point(88, 99)
        Me.bBuscar.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(136, 37)
        Me.bBuscar.TabIndex = 98
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.UseVisualStyleBackColor = False
        '
        'TBuscar
        '
        Me.TBuscar.BackColor = System.Drawing.Color.White
        Me.TBuscar.Location = New System.Drawing.Point(13, 65)
        Me.TBuscar.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.TBuscar.Name = "TBuscar"
        Me.TBuscar.Size = New System.Drawing.Size(275, 30)
        Me.TBuscar.TabIndex = 102
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ravie", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(-3, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 24)
        Me.Label1.TabIndex = 103
        '
        'bEliminar
        '
        Me.bEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.bEliminar.ForeColor = System.Drawing.SystemColors.Control
        Me.bEliminar.Location = New System.Drawing.Point(329, 0)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(139, 50)
        Me.bEliminar.TabIndex = 90
        Me.bEliminar.Text = "Eliminar proveedor"
        Me.bEliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bEliminar.UseVisualStyleBackColor = False
        '
        'bAceptar
        '
        Me.bAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.bAceptar.ForeColor = System.Drawing.SystemColors.Control
        Me.bAceptar.Location = New System.Drawing.Point(28, 0)
        Me.bAceptar.Name = "bAceptar"
        Me.bAceptar.Size = New System.Drawing.Size(141, 50)
        Me.bAceptar.TabIndex = 18
        Me.bAceptar.Text = "Aceptar"
        Me.bAceptar.UseVisualStyleBackColor = False
        '
        'bNuevoProveedor
        '
        Me.bNuevoProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bNuevoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bNuevoProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.bNuevoProveedor.ForeColor = System.Drawing.SystemColors.Control
        Me.bNuevoProveedor.Location = New System.Drawing.Point(182, 0)
        Me.bNuevoProveedor.Name = "bNuevoProveedor"
        Me.bNuevoProveedor.Size = New System.Drawing.Size(134, 50)
        Me.bNuevoProveedor.TabIndex = 18
        Me.bNuevoProveedor.Text = "Nuevo Proveedor"
        Me.bNuevoProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bNuevoProveedor.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NPro, Me.Nombre})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 167)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(315, 306)
        Me.DataGridView1.TabIndex = 108
        '
        'NPro
        '
        Me.NPro.DataPropertyName = "NPro"
        Me.NPro.HeaderText = "N°"
        Me.NPro.MinimumWidth = 8
        Me.NPro.Name = "NPro"
        Me.NPro.Visible = False
        Me.NPro.Width = 38
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre del proveedor"
        Me.Nombre.MinimumWidth = 8
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 200
        '
        'lLegajo
        '
        Me.lLegajo.AutoSize = True
        Me.lLegajo.BackColor = System.Drawing.Color.White
        Me.lLegajo.Location = New System.Drawing.Point(334, 167)
        Me.lLegajo.Name = "lLegajo"
        Me.lLegajo.Size = New System.Drawing.Size(20, 21)
        Me.lLegajo.TabIndex = 109
        Me.lLegajo.Text = "0"
        '
        'pCampos
        '
        Me.pCampos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.pCampos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pCampos.Controls.Add(Me.TextComentarios)
        Me.pCampos.Controls.Add(Me.Label7)
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
        Me.pCampos.Controls.Add(Me.TextRazonSocial)
        Me.pCampos.Controls.Add(Me.LNombre)
        Me.pCampos.Controls.Add(Me.TexNombre)
        Me.pCampos.Location = New System.Drawing.Point(382, 11)
        Me.pCampos.Name = "pCampos"
        Me.pCampos.Size = New System.Drawing.Size(440, 470)
        Me.pCampos.TabIndex = 111
        '
        'TextComentarios
        '
        Me.TextComentarios.Location = New System.Drawing.Point(138, 410)
        Me.TextComentarios.Multiline = True
        Me.TextComentarios.Name = "TextComentarios"
        Me.TextComentarios.Size = New System.Drawing.Size(271, 49)
        Me.TextComentarios.TabIndex = 44
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(-2, 413)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 21)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Comentarios:"
        '
        'TextCodigo
        '
        Me.TextCodigo.Location = New System.Drawing.Point(137, 193)
        Me.TextCodigo.Name = "TextCodigo"
        Me.TextCodigo.Size = New System.Drawing.Size(169, 30)
        Me.TextCodigo.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(3, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 21)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Codigo postal:"
        '
        'TextCUIT
        '
        Me.TextCUIT.Location = New System.Drawing.Point(138, 119)
        Me.TextCUIT.Name = "TextCUIT"
        Me.TextCUIT.Size = New System.Drawing.Size(170, 30)
        Me.TextCUIT.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(3, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 21)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "CUIT:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(313, 81)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(106, 25)
        Me.CheckBox1.TabIndex = 38
        Me.CheckBox1.Text = "Activo?"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 21)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Provincia:"
        '
        'TextProvincia
        '
        Me.TextProvincia.Location = New System.Drawing.Point(138, 266)
        Me.TextProvincia.MaxLength = 20
        Me.TextProvincia.Name = "TextProvincia"
        Me.TextProvincia.Size = New System.Drawing.Size(269, 30)
        Me.TextProvincia.TabIndex = 36
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(3, 345)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 21)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Fecha:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(138, 338)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(169, 30)
        Me.DateTimePicker1.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(3, 377)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 21)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Email:"
        '
        'TextEmail
        '
        Me.TextEmail.Location = New System.Drawing.Point(138, 374)
        Me.TextEmail.MaxLength = 35
        Me.TextEmail.Name = "TextEmail"
        Me.TextEmail.Size = New System.Drawing.Size(271, 30)
        Me.TextEmail.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(2, 305)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 21)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Teléfono:"
        '
        'TextTelefono
        '
        Me.TextTelefono.Location = New System.Drawing.Point(138, 302)
        Me.TextTelefono.MaxLength = 30
        Me.TextTelefono.Name = "TextTelefono"
        Me.TextTelefono.Size = New System.Drawing.Size(269, 30)
        Me.TextTelefono.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(3, 232)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 21)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Localidad:"
        '
        'TextLocalidad
        '
        Me.TextLocalidad.Location = New System.Drawing.Point(138, 229)
        Me.TextLocalidad.MaxLength = 10
        Me.TextLocalidad.Name = "TextLocalidad"
        Me.TextLocalidad.Size = New System.Drawing.Size(269, 30)
        Me.TextLocalidad.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 21)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Domicilio:"
        '
        'TextDomicilio
        '
        Me.TextDomicilio.Location = New System.Drawing.Point(139, 157)
        Me.TextDomicilio.MaxLength = 50
        Me.TextDomicilio.Name = "TextDomicilio"
        Me.TextDomicilio.Size = New System.Drawing.Size(268, 30)
        Me.TextDomicilio.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(8, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 21)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Doc"
        '
        'TextDoc
        '
        Me.TextDoc.Location = New System.Drawing.Point(137, 81)
        Me.TextDoc.MaxLength = 8
        Me.TextDoc.Name = "TextDoc"
        Me.TextDoc.Size = New System.Drawing.Size(170, 30)
        Me.TextDoc.TabIndex = 7
        '
        'lApellido
        '
        Me.lApellido.AutoSize = True
        Me.lApellido.ForeColor = System.Drawing.Color.White
        Me.lApellido.Location = New System.Drawing.Point(2, 44)
        Me.lApellido.Name = "lApellido"
        Me.lApellido.Size = New System.Drawing.Size(126, 21)
        Me.lApellido.TabIndex = 5
        Me.lApellido.Text = "Razon social:"
        '
        'TextRazonSocial
        '
        Me.TextRazonSocial.Location = New System.Drawing.Point(136, 41)
        Me.TextRazonSocial.MaxLength = 30
        Me.TextRazonSocial.Name = "TextRazonSocial"
        Me.TextRazonSocial.Size = New System.Drawing.Size(272, 30)
        Me.TextRazonSocial.TabIndex = 5
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.LNombre.ForeColor = System.Drawing.Color.White
        Me.LNombre.Location = New System.Drawing.Point(3, 8)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(80, 21)
        Me.LNombre.TabIndex = 3
        Me.LNombre.Text = "Nombre"
        '
        'TexNombre
        '
        Me.TexNombre.Location = New System.Drawing.Point(136, 5)
        Me.TexNombre.MaxLength = 30
        Me.TexNombre.Name = "TexNombre"
        Me.TexNombre.Size = New System.Drawing.Size(272, 30)
        Me.TexNombre.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label5.Location = New System.Drawing.Point(12, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(333, 26)
        Me.Label5.TabIndex = 112
        Me.Label5.Text = "Ingrese nombre del Proveedor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(298, 65)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 104
        Me.PictureBox8.TabStop = False
        '
        'pBotones
        '
        Me.pBotones.Controls.Add(Me.bEliminar)
        Me.pBotones.Controls.Add(Me.bAceptar)
        Me.pBotones.Controls.Add(Me.bNuevoProveedor)
        Me.pBotones.Location = New System.Drawing.Point(354, 487)
        Me.pBotones.Name = "pBotones"
        Me.pBotones.Size = New System.Drawing.Size(527, 54)
        Me.pBotones.TabIndex = 113
        '
        'Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(834, 578)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pCampos)
        Me.Controls.Add(Me.lLegajo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBuscar)
        Me.Controls.Add(Me.bBuscar)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.pBotones)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Proveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proveedores"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pCampos.ResumeLayout(False)
        Me.pCampos.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBotones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bSalir As Button
    Friend WithEvents bBuscar As Button
    Friend WithEvents TBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents bEliminar As Button
    Friend WithEvents bAceptar As Button
    Friend WithEvents bNuevoProveedor As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lLegajo As Label
    Friend WithEvents pCampos As Panel
    Friend WithEvents TextCodigo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextCUIT As TextBox
    Friend WithEvents Label3 As Label
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
    Friend WithEvents TextRazonSocial As TextBox
    Friend WithEvents LNombre As Label
    Friend WithEvents TexNombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextComentarios As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents NPro As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents pBotones As Panel
End Class
