using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Theme_menu : Form
    {
        public Theme_menu()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            foreach(Control control in this.Controls)
            {
                if(control is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        frmMain.themeID = rb.TabIndex+1;
                        break;
                    }
                }
            }
            this.Close();
        }
    }
}
