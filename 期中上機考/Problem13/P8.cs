using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem13
{
    public partial class P8 : Form
    {
        Point origin = new Point();
        public P8()
        {
            InitializeComponent();
            origin.X = pictureBox1.Left;
            origin.Y = pictureBox1.Top;

            this.KeyDown += Form1_Key;
            pictureBox1.Image = imageList1.Images[0];
            cordi_Update();
        }
        private void cordi_Update()
        {
            xLabel.Text = $"X座標 : {pictureBox1.Location.X - origin.X}";
            yLabel.Text = $"Y座標 : {pictureBox1.Location.Y - origin.Y}";
        }

        private void Form1_Key(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.W:
                    pictureBox1.Image = imageList1.Images["AP90.png"];
                    pictureBox1.Location = new Point(pictureBox1.Left, pictureBox1.Top-5);
                    cordi_Update();
                    break;
                case Keys.E:
                    pictureBox1.Image = imageList1.Images["AP45.png"];
                    pictureBox1.Location = new Point(pictureBox1.Left + 5, pictureBox1.Top - 5);
                    cordi_Update();
                    break;
                case Keys.D:
                    pictureBox1.Image = imageList1.Images["AP0.png"];
                    pictureBox1.Location = new Point(pictureBox1.Left + 5, pictureBox1.Top);
                    cordi_Update();
                    break;
                case Keys.X:
                    pictureBox1.Image = imageList1.Images["AP315.png"];
                    pictureBox1.Location = new Point(pictureBox1.Left + 5, pictureBox1.Top+5);
                    cordi_Update();
                    break;
                case Keys.S:
                    pictureBox1.Image = imageList1.Images["AP270.png"];
                    pictureBox1.Location = new Point(pictureBox1.Left, pictureBox1.Top + 5);
                    cordi_Update();
                    break;
                case Keys.Z:
                    pictureBox1.Image = imageList1.Images["AP225.png"];
                    pictureBox1.Location = new Point(pictureBox1.Left - 5, pictureBox1.Top + 5);
                    cordi_Update();
                    break;
                case Keys.A:
                    pictureBox1.Image = imageList1.Images["AP180.png"];
                    pictureBox1.Location = new Point(pictureBox1.Left - 5, pictureBox1.Top);
                    cordi_Update();
                    break;
                case Keys.Q:
                    pictureBox1.Image = imageList1.Images["AP135.png"];
                    pictureBox1.Location = new Point(pictureBox1.Left -5, pictureBox1.Top-5);
                    cordi_Update();
                    break;
                default: break;
            }
        }
    }
}
