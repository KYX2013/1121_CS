using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem7
{
    public partial class P7 : Form
    {
        public P7()
        {
            InitializeComponent();
        }

        private void MyTextChange(object sender, EventArgs e)
        {
            if(txtFront.Text.Length==0 || txtBack.Text.Length == 0 || (comboBox1.SelectedIndex==3 && int.Parse(txtBack.Text)==0))
            {
                answer.Text = "= ERROR!!!";
                return;
            }
            double result = 0;
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    result = double.Parse(txtFront.Text) + double.Parse(txtBack.Text);
                    break;
                case 1:
                    result = double.Parse(txtFront.Text) - double.Parse(txtBack.Text);
                    break;
                case 2:
                    result = double.Parse(txtFront.Text) * double.Parse(txtBack.Text);
                    break;
                case 3:
                    result = double.Parse(txtFront.Text) / double.Parse(txtBack.Text);
                    break;
                default:
                    break;
            }

            answer.Text = "= "+result.ToString();
        }

        private void add_Click(object sender, EventArgs e)
        {
            txtFront.TextChanged += MyTextChange;
            txtBack.TextChanged += MyTextChange;
        }

        private void remove_Click(object sender, EventArgs e)
        {
            txtFront.TextChanged -= MyTextChange;
            txtBack.TextChanged -= MyTextChange;
        }
    }
}
