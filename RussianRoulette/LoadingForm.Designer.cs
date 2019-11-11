﻿namespace RussianRoulette
{
    partial class LoadingForm
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.RussianRoulette = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.loading = new System.Windows.Forms.Label();
            this.StartGame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RussianRoulette
            // 
            this.RussianRoulette.AutoSize = true;
            this.RussianRoulette.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RussianRoulette.ForeColor = System.Drawing.Color.Red;
            this.RussianRoulette.Image = global::RussianRoulette.Resource1.load;
            this.RussianRoulette.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RussianRoulette.Location = new System.Drawing.Point(235, 9);
            this.RussianRoulette.Name = "RussianRoulette";
            this.RussianRoulette.Size = new System.Drawing.Size(319, 57);
            this.RussianRoulette.TabIndex = 1;
            this.RussianRoulette.Text = "RussianRoulette";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(334, 339);
            this.progressBar1.MarqueeAnimationSpeed = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(357, 36);
            this.progressBar1.Step = 500;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Value = 100;
            // 
            // loading
            // 
            this.loading.AutoSize = true;
            this.loading.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading.Location = new System.Drawing.Point(222, 350);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(81, 25);
            this.loading.TabIndex = 3;
            this.loading.Text = "Loading";
            // 
            // StartGame
            // 
            this.StartGame.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGame.ForeColor = System.Drawing.Color.Red;
            this.StartGame.Location = new System.Drawing.Point(334, 396);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(131, 42);
            this.StartGame.TabIndex = 4;
            this.StartGame.Text = "Start Game";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Image = global::RussianRoulette.Resource1.frontpage;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.RussianRoulette);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoadingForm";
            this.Text = "LoadingForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label RussianRoulette;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label loading;
        private System.Windows.Forms.Button StartGame;
    }
}

