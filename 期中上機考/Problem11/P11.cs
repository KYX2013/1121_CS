namespace Problem11
{
    public partial class P11 : Form
    {
        public P11()
        {
            InitializeComponent();
        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 清除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Text = String.Empty;
        }

        private void 字型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionFont = fontDialog.Font;
            }
        }

        private void 開啟舊檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void 儲存檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void 前景色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionColor = colorDialog.Color;
            }
        }

        private void 背景色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionBackColor = colorDialog.Color;
            }
        }

        private void 粗體ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox.SelectionFont != null)
            {
                FontStyle fontStyle = FontStyle.Bold;
                if(richTextBox.SelectionFont.Italic)
                    fontStyle = fontStyle | FontStyle.Italic;
                if(richTextBox.SelectionFont.Underline)
                    fontStyle = fontStyle | FontStyle.Underline;

                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, fontStyle);
            }
        }

        private void 斜體ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionFont != null)
            {
                FontStyle fontStyle = FontStyle.Italic;
                if (richTextBox.SelectionFont.Bold)
                    fontStyle = fontStyle | FontStyle.Bold;
                if (richTextBox.SelectionFont.Underline)
                    fontStyle = fontStyle | FontStyle.Underline;

                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, fontStyle);
            }
        }

        private void 字體底線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionFont != null)
            {
                FontStyle fontStyle = FontStyle.Underline;
                if (richTextBox.SelectionFont.Bold)
                    fontStyle = fontStyle | FontStyle.Bold;
                if (richTextBox.SelectionFont.Italic)
                    fontStyle = fontStyle | FontStyle.Italic;

                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, fontStyle);
            }
        }
    }
}
