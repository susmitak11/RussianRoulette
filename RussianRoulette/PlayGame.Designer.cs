namespace RussianRoulette
{
    partial class PlayGameForm
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
            this.Spin = new System.Windows.Forms.Button();
            this.Fire = new System.Windows.Forms.Button();
            this.PlayAgain = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.LoadImg = new System.Windows.Forms.PictureBox();
            this.ShootAway = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LoadImg)).BeginInit();
            this.SuspendLayout();
            // 
            // Spin
            // 
            this.Spin.Enabled = false;
            this.Spin.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spin.ForeColor = System.Drawing.Color.White;
            this.Spin.Image = global::RussianRoulette.Resource1.frontpage;
            this.Spin.Location = new System.Drawing.Point(650, 153);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(153, 59);
            this.Spin.TabIndex = 2;
            this.Spin.Text = "SPIN";
            this.Spin.UseVisualStyleBackColor = true;
            this.Spin.Click += new System.EventHandler(this.Spin_Click);
            // 
            // Fire
            // 
            this.Fire.Enabled = false;
            this.Fire.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fire.ForeColor = System.Drawing.Color.White;
            this.Fire.Image = global::RussianRoulette.Resource1.ShootHead;
            this.Fire.Location = new System.Drawing.Point(650, 237);
            this.Fire.Name = "Fire";
            this.Fire.Size = new System.Drawing.Size(153, 55);
            this.Fire.TabIndex = 3;
            this.Fire.Text = "FIRE!!";
            this.Fire.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Fire.UseVisualStyleBackColor = true;
            this.Fire.Click += new System.EventHandler(this.Fire_Click);
            // 
            // PlayAgain
            // 
            this.PlayAgain.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgain.ForeColor = System.Drawing.Color.Green;
            this.PlayAgain.Location = new System.Drawing.Point(98, 396);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(193, 42);
            this.PlayAgain.TabIndex = 4;
            this.PlayAgain.Text = "PLAY AGAIN";
            this.PlayAgain.UseVisualStyleBackColor = true;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBtn.ForeColor = System.Drawing.Color.White;
            this.LoadBtn.Image = global::RussianRoulette.Resource1.load;
            this.LoadBtn.Location = new System.Drawing.Point(650, 75);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(153, 58);
            this.LoadBtn.TabIndex = 5;
            this.LoadBtn.Text = "LOAD";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // LoadImg
            // 
            this.LoadImg.BackgroundImage = global::RussianRoulette.Resource1.Background;
            this.LoadImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoadImg.Location = new System.Drawing.Point(2, -8);
            this.LoadImg.Name = "LoadImg";
            this.LoadImg.Size = new System.Drawing.Size(801, 461);
            this.LoadImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadImg.TabIndex = 6;
            this.LoadImg.TabStop = false;
            // 
            // ShootAway
            // 
            this.ShootAway.Enabled = false;
            this.ShootAway.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShootAway.ForeColor = System.Drawing.Color.White;
            this.ShootAway.Image = global::RussianRoulette.Resource1.spin;
            this.ShootAway.Location = new System.Drawing.Point(650, 312);
            this.ShootAway.Name = "ShootAway";
            this.ShootAway.Size = new System.Drawing.Size(153, 59);
            this.ShootAway.TabIndex = 8;
            this.ShootAway.Text = "ShootAway";
            this.ShootAway.UseVisualStyleBackColor = true;
            this.ShootAway.Click += new System.EventHandler(this.ShootAway_Click);
            // 
            // PlayGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RussianRoulette.Resource1.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShootAway);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.Fire);
            this.Controls.Add(this.Spin);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.LoadImg);
            this.Name = "PlayGameForm";
            this.Text = "PlayGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.LoadImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Spin;
        private System.Windows.Forms.Button Fire;
        private System.Windows.Forms.Button PlayAgain;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.PictureBox LoadImg;
        private System.Windows.Forms.Button ShootAway;
    }
}