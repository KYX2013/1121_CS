using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem10
{
    public partial class P10 : Form
    {
        private static List<int> order = new List<int>();
        private static Dictionary<string,bool> flip = new Dictionary<string, bool>();
        public P10()
        {
            InitializeComponent();

            int picWid = (panel1.Width-20) / 4;
            int picHei = (panel1.Height-10) / 2;
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0;j < 2;j++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(picWid,picHei);
                    pictureBox.Location = new Point(i * (picWid+5), j * (picHei+5));
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.BackColor = Color.Transparent;
                    pictureBox.BackgroundImage = imageList1.Images["q.jpg"];
                    pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox.Name = (order.Count).ToString();
                    pictureBox.Click += PictureBox_Click;

                    panel1.Controls.Add(pictureBox);
                    order.Add(i+1);
                    flip.Add(pictureBox.Name,false);
                }
            }
            shuffle();
        }

        PictureBox hold;
        private static int match = 0;

        private async void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            if(hold == null)
            {
                hold = p;
                hold.Image = imageList1.Images[$"{order[int.Parse(hold.Name)]}.jpg"];
            }
            else
            {
                if (p.Name == hold.Name)
                    return;
                else if((flip[hold.Name] || flip[p.Name]))
                {
                    hold = null;
                    return;
                }

                if (order[int.Parse(p.Name)] == order[int.Parse(hold.Name)])
                {
                    p.Image = imageList1.Images[$"{order[int.Parse(p.Name)]}.jpg"];
                    flip[hold.Name] = true;
                    flip[p.Name] = true;
                    hold = null;
                    match++;
                    if (!flip.Values.Contains(false))
                    {
                        MessageBox.Show("成功配對所有組合!!!");
                    }
                }
                else
                {
                    p.Image = imageList1.Images[$"{order[int.Parse(p.Name)]}.jpg"];
                    await Task.Delay(500);
                    hold.Image = null;
                    hold = null;
                    p.Image = null;
                }
            }
        }

        private void shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int i1 = rand.Next(order.Count);
                int i2 = rand.Next(order.Count);

                int tmp = order[i1];
                order[i1] = order[i2];
                order[i2] = tmp;
            }
        }
        private void Game_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("時間到，遊戲結束");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showPic(3000);

            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 50000;
            timer1.Tick += Game_Tick;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showPic(8000);

            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 50000;
            timer1.Tick += Game_Tick;
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showPic(12000);

            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 50000;
            timer1.Tick += Game_Tick;
            timer1.Start();
        }

        private async void showPic(int i)
        {
            foreach (Control c in panel1.Controls)
            {
                if (c is PictureBox)
                {
                    PictureBox p = c as PictureBox;
                    p.Image = imageList1.Images[$"{order[int.Parse(p.Name)]}.jpg"];
                }
            }

            await Task.Delay(i);
            HidePic();
        }
        private void HidePic()
        {
            foreach(Control c in panel1.Controls)
            {
                if (c is PictureBox)
                {
                    PictureBox p = c as PictureBox;
                    p.Image = null;
                }
            }
        }
    }
}
