namespace sistema
{
    partial class Inicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnProveedores = new FontAwesome.Sharp.IconButton();
            this.btnCliente = new FontAwesome.Sharp.IconButton();
            this.pnlLogotipo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconUser = new FontAwesome.Sharp.IconPictureBox();
            this.lLastNameUser = new System.Windows.Forms.Label();
            this.lGestion = new System.Windows.Forms.Label();
            this.lNameUser = new System.Windows.Forms.Label();
            this.pLogoTipo = new System.Windows.Forms.PictureBox();
            this.lFecha = new System.Windows.Forms.Label();
            this.lHora = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.ntnMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.bntClose = new FontAwesome.Sharp.IconPictureBox();
            this.lTitleFormActive = new System.Windows.Forms.Label();
            this.iconFromActive = new FontAwesome.Sharp.IconButton();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblInicio = new System.Windows.Forms.Label();
            this.tmExpandirMenu = new System.Windows.Forms.Timer(this.components);
            this.tmContraerMenu = new System.Windows.Forms.Timer(this.components);
            this.tmFechaHora = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            this.pnlLogotipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLogoTipo)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntClose)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMenu.Controls.Add(this.btnSalir);
            this.pnlMenu.Controls.Add(this.btnProveedores);
            this.pnlMenu.Controls.Add(this.btnCliente);
            this.pnlMenu.Controls.Add(this.pnlLogotipo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(328, 568);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(109)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSalir.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnSalir.IconColor = System.Drawing.Color.White;
            this.btnSalir.IconSize = 32;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 311);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Rotation = 0D;
            this.btnSalir.Size = new System.Drawing.Size(328, 55);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(109)))));
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnProveedores.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.IconChar = FontAwesome.Sharp.IconChar.TruckMoving;
            this.btnProveedores.IconColor = System.Drawing.Color.White;
            this.btnProveedores.IconSize = 32;
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(0, 256);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Rotation = 0D;
            this.btnProveedores.Size = new System.Drawing.Size(328, 55);
            this.btnProveedores.TabIndex = 2;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(109)))));
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCliente.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btnCliente.IconColor = System.Drawing.Color.White;
            this.btnCliente.IconSize = 32;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(0, 201);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Rotation = 0D;
            this.btnCliente.Size = new System.Drawing.Size(328, 55);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // pnlLogotipo
            // 
            this.pnlLogotipo.Controls.Add(this.label2);
            this.pnlLogotipo.Controls.Add(this.label1);
            this.pnlLogotipo.Controls.Add(this.iconUser);
            this.pnlLogotipo.Controls.Add(this.lLastNameUser);
            this.pnlLogotipo.Controls.Add(this.lGestion);
            this.pnlLogotipo.Controls.Add(this.lNameUser);
            this.pnlLogotipo.Controls.Add(this.pLogoTipo);
            this.pnlLogotipo.Controls.Add(this.lFecha);
            this.pnlLogotipo.Controls.Add(this.lHora);
            this.pnlLogotipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogotipo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogotipo.Name = "pnlLogotipo";
            this.pnlLogotipo.Size = new System.Drawing.Size(328, 201);
            this.pnlLogotipo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 1.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(19, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 3);
            this.label2.TabIndex = 6;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 1.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(19, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 3);
            this.label1.TabIndex = 5;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // iconUser
            // 
            this.iconUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.iconUser.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconUser.IconColor = System.Drawing.Color.White;
            this.iconUser.IconSize = 29;
            this.iconUser.Location = new System.Drawing.Point(20, 81);
            this.iconUser.Name = "iconUser";
            this.iconUser.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.iconUser.Size = new System.Drawing.Size(39, 29);
            this.iconUser.TabIndex = 2;
            this.iconUser.TabStop = false;
            // 
            // lLastNameUser
            // 
            this.lLastNameUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lLastNameUser.AutoSize = true;
            this.lLastNameUser.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLastNameUser.ForeColor = System.Drawing.Color.White;
            this.lLastNameUser.Location = new System.Drawing.Point(69, 100);
            this.lLastNameUser.Name = "lLastNameUser";
            this.lLastNameUser.Size = new System.Drawing.Size(63, 19);
            this.lLastNameUser.TabIndex = 4;
            this.lLastNameUser.Text = "Romano";
            // 
            // lGestion
            // 
            this.lGestion.AutoSize = true;
            this.lGestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lGestion.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGestion.ForeColor = System.Drawing.Color.White;
            this.lGestion.Location = new System.Drawing.Point(92, 11);
            this.lGestion.Name = "lGestion";
            this.lGestion.Size = new System.Drawing.Size(175, 34);
            this.lGestion.TabIndex = 4;
            this.lGestion.Text = "Gestionsys";
            this.lGestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lNameUser
            // 
            this.lNameUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lNameUser.AutoSize = true;
            this.lNameUser.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameUser.ForeColor = System.Drawing.Color.White;
            this.lNameUser.Location = new System.Drawing.Point(69, 81);
            this.lNameUser.Name = "lNameUser";
            this.lNameUser.Size = new System.Drawing.Size(72, 19);
            this.lNameUser.TabIndex = 3;
            this.lNameUser.Text = "Juan P.";
            this.lNameUser.Click += new System.EventHandler(this.lNameUser_Click);
            // 
            // pLogoTipo
            // 
            this.pLogoTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pLogoTipo.Image = ((System.Drawing.Image)(resources.GetObject("pLogoTipo.Image")));
            this.pLogoTipo.Location = new System.Drawing.Point(6, 11);
            this.pLogoTipo.Name = "pLogoTipo";
            this.pLogoTipo.Size = new System.Drawing.Size(53, 41);
            this.pLogoTipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pLogoTipo.TabIndex = 0;
            this.pLogoTipo.TabStop = false;
            this.pLogoTipo.Click += new System.EventHandler(this.pLogoTipo_Click);
            // 
            // lFecha
            // 
            this.lFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lFecha.AutoSize = true;
            this.lFecha.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFecha.ForeColor = System.Drawing.Color.White;
            this.lFecha.Location = new System.Drawing.Point(16, 159);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(234, 19);
            this.lFecha.TabIndex = 1;
            this.lFecha.Text = "Lunes, 1 de Junio de 2020";
            // 
            // lHora
            // 
            this.lHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lHora.AutoSize = true;
            this.lHora.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHora.ForeColor = System.Drawing.Color.White;
            this.lHora.Location = new System.Drawing.Point(16, 133);
            this.lHora.Name = "lHora";
            this.lHora.Size = new System.Drawing.Size(81, 19);
            this.lHora.TabIndex = 0;
            this.lHora.Text = "23:46:42";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlTitulo.Controls.Add(this.btnMinimize);
            this.pnlTitulo.Controls.Add(this.ntnMaximize);
            this.pnlTitulo.Controls.Add(this.bntClose);
            this.pnlTitulo.Controls.Add(this.lTitleFormActive);
            this.pnlTitulo.Controls.Add(this.iconFromActive);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(328, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(956, 61);
            this.pnlTitulo.TabIndex = 1;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconSize = 21;
            this.btnMinimize.Location = new System.Drawing.Point(875, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(22, 21);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // ntnMaximize
            // 
            this.ntnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ntnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.ntnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ntnMaximize.IconChar = FontAwesome.Sharp.IconChar.CompressAlt;
            this.ntnMaximize.IconColor = System.Drawing.Color.White;
            this.ntnMaximize.IconSize = 21;
            this.ntnMaximize.Location = new System.Drawing.Point(903, 3);
            this.ntnMaximize.Name = "ntnMaximize";
            this.ntnMaximize.Size = new System.Drawing.Size(22, 21);
            this.ntnMaximize.TabIndex = 4;
            this.ntnMaximize.TabStop = false;
            this.ntnMaximize.Click += new System.EventHandler(this.ntnMaximize_Click);
            // 
            // bntClose
            // 
            this.bntClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.bntClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.bntClose.IconColor = System.Drawing.Color.White;
            this.bntClose.IconSize = 21;
            this.bntClose.Location = new System.Drawing.Point(931, 3);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(22, 21);
            this.bntClose.TabIndex = 3;
            this.bntClose.TabStop = false;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // lTitleFormActive
            // 
            this.lTitleFormActive.AutoSize = true;
            this.lTitleFormActive.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitleFormActive.ForeColor = System.Drawing.Color.White;
            this.lTitleFormActive.Location = new System.Drawing.Point(41, 16);
            this.lTitleFormActive.Name = "lTitleFormActive";
            this.lTitleFormActive.Size = new System.Drawing.Size(56, 18);
            this.lTitleFormActive.TabIndex = 2;
            this.lTitleFormActive.Text = "Inicio";
            // 
            // iconFromActive
            // 
            this.iconFromActive.FlatAppearance.BorderSize = 0;
            this.iconFromActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconFromActive.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconFromActive.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconFromActive.IconColor = System.Drawing.Color.White;
            this.iconFromActive.IconSize = 32;
            this.iconFromActive.Location = new System.Drawing.Point(3, 11);
            this.iconFromActive.Name = "iconFromActive";
            this.iconFromActive.Rotation = 0D;
            this.iconFromActive.Size = new System.Drawing.Size(32, 29);
            this.iconFromActive.TabIndex = 1;
            this.iconFromActive.UseVisualStyleBackColor = true;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.pnlContent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlContent.BackgroundImage")));
            this.pnlContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlContent.Controls.Add(this.lblInicio);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(328, 61);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(956, 507);
            this.pnlContent.TabIndex = 3;
            // 
            // lblInicio
            // 
            this.lblInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInicio.AutoSize = true;
            this.lblInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblInicio.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.Color.Black;
            this.lblInicio.Location = new System.Drawing.Point(304, 99);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(367, 306);
            this.lblInicio.TabIndex = 1;
            this.lblInicio.Text = "Gracias por utilizar\r\nGestionsys!\r\n\r\nPor favor, selecciona\r\nalguna opción del \r\nm" +
    "enu lateral izquierdo\r\npara comenzar.\r\n\r\nv1.0";
            this.lblInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmExpandirMenu
            // 
            this.tmExpandirMenu.Interval = 15;
            this.tmExpandirMenu.Tick += new System.EventHandler(this.tmExpandirMenu_Tick);
            // 
            // tmContraerMenu
            // 
            this.tmContraerMenu.Interval = 15;
            this.tmContraerMenu.Tick += new System.EventHandler(this.tmContraerMenu_Tick);
            // 
            // tmFechaHora
            // 
            this.tmFechaHora.Enabled = true;
            this.tmFechaHora.Tick += new System.EventHandler(this.tmFechaHora_Tick);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 568);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 607);
            this.Name = "Inicio";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionsys | Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.Resize += new System.EventHandler(this.Inicio_Resize);
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogotipo.ResumeLayout(false);
            this.pnlLogotipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLogoTipo)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntClose)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogotipo;
        private FontAwesome.Sharp.IconButton btnCliente;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnProveedores;
        private System.Windows.Forms.PictureBox pLogoTipo;
        private System.Windows.Forms.Panel pnlTitulo;
        private FontAwesome.Sharp.IconButton iconFromActive;
        private System.Windows.Forms.Label lTitleFormActive;
        private System.Windows.Forms.Panel pnlContent;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconPictureBox ntnMaximize;
        private FontAwesome.Sharp.IconPictureBox bntClose;
        private System.Windows.Forms.Timer tmExpandirMenu;
        private System.Windows.Forms.Timer tmContraerMenu;
        private System.Windows.Forms.Timer tmFechaHora;
        private System.Windows.Forms.Label lHora;
        private System.Windows.Forms.Label lFecha;
        private FontAwesome.Sharp.IconPictureBox iconUser;
        private System.Windows.Forms.Label lLastNameUser;
        private System.Windows.Forms.Label lNameUser;
        internal System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lGestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

