using System.Diagnostics;
using System.Globalization;

namespace Problem1
{
    struct Student
    {
        public string _id;
        public DateTime _birth;
        public bool _gender;
        public string _club;

        public Student(string id, DateTime birth, bool gender, string club)
        {
            _id = id;
            _birth = birth;
            _gender = gender;
            _club = club;
        }

        public void print(string name)
        {
            Debug.WriteLine("學生資料:\n姓名:{0}\n學號:{1}\n生日:{2}\n性別:{3}\n社團:{4}", name, _id, _birth.ToString("yyyy-MM-dd"), ((_gender) ? "女" : "男"), _club);
        }
    }
    public partial class Form1 : Form
    {
        private static SortedList<string, Student> data = new SortedList<string, Student>();
        private static string[] clubs = new string[] { "管樂隊", "啦啦隊", "服務隊", "電研社", "演辯社", "其他"};
        public Form1()
        {
            InitializeComponent();
            Club.DataSource = clubs;
            for (int i = DateTime.Now.Year; i >= 1900; i--)
            {
                BirthYear.Items.Add(i.ToString());
            }
            for(int i = 1;i<=12;i++)
            {
                BirthMon.Items.Add(i.ToString());
            }
            for(int i = 1; i <= 31; i++)
            {
                BirthDay.Items.Add(i.ToString());
            }
            BirthYear.SelectedIndex = 0;
            BirthMon.SelectedIndex = 0;
            BirthDay.SelectedIndex = 0;
        }
        private void End_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool CheckId(string id)
        {
            if(id.Length != 9)
                return false;
            int idx = (int)id[0];
            if (idx > 90 || idx < 65)
                return false;
            string no = id.Substring(1);
            if(!int.TryParse(no, out idx))
                return false;
            return true;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            //deal with birthday
            DateTime dt = new DateTime();
            try
            {
                dt = new DateTime(year: int.Parse(BirthYear.Text), month: int.Parse(BirthMon.Text), day: int.Parse(BirthDay.Text));
            }
            catch(ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("生日有誤!!!");
                return;
            }
            catch (Exception ex)
            {
                return;
            }

            //deal with other info
            if (StudentName.Text == "")
            {
                MessageBox.Show("請輸入姓名!!");
                return;
            }
            else if (data.ContainsKey(StudentName.Text))
            {
                MessageBox.Show("資料已存在!!");
                ClearTxt();
                return;
            }
            else if(!CheckId(Id.Text))
            {
                MessageBox.Show("學號有誤!!");
                return;
            }

            //
            Student nu = new Student(Id.Text,dt,(radioButton2.Checked),Club.Text);
            data.Add(StudentName.Text, nu);
            nu.print(StudentName.Text);
            Debug.WriteLine($"\n資料總筆數:{data.Count}");

            Id.Items.Add(nu._id);
            StudentName.Items.Add(StudentName.Text);

            MessageBox.Show("新增成功!!");
            ClearTxt();
        }

        private void ClearTxt()
        {
            Id.Text = "";
            StudentName.Text = "";
            BirthYear.SelectedIndex = 0;
            BirthMon.SelectedIndex = 0;
            BirthDay.SelectedIndex = 0;
            Club.SelectedIndex = 0;
        }
    }
}
