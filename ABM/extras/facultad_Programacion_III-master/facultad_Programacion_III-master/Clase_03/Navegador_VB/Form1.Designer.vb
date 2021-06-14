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
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.tBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bRojo = New System.Windows.Forms.Button()
        Me.bAzul = New System.Windows.Forms.Button()
        Me.bVerde = New System.Windows.Forms.Button()
        Me.bVer = New System.Windows.Forms.Button()
        Me.bIr = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bBuscar
        '
        Me.bBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bBuscar.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBuscar.Location = New System.Drawing.Point(605, 37)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(98, 31)
        Me.bBuscar.TabIndex = 0
        Me.bBuscar.Text = "Google!"
        Me.bBuscar.UseVisualStyleBackColor = False
        '
        'tBuscar
        '
        Me.tBuscar.BackColor = System.Drawing.Color.Silver
        Me.tBuscar.Location = New System.Drawing.Point(118, 44)
        Me.tBuscar.Name = "tBuscar"
        Me.tBuscar.Size = New System.Drawing.Size(428, 20)
        Me.tBuscar.TabIndex = 1
        Me.tBuscar.Text = "Ingresa tu url..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sitio Web"
        '
        'bRojo
        '
        Me.bRojo.BackColor = System.Drawing.Color.Red
        Me.bRojo.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bRojo.ForeColor = System.Drawing.Color.White
        Me.bRojo.Location = New System.Drawing.Point(750, 39)
        Me.bRojo.Name = "bRojo"
        Me.bRojo.Size = New System.Drawing.Size(94, 29)
        Me.bRojo.TabIndex = 4
        Me.bRojo.Text = "Rojo"
        Me.bRojo.UseVisualStyleBackColor = False
        '
        'bAzul
        '
        Me.bAzul.BackColor = System.Drawing.Color.Navy
        Me.bAzul.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAzul.ForeColor = System.Drawing.Color.White
        Me.bAzul.Location = New System.Drawing.Point(950, 39)
        Me.bAzul.Name = "bAzul"
        Me.bAzul.Size = New System.Drawing.Size(94, 29)
        Me.bAzul.TabIndex = 5
        Me.bAzul.Text = "Azul"
        Me.bAzul.UseVisualStyleBackColor = False
        '
        'bVerde
        '
        Me.bVerde.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bVerde.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bVerde.ForeColor = System.Drawing.Color.White
        Me.bVerde.Location = New System.Drawing.Point(850, 39)
        Me.bVerde.Name = "bVerde"
        Me.bVerde.Size = New System.Drawing.Size(94, 29)
        Me.bVerde.TabIndex = 6
        Me.bVerde.Text = "Verde"
        Me.bVerde.UseVisualStyleBackColor = False
        '
        'bVer
        '
        Me.bVer.Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bVer.Location = New System.Drawing.Point(1060, 42)
        Me.bVer.Name = "bVer"
        Me.bVer.Size = New System.Drawing.Size(94, 22)
        Me.bVer.TabIndex = 7
        Me.bVer.Text = "Ver"
        Me.bVer.UseVisualStyleBackColor = True
        '
        'bIr
        '
        Me.bIr.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bIr.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bIr.Location = New System.Drawing.Point(552, 37)
        Me.bIr.Name = "bIr"
        Me.bIr.Size = New System.Drawing.Size(47, 31)
        Me.bIr.TabIndex = 9
        Me.bIr.Text = "Ir"
        Me.bIr.UseVisualStyleBackColor = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 74)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1142, 553)
        Me.WebBrowser1.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(722, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 24)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "|"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1166, 639)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.bIr)
        Me.Controls.Add(Me.bVer)
        Me.Controls.Add(Me.bVerde)
        Me.Controls.Add(Me.bAzul)
        Me.Controls.Add(Me.bRojo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tBuscar)
        Me.Controls.Add(Me.bBuscar)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Navegador Web - Programación 3 - Juan P. Romano"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bBuscar As Button
    Friend WithEvents tBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bRojo As Button
    Friend WithEvents bAzul As Button
    Friend WithEvents bVerde As Button
    Friend WithEvents bVer As Button
    Friend WithEvents bIr As Button
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Label2 As Label
End Class