using System.Diagnostics;

namespace Problem13
{
    public partial class P12 : Form
    {
        public static bool yearCount = true;
        public P12()
        {
            InitializeComponent();
            lblShow.Text = string.Empty;
        }

        private static int n;
        private static double percentage;
        private static int origin;

        private void tryCal_Click(object sender, EventArgs e)
        {
            if (txtYear.Text.Length == 0 || txtPerc.Text.Length == 0 || txtDoll.Text.Length == 0)
            {
                MessageBox.Show("請完整填寫資料!");
                return;
            }
            else if(!int.TryParse(txtYear.Text, out n) || !double.TryParse(txtPerc.Text,out percentage) || !int.TryParse(txtDoll.Text,out origin))
            {
                MessageBox.Show("請輸入正確的數值資料!");
                return;
            }

            percentage /= 100;

            frmCal frmCal = new frmCal();
            frmCal.ShowDialog();

            if (yearCount)
            {
                double total = origin * Math.Pow(1 + percentage, n);
                lblShow.Text = $"{n} 年後領回本利和 : {Math.Floor(total)}";
            }
            else
            {
                double total = origin * Math.Pow(1 + (percentage / 12), n * 12);
                lblShow.Text = $"{n} 年後領回本利和 : {Math.Floor(total)}";
            }
        }

        private void calculator_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }
    }
}
