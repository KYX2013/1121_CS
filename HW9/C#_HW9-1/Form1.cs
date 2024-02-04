using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__HW9_1
{
    public partial class Form1 : Form
    {
        public static int success = 0;
        public static Image back;
        public static List<Image> imgs = new List<Image>();
        public static List<int> order = new List<int>();
        public static PictureBox nowShow;
        private static Random rng = new Random();
        private static bool flip = false;
        public Form1()
        {
            InitializeComponent();

            back = imageList1.Images["imgBack.jpg"];

            for(int i = 0; i < 5; i++)
            {
                imgs.Add(imageList1.Images[string.Format($"{(i+1)}.jpg")]);
                order.Add(i+1);
                order.Add(i+1);
            }

            for (int i = order.Count - 1; i > 0; i--)
            {
                int j = rng.Next(0, i + 1);
                int temp = order[i];
                order[i] = order[j];
                order[j] = temp;
            }

            label1.Text += string.Format($" {success} 組");

            for(int a = 0;a < 10; a++)
            {
                PictureBox p = new PictureBox();
                p.Size = new Size(144, 180);
                p.Location = new Point(35+170*(a%5),100+250*(a/5));
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                p.BackColor = Color.Transparent;
                p.BackgroundImage = back;
                p.Name = a.ToString();
                p.Click += P_Click;

                this.Controls.Add(p);
            }
        }

        private async void P_Click(object sender, EventArgs e)
        {
            if (flip) return;
            flip = true;

            PictureBox pictureBox = (PictureBox)sender;
            if (nowShow == null)
            {
                nowShow = pictureBox;
                nowShow.Image = imageList1.Images[$"{order[int.Parse(nowShow.Name)]}.jpg"];
            }
            else
            {
                if (nowShow.Name == pictureBox.Name)
                    return;
                else if (order[int.Parse(nowShow.Name)] == order[int.Parse(pictureBox.Name)])
                {
                    success++;
                    label1.Text = $"已完成配對 {success} 組";
                    pictureBox.Image = imageList1.Images[$"{order[int.Parse(pictureBox.Name)]}.jpg"];
                    nowShow = null;
                    if (success == 5)
                        MessageBox.Show("成功!!!!");
                }
                else
                {
                    pictureBox.Image = imageList1.Images[$"{order[int.Parse(pictureBox.Name)]}.jpg"];
                    await Task.Delay(1000);
                    pictureBox.Image = null;
                    nowShow.Image = null;
                    nowShow = null;
                }
            }

            flip = false;
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
