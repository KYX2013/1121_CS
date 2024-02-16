namespace Problem13
{
    partial class P11
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            檔案ToolStripMenuItem = new ToolStripMenuItem();
            開啟舊檔ToolStripMenuItem = new ToolStripMenuItem();
            儲存檔案ToolStripMenuItem = new ToolStripMenuItem();
            清除ToolStripMenuItem = new ToolStripMenuItem();
            結束ToolStripMenuItem = new ToolStripMenuItem();
            字型ToolStripMenuItem = new ToolStripMenuItem();
            色彩ToolStripMenuItem = new ToolStripMenuItem();
            前景色ToolStripMenuItem = new ToolStripMenuItem();
            背景色ToolStripMenuItem = new ToolStripMenuItem();
            字體型態ToolStripMenuItem = new ToolStripMenuItem();
            粗體ToolStripMenuItem = new ToolStripMenuItem();
            斜體ToolStripMenuItem = new ToolStripMenuItem();
            字體底線ToolStripMenuItem = new ToolStripMenuItem();
            richTextBox = new RichTextBox();
            colorDialog = new ColorDialog();
            fontDialog = new FontDialog();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Font = new Font("Microsoft JhengHei UI", 10.8318586F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip.ImageScalingSize = new Size(19, 19);
            menuStrip.Items.AddRange(new ToolStripItem[] { 檔案ToolStripMenuItem, 字型ToolStripMenuItem, 色彩ToolStripMenuItem, 字體型態ToolStripMenuItem, 字體底線ToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 30);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            檔案ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 開啟舊檔ToolStripMenuItem, 儲存檔案ToolStripMenuItem, 清除ToolStripMenuItem, 結束ToolStripMenuItem });
            檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            檔案ToolStripMenuItem.Size = new Size(58, 26);
            檔案ToolStripMenuItem.Text = "檔案";
            // 
            // 開啟舊檔ToolStripMenuItem
            // 
            開啟舊檔ToolStripMenuItem.Name = "開啟舊檔ToolStripMenuItem";
            開啟舊檔ToolStripMenuItem.Size = new Size(158, 26);
            開啟舊檔ToolStripMenuItem.Text = "開啟舊檔";
            開啟舊檔ToolStripMenuItem.Click += 開啟舊檔ToolStripMenuItem_Click;
            // 
            // 儲存檔案ToolStripMenuItem
            // 
            儲存檔案ToolStripMenuItem.Name = "儲存檔案ToolStripMenuItem";
            儲存檔案ToolStripMenuItem.Size = new Size(158, 26);
            儲存檔案ToolStripMenuItem.Text = "儲存檔案";
            儲存檔案ToolStripMenuItem.Click += 儲存檔案ToolStripMenuItem_Click;
            // 
            // 清除ToolStripMenuItem
            // 
            清除ToolStripMenuItem.Name = "清除ToolStripMenuItem";
            清除ToolStripMenuItem.Size = new Size(158, 26);
            清除ToolStripMenuItem.Text = "清除";
            清除ToolStripMenuItem.Click += 清除ToolStripMenuItem_Click;
            // 
            // 結束ToolStripMenuItem
            // 
            結束ToolStripMenuItem.Name = "結束ToolStripMenuItem";
            結束ToolStripMenuItem.Size = new Size(158, 26);
            結束ToolStripMenuItem.Text = "結束";
            結束ToolStripMenuItem.Click += 結束ToolStripMenuItem_Click;
            // 
            // 字型ToolStripMenuItem
            // 
            字型ToolStripMenuItem.Name = "字型ToolStripMenuItem";
            字型ToolStripMenuItem.Size = new Size(58, 26);
            字型ToolStripMenuItem.Text = "字型";
            字型ToolStripMenuItem.Click += 字型ToolStripMenuItem_Click;
            // 
            // 色彩ToolStripMenuItem
            // 
            色彩ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 前景色ToolStripMenuItem, 背景色ToolStripMenuItem });
            色彩ToolStripMenuItem.Name = "色彩ToolStripMenuItem";
            色彩ToolStripMenuItem.Size = new Size(58, 26);
            色彩ToolStripMenuItem.Text = "色彩";
            // 
            // 前景色ToolStripMenuItem
            // 
            前景色ToolStripMenuItem.Name = "前景色ToolStripMenuItem";
            前景色ToolStripMenuItem.Size = new Size(141, 26);
            前景色ToolStripMenuItem.Text = "前景色";
            前景色ToolStripMenuItem.Click += 前景色ToolStripMenuItem_Click;
            // 
            // 背景色ToolStripMenuItem
            // 
            背景色ToolStripMenuItem.Name = "背景色ToolStripMenuItem";
            背景色ToolStripMenuItem.Size = new Size(141, 26);
            背景色ToolStripMenuItem.Text = "背景色";
            背景色ToolStripMenuItem.Click += 背景色ToolStripMenuItem_Click;
            // 
            // 字體型態ToolStripMenuItem
            // 
            字體型態ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 粗體ToolStripMenuItem, 斜體ToolStripMenuItem });
            字體型態ToolStripMenuItem.Name = "字體型態ToolStripMenuItem";
            字體型態ToolStripMenuItem.Size = new Size(92, 26);
            字體型態ToolStripMenuItem.Text = "字體型態";
            // 
            // 粗體ToolStripMenuItem
            // 
            粗體ToolStripMenuItem.Name = "粗體ToolStripMenuItem";
            粗體ToolStripMenuItem.Size = new Size(211, 26);
            粗體ToolStripMenuItem.Text = "粗體";
            粗體ToolStripMenuItem.Click += 粗體ToolStripMenuItem_Click;
            // 
            // 斜體ToolStripMenuItem
            // 
            斜體ToolStripMenuItem.Name = "斜體ToolStripMenuItem";
            斜體ToolStripMenuItem.Size = new Size(211, 26);
            斜體ToolStripMenuItem.Text = "斜體";
            斜體ToolStripMenuItem.Click += 斜體ToolStripMenuItem_Click;
            // 
            // 字體底線ToolStripMenuItem
            // 
            字體底線ToolStripMenuItem.Name = "字體底線ToolStripMenuItem";
            字體底線ToolStripMenuItem.Size = new Size(92, 26);
            字體底線ToolStripMenuItem.Text = "字體底線";
            字體底線ToolStripMenuItem.Click += 字體底線ToolStripMenuItem_Click;
            // 
            // richTextBox
            // 
            richTextBox.Dock = DockStyle.Fill;
            richTextBox.Location = new Point(0, 30);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(800, 567);
            richTextBox.TabIndex = 1;
            richTextBox.Text = "";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 597);
            Controls.Add(richTextBox);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Form1";
            Text = "記事本 2.0 版";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem 檔案ToolStripMenuItem;
        private ToolStripMenuItem 開啟舊檔ToolStripMenuItem;
        private ToolStripMenuItem 儲存檔案ToolStripMenuItem;
        private ToolStripMenuItem 清除ToolStripMenuItem;
        private ToolStripMenuItem 結束ToolStripMenuItem;
        private ToolStripMenuItem 字型ToolStripMenuItem;
        private ToolStripMenuItem 色彩ToolStripMenuItem;
        private ToolStripMenuItem 前景色ToolStripMenuItem;
        private ToolStripMenuItem 背景色ToolStripMenuItem;
        private ToolStripMenuItem 字體型態ToolStripMenuItem;
        private ToolStripMenuItem 粗體ToolStripMenuItem;
        private ToolStripMenuItem 斜體ToolStripMenuItem;
        private ToolStripMenuItem 字體底線ToolStripMenuItem;
        private RichTextBox richTextBox;
        private ColorDialog colorDialog;
        private FontDialog fontDialog;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}
