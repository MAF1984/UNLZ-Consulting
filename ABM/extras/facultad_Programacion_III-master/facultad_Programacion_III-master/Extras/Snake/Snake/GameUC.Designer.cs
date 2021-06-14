﻿namespace Snake
{
    partial class Snake
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
            this.components = new System.ComponentModel.Container();
            this.GameCanvas = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Start_Btn = new System.Windows.Forms.Button();
            this.DareBtn = new System.Windows.Forms.Button();
            this.ScoreTxtBox = new System.Windows.Forms.TextBox();
            this.ScoreLbl = new System.Windows.Forms.Label();
            this.btn_Home = new System.Windows.Forms.Button();
            this.lbl_Game = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GameCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // GameCanvas
            // 
            this.GameCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GameCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameCanvas.Location = new System.Drawing.Point(4, 7);
            this.GameCanvas.Name = "GameCanvas";
            this.GameCanvas.Size = new System.Drawing.Size(590, 435);
            this.GameCanvas.TabIndex = 0;
            this.GameCanvas.TabStop = false;
            this.GameCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.GameCanvas_Paint);
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // Start_Btn
            // 
            this.Start_Btn.BackColor = System.Drawing.Color.Firebrick;
            this.Start_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Btn.Location = new System.Drawing.Point(600, 33);
            this.Start_Btn.Name = "Start_Btn";
            this.Start_Btn.Size = new System.Drawing.Size(205, 23);
            this.Start_Btn.TabIndex = 1;
            this.Start_Btn.Text = "Jugar/Pausa";
            this.Start_Btn.UseVisualStyleBackColor = false;
            this.Start_Btn.Click += new System.EventHandler(this.Start_Btn_Click);
            // 
            // DareBtn
            // 
            this.DareBtn.BackColor = System.Drawing.Color.Firebrick;
            this.DareBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DareBtn.Location = new System.Drawing.Point(599, 419);
            this.DareBtn.Name = "DareBtn";
            this.DareBtn.Size = new System.Drawing.Size(206, 23);
            this.DareBtn.TabIndex = 2;
            this.DareBtn.Text = "Te desafio a presionarme!";
            this.DareBtn.UseVisualStyleBackColor = false;
            this.DareBtn.Click += new System.EventHandler(this.DareBtn_Click);
            // 
            // ScoreTxtBox
            // 
            this.ScoreTxtBox.Enabled = false;
            this.ScoreTxtBox.Location = new System.Drawing.Point(644, 62);
            this.ScoreTxtBox.Name = "ScoreTxtBox";
            this.ScoreTxtBox.ReadOnly = true;
            this.ScoreTxtBox.Size = new System.Drawing.Size(161, 20);
            this.ScoreTxtBox.TabIndex = 3;
            // 
            // ScoreLbl
            // 
            this.ScoreLbl.AutoSize = true;
            this.ScoreLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScoreLbl.Location = new System.Drawing.Point(600, 63);
            this.ScoreLbl.Name = "ScoreLbl";
            this.ScoreLbl.Size = new System.Drawing.Size(40, 13);
            this.ScoreLbl.TabIndex = 4;
            this.ScoreLbl.Text = "Puntos";
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.Location = new System.Drawing.Point(600, 7);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(205, 23);
            this.btn_Home.TabIndex = 5;
            this.btn_Home.Text = "Inicio";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // lbl_Game
            // 
            this.lbl_Game.AutoSize = true;
            this.lbl_Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Game.ForeColor = System.Drawing.Color.White;
            this.lbl_Game.Location = new System.Drawing.Point(602, 92);
            this.lbl_Game.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_Game.MaximumSize = new System.Drawing.Size(182, 191);
            this.lbl_Game.Name = "lbl_Game";
            this.lbl_Game.Size = new System.Drawing.Size(0, 20);
            this.lbl_Game.TabIndex = 6;
            // 
            // Snake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lbl_Game);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.ScoreLbl);
            this.Controls.Add(this.ScoreTxtBox);
            this.Controls.Add(this.DareBtn);
            this.Controls.Add(this.Start_Btn);
            this.Controls.Add(this.GameCanvas);
            this.Name = "Snake";
            this.Size = new System.Drawing.Size(811, 449);
            ((System.ComponentModel.ISupportInitialize)(this.GameCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GameCanvas;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Button Start_Btn;
        private System.Windows.Forms.Button DareBtn;
        private System.Windows.Forms.TextBox ScoreTxtBox;
        private System.Windows.Forms.Label ScoreLbl;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Label lbl_Game;
    }
}