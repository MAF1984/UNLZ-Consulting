namespace Snake
{
    partial class TutorialUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Home = new System.Windows.Forms.Button();
            this.btn_Play = new System.Windows.Forms.Button();
            this.img_SnakeTitle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_SnakeTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 319);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usa WASD o las flechitas para jugar :)";
            // 
            // btn_Home
            // 
            this.btn_Home.AutoSize = true;
            this.btn_Home.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.Black;
            this.btn_Home.Location = new System.Drawing.Point(131, 393);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(214, 38);
            this.btn_Home.TabIndex = 10;
            this.btn_Home.Text = "Inicio";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // btn_Play
            // 
            this.btn_Play.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Play.ForeColor = System.Drawing.Color.Black;
            this.btn_Play.Location = new System.Drawing.Point(474, 393);
            this.btn_Play.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(214, 38);
            this.btn_Play.TabIndex = 9;
            this.btn_Play.Text = "Jugar";
            this.btn_Play.UseVisualStyleBackColor = false;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // img_SnakeTitle
            // 
            this.img_SnakeTitle.Image = global::Snake.Properties.Resources.PixelControls;
            this.img_SnakeTitle.Location = new System.Drawing.Point(67, 68);
            this.img_SnakeTitle.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.img_SnakeTitle.Name = "img_SnakeTitle";
            this.img_SnakeTitle.Size = new System.Drawing.Size(684, 228);
            this.img_SnakeTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_SnakeTitle.TabIndex = 6;
            this.img_SnakeTitle.TabStop = false;
            // 
            // TutorialUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.img_SnakeTitle);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "TutorialUC";
            this.Size = new System.Drawing.Size(823, 484);
            ((System.ComponentModel.ISupportInitialize)(this.img_SnakeTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_SnakeTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_Play;
    }
}
