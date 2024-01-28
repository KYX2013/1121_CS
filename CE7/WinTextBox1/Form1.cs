using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTextBox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] address = new string[] { "台中市臺灣大道三段99號惠中樓6樓",
                "台中市臺灣大道三段99號惠中樓7樓", "台中市豐原區陽明街36號"};
            AutoCompleteStringCollection myAdd = new AutoCompleteStringCollection();
            myAdd.AddRange(address);
            txtAdd.AutoCompleteCustomSource = myAdd;
            txtAdd.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtAdd.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtPage.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtPage.AutoCompleteSource = AutoCompleteSource.FileSystem;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"市府機構：{txtCompany.Text}\n地址：" +
                $"{txtAdd.Text}\n備註：{txtPage.Text}\n網址: {txtWeb.Text}");

            if (!txtCompany.AutoCompleteCustomSource.Contains(txtCompany.Text) && txtCompany.Text.Length>0)
                txtCompany.AutoCompleteCustomSource.Add(txtCompany.Text);
            if(!txtAdd.AutoCompleteCustomSource.Contains(txtAdd.Text) && txtAdd.Text.Length > 0)
                txtAdd.AutoCompleteCustomSource.Add(txtAdd.Text);

            txtAdd.Text = "";
            txtCompany.Text = "";
            txtPage.Text = "";
            txtWeb.Text = "";
        }
    }
}
