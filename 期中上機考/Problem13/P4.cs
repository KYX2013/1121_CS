using System.Diagnostics;
using System.Windows.Forms;

namespace Problem13
{
    public partial class P4 : Form
    {
        public P4()
        {
            InitializeComponent();
            int[] fonts = { 9, 10, 12, 14, 16, 18, 20, 24, 28 };
            for (int i = 0; i < fonts.Length; i++)
            {
                toolStripComboBox1.Items.Add(fonts[i]);
            }
            toolStripComboBox1.SelectedIndexChanged += ToolStripComboBox1_Update;
            string[] clrs = { "��", "��", "��", "��", "��", "��" };
            for (int i = 0; i < clrs.Length; i++)
            {
                toolStripComboBox2.Items.Add(clrs[i]);
            }
            toolStripComboBox2.SelectedIndexChanged += ToolStripComboBox2_Update;

            richTextBox1.MouseDown += RichTextBox1_Mouse;
        }

        private void RichTextBox1_Mouse(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(richTextBox1,e.Location);
            }
        }

        private void ToolStripComboBox2_Update(object? sender, EventArgs e)
        {
            richTextBox1.Focus();
            switch (toolStripComboBox2.Items[toolStripComboBox2.SelectedIndex])
            {
                case "��":
                    richTextBox1.SelectionColor = Color.Black;
                    break;
                case "��":
                    richTextBox1.SelectionColor = Color.Red;
                    break;
                case "��":
                    richTextBox1.SelectionColor = Color.Green;
                    break;
                case "��":
                    richTextBox1.SelectionColor = Color.Blue;
                    break;
                case "��":
                    richTextBox1.SelectionColor = Color.Yellow;
                    break;
                case "��":
                    richTextBox1.SelectionColor = Color.Purple;
                    break;
                default:
                    break;
            }
        }

        private void ToolStripComboBox1_Update(object? sender, EventArgs e)
        {
            richTextBox1.Focus();
            richTextBox1.SelectionFont = new Font("Microsoft JhengHei UI", int.Parse(toolStripComboBox1.Text));
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void �M��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void �}��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("GOTOP.rtf", RichTextBoxStreamType.RichText);
        }

        private void �s��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile("GOTOP.rtf", RichTextBoxStreamType.RichText);
        }

        private void ���زŸ�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = !richTextBox1.SelectionBullet;
        }

        private void �ƻsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void �K�WToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void �ŤUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
    }
}
