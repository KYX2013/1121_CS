using System.Diagnostics;
using System.Windows.Forms;

namespace Problem3
{
    public partial class P3 : Form
    {
        public P3()
        {
            InitializeComponent();
        }

        private void End_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Again_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            richTextBox1.Text = string.Empty;
            monthCalendar1.SelectionStart = DateTime.Today;
            monthCalendar1.SelectionEnd = DateTime.Today;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            string start = "預購產品如下:\n\n";
            string end1 = "\n指定取貨日期為 ";
            string end2 = " 自行取貨";

            richTextBox1.Text = start;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    richTextBox1.Text += $"\t● {checkedListBox1.Items[i]}\n";
                }
            }

            richTextBox1.Text += end1;
            richTextBox1.Text += $"{monthCalendar1.SelectionStart.ToString("yyyy/MM/dd")} 至 {monthCalendar1.SelectionEnd.ToString("yyyy/MM/dd")}";
            richTextBox1.Text += end2;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Rich Text Format (*.rtf)|*.rtf";
            saveFileDialog1.Title = "儲存RTF檔";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            Again_Click(sender, e);
            openFileDialog1.Filter = "Rich Text Format (*.rtf)|*.rtf";
            openFileDialog1.Title = "開啟RTF檔";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }

            for(int i = 0;i<richTextBox1.Text.Length;i++)
            {
                if (richTextBox1.Text[i] == '●')
                {
                    int idxItem = richTextBox1.Text.IndexOf('\n',i);
                    string item = richTextBox1.Text.Substring(i + 2, idxItem - i - 2);

                    checkedListBox1.SetItemChecked(checkedListBox1.Items.IndexOf(item), true);

                    i = idxItem;
                }
            }

            int idx = richTextBox1.Text.IndexOf("為");
            string strS = richTextBox1.Text.Substring(idx + 2, 10);
            idx = richTextBox1.Text.IndexOf("至");
            string strE = richTextBox1.Text.Substring(idx + 2, 10);

            monthCalendar1.SelectionStart = DateTime.Parse(strS);
            monthCalendar1.SelectionEnd = DateTime.Parse(strE);
        }
    }
}
