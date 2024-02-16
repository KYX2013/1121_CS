namespace Problem13
{
    partial class P6
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
            menuStrip1 = new MenuStrip();
            檔案ToolStripMenuItem = new ToolStripMenuItem();
            開檔ToolStripMenuItem = new ToolStripMenuItem();
            存檔ToolStripMenuItem = new ToolStripMenuItem();
            清除ToolStripMenuItem = new ToolStripMenuItem();
            結束ToolStripMenuItem = new ToolStripMenuItem();
            畫筆粗細ToolStripMenuItem = new ToolStripMenuItem();
            畫筆顏色ToolStripMenuItem = new ToolStripMenuItem();
            黑ToolStripMenuItem = new ToolStripMenuItem();
            紅ToolStripMenuItem = new ToolStripMenuItem();
            綠ToolStripMenuItem = new ToolStripMenuItem();
            藍ToolStripMenuItem = new ToolStripMenuItem();
            黃ToolStripMenuItem = new ToolStripMenuItem();
            橡皮擦ToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(19, 19);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 檔案ToolStripMenuItem, 畫筆粗細ToolStripMenuItem, 畫筆顏色ToolStripMenuItem, 橡皮擦ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(779, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            檔案ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 開檔ToolStripMenuItem, 存檔ToolStripMenuItem, 清除ToolStripMenuItem, 結束ToolStripMenuItem });
            檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            檔案ToolStripMenuItem.Size = new Size(50, 22);
            檔案ToolStripMenuItem.Text = "檔案";
            // 
            // 開檔ToolStripMenuItem
            // 
            開檔ToolStripMenuItem.Name = "開檔ToolStripMenuItem";
            開檔ToolStripMenuItem.Size = new Size(114, 26);
            開檔ToolStripMenuItem.Text = "開檔";
            開檔ToolStripMenuItem.Click += 開檔ToolStripMenuItem_Click;
            // 
            // 存檔ToolStripMenuItem
            // 
            存檔ToolStripMenuItem.Name = "存檔ToolStripMenuItem";
            存檔ToolStripMenuItem.Size = new Size(114, 26);
            存檔ToolStripMenuItem.Text = "存檔";
            存檔ToolStripMenuItem.Click += 存檔ToolStripMenuItem_Click;
            // 
            // 清除ToolStripMenuItem
            // 
            清除ToolStripMenuItem.Name = "清除ToolStripMenuItem";
            清除ToolStripMenuItem.Size = new Size(114, 26);
            清除ToolStripMenuItem.Text = "清除";
            清除ToolStripMenuItem.Click += 清除ToolStripMenuItem_Click;
            // 
            // 結束ToolStripMenuItem
            // 
            結束ToolStripMenuItem.Name = "結束ToolStripMenuItem";
            結束ToolStripMenuItem.Size = new Size(114, 26);
            結束ToolStripMenuItem.Text = "結束";
            結束ToolStripMenuItem.Click += 結束ToolStripMenuItem_Click;
            // 
            // 畫筆粗細ToolStripMenuItem
            // 
            畫筆粗細ToolStripMenuItem.Name = "畫筆粗細ToolStripMenuItem";
            畫筆粗細ToolStripMenuItem.Size = new Size(78, 22);
            畫筆粗細ToolStripMenuItem.Text = "畫筆粗細";
            // 
            // 畫筆顏色ToolStripMenuItem
            // 
            畫筆顏色ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 黑ToolStripMenuItem, 紅ToolStripMenuItem, 綠ToolStripMenuItem, 藍ToolStripMenuItem, 黃ToolStripMenuItem });
            畫筆顏色ToolStripMenuItem.Name = "畫筆顏色ToolStripMenuItem";
            畫筆顏色ToolStripMenuItem.Size = new Size(78, 22);
            畫筆顏色ToolStripMenuItem.Text = "畫筆顏色";
            // 
            // 黑ToolStripMenuItem
            // 
            黑ToolStripMenuItem.Name = "黑ToolStripMenuItem";
            黑ToolStripMenuItem.Size = new Size(100, 26);
            黑ToolStripMenuItem.Text = "黑";
            黑ToolStripMenuItem.Click += 黑ToolStripMenuItem_Click;
            // 
            // 紅ToolStripMenuItem
            // 
            紅ToolStripMenuItem.Name = "紅ToolStripMenuItem";
            紅ToolStripMenuItem.Size = new Size(100, 26);
            紅ToolStripMenuItem.Text = "紅";
            紅ToolStripMenuItem.Click += 紅ToolStripMenuItem_Click;
            // 
            // 綠ToolStripMenuItem
            // 
            綠ToolStripMenuItem.Name = "綠ToolStripMenuItem";
            綠ToolStripMenuItem.Size = new Size(100, 26);
            綠ToolStripMenuItem.Text = "綠";
            綠ToolStripMenuItem.Click += 綠ToolStripMenuItem_Click;
            // 
            // 藍ToolStripMenuItem
            // 
            藍ToolStripMenuItem.Name = "藍ToolStripMenuItem";
            藍ToolStripMenuItem.Size = new Size(100, 26);
            藍ToolStripMenuItem.Text = "藍";
            藍ToolStripMenuItem.Click += 藍ToolStripMenuItem_Click;
            // 
            // 黃ToolStripMenuItem
            // 
            黃ToolStripMenuItem.Name = "黃ToolStripMenuItem";
            黃ToolStripMenuItem.Size = new Size(100, 26);
            黃ToolStripMenuItem.Text = "黃";
            黃ToolStripMenuItem.Click += 黃ToolStripMenuItem_Click;
            // 
            // 橡皮擦ToolStripMenuItem
            // 
            橡皮擦ToolStripMenuItem.Name = "橡皮擦ToolStripMenuItem";
            橡皮擦ToolStripMenuItem.Size = new Size(64, 22);
            橡皮擦ToolStripMenuItem.Text = "橡皮擦";
            橡皮擦ToolStripMenuItem.Click += 橡皮擦ToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 28);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(779, 664);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // P6
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 692);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "P6";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開檔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 存檔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 結束ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 畫筆粗細ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 畫筆顏色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 橡皮擦ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem 黑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 紅ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 綠ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 藍ToolStripMenuItem;
        private ToolStripMenuItem 黃ToolStripMenuItem;
    }
}

