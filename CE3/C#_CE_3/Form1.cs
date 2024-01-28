using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__CE_3
{
    public partial class Form1 : Form
    {
        struct member
        {
            public member(string s1, string s2)
            {
                name = s1;
                password = s2;
            }
            public string name;
            public string password;
        }
        member[] record;

        public Form1()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            member tmp = new member(username.Text,password.Text);
            
            if (record==null)
            {
                record = new member[1] { tmp };
            }
            else{
                var lsts = record.ToList();
                record = lsts.Append(tmp).ToArray();
            }
            MessageBox.Show("註冊成功");
            username.Text = "";
            password.Text = "";
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (record==null)
                MessageBox.Show("登入失敗");
            else {
                bool find = false;
                for (int i = 0; i < record.Length; i++)
                {
                    if (record[i].name == username.Text)
                    {
                        if (record[i].password == password.Text)
                        {
                            MessageBox.Show("登入成功");
                            find = true;
                        }
                        else
                            break;
                    }
                }
                if (!find)
                    MessageBox.Show("登入失敗");
            }
            username.Text = "";
            password.Text = "";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
