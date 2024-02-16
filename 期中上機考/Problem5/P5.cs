using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem5
{
    struct Movie
    {
        public string _name;
        public string _description;
        public string _picPath;
        public DateTime _dateStart;
        public DateTime _dateEnd;
        public Movie(string name, string description, string picPath, DateTime dateS, DateTime dateE)
        {
            _name = name;
            _description = description;
            _picPath = picPath;
            _dateStart = dateS;
            _dateEnd = dateE;
        }
    }
    public partial class P5 : Form
    {
        List<Movie> MovieList = new List<Movie>();
        public P5()
        {
            InitializeComponent();
            txtPath.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtPath.AutoCompleteSource = AutoCompleteSource.FileSystem;
            tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            lbName.Text = comboBox1.Items[index].ToString();
            lbInfo.Text = $"上映時間  {MovieList[index]._dateStart.ToString("yyyy/MM/dd")} ~ {MovieList[index]._dateEnd.ToString("yyyy/MM/dd")}" +
                $"\n詳情:";
            textBox1.Text = MovieList[index]._description;

            try
            {
                pictureBox1.Image = Image.FromFile(MovieList[index]._picPath);
            }
            catch (Exception ex)
            {
                pictureBox1.Image=null;
                Debug.WriteLine(ex.Message);
            }
        }


        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < MovieList.Count; i++)
            {
                comboBox1.Items.Add(MovieList[i]._name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie(txtName.Text,txtInfo.Text,txtPath.Text,monthCalendar1.SelectionStart,monthCalendar1.SelectionEnd);
            MovieList.Add(movie);
        }
    }
}
