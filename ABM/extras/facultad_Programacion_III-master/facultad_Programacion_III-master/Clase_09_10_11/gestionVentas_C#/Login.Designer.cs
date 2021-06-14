namespace sistema
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.bntClose = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lGestion = new System.Windows.Forms.Label();
            this.pLogoTipo = new System.Windows.Forms.PictureBox();
            this.pnlShadowButtom = new System.Windows.Forms.Panel();
            this.pnlShadowTop = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.iconClave = new FontAwesome.Sharp.IconPictureBox();
            this.iconUsuario = new FontAwesome.Sharp.IconPictureBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLogoTipo)).BeginInit();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.pnlTitulo.Controls.Add(this.btnMinimize);
            this.pnlTitulo.Controls.Add(this.bntClose);
            this.pnlTitulo.Controls.Add(this.label3);
            this.pnlTitulo.Controls.Add(this.lGestion);
            this.pnlTitulo.Controls.Add(this.pLogoTipo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(634, 145);
            this.pnlTitulo.TabIndex = 2;
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
            this.btnMinimize.Location = new System.Drawing.Point(579, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(22, 21);
            this.btnMinimize.TabIndex = 14;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // bntClose
            // 
            this.bntClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.bntClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.bntClose.IconColor = System.Drawing.Color.White;
            this.bntClose.IconSize = 21;
            this.bntClose.Location = new System.Drawing.Point(609, 3);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(22, 21);
            this.bntClose.TabIndex = 12;
            this.bntClose.TabStop = false;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(623, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ingresa tu usuario y contraseña e inicia sesión";
            // 
            // lGestion
            // 
            this.lGestion.AutoSize = true;
            this.lGestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lGestion.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGestion.ForeColor = System.Drawing.Color.White;
            this.lGestion.Location = new System.Drawing.Point(134, 36);
            this.lGestion.Name = "lGestion";
            this.lGestion.Size = new System.Drawing.Size(175, 34);
            this.lGestion.TabIndex = 3;
            this.lGestion.Text = "Gestionsys";
            this.lGestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pLogoTipo
            // 
            this.pLogoTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pLogoTipo.Image = ((System.Drawing.Image)(resources.GetObject("pLogoTipo.Image")));
            this.pLogoTipo.Location = new System.Drawing.Point(0, 3);
            this.pLogoTipo.Name = "pLogoTipo";
            this.pLogoTipo.Size = new System.Drawing.Size(110, 99);
            this.pLogoTipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pLogoTipo.TabIndex = 2;
            this.pLogoTipo.TabStop = false;
            // 
            // pnlShadowButtom
            // 
            this.pnlShadowButtom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            this.pnlShadowButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlShadowButtom.Location = new System.Drawing.Point(0, 570);
            this.pnlShadowButtom.Name = "pnlShadowButtom";
            this.pnlShadowButtom.Size = new System.Drawing.Size(634, 9);
            this.pnlShadowButtom.TabIndex = 4;
            // 
            // pnlShadowTop
            // 
            this.pnlShadowTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            this.pnlShadowTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlShadowTop.Location = new System.Drawing.Point(0, 145);
            this.pnlShadowTop.Name = "pnlShadowTop";
            this.pnlShadowTop.Size = new System.Drawing.Size(634, 9);
            this.pnlShadowTop.TabIndex = 5;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.pnlContent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlContent.BackgroundImage")));
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Controls.Add(this.btnSalir);
            this.pnlContent.Controls.Add(this.iconClave);
            this.pnlContent.Controls.Add(this.iconUsuario);
            this.pnlContent.Controls.Add(this.txtClave);
            this.pnlContent.Controls.Add(this.txtUsuario);
            this.pnlContent.Controls.Add(this.btnLogin);
            this.pnlContent.Location = new System.Drawing.Point(0, 136);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(634, 443);
            this.pnlContent.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Usuario";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnSalir.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnSalir.IconColor = System.Drawing.Color.Red;
            this.btnSalir.IconSize = 32;
            this.btnSalir.Location = new System.Drawing.Point(389, 337);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Rotation = 0D;
            this.btnSalir.Size = new System.Drawing.Size(212, 57);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // iconClave
            // 
            this.iconClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconClave.BackColor = System.Drawing.Color.Transparent;
            this.iconClave.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconClave.IconColor = System.Drawing.Color.White;
            this.iconClave.IconSize = 38;
            this.iconClave.Location = new System.Drawing.Point(13, 115);
            this.iconClave.Name = "iconClave";
            this.iconClave.Size = new System.Drawing.Size(40, 38);
            this.iconClave.TabIndex = 6;
            this.iconClave.TabStop = false;
            // 
            // iconUsuario
            // 
            this.iconUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconUsuario.BackColor = System.Drawing.Color.Transparent;
            this.iconUsuario.IconChar = FontAwesome.Sharp.IconChar.UserNinja;
            this.iconUsuario.IconColor = System.Drawing.Color.White;
            this.iconUsuario.IconSize = 38;
            this.iconUsuario.Location = new System.Drawing.Point(12, 53);
            this.iconUsuario.Name = "iconUsuario";
            this.iconUsuario.Size = new System.Drawing.Size(40, 38);
            this.iconUsuario.TabIndex = 5;
            this.iconUsuario.TabStop = false;
            // 
            // txtClave
            // 
            this.txtClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClave.Location = new System.Drawing.Point(209, 125);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(392, 25);
            this.txtClave.TabIndex = 4;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Location = new System.Drawing.Point(209, 66);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(392, 25);
            this.txtUsuario.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnLogin.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnLogin.IconColor = System.Drawing.Color.ForestGreen;
            this.btnLogin.IconSize = 32;
            this.btnLogin.Location = new System.Drawing.Point(389, 229);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Rotation = 0D;
            this.btnLogin.Size = new System.Drawing.Size(212, 57);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 579);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlShadowTop);
            this.Controls.Add(this.pnlShadowButtom);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(650, 618);
            this.MinimumSize = new System.Drawing.Size(650, 618);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionsys | Iniciar sesión | Juan P. Romano";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLogoTipo)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lGestion;
        private System.Windows.Forms.PictureBox pLogoTipo;
        private System.Windows.Forms.Panel pnlShadowButtom;
        private System.Windows.Forms.Panel pnlShadowTop;
        private System.Windows.Forms.Panel pnlContent;
        private FontAwesome.Sharp.IconButton btnLogin;
        private System.Windows.Forms.TextBox txtUsuario;
        private FontAwesome.Sharp.IconPictureBox iconUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private FontAwesome.Sharp.IconPictureBox iconClave;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconPictureBox bntClose;
    }
}