namespace ROCK_PAPER_SCISSORS_V1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComPicRock = new System.Windows.Forms.PictureBox();
            this.PlayPicRock = new System.Windows.Forms.PictureBox();
            this.ComPicPaper = new System.Windows.Forms.PictureBox();
            this.PlayPicPaper = new System.Windows.Forms.PictureBox();
            this.ComPicScissors = new System.Windows.Forms.PictureBox();
            this.PlayPicScissors = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblComScoreResult = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblComDisDraws = new System.Windows.Forms.Label();
            this.lblComDisLosses = new System.Windows.Forms.Label();
            this.lblComDisWins = new System.Windows.Forms.Label();
            this.lblPlaDisDraws = new System.Windows.Forms.Label();
            this.lblPlaDisLosses = new System.Windows.Forms.Label();
            this.lblPlaDisWins = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblDisplayMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ComPicRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayPicRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComPicPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayPicPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComPicScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayPicScissors)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRock.Location = new System.Drawing.Point(293, 14);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(83, 80);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaper.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPaper.Location = new System.Drawing.Point(293, 100);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(83, 80);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScissors.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnScissors.Location = new System.Drawing.Point(293, 186);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(83, 80);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Info;
            this.btnExit.Location = new System.Drawing.Point(293, 295);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 60);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(75, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Computer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Magneto", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(485, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player";
            // 
            // ComPicRock
            // 
            this.ComPicRock.ErrorImage = null;
            this.ComPicRock.Image = ((System.Drawing.Image)(resources.GetObject("ComPicRock.Image")));
            this.ComPicRock.Location = new System.Drawing.Point(59, 58);
            this.ComPicRock.Name = "ComPicRock";
            this.ComPicRock.Size = new System.Drawing.Size(154, 151);
            this.ComPicRock.TabIndex = 6;
            this.ComPicRock.TabStop = false;
            // 
            // PlayPicRock
            // 
            this.PlayPicRock.ErrorImage = null;
            this.PlayPicRock.Image = ((System.Drawing.Image)(resources.GetObject("PlayPicRock.Image")));
            this.PlayPicRock.Location = new System.Drawing.Point(454, 58);
            this.PlayPicRock.Name = "PlayPicRock";
            this.PlayPicRock.Size = new System.Drawing.Size(154, 151);
            this.PlayPicRock.TabIndex = 7;
            this.PlayPicRock.TabStop = false;
            // 
            // ComPicPaper
            // 
            this.ComPicPaper.ErrorImage = null;
            this.ComPicPaper.Image = ((System.Drawing.Image)(resources.GetObject("ComPicPaper.Image")));
            this.ComPicPaper.Location = new System.Drawing.Point(59, 58);
            this.ComPicPaper.Name = "ComPicPaper";
            this.ComPicPaper.Size = new System.Drawing.Size(154, 151);
            this.ComPicPaper.TabIndex = 8;
            this.ComPicPaper.TabStop = false;
            // 
            // PlayPicPaper
            // 
            this.PlayPicPaper.ErrorImage = null;
            this.PlayPicPaper.Image = ((System.Drawing.Image)(resources.GetObject("PlayPicPaper.Image")));
            this.PlayPicPaper.Location = new System.Drawing.Point(454, 58);
            this.PlayPicPaper.Name = "PlayPicPaper";
            this.PlayPicPaper.Size = new System.Drawing.Size(154, 151);
            this.PlayPicPaper.TabIndex = 9;
            this.PlayPicPaper.TabStop = false;
            // 
            // ComPicScissors
            // 
            this.ComPicScissors.ErrorImage = null;
            this.ComPicScissors.Image = ((System.Drawing.Image)(resources.GetObject("ComPicScissors.Image")));
            this.ComPicScissors.Location = new System.Drawing.Point(59, 58);
            this.ComPicScissors.Name = "ComPicScissors";
            this.ComPicScissors.Size = new System.Drawing.Size(154, 151);
            this.ComPicScissors.TabIndex = 10;
            this.ComPicScissors.TabStop = false;
            // 
            // PlayPicScissors
            // 
            this.PlayPicScissors.ErrorImage = null;
            this.PlayPicScissors.Image = ((System.Drawing.Image)(resources.GetObject("PlayPicScissors.Image")));
            this.PlayPicScissors.Location = new System.Drawing.Point(454, 58);
            this.PlayPicScissors.Name = "PlayPicScissors";
            this.PlayPicScissors.Size = new System.Drawing.Size(154, 151);
            this.PlayPicScissors.TabIndex = 11;
            this.PlayPicScissors.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Magneto", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(54, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Computers Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Magneto", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(464, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Players Score";
            // 
            // lblComScoreResult
            // 
            this.lblComScoreResult.AutoSize = true;
            this.lblComScoreResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComScoreResult.ForeColor = System.Drawing.Color.Gray;
            this.lblComScoreResult.Location = new System.Drawing.Point(56, 287);
            this.lblComScoreResult.Name = "lblComScoreResult";
            this.lblComScoreResult.Size = new System.Drawing.Size(35, 13);
            this.lblComScoreResult.TabIndex = 14;
            this.lblComScoreResult.Text = "Wins";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(56, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Losses";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(56, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Draws";
            // 
            // lblComDisDraws
            // 
            this.lblComDisDraws.AutoSize = true;
            this.lblComDisDraws.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblComDisDraws.Location = new System.Drawing.Point(122, 337);
            this.lblComDisDraws.Name = "lblComDisDraws";
            this.lblComDisDraws.Size = new System.Drawing.Size(0, 13);
            this.lblComDisDraws.TabIndex = 20;
            // 
            // lblComDisLosses
            // 
            this.lblComDisLosses.AutoSize = true;
            this.lblComDisLosses.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblComDisLosses.Location = new System.Drawing.Point(122, 311);
            this.lblComDisLosses.Name = "lblComDisLosses";
            this.lblComDisLosses.Size = new System.Drawing.Size(0, 13);
            this.lblComDisLosses.TabIndex = 19;
            // 
            // lblComDisWins
            // 
            this.lblComDisWins.AutoSize = true;
            this.lblComDisWins.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblComDisWins.Location = new System.Drawing.Point(122, 287);
            this.lblComDisWins.Name = "lblComDisWins";
            this.lblComDisWins.Size = new System.Drawing.Size(0, 13);
            this.lblComDisWins.TabIndex = 18;
            // 
            // lblPlaDisDraws
            // 
            this.lblPlaDisDraws.AutoSize = true;
            this.lblPlaDisDraws.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlaDisDraws.Location = new System.Drawing.Point(531, 337);
            this.lblPlaDisDraws.Name = "lblPlaDisDraws";
            this.lblPlaDisDraws.Size = new System.Drawing.Size(0, 13);
            this.lblPlaDisDraws.TabIndex = 26;
            // 
            // lblPlaDisLosses
            // 
            this.lblPlaDisLosses.AutoSize = true;
            this.lblPlaDisLosses.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlaDisLosses.Location = new System.Drawing.Point(531, 311);
            this.lblPlaDisLosses.Name = "lblPlaDisLosses";
            this.lblPlaDisLosses.Size = new System.Drawing.Size(0, 13);
            this.lblPlaDisLosses.TabIndex = 25;
            // 
            // lblPlaDisWins
            // 
            this.lblPlaDisWins.AutoSize = true;
            this.lblPlaDisWins.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlaDisWins.Location = new System.Drawing.Point(531, 287);
            this.lblPlaDisWins.Name = "lblPlaDisWins";
            this.lblPlaDisWins.Size = new System.Drawing.Size(0, 13);
            this.lblPlaDisWins.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(465, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Draws";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(465, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Losses";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(465, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Wins";
            // 
            // lblDisplayMessage
            // 
            this.lblDisplayMessage.AutoSize = true;
            this.lblDisplayMessage.Font = new System.Drawing.Font("Engravers MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayMessage.Location = new System.Drawing.Point(153, 413);
            this.lblDisplayMessage.Name = "lblDisplayMessage";
            this.lblDisplayMessage.Size = new System.Drawing.Size(0, 25);
            this.lblDisplayMessage.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(677, 447);
            this.Controls.Add(this.lblDisplayMessage);
            this.Controls.Add(this.lblPlaDisDraws);
            this.Controls.Add(this.lblPlaDisLosses);
            this.Controls.Add(this.lblPlaDisWins);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblComDisDraws);
            this.Controls.Add(this.lblComDisLosses);
            this.Controls.Add(this.lblComDisWins);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblComScoreResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PlayPicScissors);
            this.Controls.Add(this.ComPicScissors);
            this.Controls.Add(this.PlayPicPaper);
            this.Controls.Add(this.ComPicPaper);
            this.Controls.Add(this.PlayPicRock);
            this.Controls.Add(this.ComPicRock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scissors Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComPicRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayPicRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComPicPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayPicPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComPicScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayPicScissors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ComPicRock;
        private System.Windows.Forms.PictureBox PlayPicRock;
        private System.Windows.Forms.PictureBox ComPicPaper;
        private System.Windows.Forms.PictureBox PlayPicPaper;
        private System.Windows.Forms.PictureBox ComPicScissors;
        private System.Windows.Forms.PictureBox PlayPicScissors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblComScoreResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblComDisDraws;
        private System.Windows.Forms.Label lblComDisLosses;
        private System.Windows.Forms.Label lblComDisWins;
        private System.Windows.Forms.Label lblPlaDisDraws;
        private System.Windows.Forms.Label lblPlaDisLosses;
        private System.Windows.Forms.Label lblPlaDisWins;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblDisplayMessage;
    }
}

