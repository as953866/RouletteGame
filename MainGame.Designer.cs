namespace RouletteGame
{
    partial class MainGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblComputerWin = new System.Windows.Forms.Label();
            this.lblUserWin = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRemainingGame = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureTurns = new System.Windows.Forms.PictureBox();
            this.lblTurn = new System.Windows.Forms.Label();
            this.btnGame = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.btnFire = new System.Windows.Forms.Button();
            this.lblComputerMessage = new System.Windows.Forms.Label();
            this.lblUserMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTurns)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(282, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fight With Your Luck!!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Computer Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(697, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Computer Win:";
            // 
            // lblComputerWin
            // 
            this.lblComputerWin.AutoSize = true;
            this.lblComputerWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerWin.Location = new System.Drawing.Point(187, 130);
            this.lblComputerWin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComputerWin.Name = "lblComputerWin";
            this.lblComputerWin.Size = new System.Drawing.Size(25, 26);
            this.lblComputerWin.TabIndex = 4;
            this.lblComputerWin.Text = "0";
            // 
            // lblUserWin
            // 
            this.lblUserWin.AutoSize = true;
            this.lblUserWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserWin.Location = new System.Drawing.Point(824, 130);
            this.lblUserWin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserWin.Name = "lblUserWin";
            this.lblUserWin.Size = new System.Drawing.Size(25, 26);
            this.lblUserWin.TabIndex = 6;
            this.lblUserWin.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(716, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "User Win:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRemainingGame
            // 
            this.lblRemainingGame.AutoSize = true;
            this.lblRemainingGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingGame.Location = new System.Drawing.Point(560, 130);
            this.lblRemainingGame.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemainingGame.Name = "lblRemainingGame";
            this.lblRemainingGame.Size = new System.Drawing.Size(0, 26);
            this.lblRemainingGame.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(359, 130);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 26);
            this.label8.TabIndex = 7;
            this.label8.Text = "Remaining Games:";
            // 
            // pictureTurns
            // 
            this.pictureTurns.Image = global::RouletteGame.ImageResource.TwoRevolver;
            this.pictureTurns.Location = new System.Drawing.Point(331, 170);
            this.pictureTurns.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureTurns.Name = "pictureTurns";
            this.pictureTurns.Size = new System.Drawing.Size(257, 222);
            this.pictureTurns.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTurns.TabIndex = 9;
            this.pictureTurns.TabStop = false;
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.Location = new System.Drawing.Point(392, 181);
            this.lblTurn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(0, 26);
            this.lblTurn.TabIndex = 10;
            this.lblTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGame
            // 
            this.btnGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame.Location = new System.Drawing.Point(158, 368);
            this.btnGame.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(160, 58);
            this.btnGame.TabIndex = 11;
            this.btnGame.Text = "Start Game";
            this.btnGame.UseVisualStyleBackColor = false;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(603, 273);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(112, 64);
            this.btnLoad.TabIndex = 12;
            this.btnLoad.Text = "Load Bullet";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSpin
            // 
            this.btnSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.Location = new System.Drawing.Point(610, 362);
            this.btnSpin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(105, 64);
            this.btnSpin.TabIndex = 13;
            this.btnSpin.Text = "Spin Chambers";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // btnFire
            // 
            this.btnFire.BackColor = System.Drawing.SystemColors.Control;
            this.btnFire.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFire.Location = new System.Drawing.Point(729, 328);
            this.btnFire.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(104, 64);
            this.btnFire.TabIndex = 14;
            this.btnFire.Text = "Fire";
            this.btnFire.UseVisualStyleBackColor = false;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // lblComputerMessage
            // 
            this.lblComputerMessage.AutoSize = true;
            this.lblComputerMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerMessage.Location = new System.Drawing.Point(19, 273);
            this.lblComputerMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComputerMessage.Name = "lblComputerMessage";
            this.lblComputerMessage.Size = new System.Drawing.Size(0, 26);
            this.lblComputerMessage.TabIndex = 15;
            // 
            // lblUserMessage
            // 
            this.lblUserMessage.AutoSize = true;
            this.lblUserMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserMessage.Location = new System.Drawing.Point(700, 255);
            this.lblUserMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserMessage.Name = "lblUserMessage";
            this.lblUserMessage.Size = new System.Drawing.Size(0, 26);
            this.lblUserMessage.TabIndex = 16;
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.Controls.Add(this.lblUserMessage);
            this.Controls.Add(this.lblComputerMessage);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.pictureTurns);
            this.Controls.Add(this.lblRemainingGame);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblUserWin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblComputerWin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fight With Your Luck!!!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainGame_FormClosing);
            this.Load += new System.EventHandler(this.MainGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTurns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblComputerWin;
        private System.Windows.Forms.Label lblUserWin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRemainingGame;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureTurns;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Label lblComputerMessage;
        private System.Windows.Forms.Label lblUserMessage;
    }
}

