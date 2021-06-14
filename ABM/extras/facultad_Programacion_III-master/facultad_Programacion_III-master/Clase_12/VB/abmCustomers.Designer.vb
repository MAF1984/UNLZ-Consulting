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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.NCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.pBotones = New System.Windows.Forms.Panel()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bNuevoCli = New System.Windows.Forms.Button()
        Me.bGuardar = New System.Windows.Forms.Button()
        Me.lIdCliente = New System.Windows.Forms.Label()
        Me.gridFacturas = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lnfact = New System.Windows.Forms.Label()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PconIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gridDetalles = New System.Windows.Forms.DataGridView()
        Me.pCampos.SuspendLayout()
        CType(Me.gridClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBotones.SuspendLayout()
        CType(Me.gridFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pCampos
        '
        Me.pCampos.BackColor = System.Drawing.SystemColors.ActiveCaption
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
        Me.pCampos.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pCampos.Location = New System.Drawing.Point(23, 368)
        Me.pCampos.Name = "pCampos"
        Me.pCampos.Size = New System.Drawing.Size(340, 270)
        Me.pCampos.TabIndex = 58
        '
        'lPais
        '
        Me.lPais.AutoSize = True
        Me.lPais.ForeColor = System.Drawing.Color.Black
        Me.lPais.Location = New System.Drawing.Point(4, 185)
        Me.lPais.Name = "lPais"
        Me.lPais.Size = New System.Drawing.Size(37, 13)
        Me.lPais.TabIndex = 47
        Me.lPais.Text = "Pais:"
        '
        'tPais
        '
        Me.tPais.Location = New System.Drawing.Point(91, 185)
        Me.tPais.MaxLength = 20
        Me.tPais.Name = "tPais"
        Me.tPais.Size = New System.Drawing.Size(232, 20)
        Me.tPais.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 26)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Nombre del " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contacto:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(192, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "CP:"
        '
        'tCP
        '
        Me.tCP.Location = New System.Drawing.Point(228, 131)
        Me.tCP.MaxLength = 10
        Me.tCP.Name = "tCP"
        Me.tCP.Size = New System.Drawing.Size(95, 20)
        Me.tCP.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(1, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Cargo:"
        '
        'tCargo
        '
        Me.tCargo.Location = New System.Drawing.Point(92, 75)
        Me.tCargo.MaxLength = 30
        Me.tCargo.Name = "tCargo"
        Me.tCargo.Size = New System.Drawing.Size(232, 20)
        Me.tCargo.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Ciudad:"
        '
        'tCiudad
        '
        Me.tCiudad.Location = New System.Drawing.Point(91, 157)
        Me.tCiudad.MaxLength = 20
        Me.tCiudad.Name = "tCiudad"
        Me.tCiudad.Size = New System.Drawing.Size(232, 20)
        Me.tCiudad.TabIndex = 36
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(3, 241)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Tel. Fax:"
        '
        'tFax
        '
        Me.tFax.Location = New System.Drawing.Point(92, 238)
        Me.tFax.MaxLength = 35
        Me.tFax.Name = "tFax"
        Me.tFax.Size = New System.Drawing.Size(232, 20)
        Me.tFax.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(3, 214)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Teléfono:"
        '
        'tTelefono
        '
        Me.tTelefono.Location = New System.Drawing.Point(92, 211)
        Me.tTelefono.MaxLength = 30
        Me.tTelefono.Name = "tTelefono"
        Me.tTelefono.Size = New System.Drawing.Size(232, 20)
        Me.tTelefono.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(1, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Localidad:"
        '
        'tLocalidad
        '
        Me.tLocalidad.Location = New System.Drawing.Point(92, 131)
        Me.tLocalidad.MaxLength = 10
        Me.tLocalidad.Name = "tLocalidad"
        Me.tLocalidad.Size = New System.Drawing.Size(99, 20)
        Me.tLocalidad.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(1, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Dirección:"
        '
        'tDireccion
        '
        Me.tDireccion.Location = New System.Drawing.Point(92, 104)
        Me.tDireccion.MaxLength = 50
        Me.tDireccion.Name = "tDireccion"
        Me.tDireccion.Size = New System.Drawing.Size(231, 20)
        Me.tDireccion.TabIndex = 9
        '
        'tContacto
        '
        Me.tContacto.Location = New System.Drawing.Point(92, 32)
        Me.tContacto.MaxLength = 30
        Me.tContacto.Multiline = True
        Me.tContacto.Name = "tContacto"
        Me.tContacto.Size = New System.Drawing.Size(232, 37)
        Me.tContacto.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(3, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cliente:"
        '
        'tCliente
        '
        Me.tCliente.Location = New System.Drawing.Point(92, 7)
        Me.tCliente.MaxLength = 30
        Me.tCliente.Name = "tCliente"
        Me.tCliente.Size = New System.Drawing.Size(232, 20)
        Me.tCliente.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 13)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Buscar por nombre o apellido"
        '
        'tBuscar
        '
        Me.tBuscar.Location = New System.Drawing.Point(23, 26)
        Me.tBuscar.Name = "tBuscar"
        Me.tBuscar.Size = New System.Drawing.Size(271, 21)
        Me.tBuscar.TabIndex = 62
        '
        'gridClientes
        '
        Me.gridClientes.AllowUserToDeleteRows = False
        Me.gridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gridClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gridClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NCliente, Me.cliente, Me.contacto})
        Me.gridClientes.Location = New System.Drawing.Point(23, 66)
        Me.gridClientes.Name = "gridClientes"
        Me.gridClientes.ReadOnly = True
        Me.gridClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.gridClientes.Size = New System.Drawing.Size(340, 296)
        Me.gridClientes.TabIndex = 63
        '
        'NCliente
        '
        Me.NCliente.DataPropertyName = "NCliente"
        Me.NCliente.HeaderText = "NCliente"
        Me.NCliente.Name = "NCliente"
        Me.NCliente.ReadOnly = True
        Me.NCliente.Visible = False
        Me.NCliente.Width = 84
        '
        'cliente
        '
        Me.cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cliente.DataPropertyName = "cliente"
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.Name = "cliente"
        Me.cliente.ReadOnly = True
        '
        'contacto
        '
        Me.contacto.DataPropertyName = "contacto"
        Me.contacto.HeaderText = "Contacto"
        Me.contacto.Name = "contacto"
        Me.contacto.ReadOnly = True
        Me.contacto.Visible = False
        Me.contacto.Width = 87
        '
        'bBuscar
        '
        Me.bBuscar.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBuscar.Location = New System.Drawing.Point(300, 26)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(63, 21)
        Me.bBuscar.TabIndex = 64
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.UseVisualStyleBackColor = True
        '
        'pBotones
        '
        Me.pBotones.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pBotones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pBotones.Controls.Add(Me.bEliminar)
        Me.pBotones.Controls.Add(Me.bNuevoCli)
        Me.pBotones.Controls.Add(Me.bGuardar)
        Me.pBotones.Location = New System.Drawing.Point(23, 644)
        Me.pBotones.Name = "pBotones"
        Me.pBotones.Size = New System.Drawing.Size(340, 41)
        Me.pBotones.TabIndex = 65
        '
        'bEliminar
        '
        Me.bEliminar.BackColor = System.Drawing.Color.IndianRed
        Me.bEliminar.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bEliminar.Location = New System.Drawing.Point(224, 0)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(104, 36)
        Me.bEliminar.TabIndex = 2
        Me.bEliminar.Text = "Eliminar Cliente"
        Me.bEliminar.UseVisualStyleBackColor = False
        '
        'bNuevoCli
        '
        Me.bNuevoCli.BackColor = System.Drawing.SystemColors.HotTrack
        Me.bNuevoCli.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bNuevoCli.Location = New System.Drawing.Point(114, 0)
        Me.bNuevoCli.Name = "bNuevoCli"
        Me.bNuevoCli.Size = New System.Drawing.Size(104, 36)
        Me.bNuevoCli.TabIndex = 1
        Me.bNuevoCli.Text = "Nuevo Cliente"
        Me.bNuevoCli.UseVisualStyleBackColor = False
        '
        'bGuardar
        '
        Me.bGuardar.BackColor = System.Drawing.Color.ForestGreen
        Me.bGuardar.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bGuardar.Location = New System.Drawing.Point(4, 0)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(104, 36)
        Me.bGuardar.TabIndex = 0
        Me.bGuardar.Text = "Guardar Cambios"
        Me.bGuardar.UseVisualStyleBackColor = False
        '
        'lIdCliente
        '
        Me.lIdCliente.AutoSize = True
        Me.lIdCliente.BackColor = System.Drawing.Color.White
        Me.lIdCliente.Location = New System.Drawing.Point(348, 49)
        Me.lIdCliente.Name = "lIdCliente"
        Me.lIdCliente.Size = New System.Drawing.Size(15, 13)
        Me.lIdCliente.TabIndex = 94
        Me.lIdCliente.Text = "0"
        '
        'gridFacturas
        '
        Me.gridFacturas.AllowUserToDeleteRows = False
        Me.gridFacturas.AllowUserToOrderColumns = True
        Me.gridFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gridFacturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gridFacturas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridFacturas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.gridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Total})
        Me.gridFacturas.Location = New System.Drawing.Point(385, 12)
        Me.gridFacturas.Name = "gridFacturas"
        Me.gridFacturas.ReadOnly = True
        Me.gridFacturas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.gridFacturas.Size = New System.Drawing.Size(953, 350)
        Me.gridFacturas.TabIndex = 95
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nfact"
        Me.DataGridViewTextBoxColumn2.HeaderText = "N° Factura"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 98
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "contacto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 69
        '
        'Total
        '
        Me.Total.DataPropertyName = "total"
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 65
        '
        'lnfact
        '
        Me.lnfact.AutoSize = True
        Me.lnfact.BackColor = System.Drawing.Color.White
        Me.lnfact.Location = New System.Drawing.Point(1323, 50)
        Me.lnfact.Name = "lnfact"
        Me.lnfact.Size = New System.Drawing.Size(15, 13)
        Me.lnfact.TabIndex = 98
        Me.lnfact.Text = "0"
        '
        'Subtotal
        '
        Me.Subtotal.DataPropertyName = "subtotal"
        Me.Subtotal.HeaderText = "Subtotal"
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
        Me.Subtotal.Width = 86
        '
        'Cant
        '
        Me.Cant.DataPropertyName = "cant"
        Me.Cant.HeaderText = "Cant"
        Me.Cant.Name = "Cant"
        Me.Cant.ReadOnly = True
        Me.Cant.Width = 60
        '
        'PconIVA
        '
        Me.PconIVA.DataPropertyName = "pconiva"
        Me.PconIVA.HeaderText = "PconIVA"
        Me.PconIVA.Name = "PconIVA"
        Me.PconIVA.ReadOnly = True
        Me.PconIVA.Width = 84
        '
        'IVA
        '
        Me.IVA.DataPropertyName = "iva"
        Me.IVA.HeaderText = "IVA"
        Me.IVA.Name = "IVA"
        Me.IVA.ReadOnly = True
        Me.IVA.Width = 54
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 72
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "producto"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'gridDetalles
        '
        Me.gridDetalles.AllowUserToDeleteRows = False
        Me.gridDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gridDetalles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gridDetalles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridDetalles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.gridDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridDetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.IVA, Me.PconIVA, Me.Cant, Me.Subtotal})
        Me.gridDetalles.Location = New System.Drawing.Point(385, 368)
        Me.gridDetalles.Name = "gridDetalles"
        Me.gridDetalles.ReadOnly = True
        Me.gridDetalles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.gridDetalles.Size = New System.Drawing.Size(953, 317)
        Me.gridDetalles.TabIndex = 97
        '
        'abmCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1350, 712)
        Me.Controls.Add(Me.gridDetalles)
        Me.Controls.Add(Me.lnfact)
        Me.Controls.Add(Me.gridFacturas)
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
        Me.Text = "CRUD | Customers | Juan P. Romano"
        Me.pCampos.ResumeLayout(False)
        Me.pCampos.PerformLayout()
        CType(Me.gridClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBotones.ResumeLayout(False)
        CType(Me.gridFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDetalles, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lPais As Label
    Friend WithEvents tPais As TextBox
    Friend WithEvents gridFacturas As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents lnfact As Label
    Friend WithEvents NCliente As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents contacto As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
    Friend WithEvents Cant As DataGridViewTextBoxColumn
    Friend WithEvents PconIVA As DataGridViewTextBoxColumn
    Friend WithEvents IVA As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents gridDetalles As DataGridView
End Class
