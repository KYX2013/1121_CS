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

namespace Problem13
{
    public partial class P6 : Form
    {
        private static Color penClr = Color.Black;
        private static float penPx = 1F;
        private static Bitmap drawbmp;
        private static Graphics drawgh;
        private static Point drawpt;
        private static bool isPen = true;
        private static bool isDrawing = false;
        public P6()
        {
            InitializeComponent();
            drawbmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(drawbmp))
            {
                g.FillRectangle(Brushes.White, 0, 0, drawbmp.Width, drawbmp.Height);
            }
            drawgh = Graphics.FromImage(drawbmp);
            drawgh.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            drawpt = Point.Empty;

            pictureBox1.MouseDown += PictureBox1_MouseDown;
            pictureBox1.MouseMove += PictureBox1_MouseMove;
            pictureBox1.MouseUp += PictureBox1_MouseUp;


            // pxToolStripMenuItem
            for (int i = 1; i <= 10; i++)
            {
                ToolStripMenuItem pxToolStripMenuItem = new ToolStripMenuItem();
                pxToolStripMenuItem.Name = $"pxToolStripMenuItem{i}";
                pxToolStripMenuItem.Size = new Size(114, 26);
                pxToolStripMenuItem.Text = $"{i} px";
                pxToolStripMenuItem.Click += pxToolStripMenuItem_Click;

                畫筆粗細ToolStripMenuItem.DropDownItems.Add(pxToolStripMenuItem);
            }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                if (isPen)
                {
                    using (Pen pen = new Pen(penClr, penPx))
                    {
                        drawgh.DrawLine(pen, drawpt, e.Location);
                        drawpt = e.Location;
                    }

                    pictureBox1.Image = drawbmp;
                }
                else
                {
                    using (Pen pen = new Pen(Color.White, 11))
                    {
                        drawgh.DrawLine(pen, drawpt, e.Location);
                        drawpt = e.Location;
                    }

                    pictureBox1.Image = drawbmp;
                }
            }
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            drawpt = e.Location;
        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 開檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("myPic.jpg");
            drawbmp = new Bitmap(pictureBox1.Image);
            drawgh = Graphics.FromImage(drawbmp);
        }

        private void 存檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image.Save("myPic.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void 清除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.FillRectangle(Brushes.White, 0, 0, bmp.Width, bmp.Height);
            }
            drawbmp = bmp;
            drawgh = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
        }

        private void pxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem px = (ToolStripMenuItem)sender;
            penPx = int.Parse(px.Text.Substring(0, 1));
        }

        private void 黑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            penClr = Color.Black;
        }

        private void 紅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            penClr = Color.Red;
        }

        private void 綠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            penClr = Color.Green;
        }

        private void 藍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            penClr = Color.Blue;
        }

        private void 橡皮擦ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isPen = !isPen;
        }

        private void 黃ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            penClr = Color.Gold;
        }
    }
}
