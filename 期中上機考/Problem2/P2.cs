namespace Problem2
{
    public partial class P2 : Form
    {
        private static string oriInfo = "�п�� 6 �Ӹ��X�� 1 �ӯS�O��!";
        public P2()
        {
            InitializeComponent();
            info.Text = oriInfo;
            for (int i = 1; i <= 38; i++)
            {
                pcLot1.Items.Add(i.ToString());
            }
            for (int i = 1; i <= 8; i++)
            {
                pcLot2.Items.Add(i.ToString());
            }
        }
        private int count(CheckedListBox clb)
        {
            int sum = 0;
            for (int i = 0; i < clb.Items.Count; i++)
            {
                if (clb.GetItemChecked(i))
                    sum++;
            }
            return sum;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pcLot1.Items.Count; i++)
            {
                pcLot1.SetItemChecked(i, false);
            }
            for (int i = 0; i < pcLot2.Items.Count; i++)
            {
                pcLot2.SetItemChecked(i, false);
            }
            info.Text = oriInfo;
        }

        private static string winInfo = "���ߧA���j���F�K";
        private static string failInfo = "�S���A�ЦA���A�F�K";

        private void claim_Click(object sender, EventArgs e)
        {
            //Check Choosed number
            if(count(pcLot1)!=6 ||  count(pcLot2)!=1)
            {
                MessageBox.Show(oriInfo);
                return;
            }

            //generate award number
            Random rnd = new Random();
            List<int> six = new List<int>();
            List<int> pool = new List<int>();
            for(int i=1;i<=38;i++)
                pool.Add(i);
            for(int i =0; i < 6; i++)
            {
                int idx = rnd.Next(pool.Count);
                six.Add(pool[idx]);
                pool.RemoveAt(idx);
            }
            int special = rnd.Next(1,9);

            info.Text = "�������X:\n";
            foreach(int i in six)
                info.Text += i.ToString()+", ";
            info.Text += "�S�O��: "+special.ToString()+"\n";

            //Get Choosed Number
            List<int> pick = new List<int>();
            int pickS = new int();

            for(int i = 0; i < pcLot1.Items.Count; i++)
            {
                if(pcLot1.GetItemChecked(i))
                {
                    pick.Add(i);
                }
            }
            for(int i = 0;i<pcLot2.Items.Count;i++)
            {
                if (pcLot2.GetItemChecked(i))
                {
                    pickS = i;
                    break;
                }
            }


            //Claim Price
            if (pickS != special)
                info.Text += failInfo;
            else if (!eql(pick, six))
                info.Text += failInfo;
            else
                info.Text += winInfo;
        }

        private static bool eql(List<int> l1, List<int> l2)
        {
            foreach(int i in l1)
            {
                if(!l2.Contains(i))
                    return false;
            }
            return true;
        }
    }
}
