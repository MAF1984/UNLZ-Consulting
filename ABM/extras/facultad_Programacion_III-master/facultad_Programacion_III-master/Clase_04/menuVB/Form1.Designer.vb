<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.bSalir = New System.Windows.Forms.Button()
        Me.bClientes = New System.Windows.Forms.Button()
        Me.bProveedores = New System.Windows.Forms.Button()
        Me.bListados = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IIBBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntregasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bSalir
        '
        Me.bSalir.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bSalir.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSalir.Location = New System.Drawing.Point(778, 420)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(122, 40)
        Me.bSalir.TabIndex = 0
        Me.bSalir.Text = "Salir"
        Me.bSalir.UseVisualStyleBackColor = False
        '
        'bClientes
        '
        Me.bClientes.BackColor = System.Drawing.Color.SeaGreen
        Me.bClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bClientes.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bClientes.ForeColor = System.Drawing.Color.White
        Me.bClientes.Location = New System.Drawing.Point(14, 78)
        Me.bClientes.Name = "bClientes"
        Me.bClientes.Size = New System.Drawing.Size(196, 61)
        Me.bClientes.TabIndex = 1
        Me.bClientes.Text = "Clientes"
        Me.bClientes.UseVisualStyleBackColor = False
        '
        'bProveedores
        '
        Me.bProveedores.BackColor = System.Drawing.Color.SteelBlue
        Me.bProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bProveedores.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bProveedores.ForeColor = System.Drawing.Color.White
        Me.bProveedores.Location = New System.Drawing.Point(14, 147)
        Me.bProveedores.Name = "bProveedores"
        Me.bProveedores.Size = New System.Drawing.Size(196, 61)
        Me.bProveedores.TabIndex = 2
        Me.bProveedores.Text = "Proveedores"
        Me.bProveedores.UseVisualStyleBackColor = False
        '
        'bListados
        '
        Me.bListados.BackColor = System.Drawing.Color.Coral
        Me.bListados.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bListados.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bListados.ForeColor = System.Drawing.Color.White
        Me.bListados.Location = New System.Drawing.Point(14, 215)
        Me.bListados.Name = "bListados"
        Me.bListados.Size = New System.Drawing.Size(196, 61)
        Me.bListados.TabIndex = 3
        Me.bListados.Text = "Listados"
        Me.bListados.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ComprasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(915, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadosToolStripMenuItem, Me.BackupsToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.SistemaToolStripMenuItem.Text = "Sistemas"
        '
        'ListadosToolStripMenuItem
        '
        Me.ListadosToolStripMenuItem.Name = "ListadosToolStripMenuItem"
        Me.ListadosToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ListadosToolStripMenuItem.Text = "Listados"
        '
        'BackupsToolStripMenuItem
        '
        Me.BackupsToolStripMenuItem.Name = "BackupsToolStripMenuItem"
        Me.BackupsToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.BackupsToolStripMenuItem.Text = "Backups"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.FacturasToolStripMenuItem, Me.IIBBToolStripMenuItem})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'FacturasToolStripMenuItem
        '
        Me.FacturasToolStripMenuItem.Name = "FacturasToolStripMenuItem"
        Me.FacturasToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.FacturasToolStripMenuItem.Text = "Facturas"
        '
        'IIBBToolStripMenuItem
        '
        Me.IIBBToolStripMenuItem.Name = "IIBBToolStripMenuItem"
        Me.IIBBToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.IIBBToolStripMenuItem.Text = "IIBB"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedoresToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.EntregasToolStripMenuItem})
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'EntregasToolStripMenuItem
        '
        Me.EntregasToolStripMenuItem.Name = "EntregasToolStripMenuItem"
        Me.EntregasToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.EntregasToolStripMenuItem.Text = "Entregas"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(915, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.bListados)
        Me.Controls.Add(Me.bProveedores)
        Me.Controls.Add(Me.bClientes)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Menu | Gestion - Juan P. Romano- Programación III"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bSalir As Button
    Friend WithEvents bClientes As Button
    Friend WithEvents bProveedores As Button
    Friend WithEvents bListados As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackupsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IIBBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntregasToolStripMenuItem As ToolStripMenuItem
End Class
