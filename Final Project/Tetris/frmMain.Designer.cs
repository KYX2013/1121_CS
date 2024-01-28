namespace Tetris
{
    partial class frmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.Play = new System.Windows.Forms.Button();
            this.Map = new System.Windows.Forms.Button();
            this.setting = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Black;
            this.Play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Play.BackgroundImage")));
            this.Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Play.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Play.FlatAppearance.BorderSize = 2;
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Play.Location = new System.Drawing.Point(131, 237);
            this.Play.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(187, 47);
            this.Play.TabIndex = 0;
            this.Play.Text = "PLAY";
            this.Play.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Map
            // 
            this.Map.BackColor = System.Drawing.Color.Black;
            this.Map.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Map.BackgroundImage")));
            this.Map.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Map.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Map.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Map.FlatAppearance.BorderSize = 2;
            this.Map.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Map.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Map.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Map.Location = new System.Drawing.Point(131, 309);
            this.Map.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(187, 47);
            this.Map.TabIndex = 1;
            this.Map.Text = "MAP";
            this.Map.UseVisualStyleBackColor = false;
            this.Map.Click += new System.EventHandler(this.Map_Click);
            // 
            // setting
            // 
            this.setting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("setting.BackgroundImage")));
            this.setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.setting.Location = new System.Drawing.Point(376, 442);
            this.setting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(58, 58);
            this.setting.TabIndex = 4;
            this.setting.UseVisualStyleBackColor = true;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(448, 514);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Map);
            this.Controls.Add(this.setting);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Tetris";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Map;
        private System.Windows.Forms.Button setting;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

