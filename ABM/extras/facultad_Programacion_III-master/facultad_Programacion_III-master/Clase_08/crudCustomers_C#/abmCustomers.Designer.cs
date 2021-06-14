namespace AMB
{
    partial class abmCustomers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(abmCustomers));
            this.bBuscar = new System.Windows.Forms.Button();
            this.tBuscar = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBotones = new System.Windows.Forms.Panel();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bNuevoCli = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.pCampos = new System.Windows.Forms.Panel();
            this.lPais = new System.Windows.Forms.Label();
            this.tPais = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.tCP = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.tCargo = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.tCiudad = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.tFax = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.tTelefono = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.tLocalidad = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.tDireccion = new System.Windows.Forms.TextBox();
            this.tContacto = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.tCliente = new System.Windows.Forms.TextBox();
            this.lIdCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            this.pBotones.SuspendLayout();
            this.pCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // bBuscar
            // 
            this.bBuscar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscar.Location = new System.Drawing.Point(876, 25);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(94, 23);
            this.bBuscar.TabIndex = 68;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // tBuscar
            // 
            this.tBuscar.Location = new System.Drawing.Point(222, 25);
            this.tBuscar.Name = "tBuscar";
            this.tBuscar.Size = new System.Drawing.Size(648, 21);
            this.tBuscar.TabIndex = 67;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Label7.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(47, 33);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(169, 13);
            this.Label7.TabIndex = 65;
            this.Label7.Text = "Buscar por nombre o apelido";
            // 
            // gridClientes
            // 
            this.gridClientes.AllowUserToDeleteRows = false;
            this.gridClientes.AllowUserToOrderColumns = true;
            this.gridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.cliente,
            this.contacto});
            this.gridClientes.Location = new System.Drawing.Point(554, 76);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.ReadOnly = true;
            this.gridClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridClientes.Size = new System.Drawing.Size(416, 363);
            this.gridClientes.TabIndex = 69;
            this.gridClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClientes_CellContentClick);
            this.gridClientes.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClientes_CellEnter);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 47;
            // 
            // cliente
            // 
            this.cliente.DataPropertyName = "cliente";
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            this.cliente.Width = 81;
            // 
            // contacto
            // 
            this.contacto.DataPropertyName = "contacto";
            this.contacto.HeaderText = "Contacto";
            this.contacto.Name = "contacto";
            this.contacto.ReadOnly = true;
            this.contacto.Width = 88;
            // 
            // pBotones
            // 
            this.pBotones.BackColor = System.Drawing.Color.Transparent;
            this.pBotones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBotones.Controls.Add(this.bEliminar);
            this.pBotones.Controls.Add(this.bNuevoCli);
            this.pBotones.Controls.Add(this.bGuardar);
            this.pBotones.Location = new System.Drawing.Point(31, 366);
            this.pBotones.Name = "pBotones";
            this.pBotones.Size = new System.Drawing.Size(507, 73);
            this.pBotones.TabIndex = 71;
            // 
            // bEliminar
            // 
            this.bEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.bEliminar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bEliminar.Location = new System.Drawing.Point(330, 3);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(170, 63);
            this.bEliminar.TabIndex = 2;
            this.bEliminar.Text = "Eliminar Cliente";
            this.bEliminar.UseVisualStyleBackColor = false;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bNuevoCli
            // 
            this.bNuevoCli.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bNuevoCli.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNuevoCli.Location = new System.Drawing.Point(3, 3);
            this.bNuevoCli.Name = "bNuevoCli";
            this.bNuevoCli.Size = new System.Drawing.Size(147, 63);
            this.bNuevoCli.TabIndex = 1;
            this.bNuevoCli.Text = "Nuevo Cliente";
            this.bNuevoCli.UseVisualStyleBackColor = false;
            this.bNuevoCli.Click += new System.EventHandler(this.bNuevoCli_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.bGuardar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGuardar.Location = new System.Drawing.Point(156, 3);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(168, 63);
            this.bGuardar.TabIndex = 0;
            this.bGuardar.Text = "Guardar Cambios";
            this.bGuardar.UseVisualStyleBackColor = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // pCampos
            // 
            this.pCampos.BackColor = System.Drawing.Color.Transparent;
            this.pCampos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pCampos.Controls.Add(this.lPais);
            this.pCampos.Controls.Add(this.tPais);
            this.pCampos.Controls.Add(this.Label1);
            this.pCampos.Controls.Add(this.Label6);
            this.pCampos.Controls.Add(this.tCP);
            this.pCampos.Controls.Add(this.Label3);
            this.pCampos.Controls.Add(this.tCargo);
            this.pCampos.Controls.Add(this.Label2);
            this.pCampos.Controls.Add(this.tCiudad);
            this.pCampos.Controls.Add(this.Label11);
            this.pCampos.Controls.Add(this.tFax);
            this.pCampos.Controls.Add(this.Label10);
            this.pCampos.Controls.Add(this.tTelefono);
            this.pCampos.Controls.Add(this.Label9);
            this.pCampos.Controls.Add(this.tLocalidad);
            this.pCampos.Controls.Add(this.Label8);
            this.pCampos.Controls.Add(this.tDireccion);
            this.pCampos.Controls.Add(this.tContacto);
            this.pCampos.Controls.Add(this.Label4);
            this.pCampos.Controls.Add(this.tCliente);
            this.pCampos.Location = new System.Drawing.Point(31, 76);
            this.pCampos.Name = "pCampos";
            this.pCampos.Size = new System.Drawing.Size(507, 284);
            this.pCampos.TabIndex = 70;
            // 
            // lPais
            // 
            this.lPais.AutoSize = true;
            this.lPais.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lPais.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPais.ForeColor = System.Drawing.Color.Black;
            this.lPais.Location = new System.Drawing.Point(14, 187);
            this.lPais.Name = "lPais";
            this.lPais.Size = new System.Drawing.Size(42, 15);
            this.lPais.TabIndex = 47;
            this.lPais.Text = "Pais:";
            // 
            // tPais
            // 
            this.tPais.Location = new System.Drawing.Point(114, 187);
            this.tPais.MaxLength = 20;
            this.tPais.Name = "tPais";
            this.tPais.Size = new System.Drawing.Size(373, 21);
            this.tPais.TabIndex = 46;
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(14, 35);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(49, 15);
            this.Label1.TabIndex = 45;
            this.Label1.Text = "Nombre";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Black;
            this.Label6.Location = new System.Drawing.Point(313, 129);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(28, 15);
            this.Label6.TabIndex = 44;
            this.Label6.Text = "CP:";
            // 
            // tCP
            // 
            this.tCP.Location = new System.Drawing.Point(345, 126);
            this.tCP.MaxLength = 10;
            this.tCP.Name = "tCP";
            this.tCP.Size = new System.Drawing.Size(142, 21);
            this.tCP.TabIndex = 43;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(14, 66);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(49, 15);
            this.Label3.TabIndex = 41;
            this.Label3.Text = "Cargo:";
            // 
            // tCargo
            // 
            this.tCargo.Location = new System.Drawing.Point(114, 63);
            this.tCargo.MaxLength = 30;
            this.tCargo.Name = "tCargo";
            this.tCargo.Size = new System.Drawing.Size(373, 21);
            this.tCargo.TabIndex = 42;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(13, 160);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(56, 15);
            this.Label2.TabIndex = 37;
            this.Label2.Text = "Ciudad:";
            // 
            // tCiudad
            // 
            this.tCiudad.Location = new System.Drawing.Point(114, 160);
            this.tCiudad.MaxLength = 20;
            this.tCiudad.Name = "tCiudad";
            this.tCiudad.Size = new System.Drawing.Size(373, 21);
            this.tCiudad.TabIndex = 36;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label11.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.Black;
            this.Label11.Location = new System.Drawing.Point(14, 244);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(70, 15);
            this.Label11.TabIndex = 23;
            this.Label11.Text = "Tel. Fax:";
            // 
            // tFax
            // 
            this.tFax.Location = new System.Drawing.Point(114, 241);
            this.tFax.MaxLength = 35;
            this.tFax.Name = "tFax";
            this.tFax.Size = new System.Drawing.Size(373, 21);
            this.tFax.TabIndex = 12;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label10.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.Black;
            this.Label10.Location = new System.Drawing.Point(13, 214);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(70, 15);
            this.Label10.TabIndex = 21;
            this.Label10.Text = "Teléfono:";
            // 
            // tTelefono
            // 
            this.tTelefono.Location = new System.Drawing.Point(114, 214);
            this.tTelefono.MaxLength = 30;
            this.tTelefono.Name = "tTelefono";
            this.tTelefono.Size = new System.Drawing.Size(373, 21);
            this.tTelefono.TabIndex = 11;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.Black;
            this.Label9.Location = new System.Drawing.Point(13, 126);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(77, 15);
            this.Label9.TabIndex = 19;
            this.Label9.Text = "Localidad:";
            // 
            // tLocalidad
            // 
            this.tLocalidad.Location = new System.Drawing.Point(114, 126);
            this.tLocalidad.MaxLength = 10;
            this.tLocalidad.Name = "tLocalidad";
            this.tLocalidad.Size = new System.Drawing.Size(182, 21);
            this.tLocalidad.TabIndex = 10;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label8.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.Black;
            this.Label8.Location = new System.Drawing.Point(14, 99);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(67, 13);
            this.Label8.TabIndex = 17;
            this.Label8.Text = "Dirección:";
            // 
            // tDireccion
            // 
            this.tDireccion.Location = new System.Drawing.Point(114, 96);
            this.tDireccion.MaxLength = 50;
            this.tDireccion.Name = "tDireccion";
            this.tDireccion.Size = new System.Drawing.Size(373, 21);
            this.tDireccion.TabIndex = 9;
            // 
            // tContacto
            // 
            this.tContacto.Location = new System.Drawing.Point(114, 32);
            this.tContacto.MaxLength = 30;
            this.tContacto.Multiline = true;
            this.tContacto.Name = "tContacto";
            this.tContacto.Size = new System.Drawing.Size(373, 25);
            this.tContacto.TabIndex = 5;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(14, 10);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(63, 15);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Cliente:";
            // 
            // tCliente
            // 
            this.tCliente.Location = new System.Drawing.Point(114, 7);
            this.tCliente.MaxLength = 30;
            this.tCliente.Name = "tCliente";
            this.tCliente.Size = new System.Drawing.Size(373, 21);
            this.tCliente.TabIndex = 4;
            // 
            // lIdCliente
            // 
            this.lIdCliente.AutoSize = true;
            this.lIdCliente.BackColor = System.Drawing.Color.White;
            this.lIdCliente.Location = new System.Drawing.Point(955, 76);
            this.lIdCliente.Name = "lIdCliente";
            this.lIdCliente.Size = new System.Drawing.Size(15, 13);
            this.lIdCliente.TabIndex = 95;
            this.lIdCliente.Text = "0";
            // 
            // abmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(999, 468);
            this.Controls.Add(this.lIdCliente);
            this.Controls.Add(this.pBotones);
            this.Controls.Add(this.pCampos);
            this.Controls.Add(this.gridClientes);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.tBuscar);
            this.Controls.Add(this.Label7);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "abmCustomers";
            this.Text = "CRUD | Clientes | Juan P. Romano";
            this.Load += new System.EventHandler(this.abmCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            this.pBotones.ResumeLayout(false);
            this.pCampos.ResumeLayout(false);
            this.pCampos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button bBuscar;
        internal System.Windows.Forms.TextBox tBuscar;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.DataGridView gridClientes;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ID;
        internal System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        internal System.Windows.Forms.DataGridViewTextBoxColumn contacto;
        internal System.Windows.Forms.Panel pBotones;
        internal System.Windows.Forms.Button bEliminar;
        internal System.Windows.Forms.Button bNuevoCli;
        internal System.Windows.Forms.Button bGuardar;
        internal System.Windows.Forms.Panel pCampos;
        internal System.Windows.Forms.Label lPais;
        internal System.Windows.Forms.TextBox tPais;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox tCP;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox tCargo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox tCiudad;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox tFax;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox tTelefono;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox tLocalidad;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox tDireccion;
        internal System.Windows.Forms.TextBox tContacto;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox tCliente;
        internal System.Windows.Forms.Label lIdCliente;
    }
}

