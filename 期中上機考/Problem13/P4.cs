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
            string[] clrs = { "黑", "紅", "綠", "藍", "黃", "紫" };
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
                case "黑":
                    richTextBox1.SelectionColor = Color.Black;
                    break;
                case "紅":
                    richTextBox1.SelectionColor = Color.Red;
                    break;
                case "綠":
                    richTextBox1.SelectionColor = Color.Green;
                    break;
                case "藍":
                    richTextBox1.SelectionColor = Color.Blue;
                    break;
                case "黃":
                    richTextBox1.SelectionColor = Color.Yellow;
                    break;
                case "紫":
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

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 清除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void 開檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("GOTOP.rtf", RichTextBoxStreamType.RichText);
        }

        private void 存檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile("GOTOP.rtf", RichTextBoxStreamType.RichText);
        }

        private void 項目符號ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = !richTextBox1.SelectionBullet;
        }

        private void 複製ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void 貼上ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void 剪下ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
    }
}
