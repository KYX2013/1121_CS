namespace Problem11
{
    public partial class P11 : Form
    {
        public P11()
        {
            InitializeComponent();
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void �M��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Text = String.Empty;
        }

        private void �r��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionFont = fontDialog.Font;
            }
        }

        private void �}������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void �x�s�ɮ�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void �e����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionColor = colorDialog.Color;
            }
        }

        private void �I����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionBackColor = colorDialog.Color;
            }
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void �r�驳�uToolStripMenuItem_Click(object sender, EventArgs e)
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
