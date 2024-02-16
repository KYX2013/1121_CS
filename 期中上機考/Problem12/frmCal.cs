using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem12
{
    public partial class frmCal : Form
    {
        public frmCal()
        {
            InitializeComponent();
            this.FormClosing += FrmCal_FormClose;
        }

        private void FrmCal_FormClose(object? sender, FormClosingEventArgs e)
        {
            if(!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("請選擇一個選項!");
                e.Cancel = true;
            }
            P12.yearCount = radioButton1.Checked;
        }
    }
}
