namespace Problem13
{
    partial class P4
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            檔案ToolStripMenuItem = new ToolStripMenuItem();
            開檔ToolStripMenuItem = new ToolStripMenuItem();
            存檔ToolStripMenuItem = new ToolStripMenuItem();
            清除ToolStripMenuItem = new ToolStripMenuItem();
            結束ToolStripMenuItem = new ToolStripMenuItem();
            項目符號ToolStripMenuItem = new ToolStripMenuItem();
            字型大小ToolStripMenuItem = new ToolStripMenuItem();
            toolStripComboBox1 = new ToolStripComboBox();
            字型色彩ToolStripMenuItem = new ToolStripMenuItem();
            toolStripComboBox2 = new ToolStripComboBox();
            richTextBox1 = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            複製ToolStripMenuItem = new ToolStripMenuItem();
            貼上ToolStripMenuItem = new ToolStripMenuItem();
            剪下ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Microsoft YaHei UI", 10.1946907F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(19, 19);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 檔案ToolStripMenuItem, 項目符號ToolStripMenuItem, 字型大小ToolStripMenuItem, toolStripComboBox1, 字型色彩ToolStripMenuItem, toolStripComboBox2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            檔案ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 開檔ToolStripMenuItem, 存檔ToolStripMenuItem, 清除ToolStripMenuItem, 結束ToolStripMenuItem });
            檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            檔案ToolStripMenuItem.Size = new Size(56, 26);
            檔案ToolStripMenuItem.Text = "檔案";
            // 
            // 開檔ToolStripMenuItem
            // 
            開檔ToolStripMenuItem.Name = "開檔ToolStripMenuItem";
            開檔ToolStripMenuItem.Size = new Size(211, 26);
            開檔ToolStripMenuItem.Text = "開檔";
            開檔ToolStripMenuItem.Click += 開檔ToolStripMenuItem_Click;
            // 
            // 存檔ToolStripMenuItem
            // 
            存檔ToolStripMenuItem.Name = "存檔ToolStripMenuItem";
            存檔ToolStripMenuItem.Size = new Size(211, 26);
            存檔ToolStripMenuItem.Text = "存檔";
            存檔ToolStripMenuItem.Click += 存檔ToolStripMenuItem_Click;
            // 
            // 清除ToolStripMenuItem
            // 
            清除ToolStripMenuItem.Name = "清除ToolStripMenuItem";
            清除ToolStripMenuItem.Size = new Size(211, 26);
            清除ToolStripMenuItem.Text = "清除";
            清除ToolStripMenuItem.Click += 清除ToolStripMenuItem_Click;
            // 
            // 結束ToolStripMenuItem
            // 
            結束ToolStripMenuItem.Name = "結束ToolStripMenuItem";
            結束ToolStripMenuItem.Size = new Size(211, 26);
            結束ToolStripMenuItem.Text = "結束";
            結束ToolStripMenuItem.Click += 結束ToolStripMenuItem_Click;
            // 
            // 項目符號ToolStripMenuItem
            // 
            項目符號ToolStripMenuItem.Name = "項目符號ToolStripMenuItem";
            項目符號ToolStripMenuItem.Size = new Size(88, 26);
            項目符號ToolStripMenuItem.Text = "項目符號";
            項目符號ToolStripMenuItem.Click += 項目符號ToolStripMenuItem_Click;
            // 
            // 字型大小ToolStripMenuItem
            // 
            字型大小ToolStripMenuItem.Name = "字型大小ToolStripMenuItem";
            字型大小ToolStripMenuItem.Size = new Size(88, 26);
            字型大小ToolStripMenuItem.Text = "字型大小";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.BackColor = SystemColors.MenuBar;
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 26);
            // 
            // 字型色彩ToolStripMenuItem
            // 
            字型色彩ToolStripMenuItem.Name = "字型色彩ToolStripMenuItem";
            字型色彩ToolStripMenuItem.Size = new Size(88, 26);
            字型色彩ToolStripMenuItem.Text = "字型色彩";
            // 
            // toolStripComboBox2
            // 
            toolStripComboBox2.BackColor = SystemColors.MenuBar;
            toolStripComboBox2.Name = "toolStripComboBox2";
            toolStripComboBox2.Size = new Size(121, 26);
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 610);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(19, 19);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { 複製ToolStripMenuItem, 貼上ToolStripMenuItem, 剪下ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(105, 70);
            // 
            // 複製ToolStripMenuItem
            // 
            複製ToolStripMenuItem.Name = "複製ToolStripMenuItem";
            複製ToolStripMenuItem.Size = new Size(104, 22);
            複製ToolStripMenuItem.Text = "複製";
            複製ToolStripMenuItem.Click += 複製ToolStripMenuItem_Click;
            // 
            // 貼上ToolStripMenuItem
            // 
            貼上ToolStripMenuItem.Name = "貼上ToolStripMenuItem";
            貼上ToolStripMenuItem.Size = new Size(104, 22);
            貼上ToolStripMenuItem.Text = "貼上";
            貼上ToolStripMenuItem.Click += 貼上ToolStripMenuItem_Click;
            // 
            // 剪下ToolStripMenuItem
            // 
            剪下ToolStripMenuItem.Name = "剪下ToolStripMenuItem";
            剪下ToolStripMenuItem.Size = new Size(104, 22);
            剪下ToolStripMenuItem.Text = "剪下";
            剪下ToolStripMenuItem.Click += 剪下ToolStripMenuItem_Click;
            // 
            // P4
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 610);
            Controls.Add(menuStrip1);
            Controls.Add(richTextBox1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "P4";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 檔案ToolStripMenuItem;
        private ToolStripMenuItem 開檔ToolStripMenuItem;
        private ToolStripMenuItem 存檔ToolStripMenuItem;
        private ToolStripMenuItem 清除ToolStripMenuItem;
        private ToolStripMenuItem 結束ToolStripMenuItem;
        private ToolStripMenuItem 項目符號ToolStripMenuItem;
        private ToolStripMenuItem 字型大小ToolStripMenuItem;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripMenuItem 字型色彩ToolStripMenuItem;
        private ToolStripComboBox toolStripComboBox2;
        private RichTextBox richTextBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 複製ToolStripMenuItem;
        private ToolStripMenuItem 貼上ToolStripMenuItem;
        private ToolStripMenuItem 剪下ToolStripMenuItem;
    }
}
