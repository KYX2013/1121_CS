using System.Windows.Forms;

namespace Tetris
{
    partial class Playing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Playing));
            this.holding = new System.Windows.Forms.PictureBox();
            this.next = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.next_1 = new System.Windows.Forms.PictureBox();
            this.next_2 = new System.Windows.Forms.PictureBox();
            this.ScoreImg = new System.Windows.Forms.PictureBox();
            this.TimeImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.holding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeImg)).BeginInit();
            this.SuspendLayout();
            // 
            // holding
            // 
            this.holding.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.holding.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.holding.Location = new System.Drawing.Point(61, 66);
            this.holding.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.holding.Name = "holding";
            this.holding.Size = new System.Drawing.Size(104, 104);
            this.holding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.holding.TabIndex = 0;
            this.holding.TabStop = false;
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.next.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.next.Location = new System.Drawing.Point(734, 66);
            this.next.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(104, 104);
            this.next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.next.TabIndex = 1;
            this.next.TabStop = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.White;
            this.Score.Location = new System.Drawing.Point(54, 332);
            this.Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(131, 38);
            this.Score.TabIndex = 2;
            this.Score.Text = "Score:";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.BackColor = System.Drawing.Color.Transparent;
            this.Time.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold);
            this.Time.ForeColor = System.Drawing.Color.White;
            this.Time.Location = new System.Drawing.Point(59, 470);
            this.Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(118, 38);
            this.Time.TabIndex = 3;
            this.Time.Text = "Time:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(286, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 630);
            this.panel1.TabIndex = 4;
            // 
            // next_1
            // 
            this.next_1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.next_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.next_1.Location = new System.Drawing.Point(734, 209);
            this.next_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.next_1.Name = "next_1";
            this.next_1.Size = new System.Drawing.Size(104, 104);
            this.next_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.next_1.TabIndex = 6;
            this.next_1.TabStop = false;
            // 
            // next_2
            // 
            this.next_2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.next_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.next_2.Location = new System.Drawing.Point(734, 349);
            this.next_2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.next_2.Name = "next_2";
            this.next_2.Size = new System.Drawing.Size(104, 104);
            this.next_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.next_2.TabIndex = 7;
            this.next_2.TabStop = false;
            // 
            // ScoreImg
            // 
            this.ScoreImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ScoreImg.Location = new System.Drawing.Point(46, 267);
            this.ScoreImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ScoreImg.Name = "ScoreImg";
            this.ScoreImg.Size = new System.Drawing.Size(140, 47);
            this.ScoreImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ScoreImg.TabIndex = 8;
            this.ScoreImg.TabStop = false;
            // 
            // TimeImg
            // 
            this.TimeImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TimeImg.Location = new System.Drawing.Point(46, 404);
            this.TimeImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TimeImg.Name = "TimeImg";
            this.TimeImg.Size = new System.Drawing.Size(140, 47);
            this.TimeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TimeImg.TabIndex = 9;
            this.TimeImg.TabStop = false;
            // 
            // Playing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(80)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 654);
            this.Controls.Add(this.TimeImg);
            this.Controls.Add(this.ScoreImg);
            this.Controls.Add(this.next_2);
            this.Controls.Add(this.next_1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.next);
            this.Controls.Add(this.holding);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Playing";
            this.Text = "playing";
            ((System.ComponentModel.ISupportInitialize)(this.holding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private static Timer countdownTimer;
        private void InitializeTimer()
        {
            countdownTimer = new Timer();
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += Clock_Tick;
            countdownTimer.Start();
        }

        #endregion

        private System.Windows.Forms.PictureBox holding;
        private System.Windows.Forms.PictureBox next;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Panel panel1;
        private PictureBox next_1;
        private PictureBox next_2;
        private PictureBox ScoreImg;
        private PictureBox TimeImg;
    }
}