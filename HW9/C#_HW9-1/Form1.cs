using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace C__HW9_1
{
    public partial class Form1 : Form
    {
        public static int success = 0;
        public static string slnPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
        public static string dir = slnPath+"\\images\\";
        public static Image back = Image.FromFile(slnPath + "\\images\\imgBack.jpg");
        public static Image[] box = new Image[10];
        public static string[] imgDir = new string[5];
        public static int[] order = new int[10];
        public static PictureBox nowShow = null;
        public static bool[] flip = new bool[10];
        private static Random rng = new Random();
        private static bool timerFlag = false;
        public Form1()
        {
            InitializeComponent();
            for(int i = 0; i < imgDir.Length; i++)
            {
                imgDir[i] = dir + string.Format($"{(i+1)}.jpg");
                order[2*i]=i;
                order[2*i+1] = i;
            }

            for (int i = order.Length - 1; i > 0; i--)
            {
                int j = rng.Next(0, i + 1);
                int temp = order[i];
                order[i] = order[j];
                order[j] = temp;
            }

            for (int a  = 0; a < order.Length; a++)
            {
                box[a] = Image.FromFile(imgDir[order[a]]);
                flip[a] = false;
            }
            label1.Text += string.Format($" {success} 組");
            pictureBox1.Image = back;
            pictureBox2.Image = back;
            pictureBox3.Image = back;
            pictureBox4.Image = back;
            pictureBox5.Image = back;
            pictureBox6.Image = back;
            pictureBox7.Image = back;
            pictureBox8.Image = back;
            pictureBox9.Image = back;
            pictureBox10.Image = back;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (timerFlag || flip[0] || (nowShow!=null && nowShow.TabIndex==0)) return;
            pictureBox1.Image = box[0];
            if (nowShow == null)
            {
                nowShow = pictureBox1;
            }
            else
            {
                if (order[nowShow.TabIndex] != order[0])
                {
                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                    timer.Interval = 200;
                    timer.Tick += (s, args) =>
                    {
                        timerFlag = true;
                        nowShow.Image = back;
                        pictureBox1.Image = back;
                        nowShow = null;
                        timer.Stop();
                        timerFlag = false;
                    };
                    timer.Start();
                }
                else
                {
                    flip[nowShow.TabIndex] = true;
                    flip[0] = true;
                    success++;
                    label1.Text = string.Format($"已完成配對: {success} 組");
                    nowShow = null;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (timerFlag || flip[1] || (nowShow!=null && nowShow.TabIndex==1) ) return;
            pictureBox2.Image = box[1];
            if (nowShow == null)
            {
                nowShow = pictureBox2;
            }
            else
            {
                if (order[nowShow.TabIndex] != order[1])
                {
                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                    timer.Interval = 200;
                    timer.Tick += (s, args) =>
                    {
                        timerFlag = true;
                        nowShow.Image = back;
                        pictureBox2.Image = back;
                        nowShow = null;
                        timer.Stop();
                        timerFlag = false;
                    };
                    timer.Start();
                }
                else
                {
                    flip[nowShow.TabIndex] = true;
                    flip[1] = true;
                    success++;
                    label1.Text = string.Format($"已完成配對: {success} 組");
                    nowShow = null;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (timerFlag || flip[2] || (nowShow!=null && nowShow.TabIndex==2) ) return;
            pictureBox3.Image = box[2];
            if (nowShow == null)
            {
                nowShow = pictureBox3;
            }
            else
            {
                if (order[nowShow.TabIndex] != order[2])
                {
                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                    timer.Interval = 200;
                    timer.Tick += (s, args) =>
                    {
                        timerFlag = true;
                        nowShow.Image = back;
                        pictureBox3.Image = back;
                        nowShow = null;
                        timer.Stop();
                        timerFlag = false;
                    };
                    timer.Start();
                }
                else
                {
                    flip[nowShow.TabIndex] = true;
                    flip[2] = true;
                    success++;
                    label1.Text = string.Format($"已完成配對: {success} 組");
                    nowShow = null;
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (timerFlag || flip[3] || (nowShow!=null && nowShow.TabIndex==3) ) return;
            pictureBox4.Image = box[3];
            if (nowShow == null)
            {
                nowShow = pictureBox4;
            }
            else
            {
                if (order[nowShow.TabIndex] != order[3])
                {
                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                    timer.Interval = 200;
                    timer.Tick += (s, args) =>
                    {
                        timerFlag = true;
                        nowShow.Image = back;
                        pictureBox4.Image = back;
                        nowShow = null;
                        timer.Stop();
                        timerFlag = false;
                    };
                    timer.Start();
                }
                else
                {
                    flip[nowShow.TabIndex] = true;
                    flip[3] = true;
                    success++;
                    label1.Text = string.Format($"已完成配對: {success} 組");
                    nowShow = null;
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (timerFlag || flip[4] || (nowShow!=null && nowShow.TabIndex==4) ) return;
            pictureBox5.Image = box[4];
            if (nowShow == null)
            {
                nowShow = pictureBox5;
            }
            else
            {
                if (order[nowShow.TabIndex] != order[4])
                {
                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                    timer.Interval = 200;
                    timer.Tick += (s, args) =>
                    {
                        timerFlag = true;
                        nowShow.Image = back;
                        pictureBox5.Image = back;
                        nowShow = null;
                        timer.Stop();
                        timerFlag = false;
                    };
                    timer.Start();
                }
                else
                {
                    flip[nowShow.TabIndex] = true;
                    flip[4] = true;
                    success++;
                    label1.Text = string.Format($"已完成配對: {success} 組");
                    nowShow = null;
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (timerFlag || flip[5] || (nowShow!=null && nowShow.TabIndex==5) ) return;
            pictureBox6.Image = box[5];
            if (nowShow == null)
            {
                nowShow = pictureBox6;
            }
            else
            {
                if (order[nowShow.TabIndex] != order[5])
                {
                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                    timer.Interval = 200;
                    timer.Tick += (s, args) =>
                    {
                        timerFlag = true;
                        nowShow.Image = back;
                        pictureBox6.Image = back;
                        nowShow = null;
                        timer.Stop();
                        timerFlag = false;
                    };
                    timer.Start();
                }
                else
                {
                    flip[nowShow.TabIndex] = true;
                    flip[5] = true;
                    success++;
                    label1.Text = string.Format($"已完成配對: {success} 組");
                    nowShow = null;
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (timerFlag || flip[6] || (nowShow!=null && nowShow.TabIndex==6) ) return;
            pictureBox7.Image = box[6];
            if (nowShow == null)
            {
                nowShow = pictureBox7;
            }
            else
            {
                if (order[nowShow.TabIndex] != order[6])
                {
                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                    timer.Interval = 200;
                    timer.Tick += (s, args) =>
                    {
                        timerFlag = true;
                        nowShow.Image = back;
                        pictureBox7.Image = back;
                        nowShow = null;
                        timer.Stop();
                        timerFlag = false;
                    };
                    timer.Start();
                }
                else
                {
                    flip[nowShow.TabIndex] = true;
                    flip[6] = true;
                    success++;
                    label1.Text = string.Format($"已完成配對: {success} 組");
                    nowShow = null;
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (timerFlag || flip[7] || (nowShow!=null && nowShow.TabIndex==7) ) return;
            pictureBox8.Image = box[7];
            if (nowShow == null)
            {
                nowShow = pictureBox8;
            }
            else
            {
                if (order[nowShow.TabIndex] != order[7])
                {
                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                    timer.Interval = 200;
                    timer.Tick += (s, args) =>
                    {
                        timerFlag = true;
                        nowShow.Image = back;
                        pictureBox8.Image = back;
                        nowShow = null;
                        timer.Stop();
                        timerFlag = false;
                    };
                    timer.Start();
                }
                else
                {
                    flip[nowShow.TabIndex] = true;
                    flip[7] = true;
                    success++;
                    label1.Text = string.Format($"已完成配對: {success} 組");
                    nowShow = null;
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (timerFlag || flip[8] || (nowShow!=null && nowShow.TabIndex==8) ) return;
            pictureBox9.Image = box[8];
            if (nowShow == null)
            {
                nowShow = pictureBox9;
            }
            else
            {
                if (order[nowShow.TabIndex] != order[8])
                {
                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                    timer.Interval = 200;
                    timer.Tick += (s, args) =>
                    {
                        timerFlag = true;
                        nowShow.Image = back;
                        pictureBox9.Image = back;
                        nowShow = null;
                        timer.Stop();
                        timerFlag = false;
                    };
                    timer.Start();
                }
                else
                {
                    flip[nowShow.TabIndex] = true;
                    flip[8] = true;
                    success++;
                    label1.Text = string.Format($"已完成配對: {success} 組");
                    nowShow = null;
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (timerFlag || flip[9] || (nowShow!=null && nowShow.TabIndex==9) ) return;
            pictureBox10.Image = box[9];
            if (nowShow == null)
            {
                nowShow = pictureBox10;
            }
            else
            {
                if (order[nowShow.TabIndex] != order[9])
                {
                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                    timer.Interval = 200;
                    timer.Tick += (s, args) =>
                    {
                        timerFlag = true;
                        nowShow.Image = back;
                        pictureBox10.Image = back;
                        nowShow = null;
                        timer.Stop();
                        timerFlag = false;
                    };
                    timer.Start();
                }
                else
                {
                    flip[nowShow.TabIndex] = true;
                    flip[9] = true;
                    success++;
                    label1.Text = string.Format($"已完成配對: {success} 組");
                    nowShow = null;
                }
            }
        }

        private void restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
