<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inicio
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inicio))
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.pRestaurar = New System.Windows.Forms.PictureBox()
        Me.pMini = New System.Windows.Forms.PictureBox()
        Me.pMaxi = New System.Windows.Forms.PictureBox()
        Me.pCerrar = New System.Windows.Forms.PictureBox()
        Me.pnlContenido = New System.Windows.Forms.Panel()
        Me.lblInicio = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblSistema = New System.Windows.Forms.Label()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnProvvedores = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlTitulo.SuspendLayout()
        CType(Me.pRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaxi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContenido.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlTitulo.Controls.Add(Me.pRestaurar)
        Me.pnlTitulo.Controls.Add(Me.pMini)
        Me.pnlTitulo.Controls.Add(Me.pMaxi)
        Me.pnlTitulo.Controls.Add(Me.pCerrar)
        Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(886, 35)
        Me.pnlTitulo.TabIndex = 0
        '
        'pRestaurar
        '
        Me.pRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pRestaurar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pRestaurar.Image = Global.sistema.My.Resources.Resources.restore
        Me.pRestaurar.Location = New System.Drawing.Point(804, 3)
        Me.pRestaurar.Name = "pRestaurar"
        Me.pRestaurar.Size = New System.Drawing.Size(32, 32)
        Me.pRestaurar.TabIndex = 3
        Me.pRestaurar.TabStop = False
        Me.pRestaurar.Visible = False
        '
        'pMini
        '
        Me.pMini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pMini.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pMini.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pMini.Image = Global.sistema.My.Resources.Resources.minimize
        Me.pMini.Location = New System.Drawing.Point(766, 3)
        Me.pMini.Name = "pMini"
        Me.pMini.Size = New System.Drawing.Size(32, 32)
        Me.pMini.TabIndex = 2
        Me.pMini.TabStop = False
        '
        'pMaxi
        '
        Me.pMaxi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pMaxi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pMaxi.Image = Global.sistema.My.Resources.Resources.maximize
        Me.pMaxi.Location = New System.Drawing.Point(804, 3)
        Me.pMaxi.Name = "pMaxi"
        Me.pMaxi.Size = New System.Drawing.Size(32, 32)
        Me.pMaxi.TabIndex = 1
        Me.pMaxi.TabStop = False
        '
        'pCerrar
        '
        Me.pCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pCerrar.BackColor = System.Drawing.Color.IndianRed
        Me.pCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pCerrar.Image = Global.sistema.My.Resources.Resources.cancel1
        Me.pCerrar.Location = New System.Drawing.Point(842, 3)
        Me.pCerrar.Name = "pCerrar"
        Me.pCerrar.Size = New System.Drawing.Size(32, 32)
        Me.pCerrar.TabIndex = 0
        Me.pCerrar.TabStop = False
        '
        'pnlContenido
        '
        Me.pnlContenido.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlContenido.Controls.Add(Me.lblInicio)
        Me.pnlContenido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlContenido.Location = New System.Drawing.Point(186, 35)
        Me.pnlContenido.Name = "pnlContenido"
        Me.pnlContenido.Size = New System.Drawing.Size(742, 446)
        Me.pnlContenido.TabIndex = 2
        '
        'lblInicio
        '
        Me.lblInicio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInicio.AutoSize = True
        Me.lblInicio.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInicio.ForeColor = System.Drawing.Color.Black
        Me.lblInicio.Location = New System.Drawing.Point(78, 110)
        Me.lblInicio.Name = "lblInicio"
        Me.lblInicio.Size = New System.Drawing.Size(559, 170)
        Me.lblInicio.TabIndex = 0
        Me.lblInicio.Text = "¡Gracias por utilizar Gestionsys! " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Por favor, selecciona una " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de las opciones" &
    " del menu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "lateral izquierdo para comenzar." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(188, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblSistema
        '
        Me.lblSistema.AutoSize = True
        Me.lblSistema.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSistema.ForeColor = System.Drawing.Color.White
        Me.lblSistema.Location = New System.Drawing.Point(29, 106)
        Me.lblSistema.Name = "lblSistema"
        Me.lblSistema.Size = New System.Drawing.Size(142, 28)
        Me.lblSistema.TabIndex = 0
        Me.lblSistema.Text = "Gestionsys"
        Me.lblSistema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClientes
        '
        Me.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.Color.White
        Me.btnClientes.Image = CType(resources.GetObject("btnClientes.Image"), System.Drawing.Image)
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(0, 175)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(185, 38)
        Me.btnClientes.TabIndex = 0
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnProvvedores
        '
        Me.btnProvvedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProvvedores.FlatAppearance.BorderSize = 0
        Me.btnProvvedores.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnProvvedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProvvedores.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProvvedores.ForeColor = System.Drawing.Color.White
        Me.btnProvvedores.Image = CType(resources.GetObject("btnProvvedores.Image"), System.Drawing.Image)
        Me.btnProvvedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProvvedores.Location = New System.Drawing.Point(0, 242)
        Me.btnProvvedores.Name = "btnProvvedores"
        Me.btnProvvedores.Size = New System.Drawing.Size(197, 38)
        Me.btnProvvedores.TabIndex = 2
        Me.btnProvvedores.Text = "Proveedores"
        Me.btnProvvedores.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(0, 310)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(197, 38)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlMenu.Controls.Add(Me.Label1)
        Me.pnlMenu.Controls.Add(Me.btnSalir)
        Me.pnlMenu.Controls.Add(Me.btnProvvedores)
        Me.pnlMenu.Controls.Add(Me.btnClientes)
        Me.pnlMenu.Controls.Add(Me.lblSistema)
        Me.pnlMenu.Controls.Add(Me.PictureBox1)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 35)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(194, 434)
        Me.pnlMenu.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(5, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "____________________________"
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 469)
        Me.Controls.Add(Me.pnlContenido)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "inicio"
        Me.Text = "Inicio Sistema"
        Me.pnlTitulo.ResumeLayout(False)
        CType(Me.pRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaxi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContenido.ResumeLayout(False)
        Me.pnlContenido.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents pCerrar As PictureBox
    Friend WithEvents pMaxi As PictureBox
    Friend WithEvents pMini As PictureBox
    Friend WithEvents pRestaurar As PictureBox
    Friend WithEvents pnlContenido As Panel
    Friend WithEvents lblInicio As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblSistema As Label
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnProvvedores As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents Label1 As Label
End Class
