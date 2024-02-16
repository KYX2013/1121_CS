using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem9
{
    public partial class P9 : Form
    {
        int[] box = {0, 0, 0, 0};
        int total;
        int tick;
        bool init = true;
        public P9()
        {
            InitializeComponent();
            total = 50;
            label_Refresh(true);
            pic_Refresh();
            pictureBox5.Image = imageList2.Images[1];
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();

            for (int i = 0; i < box.Length; i++)
            {
                box[i] = rd.Next(4);
            }

            pic_Refresh();

            tick++;
            if(tick >= 60)
            {
                animTimer.Stop();
                tick = 0;
                pictureBox5.Image = imageList2.Images[1];
                label_Refresh(true);
            }
        }

        private void Animation()
        {
            pictureBox5.Image = imageList2.Images[0];
            animTimer = new Timer();
            animTimer.Interval = 50;
            animTimer.Start();
            animTimer.Tick += Timer_Tick;
        }
        private void CheckAward()
        {
            if (init)
            {
                init = false;
                return;
            }
            int idx = box[0];
            if (box[1]==idx && box[2]==idx && box[3] == idx)
            {
                switch (box[0])
                {
                    case 0:
                        total += int.Parse(UpDown.Text)*6;
                        break;
                    case 1:
                        total += int.Parse(UpDown.Text)*11;
                        break;
                    case 2:
                        total += int.Parse(UpDown.Text)*16;
                        break;
                    case 3:
                        total += int.Parse(UpDown.Text)*21;
                        break;
                }
                label_Refresh(true);
            }
        }
        private void label_Refresh(bool mes)
        {
            label1.Text = "總數量 : " + total.ToString();
            if (total <= 0 && mes)
            {
                MessageBox.Show("遊戲結束!!!重新開始");
                Application.Restart();
            }
        }
        private void pic_Refresh()
        {
            pictureBox1.Image = imageList1.Images[string.Format($"{box[0]}.jpg")];
            pictureBox2.Image = imageList1.Images[string.Format($"{box[1]}.jpg")];
            pictureBox3.Image = imageList1.Images[string.Format($"{box[2]}.jpg")];
            pictureBox4.Image = imageList1.Images[string.Format($"{box[3]}.jpg")];
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            total -= int.Parse(UpDown.Text);
            label_Refresh(false);

            tick = 0;
            Animation();
            CheckAward();
        }
    }
}
