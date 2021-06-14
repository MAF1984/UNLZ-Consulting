namespace sistema
{
    partial class Proveedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
            this.lIdProveedor = new System.Windows.Forms.Label();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.tBuscar = new System.Windows.Forms.TextBox();
            this.gridProveedores = new System.Windows.Forms.DataGridView();
            this.nproveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApeYNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBordeBorrar = new System.Windows.Forms.Panel();
            this.btnBorrar = new FontAwesome.Sharp.IconButton();
            this.pnlBordeEditar = new System.Windows.Forms.Panel();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.pnlBordeNuevo = new System.Windows.Forms.Panel();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.tCUIT = new System.Windows.Forms.TextBox();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.tLocalidad = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.tComentario = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Label11 = new System.Windows.Forms.Label();
            this.tTelefono = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.tProvincia = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.tCP = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.tDireccion = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.tDNI = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.tApellido = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // lIdProveedor
            // 
            this.lIdProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lIdProveedor.AutoSize = true;
            this.lIdProveedor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lIdProveedor.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIdProveedor.ForeColor = System.Drawing.Color.White;
            this.lIdProveedor.Location = new System.Drawing.Point(584, 79);
            this.lIdProveedor.Name = "lIdProveedor";
            this.lIdProveedor.Size = new System.Drawing.Size(13, 13);
            this.lIdProveedor.TabIndex = 102;
            this.lIdProveedor.Text = "0";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBuscar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconSize = 32;
            this.btnBuscar.Location = new System.Drawing.Point(924, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Rotation = 0D;
            this.btnBuscar.Size = new System.Drawing.Size(110, 26);
            this.btnBuscar.TabIndex = 100;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(523, 79);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(49, 13);
            this.Label2.TabIndex = 99;
            this.Label2.Text = "User ID";
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(522, 6);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(162, 19);
            this.Label1.TabIndex = 98;
            this.Label1.Text = "Buscar por nombre";
            // 
            // tBuscar
            // 
            this.tBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBuscar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBuscar.Location = new System.Drawing.Point(526, 32);
            this.tBuscar.Name = "tBuscar";
            this.tBuscar.Size = new System.Drawing.Size(392, 26);
            this.tBuscar.TabIndex = 97;
            // 
            // gridProveedores
            // 
            this.gridProveedores.AllowUserToAddRows = false;
            this.gridProveedores.AllowUserToDeleteRows = false;
            this.gridProveedores.AllowUserToOrderColumns = true;
            this.gridProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gridProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProveedores.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProveedores.ColumnHeadersHeight = 30;
            this.gridProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nproveedor,
            this.ApeYNom,
            this.cuit});
            this.gridProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProveedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridProveedores.EnableHeadersVisualStyles = false;
            this.gridProveedores.Location = new System.Drawing.Point(526, 104);
            this.gridProveedores.Name = "gridProveedores";
            this.gridProveedores.ReadOnly = true;
            this.gridProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridProveedores.Size = new System.Drawing.Size(508, 294);
            this.gridProveedores.TabIndex = 103;
            this.gridProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProveedores_CellContentClick);
            this.gridProveedores.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProveedores_CellEnter);
            // 
            // nproveedor
            // 
            this.nproveedor.DataPropertyName = "nproveedor";
            this.nproveedor.HeaderText = "nproveedor";
            this.nproveedor.Name = "nproveedor";
            this.nproveedor.ReadOnly = true;
            this.nproveedor.Visible = false;
            // 
            // ApeYNom
            // 
            this.ApeYNom.DataPropertyName = "ApeYNom";
            this.ApeYNom.HeaderText = "Apellido y Nombre";
            this.ApeYNom.Name = "ApeYNom";
            this.ApeYNom.ReadOnly = true;
            // 
            // cuit
            // 
            this.cuit.DataPropertyName = "CUIT";
            this.cuit.HeaderText = "CUIT";
            this.cuit.Name = "cuit";
            this.cuit.ReadOnly = true;
            // 
            // pnlBordeBorrar
            // 
            this.pnlBordeBorrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBordeBorrar.BackColor = System.Drawing.Color.Red;
            this.pnlBordeBorrar.Location = new System.Drawing.Point(862, 425);
            this.pnlBordeBorrar.Name = "pnlBordeBorrar";
            this.pnlBordeBorrar.Size = new System.Drawing.Size(8, 47);
            this.pnlBordeBorrar.TabIndex = 109;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBorrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBorrar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.IconChar = FontAwesome.Sharp.IconChar.ShippingFast;
            this.btnBorrar.IconColor = System.Drawing.Color.White;
            this.btnBorrar.IconSize = 32;
            this.btnBorrar.Location = new System.Drawing.Point(868, 425);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Rotation = 0D;
            this.btnBorrar.Size = new System.Drawing.Size(122, 47);
            this.btnBorrar.TabIndex = 108;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // pnlBordeEditar
            // 
            this.pnlBordeEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBordeEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlBordeEditar.Location = new System.Drawing.Point(716, 425);
            this.pnlBordeEditar.Name = "pnlBordeEditar";
            this.pnlBordeEditar.Size = new System.Drawing.Size(8, 47);
            this.pnlBordeEditar.TabIndex = 107;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEditar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.TruckMonster;
            this.btnEditar.IconColor = System.Drawing.Color.White;
            this.btnEditar.IconSize = 32;
            this.btnEditar.Location = new System.Drawing.Point(722, 425);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Rotation = 0D;
            this.btnEditar.Size = new System.Drawing.Size(125, 47);
            this.btnEditar.TabIndex = 106;
            this.btnEditar.Text = "Guardar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // pnlBordeNuevo
            // 
            this.pnlBordeNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBordeNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(253)))), ((int)(((byte)(114)))));
            this.pnlBordeNuevo.Location = new System.Drawing.Point(572, 425);
            this.pnlBordeNuevo.Name = "pnlBordeNuevo";
            this.pnlBordeNuevo.Size = new System.Drawing.Size(8, 47);
            this.pnlBordeNuevo.TabIndex = 105;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(253)))), ((int)(((byte)(114)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNuevo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btnNuevo.IconColor = System.Drawing.Color.White;
            this.btnNuevo.IconSize = 32;
            this.btnNuevo.Location = new System.Drawing.Point(578, 425);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Rotation = 0D;
            this.btnNuevo.Size = new System.Drawing.Size(122, 47);
            this.btnNuevo.TabIndex = 104;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // tEmail
            // 
            this.tEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tEmail.Location = new System.Drawing.Point(135, 347);
            this.tEmail.MaxLength = 35;
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(359, 23);
            this.tEmail.TabIndex = 134;
            // 
            // Label15
            // 
            this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label15.AutoSize = true;
            this.Label15.ForeColor = System.Drawing.Color.White;
            this.Label15.Location = new System.Drawing.Point(361, 238);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(26, 16);
            this.Label15.TabIndex = 133;
            this.Label15.Text = "CP:";
            // 
            // Label7
            // 
            this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(25, 166);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(31, 13);
            this.Label7.TabIndex = 132;
            this.Label7.Text = "CUIT";
            // 
            // tCUIT
            // 
            this.tCUIT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tCUIT.Location = new System.Drawing.Point(135, 163);
            this.tCUIT.MaxLength = 30;
            this.tCUIT.Name = "tCUIT";
            this.tCUIT.Size = new System.Drawing.Size(359, 23);
            this.tCUIT.TabIndex = 131;
            // 
            // CheckBox1
            // 
            this.CheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.CheckBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox1.ForeColor = System.Drawing.Color.White;
            this.CheckBox1.Location = new System.Drawing.Point(428, 130);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(74, 17);
            this.CheckBox1.TabIndex = 130;
            this.CheckBox1.Text = "¿Activo?";
            this.CheckBox1.UseVisualStyleBackColor = false;
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(25, 277);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(67, 13);
            this.Label3.TabIndex = 129;
            this.Label3.Text = "Provincia:";
            // 
            // tLocalidad
            // 
            this.tLocalidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tLocalidad.Location = new System.Drawing.Point(135, 235);
            this.tLocalidad.MaxLength = 20;
            this.tLocalidad.Name = "tLocalidad";
            this.tLocalidad.Size = new System.Drawing.Size(218, 23);
            this.tLocalidad.TabIndex = 128;
            // 
            // Label16
            // 
            this.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label16.AutoSize = true;
            this.Label16.BackColor = System.Drawing.Color.Transparent;
            this.Label16.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.ForeColor = System.Drawing.Color.White;
            this.Label16.Location = new System.Drawing.Point(25, 410);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(73, 13);
            this.Label16.TabIndex = 127;
            this.Label16.Text = "Comentarios";
            // 
            // tComentario
            // 
            this.tComentario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tComentario.Location = new System.Drawing.Point(135, 383);
            this.tComentario.MaxLength = 200;
            this.tComentario.Multiline = true;
            this.tComentario.Name = "tComentario";
            this.tComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tComentario.Size = new System.Drawing.Size(359, 89);
            this.tComentario.TabIndex = 122;
            // 
            // Label12
            // 
            this.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label12.AutoSize = true;
            this.Label12.BackColor = System.Drawing.Color.Transparent;
            this.Label12.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.Color.White;
            this.Label12.Location = new System.Drawing.Point(25, 133);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(67, 13);
            this.Label12.TabIndex = 126;
            this.Label12.Text = "Nacimiento";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker1.Location = new System.Drawing.Point(156, 127);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(139, 23);
            this.DateTimePicker1.TabIndex = 119;
            // 
            // Label11
            // 
            this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.White;
            this.Label11.Location = new System.Drawing.Point(25, 354);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(37, 13);
            this.Label11.TabIndex = 125;
            this.Label11.Text = "Email";
            // 
            // tTelefono
            // 
            this.tTelefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tTelefono.Location = new System.Drawing.Point(135, 310);
            this.tTelefono.MaxLength = 35;
            this.tTelefono.Name = "tTelefono";
            this.tTelefono.Size = new System.Drawing.Size(359, 23);
            this.tTelefono.TabIndex = 118;
            // 
            // Label10
            // 
            this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(25, 313);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(55, 13);
            this.Label10.TabIndex = 124;
            this.Label10.Text = "Teléfono";
            // 
            // tProvincia
            // 
            this.tProvincia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tProvincia.Location = new System.Drawing.Point(135, 271);
            this.tProvincia.MaxLength = 30;
            this.tProvincia.Name = "tProvincia";
            this.tProvincia.Size = new System.Drawing.Size(359, 23);
            this.tProvincia.TabIndex = 117;
            // 
            // Label9
            // 
            this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.White;
            this.Label9.Location = new System.Drawing.Point(25, 238);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(61, 13);
            this.Label9.TabIndex = 123;
            this.Label9.Text = "Localidad";
            // 
            // tCP
            // 
            this.tCP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tCP.Location = new System.Drawing.Point(395, 235);
            this.tCP.MaxLength = 10;
            this.tCP.Name = "tCP";
            this.tCP.Size = new System.Drawing.Size(99, 23);
            this.tCP.TabIndex = 116;
            // 
            // Label8
            // 
            this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(25, 202);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(61, 13);
            this.Label8.TabIndex = 121;
            this.Label8.Text = "Dirección";
            // 
            // tDireccion
            // 
            this.tDireccion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tDireccion.Location = new System.Drawing.Point(135, 199);
            this.tDireccion.MaxLength = 50;
            this.tDireccion.Name = "tDireccion";
            this.tDireccion.Size = new System.Drawing.Size(359, 23);
            this.tDireccion.TabIndex = 115;
            // 
            // Label6
            // 
            this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(25, 94);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(25, 13);
            this.Label6.TabIndex = 120;
            this.Label6.Text = "DNI";
            // 
            // tDNI
            // 
            this.tDNI.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tDNI.Location = new System.Drawing.Point(135, 91);
            this.tDNI.MaxLength = 8;
            this.tDNI.Name = "tDNI";
            this.tDNI.Size = new System.Drawing.Size(359, 23);
            this.tDNI.TabIndex = 114;
            // 
            // Label5
            // 
            this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(25, 58);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(43, 13);
            this.Label5.TabIndex = 113;
            this.Label5.Text = "Nombre";
            // 
            // tNombre
            // 
            this.tNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tNombre.Location = new System.Drawing.Point(135, 55);
            this.tNombre.MaxLength = 30;
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(359, 23);
            this.tNombre.TabIndex = 112;
            // 
            // Label4
            // 
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(25, 22);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(55, 13);
            this.Label4.TabIndex = 110;
            this.Label4.Text = "Apellido";
            // 
            // tApellido
            // 
            this.tApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tApellido.Location = new System.Drawing.Point(135, 19);
            this.tApellido.MaxLength = 30;
            this.tApellido.Name = "tApellido";
            this.tApellido.Size = new System.Drawing.Size(359, 23);
            this.tApellido.TabIndex = 111;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(356, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 135;
            this.label13.Text = "Estado:";
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1046, 497);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tEmail);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.tCUIT);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.tLocalidad);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.tComentario);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.tTelefono);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.tProvincia);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.tCP);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.tDireccion);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.tDNI);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.tApellido);
            this.Controls.Add(this.pnlBordeBorrar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.pnlBordeEditar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.pnlBordeNuevo);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gridProveedores);
            this.Controls.Add(this.lIdProveedor);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.tBuscar);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lIdProveedor;
        private FontAwesome.Sharp.IconButton btnBuscar;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox tBuscar;
        internal System.Windows.Forms.DataGridView gridProveedores;
        internal System.Windows.Forms.DataGridViewTextBoxColumn nproveedor;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ApeYNom;
        internal System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.Panel pnlBordeBorrar;
        private FontAwesome.Sharp.IconButton btnBorrar;
        private System.Windows.Forms.Panel pnlBordeEditar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private System.Windows.Forms.Panel pnlBordeNuevo;
        private FontAwesome.Sharp.IconButton btnNuevo;
        internal System.Windows.Forms.TextBox tEmail;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox tCUIT;
        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox tLocalidad;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.TextBox tComentario;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox tTelefono;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox tProvincia;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox tCP;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox tDireccion;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox tDNI;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox tNombre;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox tApellido;
        internal System.Windows.Forms.Label label13;
    }
}