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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 第一題ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1 p1 = new P1();
            p1.MdiParent = this;
            p1.Text = "第一題";
            p1.Show();
        }

        private void 第二題ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P2 p2 = new P2();
            p2.MdiParent = this;
            p2.Text = "第二題";
            p2.Show();
        }

        private void 第三題ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P3 p3 = new P3();
            p3.MdiParent = this;
            p3.Text = "第三題";
            p3.Show();
        }

        private void 第四題ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P4 p4 = new P4();
            p4.MdiParent = this;
            p4.Text = "第四題";
            p4.Show();
        }

        private void 第五題ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P5 p5 = new P5();
            p5.MdiParent = this;
            p5.Text = "第五題";
            p5.Show();
        }

        private void 第六題ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P6 p6 = new P6();
            p6.MdiParent = this;
            p6.Text = "第六題";
            p6.Show();
        }

        private void 第七題ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P7 p7 = new P7();
            p7.MdiParent = this;
            p7.Text = "第七題";
            p7.Show();
        }

        private void 第八題ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P8 p8 = new P8();
            p8.MdiParent = this;
            p8.Text = "第八題";
            p8.Show();
        }
        private void 第九題ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P9 p9 = new P9();
            p9.MdiParent = this;
            p9.Text = "第九題";
            p9.Show();
        }

        private void 第十題ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P10 p10 = new P10();
            p10.MdiParent = this;
            p10.Text = "第十題";
            p10.Show();
        }

        private void 第十一題ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P11 p11 = new P11();
            p11.MdiParent = this;
            p11.Text = "第十一題";
            p11.Show();
        }

        private void 第十二題ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P12 p12 = new P12();
            p12.MdiParent = this;
            p12.Text = "第十二題";
            p12.Show();
        }
    }
}
