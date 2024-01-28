using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 定義Movie會員類別
        class Movie
        {
            public string Name { get; set; }       // 名稱屬性
            public string Path { get; set; }     // 圖片路徑屬性
            public string Detail { get; set; }      // 詳情屬性
            public DateTime Date { get; set; }      // 日期屬性
        }
        class Customer
        {
            public string Name { get; set; }
            public string Watch { get; set; }
            public DateTime Date { get; set; }
        }
        // 建立emp串列物件用來存放Employee物件資料
        List<Movie> movies = new List<Movie>();
        List<Customer> cstms = new List<Customer>();
        // 表單載入時執行
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //  在emp串列物件內放入使用者輸入的Movie物件資料
            movies.Add(new Movie()
            {
                Name = txtName.Text,
                Path = txtPath.Text,
                Detail = txtDetail.Text,
                Date = monthCalendar1.SelectionStart
            });
            MessageBox.Show("電影新增成功");
            // 還原預設值
            txtName.Text = "";
            txtPath.Text = "";
            txtDetail.Text = "";
            monthCalendar1.SetDate(DateTime.Now);
        }
        int lstIdx = 0,cbIdx1=0,cbIdx2=0;
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)   // 判斷是否切換到「上映電影」標籤頁
            {
                for(;cbIdx1<movies.Count;cbIdx1++)
                {
                    comboBox1.Items.Add(movies[cbIdx1].Name);
                }
            }
            else if (tabControl1.SelectedIndex == 2) // 判斷是否切換到「訂票」標籤頁
            {
                for (; cbIdx2 < movies.Count; cbIdx2++)
                {
                    comboBox2.Items.Add(movies[cbIdx2].Name);
                }
            }
            else if (tabControl1.SelectedIndex == 3)  // 判斷是否切換到「訂票資訊」標籤頁
            {
                for (;lstIdx<cstms.Count;lstIdx++)
                {
                    ListViewItem item = new ListViewItem(cstms[lstIdx].Name);
                    item.SubItems.Add(cstms[lstIdx].Date.ToString("yyyy-MM-dd"));
                    item.SubItems.Add(cstms[lstIdx].Watch);
                    listView1.Items.Add(item);
                }
            }
        }

            
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Code to handle the selection change
            // The selected item has changed.
            int select = comboBox1.SelectedIndex;
            label5.Text = string.Format($"電影名稱 : {movies[select].Name}");
            label6.Text = string.Format($"上映日期 : {movies[select].Date.ToString("yyyy / MM / dd")}");
            label7.Text = string.Format($"電影詳情 : {movies[select].Detail}");
            if (System.IO.File.Exists(movies[select].Path))
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(movies[select].Path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading the image: " + ex.Message);
                }
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void book_Click(object sender, EventArgs e)
        {
            int idx = comboBox2.SelectedIndex;
            DateTime tmp = monthCalendar2.SelectionStart;
            if (movies[idx].Date <= tmp)
            {
                cstms.Add(new Customer()
                {
                    Name = textBox2.Text,
                    Watch = movies[idx].Name,
                    Date = monthCalendar2.SelectionStart
                });
                MessageBox.Show("訂票成功");
            }
            else
            {
                MessageBox.Show("日期錯誤，電影未上映");
            }
            textBox2.Text = "";
            comboBox2.SelectedIndex = -1;
            monthCalendar2.SetDate(DateTime.Now);
        }
    }
}
