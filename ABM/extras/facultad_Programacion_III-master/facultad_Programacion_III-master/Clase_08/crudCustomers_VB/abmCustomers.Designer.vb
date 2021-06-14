<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class abmCustomers
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(abmCustomers))
        Me.pCampos = New System.Windows.Forms.Panel()
        Me.lPais = New System.Windows.Forms.Label()
        Me.tPais = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tCP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tCargo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tCiudad = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tFax = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tTelefono = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tLocalidad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tDireccion = New System.Windows.Forms.TextBox()
        Me.tContacto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tCliente = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tBuscar = New System.Windows.Forms.TextBox()
        Me.gridClientes = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.pBotones = New System.Windows.Forms.Panel()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bNuevoCli = New System.Windows.Forms.Button()
        Me.bGuardar = New System.Windows.Forms.Button()
        Me.lIdCliente = New System.Windows.Forms.Label()
        Me.pCampos.SuspendLayout()
        CType(Me.gridClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'pCampos
        '
        Me.pCampos.BackColor = System.Drawing.Color.Transparent
        Me.pCampos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pCampos.Controls.Add(Me.lPais)
        Me.pCampos.Controls.Add(Me.tPais)
        Me.pCampos.Controls.Add(Me.Label1)
        Me.pCampos.Controls.Add(Me.Label6)
        Me.pCampos.Controls.Add(Me.tCP)
        Me.pCampos.Controls.Add(Me.Label3)
        Me.pCampos.Controls.Add(Me.tCargo)
        Me.pCampos.Controls.Add(Me.Label2)
        Me.pCampos.Controls.Add(Me.tCiudad)
        Me.pCampos.Controls.Add(Me.Label11)
        Me.pCampos.Controls.Add(Me.tFax)
        Me.pCampos.Controls.Add(Me.Label10)
        Me.pCampos.Controls.Add(Me.tTelefono)
        Me.pCampos.Controls.Add(Me.Label9)
        Me.pCampos.Controls.Add(Me.tLocalidad)
        Me.pCampos.Controls.Add(Me.Label8)
        Me.pCampos.Controls.Add(Me.tDireccion)
        Me.pCampos.Controls.Add(Me.tContacto)
        Me.pCampos.Controls.Add(Me.Label4)
        Me.pCampos.Controls.Add(Me.tCliente)
        Me.pCampos.Location = New System.Drawing.Point(41, 66)
        Me.pCampos.Name = "pCampos"
        Me.pCampos.Size = New System.Drawing.Size(463, 308)
        Me.pCampos.TabIndex = 58
        '
        'lPais
        '
        Me.lPais.AutoSize = True
        Me.lPais.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lPais.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPais.ForeColor = System.Drawing.Color.Black
        Me.lPais.Location = New System.Drawing.Point(4, 171)
        Me.lPais.Name = "lPais"
        Me.lPais.Size = New System.Drawing.Size(42, 15)
        Me.lPais.TabIndex = 47
        Me.lPais.Text = "Pais:"
        '
        'tPais
        '
        Me.tPais.Location = New System.Drawing.Point(101, 173)
        Me.tPais.MaxLength = 20
        Me.tPais.Name = "tPais"
        Me.tPais.Size = New System.Drawing.Size(350, 21)
        Me.tPais.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Nombre"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(316, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 15)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "CP:"
        '
        'tCP
        '
        Me.tCP.Location = New System.Drawing.Point(356, 120)
        Me.tCP.MaxLength = 10
        Me.tCP.Name = "tCP"
        Me.tCP.Size = New System.Drawing.Size(95, 21)
        Me.tCP.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(1, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Cargo:"
        '
        'tCargo
        '
        Me.tCargo.Location = New System.Drawing.Point(101, 61)
        Me.tCargo.MaxLength = 30
        Me.tCargo.Name = "tCargo"
        Me.tCargo.Size = New System.Drawing.Size(351, 21)
        Me.tCargo.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Ciudad:"
        '
        'tCiudad
        '
        Me.tCiudad.Location = New System.Drawing.Point(101, 146)
        Me.tCiudad.MaxLength = 20
        Me.tCiudad.Name = "tCiudad"
        Me.tCiudad.Size = New System.Drawing.Size(350, 21)
        Me.tCiudad.TabIndex = 36
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label11.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(3, 227)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 15)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Tel. Fax:"
        '
        'tFax
        '
        Me.tFax.Location = New System.Drawing.Point(101, 227)
        Me.tFax.MaxLength = 35
        Me.tFax.Name = "tFax"
        Me.tFax.Size = New System.Drawing.Size(350, 21)
        Me.tFax.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label10.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(3, 200)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Teléfono:"
        '
        'tTelefono
        '
        Me.tTelefono.Location = New System.Drawing.Point(101, 200)
        Me.tTelefono.MaxLength = 30
        Me.tTelefono.Name = "tTelefono"
        Me.tTelefono.Size = New System.Drawing.Size(350, 21)
        Me.tTelefono.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(1, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 15)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Localidad:"
        '
        'tLocalidad
        '
        Me.tLocalidad.Location = New System.Drawing.Point(101, 120)
        Me.tLocalidad.MaxLength = 10
        Me.tLocalidad.Name = "tLocalidad"
        Me.tLocalidad.Size = New System.Drawing.Size(212, 21)
        Me.tLocalidad.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(1, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 15)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Dirección:"
        '
        'tDireccion
        '
        Me.tDireccion.Location = New System.Drawing.Point(101, 90)
        Me.tDireccion.MaxLength = 50
        Me.tDireccion.Name = "tDireccion"
        Me.tDireccion.Size = New System.Drawing.Size(350, 21)
        Me.tDireccion.TabIndex = 9
        '
        'tContacto
        '
        Me.tContacto.Location = New System.Drawing.Point(101, 32)
        Me.tContacto.MaxLength = 30
        Me.tContacto.Multiline = True
        Me.tContacto.Name = "tContacto"
        Me.tContacto.Size = New System.Drawing.Size(351, 23)
        Me.tContacto.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(3, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cliente:"
        '
        'tCliente
        '
        Me.tCliente.Location = New System.Drawing.Point(101, 7)
        Me.tCliente.MaxLength = 30
        Me.tCliente.Name = "tCliente"
        Me.tCliente.Size = New System.Drawing.Size(351, 21)
        Me.tCliente.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(203, 15)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Buscar por nombre o apellido"
        '
        'tBuscar
        '
        Me.tBuscar.Location = New System.Drawing.Point(239, 25)
        Me.tBuscar.Name = "tBuscar"
        Me.tBuscar.Size = New System.Drawing.Size(537, 21)
        Me.tBuscar.TabIndex = 62
        '
        'gridClientes
        '
        Me.gridClientes.AllowUserToDeleteRows = False
        Me.gridClientes.AllowUserToOrderColumns = True
        Me.gridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gridClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gridClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.cliente, Me.contacto})
        Me.gridClientes.GridColor = System.Drawing.SystemColors.Control
        Me.gridClientes.Location = New System.Drawing.Point(521, 66)
        Me.gridClientes.Name = "gridClientes"
        Me.gridClientes.ReadOnly = True
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridClientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.gridClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.gridClientes.Size = New System.Drawing.Size(355, 397)
        Me.gridClientes.TabIndex = 63
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        Me.ID.Width = 47
        '
        'cliente
        '
        Me.cliente.DataPropertyName = "cliente"
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.Name = "cliente"
        Me.cliente.ReadOnly = True
        Me.cliente.Width = 81
        '
        'contacto
        '
        Me.contacto.DataPropertyName = "contacto"
        Me.contacto.HeaderText = "Contacto"
        Me.contacto.Name = "contacto"
        Me.contacto.ReadOnly = True
        Me.contacto.Width = 88
        '
        'bBuscar
        '
        Me.bBuscar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBuscar.Location = New System.Drawing.Point(782, 22)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(94, 24)
        Me.bBuscar.TabIndex = 64
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.UseVisualStyleBackColor = True
        '
        'pBotones
        '
        Me.pBotones.BackColor = System.Drawing.Color.Transparent
        Me.pBotones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pBotones.Controls.Add(Me.bEliminar)
        Me.pBotones.Controls.Add(Me.bNuevoCli)
        Me.pBotones.Controls.Add(Me.bGuardar)
        Me.pBotones.Location = New System.Drawing.Point(41, 390)
        Me.pBotones.Name = "pBotones"
        Me.pBotones.Size = New System.Drawing.Size(463, 73)
        Me.pBotones.TabIndex = 65
        '
        'bEliminar
        '
        Me.bEliminar.BackColor = System.Drawing.Color.IndianRed
        Me.bEliminar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bEliminar.Location = New System.Drawing.Point(319, 3)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(137, 63)
        Me.bEliminar.TabIndex = 2
        Me.bEliminar.Text = "Eliminar Cliente"
        Me.bEliminar.UseVisualStyleBackColor = False
        '
        'bNuevoCli
        '
        Me.bNuevoCli.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bNuevoCli.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bNuevoCli.Location = New System.Drawing.Point(6, 3)
        Me.bNuevoCli.Name = "bNuevoCli"
        Me.bNuevoCli.Size = New System.Drawing.Size(143, 63)
        Me.bNuevoCli.TabIndex = 1
        Me.bNuevoCli.Text = "Nuevo Cliente"
        Me.bNuevoCli.UseVisualStyleBackColor = False
        '
        'bGuardar
        '
        Me.bGuardar.BackColor = System.Drawing.Color.OliveDrab
        Me.bGuardar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bGuardar.Location = New System.Drawing.Point(156, 3)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(157, 63)
        Me.bGuardar.TabIndex = 0
        Me.bGuardar.Text = "Guardar Cambios"
        Me.bGuardar.UseVisualStyleBackColor = False
        '
        'lIdCliente
        '
        Me.lIdCliente.AutoSize = True
        Me.lIdCliente.BackColor = System.Drawing.Color.White
        Me.lIdCliente.Location = New System.Drawing.Point(861, 66)
        Me.lIdCliente.Name = "lIdCliente"
        Me.lIdCliente.Size = New System.Drawing.Size(15, 13)
        Me.lIdCliente.TabIndex = 94
        Me.lIdCliente.Text = "0"
        '
        'abmCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(888, 484)
        Me.Controls.Add(Me.lIdCliente)
        Me.Controls.Add(Me.pBotones)
        Me.Controls.Add(Me.bBuscar)
        Me.Controls.Add(Me.gridClientes)
        Me.Controls.Add(Me.tBuscar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.pCampos)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "abmCustomers"
        Me.Text = "CRUD | Clientes | Juan P. Romano"
        Me.pCampos.ResumeLayout(False)
        Me.pCampos.PerformLayout()
        CType(Me.gridClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBotones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pCampos As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents tCiudad As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tFax As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tTelefono As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tLocalidad As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tDireccion As TextBox
    Friend WithEvents tContacto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tCliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tCargo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tCP As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tBuscar As TextBox
    Friend WithEvents gridClientes As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents bBuscar As Button
    Friend WithEvents pBotones As Panel
    Friend WithEvents bEliminar As Button
    Friend WithEvents bNuevoCli As Button
    Friend WithEvents bGuardar As Button
    Friend WithEvents lIdCliente As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents contacto As DataGridViewTextBoxColumn
    Friend WithEvents lPais As Label
    Friend WithEvents tPais As TextBox
End Class
