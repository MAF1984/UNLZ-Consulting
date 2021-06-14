namespace Menu
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bSalir = new System.Windows.Forms.Button();
            this.bClientes = new System.Windows.Forms.Button();
            this.bProveedores = new System.Windows.Forms.Button();
            this.bListados = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baackupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iIBBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entregasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bSalir
            // 
            this.bSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bSalir.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalir.Location = new System.Drawing.Point(784, 408);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(117, 52);
            this.bSalir.TabIndex = 0;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = false;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // bClientes
            // 
            this.bClientes.BackColor = System.Drawing.Color.SeaGreen;
            this.bClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bClientes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClientes.ForeColor = System.Drawing.Color.White;
            this.bClientes.Location = new System.Drawing.Point(14, 66);
            this.bClientes.Name = "bClientes";
            this.bClientes.Size = new System.Drawing.Size(210, 52);
            this.bClientes.TabIndex = 1;
            this.bClientes.Text = "Clientes";
            this.bClientes.UseVisualStyleBackColor = false;
            this.bClientes.Click += new System.EventHandler(this.bClientes_Click);
            // 
            // bProveedores
            // 
            this.bProveedores.BackColor = System.Drawing.Color.SteelBlue;
            this.bProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bProveedores.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bProveedores.ForeColor = System.Drawing.Color.White;
            this.bProveedores.Location = new System.Drawing.Point(14, 125);
            this.bProveedores.Name = "bProveedores";
            this.bProveedores.Size = new System.Drawing.Size(210, 52);
            this.bProveedores.TabIndex = 2;
            this.bProveedores.Text = "Proveedores";
            this.bProveedores.UseVisualStyleBackColor = false;
            this.bProveedores.Click += new System.EventHandler(this.bProveedores_Click);
            // 
            // bListados
            // 
            this.bListados.BackColor = System.Drawing.Color.DarkOrange;
            this.bListados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bListados.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bListados.ForeColor = System.Drawing.Color.White;
            this.bListados.Location = new System.Drawing.Point(14, 183);
            this.bListados.Name = "bListados";
            this.bListados.Size = new System.Drawing.Size(210, 52);
            this.bListados.TabIndex = 3;
            this.bListados.Text = "Listados";
            this.bListados.UseVisualStyleBackColor = false;
            this.bListados.Click += new System.EventHandler(this.bListados_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemasToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.comprasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(915, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemasToolStripMenuItem
            // 
            this.sistemasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadosToolStripMenuItem,
            this.baackupsToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sistemasToolStripMenuItem.Name = "sistemasToolStripMenuItem";
            this.sistemasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.sistemasToolStripMenuItem.Text = "Sistemas";
            // 
            // listadosToolStripMenuItem
            // 
            this.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            this.listadosToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.listadosToolStripMenuItem.Text = "Listados";
            this.listadosToolStripMenuItem.Click += new System.EventHandler(this.listadosToolStripMenuItem_Click);
            // 
            // baackupsToolStripMenuItem
            // 
            this.baackupsToolStripMenuItem.Name = "baackupsToolStripMenuItem";
            this.baackupsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.baackupsToolStripMenuItem.Text = "Baackups";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.facturasToolStripMenuItem,
            this.iIBBToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.facturasToolStripMenuItem.Text = "Facturas";
            // 
            // iIBBToolStripMenuItem
            // 
            this.iIBBToolStripMenuItem.Name = "iIBBToolStripMenuItem";
            this.iIBBToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.iIBBToolStripMenuItem.Text = "IIBB";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedorsToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.entregasToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comprasToolStripMenuItem.Text = "Compras";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // proveedorsToolStripMenuItem
            // 
            this.proveedorsToolStripMenuItem.Name = "proveedorsToolStripMenuItem";
            this.proveedorsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.proveedorsToolStripMenuItem.Text = "Proveedores";
            this.proveedorsToolStripMenuItem.Click += new System.EventHandler(this.proveedorsToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // entregasToolStripMenuItem
            // 
            this.entregasToolStripMenuItem.Name = "entregasToolStripMenuItem";
            this.entregasToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.entregasToolStripMenuItem.Text = "Entregas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 474);
            this.ControlBox = false;
            this.Controls.Add(this.bListados);
            this.Controls.Add(this.bProveedores);
            this.Controls.Add(this.bClientes);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Menu | Gestion - Juan P. Romano - Programación III";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Button bClientes;
        private System.Windows.Forms.Button bProveedores;
        private System.Windows.Forms.Button bListados;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baackupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iIBBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entregasToolStripMenuItem;
    }
}

