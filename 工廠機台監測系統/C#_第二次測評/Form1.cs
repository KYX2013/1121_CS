using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace C__第二次測評
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnGreen.CheckedChanged += Green_cc;
            btnYellow.CheckedChanged += Yellow_cc;
            btnRed.CheckedChanged += Red_cc;
            btnCyan.CheckedChanged += Cyan_cc;
            btnGray.CheckedChanged += Gray_cc;
        }
        GroupBox current;
        private static bool gp1_load = false;
        private static List<Machine> exist = new List<Machine>();
        private void Green_cc(object sender, EventArgs e)
        {
            string thisCon = "正常生產";
            if(btnGreen.Checked)
            {
                int cnt = 0;
                foreach(Machine m in exist)
                {
                    if (m.condi == thisCon && cnt==0)
                    {
                        cnt++;
                        float val7 = (float)(m.real*100 / ((m.nowTime - m.startTime).TotalSeconds / m.duration)), 
                            val8 = 0.0F, val9 = (float)((m.nowTime - m.startTime).TotalSeconds * 100 / m.duration);
                        if (m.real != 0)
                            val8 = (float)(m.good * 100 / m.real);
                        panel1_0.Text = "機台型號"+m.name;
                        panel1_1.Text = m.condi;
                        panel1_1.BackColor = Color.Green;
                        panel1_1.ForeColor = Color.Black;
                        panel1_2.Text = m.zhiling;
                        panel1_3.Text = m.startTime.ToString("HH:mm:ss");
                        panel1_4.Text = m.target.ToString();
                        panel1_5.Text = m.real.ToString();
                        panel1_6.Text = ((float)m.real*100/m.target).ToString()+"%";
                        panel1_7.Text = val7.ToString()+"%";
                        panel1_8.Text = val8.ToString()+"%";
                        panel1_9.Text = val9.ToString() +"%";
                        panel1_10.Text = (val7*val8*val9).ToString();
                        pictureBox1.Image = imageList1.Images[$"{m.name[0]}.png"];
                    }
                    else if (m.condi == thisCon && cnt == 1)
                    {
                        cnt++;
                        float val7 = (float)(m.real * 100 / ((m.nowTime - m.startTime).TotalSeconds / m.duration)),
                            val8 = 0.0F, val9 = (float)((m.nowTime - m.startTime).TotalSeconds * 100 / m.duration);
                        if (m.real != 0)
                            val8 = (float)(m.good * 100 / m.real);
                        panel2_0.Text = "機台型號" + m.name;
                        panel2_1.Text = m.condi;
                        panel2_1.BackColor = Color.Green;
                        panel2_1.ForeColor = Color.Black;
                        panel2_2.Text = m.zhiling;
                        panel2_3.Text = m.startTime.ToString("HH:mm:ss");
                        panel2_4.Text = m.target.ToString();
                        panel2_5.Text = m.real.ToString();
                        panel2_6.Text = ((float)m.real * 100 / m.target).ToString() + "%";
                        panel2_7.Text = val7.ToString() + "%";
                        panel2_8.Text = val8.ToString() + "%";
                        panel2_9.Text = val9.ToString() + "%";
                        panel2_10.Text = (val7 * val8 * val9).ToString();
                        pictureBox2.Image = imageList1.Images[$"{m.name[0]}.png"];
                    }
                    else if (m.condi == thisCon && cnt == 2)
                    {
                        cnt++;
                        float val7 = (float)(m.real * 100 / ((m.nowTime - m.startTime).TotalSeconds / m.duration)),
                            val8 = 0.0F, val9 = (float)((m.nowTime - m.startTime).TotalSeconds * 100 / m.duration);
                        if (m.real != 0)
                            val8 = (float)(m.good * 100 / m.real);
                        panel3_0.Text = "機台型號" + m.name;
                        panel3_1.Text = m.condi;
                        panel3_1.BackColor = Color.Green;
                        panel3_1.ForeColor = Color.Black;
                        panel3_2.Text = m.zhiling;
                        panel3_3.Text = m.startTime.ToString("HH:mm:ss");
                        panel3_4.Text = m.target.ToString();
                        panel3_5.Text = m.real.ToString();
                        panel3_6.Text = ((float)m.real * 100 / m.target).ToString() + "%";
                        panel3_7.Text = val7.ToString() + "%";
                        panel3_8.Text = val8.ToString() + "%";
                        panel3_9.Text = val9.ToString() + "%";
                        panel3_10.Text = (val7 * val8 * val9).ToString();
                        pictureBox3.Image = imageList1.Images[$"{m.name[0]}.png"];
                    }

                    if (cnt >= 3)
                        break;
                }
            }
        }
        private void Yellow_cc(object sender, EventArgs e)
        {
            string thisCon = "待料中";
            if (btnYellow.Checked)
            {
                int cnt = 0;
                foreach (Machine m in exist)
                {
                    if (m.condi == thisCon && cnt == 0)
                    {
                        cnt++;
                        float val7 = (float)(m.real * 100 / ((m.nowTime - m.startTime).TotalSeconds / m.duration)),
                            val8 = 0.0F, val9 = (float)((m.nowTime - m.startTime).TotalSeconds * 100 / m.duration);
                        if (m.real != 0)
                            val8 = (float)(m.good * 100 / m.real);
                        panel1_0.Text = "機台型號" + m.name;
                        panel1_1.Text = m.condi;
                        panel1_1.BackColor = Color.Yellow;
                        panel1_1.ForeColor = Color.Black;
                        panel1_2.Text = m.zhiling;
                        panel1_3.Text = m.startTime.ToString("HH:mm:ss");
                        panel1_4.Text = m.target.ToString();
                        panel1_5.Text = m.real.ToString();
                        panel1_6.Text = ((float)m.real * 100 / m.target).ToString() + "%";
                        panel1_7.Text = val7.ToString() + "%";
                        panel1_8.Text = val8.ToString() + "%";
                        panel1_9.Text = val9.ToString() + "%";
                        panel1_10.Text = (val7 * val8 * val9).ToString();
                        pictureBox1.Image = imageList1.Images[$"{m.name[0]}.png"];
                    }
                    else if (m.condi == thisCon && cnt == 1)
                    {
                        cnt++;
                        float val7 = (float)(m.real * 100 / ((m.nowTime - m.startTime).TotalSeconds / m.duration)),
                            val8 = 0.0F, val9 = (float)((m.nowTime - m.startTime).TotalSeconds * 100 / m.duration);
                        if (m.real != 0)
                            val8 = (float)(m.good * 100 / m.real);
                        panel2_0.Text = "機台型號" + m.name;
                        panel2_1.Text = m.condi;
                        panel2_1.BackColor = Color.Yellow;
                        panel2_1.ForeColor = Color.Black;
                        panel2_2.Text = m.zhiling;
                        panel2_3.Text = m.startTime.ToString("HH:mm:ss");
                        panel2_4.Text = m.target.ToString();
                        panel2_5.Text = m.real.ToString();
                        panel2_6.Text = ((float)m.real * 100 / m.target).ToString() + "%";
                        panel2_7.Text = val7.ToString() + "%";
                        panel2_8.Text = val8.ToString() + "%";
                        panel2_9.Text = val9.ToString() + "%";
                        panel2_10.Text = (val7 * val8 * val9).ToString();
                        pictureBox2.Image = imageList1.Images[$"{m.name[0]}.png"];
                    }
                    else if (m.condi == thisCon && cnt == 2)
                    {
                        cnt++;
                        float val7 = (float)(m.real * 100 / ((m.nowTime - m.startTime).TotalSeconds / m.duration)),
                            val8 = 0.0F, val9 = (float)((m.nowTime - m.startTime).TotalSeconds * 100 / m.duration);
                        if (m.real != 0)
                            val8 = (float)(m.good * 100 / m.real);
                        panel3_0.Text = "機台型號" + m.name;
                        panel3_1.Text = m.condi;
                        panel3_1.BackColor = Color.Yellow;
                        panel3_1.ForeColor = Color.Black;
                        panel3_2.Text = m.zhiling;
                        panel3_3.Text = m.startTime.ToString("HH:mm:ss");
                        panel3_4.Text = m.target.ToString();
                        panel3_5.Text = m.real.ToString();
                        panel3_6.Text = ((float)m.real * 100 / m.target).ToString() + "%";
                        panel3_7.Text = val7.ToString() + "%";
                        panel3_8.Text = val8.ToString() + "%";
                        panel3_9.Text = val9.ToString() + "%";
                        panel3_10.Text = (val7 * val8 * val9).ToString();
                        pictureBox3.Image = imageList1.Images[$"{m.name[0]}.png"];
                    }

                    if (cnt >= 3)
                        break;
                }
            }
        }
        private void Red_cc(object sender, EventArgs e)
        {
            string thisCon = "故障";
            if (btnRed.Checked)
            {
                int cnt = 0;
                foreach (Machine m in exist)
                {
                    if (m.condi == thisCon && cnt == 0)
                    {
                        cnt++;
                        float val7 = (float)(m.real * 100 / ((m.nowTime - m.startTime).TotalSeconds / m.duration)),
                            val8 = 0.0F, val9 = (float)((m.nowTime - m.startTime).TotalSeconds * 100 / m.duration);
                        if (m.real != 0)
                            val8 = (float)(m.good * 100 / m.real);
                        panel1_0.Text = "機台型號" + m.name;
                        panel1_1.Text = m.condi;
                        panel1_1.BackColor = Color.Red;
                        panel1_1.ForeColor = Color.Black;
                        panel1_2.Text = m.zhiling;
                        panel1_3.Text = m.startTime.ToString("HH:mm:ss");
                        panel1_4.Text = m.target.ToString();
                        panel1_5.Text = m.real.ToString();
                        panel1_6.Text = ((float)m.real * 100 / m.target).ToString() + "%";
                        panel1_7.Text = val7.ToString() + "%";
                        panel1_8.Text = val8.ToString() + "%";
                        panel1_9.Text = val9.ToString() + "%";
                        panel1_10.Text = (val7 * val8 * val9).ToString();
                        pictureBox1.Image = imageList1.Images[$"{m.name[0]}.png"];
                    }
                    else if (m.condi == thisCon && cnt == 1)
                    {
                        cnt++;
                        float val7 = (float)(m.real * 100 / ((m.nowTime - m.startTime).TotalSeconds / m.duration)),
                            val8 = 0.0F, val9 = (float)((m.nowTime - m.startTime).TotalSeconds * 100 / m.duration);
                        if (m.real != 0)
                            val8 = (float)(m.good * 100 / m.real);
                        panel2_0.Text = "機台型號" + m.name;
                        panel2_1.Text = m.condi;
                        panel2_1.BackColor = Color.Red;
                        panel2_1.ForeColor = Color.Black;
                        panel2_2.Text = m.zhiling;
                        panel2_3.Text = m.startTime.ToString("HH:mm:ss");
                        panel2_4.Text = m.target.ToString();
                        panel2_5.Text = m.real.ToString();
                        panel2_6.Text = ((float)m.real * 100 / m.target).ToString() + "%";
                        panel2_7.Text = val7.ToString() + "%";
                        panel2_8.Text = val8.ToString() + "%";
                        panel2_9.Text = val9.ToString() + "%";
                        panel2_10.Text = (val7 * val8 * val9).ToString();
                        pictureBox2.Image = imageList1.Images[$"{m.name[0]}.png"];
                    }
                    else if (m.condi == thisCon && cnt == 2)
                    {
                        cnt++;
                        float val7 = (float)(m.real * 100 / ((m.nowTime - m.startTime).TotalSeconds / m.duration)),
                            val8 = 0.0F, val9 = (float)((m.nowTime - m.startTime).TotalSeconds * 100 / m.duration);
                        if (m.real != 0)
                            val8 = (float)(m.good * 100 / m.real);
                        panel3_0.Text = "機台型號" + m.name;
                        panel3_1.Text = m.condi;
                        panel3_1.BackColor = Color.Red;
                        panel3_1.ForeColor = Color.Black;
                        panel3_2.Text = m.zhiling;
                        panel3_3.Text = m.startTime.ToString("HH:mm:ss");
                        panel3_4.Text = m.target.ToString();
                        panel3_5.Text = m.real.ToString();
                        panel3_6.Text = ((float)m.real * 100 / m.target).ToString() + "%";
                        panel3_7.Text = val7.ToString() + "%";
                        panel3_8.Text = val8.ToString() + "%";
                        panel3_9.Text = val9.ToString() + "%";
                        panel3_10.Text = (val7 * val8 * val9).ToString();
                        pictureBox3.Image = imageList1.Images[$"{m.name[0]}.png"];
                    }

                    if (cnt >= 3)
                        break;
                }
            }
        }
        private void Cyan_cc(object sender, EventArgs e)
        {
            string thisCon = "維修中";
            if (btnCyan.Checked)
            {
                int cnt = 0;
                foreach (Machine m in exist)
                {
                    if (m.condi == thisCon && cnt == 0)
                    {
                        cnt++;
                        float val7 = (float)(m.real * 100 / ((m.nowTime - m.startTime).TotalSeconds / m.duration)),
                            val8 = 0.0F, val9 = (float)((m.nowTime - m.startTime).TotalSeconds * 100 / m.duration);
                        if (m.real != 0)
                            val8 = (float)(m.good * 100 / m.real);
                        panel1_0.Text = "機台型號" + m.name;
                        panel1_1.Text = m.condi;
                        panel1_1.BackColor = Color.Cyan;
                        panel1_1.ForeColor = Color.Black;
                        panel1_2.Text = m.zhiling;
                        panel1_3.Text = m.startTime.ToString("HH:mm:ss");
                        panel1_4.Text = m.target.ToString();
                        panel1_5.Text = m.real.ToString();
                        panel1_6.Text = ((float)m.real * 100 / m.target).ToString() + "%";
                        panel1_7.Text = val7.ToString() + "%";
                        panel1_8.Text = val8.ToString() + "%";
                        panel1_9.Text = val9.ToString() + "%";
                        panel1_10.Text = (val7 * val8 * val9).ToString();
                        pictureBox1.Image = imageList1.Images[$"{m.name[0]}.png"];
                    }
                    else if (m.condi == thisCon && cnt == 1)
                    {
                        cnt++;
                        float val7 = (float)(m.real * 100 / ((m.nowTime - m.startTime).TotalSeconds / m.duration)),
                            val8 = 0.0F, val9 = (float)((m.nowTime - m.startTime).TotalSeconds * 100 / m.duration);
                        if (m.real != 0)
                            val8 = (float)(m.good * 100 / m.real);
                        panel2_0.Text = "機台型號" + m.name;
                        panel2_1.Text = m.condi;
                        panel2_1.BackColor = Color.Cyan;
                        panel2_1.ForeColor = Color.Black;
                        panel2_2.Text = m.zhiling;
                        panel2_3.Text = m.startTime.ToString("HH:mm:ss");
                        panel2_4.Text = m.target.ToString();
                        panel2_5.Text = m.real.ToString();
                        panel2_6.Text = ((float)m.real * 100 / m.target).ToString() + "%";
                        panel2_7.Text = val7.ToString() + "%";
                        panel2_8.Text = val8.ToString() + "%";
                        panel2_9.Text = val9.ToString() + "%";
                        panel2_10.Text = (val7 * val8 * val9).ToString();
                        pictureBox2.Image = imageList1.Images[$"{m.name[0]}.png"];
                    }
                    else if (m.condi == thisCon && cnt == 2)
                    {
                        cnt++;
                        float val7 = (float)(m.real * 100 / ((m.nowTime - m.startTime).TotalSeconds / m.duration)),
                            val8 = 0.0F, val9 = (float)((m.nowTime - m.startTime).TotalSeconds * 100 / m.duration);
                        if (m.real != 0)
                            val8 = (float)(m.good * 100 / m.real);
                        panel3_0.Text = "機台型號" + m.name;
                        panel3_1.Text = m.condi;
                        panel3_1.BackColor = Color.Cyan;
                        panel3_1.ForeColor = Color.Black;
                        panel3_2.Text = m.zhiling;
                        panel3_3.Text = m.startTime.ToString("HH:mm:ss");
                        panel3_4.Text = m.target.ToString();
                        panel3_5.Text = m.real.ToString();
                        panel3_6.Text = ((float)m.real * 100 / m.target).ToString() + "%";
                        panel3_7.Text = val7.ToString() + "%";
                        panel3_8.Text = val8.ToString() + "%";
                        panel3_9.Text = val9.ToString() + "%";
                        panel3_10.Text = (val7 * val8 * val9).ToString();
                        pictureBox3.Image = imageList1.Images[$"{m.name[0]}.png"];
                    }

                    if (cnt >= 3)
                        break;
                }
            }
        }
        private void Gray_cc(object sender, EventArgs e)
        {
            string thisCon = "待單停機";
            if (btnGray.Checked)
            {
                int cnt = 0;
                foreach (Machine m in exist)
                {
                    if (m.condi == thisCon && cnt == 0)
                    {
                        cnt++;
                        float val7 = (float)(m.real * 100 / ((m.nowTime - m.startTime).TotalSeconds / m.duration)),
                            val8 = 0.0F, val9 = (float)((m.nowTime - m.startTime).TotalSeconds * 100 / m.duration);
                        if (m.real != 0)
                            val8 = (float)(m.good * 100 / m.real);
                        panel1_0.Text = "機台型號" + m.name;
                        panel1_1.Text = m.condi;
                        panel1_1.BackColor = Color.Gray;
                        panel1_1.ForeColor = Color.Black;
                        panel1_2.Text = m.zhiling;
                        panel1_3.Text = m.startTime.ToString("HH:mm:ss");
                        panel1_4.Text = m.target.ToString();
                        panel1_5.Text = m.real.ToString();
                        panel1_6.Text = ((float)m.real * 100 / m.target).ToString() + "%";
                        panel1_7.Text = val7.ToString() + "%";
                        panel1_8.Text = val8.ToString() + "%";
                        panel1_9.Text = val9.ToString() + "%";
                        panel1_10.Text = (val7 * val8 * val9).ToString();
                        pictureBox1.Image = imageList1.Images[$"{m.name[0]}.png"];
                    }
                    else if (m.condi == thisCon && cnt == 1)
                    {
                        cnt++;
                        float val7 = (float)(m.real * 100 / ((m.nowTime - m.startTime).TotalSeconds / m.duration)),
                            val8 = 0.0F, val9 = (float)((m.nowTime - m.startTime).TotalSeconds * 100 / m.duration);
                        if (m.real != 0)
                            val8 = (float)(m.good * 100 / m.real);
                        panel2_0.Text = "機台型號" + m.name;
                        panel2_1.Text = m.condi;
                        panel2_1.BackColor = Color.Gray;
                        panel2_1.ForeColor = Color.Black;
                        panel2_2.Text = m.zhiling;
                        panel2_3.Text = m.startTime.ToString("HH:mm:ss");
                        panel2_4.Text = m.target.ToString();
                        panel2_5.Text = m.real.ToString();
                        panel2_6.Text = ((float)m.real * 100 / m.target).ToString() + "%";
                        panel2_7.Text = val7.ToString() + "%";
                        panel2_8.Text = val8.ToString() + "%";
                        panel2_9.Text = val9.ToString() + "%";
                        panel2_10.Text = (val7 * val8 * val9).ToString();
                        pictureBox2.Image = imageList1.Images[$"{m.name[0]}.png"];
                    }
                    else if (m.condi == thisCon && cnt == 2)
                    {
                        cnt++;
                        float val7 = (float)(m.real * 100 / ((m.nowTime - m.startTime).TotalSeconds / m.duration)),
                            val8 = 0.0F, val9 = (float)((m.nowTime - m.startTime).TotalSeconds * 100 / m.duration);
                        if (m.real != 0)
                            val8 = (float)(m.good * 100 / m.real);
                        panel3_0.Text = "機台型號" + m.name;
                        panel3_1.Text = m.condi;
                        panel3_1.BackColor = Color.Gray;
                        panel3_1.ForeColor = Color.Black;
                        panel3_2.Text = m.zhiling;
                        panel3_3.Text = m.startTime.ToString("HH:mm:ss");
                        panel3_4.Text = m.target.ToString();
                        panel3_5.Text = m.real.ToString();
                        panel3_6.Text = ((float)m.real * 100 / m.target).ToString() + "%";
                        panel3_7.Text = val7.ToString() + "%";
                        panel3_8.Text = val8.ToString() + "%";
                        panel3_9.Text = val9.ToString() + "%";
                        panel3_10.Text = (val7 * val8 * val9).ToString();
                        pictureBox3.Image = imageList1.Images[$"{m.name[0]}.png"];
                    }

                    if (cnt >= 3)
                        break;
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                current.Visible = false;
            }
            current = group1;
            current.Visible = true;

            if (!gp1_load)
            {
                gp1_load = true;
                using(SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                        $"AttachDbFilename={Directory.GetParent(Directory.GetCurrentDirectory())}\\Test.mdf;" +
                        "Integrated Security=True";
                    cn.Open();

                    string table1 = "生產製造心跳表";//開始生產時間、機台編號、目標數量
                    string table2 = "機台異常記錄表";//機台編號、製令單號
                    string table3 = "即時生產資訊表";//機台編號、實際數量
                    string table4 = "機台監測即時數據資料表";//機台編號、運作狀態
                    string table5 = "即時生產品質記錄表";
                    string table6 = "機台健康度記錄表";

                    SqlDataAdapter sda = new SqlDataAdapter($"SELECT MAX({table1}.機台編號) AS 機台, {table2}.製令單號, MIN({table1}.開始生產時間) AS 時間, MAX({table1}.目標數量) AS 目標, SUM({table3}.生產數量) AS 實際數量, MAX({table3}.時間) AS 現在 " +
                        $" FROM {table2} " +
                        $"LEFT JOIN {table1} ON {table1}.機台編號={table2}.機台編號 " +
                        $"LEFT JOIN {table3} ON {table3}.機台編號={table2}.機台編號 " +
                        $"GROUP BY {table2}.製令單號 ",cn);
                    SqlDataAdapter tb4 = new SqlDataAdapter($"SELECT {table4}.機台編號, MAX({table4}.運作狀態) AS 狀態, SUM({table5}.良品數量) AS 良品, MAX({table6}.已運行時數) AS 過程 " +
                        $" FROM {table4}" +
                        $" LEFT JOIN {table5} ON {table4}.機台編號={table5}.機台編號" +
                        $" LEFT JOIN {table6} ON {table4}.機台編號={table6}.機台編號" +
                        $" GROUP BY {table4}.機台編號",cn);


                    DataSet dsP2 = new DataSet();
                    sda.Fill(dsP2, "main");
                    tb4.Fill(dsP2, "tb4");

                    foreach (DataRow dr in dsP2.Tables["main"].Rows)
                    {
                        foreach(DataRow dr4 in dsP2.Tables["tb4"].Rows)
                        {
                            if (dr["機台"].ToString() == dr4["機台編號"].ToString())
                            {
                                string s1, s2, s3;
                                DateTime d1, d2;
                                int i1, i2, i3, i4;
                                switch (dr4["狀態"].ToString())
                                {
                                    case "正常生產":
                                        green.Text = (int.Parse(green.Text)+1).ToString();

                                        s1 = dr4["狀態"].ToString();
                                        s2 = dr["製令單號"].ToString();
                                        s3 = dr["機台"].ToString();
                                        d1 = (DateTime)dr["時間"];
                                        if (dr["現在"] is DBNull)
                                            d2 = DateTime.Now;
                                        else
                                            d2 = (DateTime)dr["現在"];
                                        i1 = int.Parse(dr["目標"].ToString());
                                        if (dr["實際數量"].ToString().Length > 0)
                                            i2 = int.Parse(dr["實際數量"].ToString());
                                        else
                                            i2 = 0;
                                        if (dr4["良品"].ToString().Length > 0)
                                            i3 = int.Parse(dr4["良品"].ToString());
                                        else
                                            i3 = 0;
                                        i4 = int.Parse(dr4["過程"].ToString());

                                        Machine n = new Machine(s1,s2,s3,d1,d2,i1,i2,i3,i4);
                                        exist.Add(n);

                                        break;
                                    case "待料中":
                                        yellow.Text = (int.Parse(yellow.Text) + 1).ToString();

                                        s1 = dr4["狀態"].ToString();
                                        s2 = dr["製令單號"].ToString();
                                        s3 = dr["機台"].ToString();
                                        d1 = (DateTime)dr["時間"];
                                        if (dr["現在"] is DBNull)
                                            d2 = DateTime.Now;
                                        else
                                            d2 = (DateTime)dr["現在"];
                                        i1 = int.Parse(dr["目標"].ToString());
                                        if (dr["實際數量"].ToString().Length > 0)
                                            i2 = int.Parse(dr["實際數量"].ToString());
                                        else
                                            i2 = 0;
                                        if (dr4["良品"].ToString().Length > 0)
                                            i3 = int.Parse(dr4["良品"].ToString());
                                        else
                                            i3 = 0;
                                        i4 = int.Parse(dr4["過程"].ToString());

                                        n = new Machine(s1, s2, s3, d1, d2, i1, i2, i3, i4);
                                        exist.Add(n);

                                        break;
                                    case "故障":
                                        red.Text = (int.Parse(red.Text) + 1).ToString();
                                        
                                        s1 = dr4["狀態"].ToString();
                                        s2 = dr["製令單號"].ToString();
                                        s3 = dr["機台"].ToString();
                                        d1 = (DateTime)dr["時間"];
                                        if (dr["現在"] is DBNull)
                                            d2 = DateTime.Now;
                                        else
                                            d2 = (DateTime)dr["現在"];
                                        i1 = int.Parse(dr["目標"].ToString());
                                        if (dr["實際數量"].ToString().Length > 0)
                                            i2 = int.Parse(dr["實際數量"].ToString());
                                        else
                                            i2 = 0;
                                        if (dr4["良品"].ToString().Length > 0)
                                            i3 = int.Parse(dr4["良品"].ToString());
                                        else
                                            i3 = 0;
                                        i4 = int.Parse(dr4["過程"].ToString());

                                        n = new Machine(s1, s2, s3, d1, d2, i1, i2, i3, i4);
                                        exist.Add(n);

                                        break;
                                    case "維修中":
                                        cyan.Text = (int.Parse(cyan.Text) + 1).ToString();

                                        s1 = dr4["狀態"].ToString();
                                        s2 = dr["製令單號"].ToString();
                                        s3 = dr["機台"].ToString();
                                        d1 = (DateTime)dr["時間"];
                                        if (dr["現在"] is DBNull)
                                            d2 = DateTime.Now;
                                        else
                                            d2 = (DateTime)dr["現在"];
                                        i1 = int.Parse(dr["目標"].ToString());
                                        if (dr["實際數量"].ToString().Length > 0)
                                            i2 = int.Parse(dr["實際數量"].ToString());
                                        else
                                            i2 = 0;
                                        if (dr4["良品"].ToString().Length > 0)
                                            i3 = int.Parse(dr4["良品"].ToString());
                                        else
                                            i3 = 0;
                                        i4 = int.Parse(dr4["過程"].ToString());

                                        n = new Machine(s1, s2, s3, d1, d2, i1, i2, i3, i4);
                                        exist.Add(n);

                                        break;
                                    case "待單停機":
                                        gray.Text = (int.Parse(gray.Text) + 1).ToString();

                                        s1 = dr4["狀態"].ToString();
                                        s2 = dr["製令單號"].ToString();
                                        s3 = dr["機台"].ToString();
                                        d1 = (DateTime)dr["時間"];
                                        if (dr["現在"] is DBNull)
                                            d2 = DateTime.Now;
                                        else
                                            d2 = (DateTime)dr["現在"];
                                        i1 = int.Parse(dr["目標"].ToString());
                                        if (dr["實際數量"].ToString().Length > 0)
                                            i2 = int.Parse(dr["實際數量"].ToString());
                                        else
                                            i2 = 0;
                                        if(dr4["良品"].ToString().Length>0)
                                            i3 = int.Parse(dr4["良品"].ToString());
                                        else
                                            i3 = 0;
                                        i4 = int.Parse(dr4["過程"].ToString());

                                        n = new Machine(s1, s2, s3, d1, d2, i1, i2, i3, i4);
                                        exist.Add(n);

                                        break;
                                    default: break;
                                }
                            }
                        }
                    }

                    cn.Close();
                }
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                current.Visible = false;
            }
            current = group2;
            current.Visible = true;

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    $"AttachDbFilename={Directory.GetParent(Directory.GetCurrentDirectory())}\\Test.mdf;" +
                    "Integrated Security=True";
                cn.Open();

                string table = "機台監測即時數據資料表";
                SqlDataAdapter work = new SqlDataAdapter($"SELECT 機台編號, DATEDIFF(second,MIN(時間),MAX(時間)) AS 時間, 運作狀態" +
                    $" FROM {table}" +
                    $" GROUP BY 機台編號, 運作狀態" +
                    $" ORDER BY 機台編號", cn);
                SqlDataAdapter time = new SqlDataAdapter($"SELECT 機台編號, DATEDIFF(second,MIN(時間),MAX(時間)) AS 時間, MAX(運作狀態) AS 運作狀態" +
                    $" FROM {table} " +
                    $" GROUP BY 機台編號" +
                    $" ORDER BY 機台編號", cn);

                DataSet ds3 = new DataSet();
                time.Fill(ds3, "time");
                work.Fill(ds3, "work");


                ds3.Tables["time"].Columns.Add("稼動率");

                foreach (DataRow dr in ds3.Tables["time"].Rows)
                {
                    float ratio = 0.0F;
                    int divisor = int.Parse(dr["時間"].ToString());

                    foreach (DataRow dr2 in ds3.Tables["work"].Rows)
                    {
                        if (dr2["機台編號"].ToString() == dr["機台編號"].ToString() && dr2["運作狀態"].ToString() == "正常生產")
                        {
                            int dividend = int.Parse(dr2["時間"].ToString());
                            ratio += dividend;
                            ratio /= divisor;
                        }
                    }

                    dr["稼動率"] = string.Format("{0:f1}%", ratio * 100);
                }

                comboBox1.DataSource = ds3;
                comboBox1.DisplayMember = "time.機台編號";
                condition.DataBindings.Add("Text", ds3, "time.運作狀態");
                Ratio.DataBindings.Add("Text", ds3, "time.稼動率");

                cn.Close();
            }
        }
        private void Machine_info(object sender, EventArgs e)
        {
            label9.Text = comboBox1.Text + " (機台型號)";
            pictureBox4.Image = imageList1.Images[($"{comboBox1.Text[0]}.png")];

            string comStr = comboBox1.Text;

            gen_info1.Text = "";
            gen_info2.Text = "";
            gen_info3.Text = "";
            gen_info4.Text = "";
            gen_info5.Text = "";
            err_info1.Text = "";
            err_info2.Text = "";
            err_info3.Text = "";
            err_info4.Text = "";
            err_info5.Text = "";

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    $"AttachDbFilename={Directory.GetParent(Directory.GetCurrentDirectory())}\\Test.mdf;" +
                    "Integrated Security=True";
                cn.Open();
                string table1 = "生產製造心跳表";
                string table2 = "機台異常記錄表";
                string table3 = "即時生產資訊表";
                string table4 = "機台健康度記錄表";

                SqlDataAdapter err = new SqlDataAdapter($"SELECT {table2}.機台編號, {table2}.時間, {table2}.異常資訊, {table2}.製令單號," +
                    $" {table1}.開始生產時間, {table1}.作業人員, {table1}.目標數量, {table1}.生產週期" +
                    $" FROM {table2}" +
                    $" LEFT JOIN {table1} ON {table1}.機台編號={table2}.機台編號", cn);
                SqlDataAdapter count = new SqlDataAdapter($"SELECT {table3}.機台編號, SUM({table3}.生產數量) AS 實際數量, MAX({table4}.已運行時數) AS 已生產時間 " +
                    $"FROM {table3} " +
                    $"LEFT JOIN {table4} ON {table3}.機台編號={table4}.機台編號 " +
                    $"GROUP BY {table3}.機台編號 " +
                    $"ORDER BY {table3}.機台編號", cn);

                DataSet ds = new DataSet();
                err.Fill(ds, "err");
                count.Fill(ds, "count");

                foreach (DataRow dr in ds.Tables["err"].Rows)
                {
                    if (dr["機台編號"].ToString() == comStr)
                    {
                        float ratio = 1.0F;
                        string str = "";
                        foreach (DataRow dr2 in ds.Tables["count"].Rows)
                        {
                            if (dr2["機台編號"].ToString() == comStr)
                            {
                                ratio = float.Parse(dr2["實際數量"].ToString());
                                ratio /= float.Parse(dr["目標數量"].ToString());
                                ratio *= 100;
                                break;
                            }
                            str = dr2["已生產時間"].ToString();
                        }
                        if (str.Length == 0)
                            str = "0";
                        DateTime dateTime = (DateTime)dr["時間"];
                        gen_info1.Text = dr["製令單號"].ToString()+"\n";
                        gen_info2.Text = "產品名稱"+"\n";
                        gen_info3.Text = string.Format("{0:f2}%",ratio)+"\n";
                        gen_info4.Text = str+"\n";
                        gen_info5.Text = dr["作業人員"].ToString() + "\n";
                        err_info1.Text = dr["製令單號"].ToString() + "\n";
                        err_info2.Text = "產品名稱" + "\n";
                        err_info3.Text = dr["異常資訊"].ToString() + "\n";
                        err_info4.Text = dateTime.ToString("MM/dd,HH:mm")+"\n";
                        err_info5.Text = dr["作業人員"].ToString() + "\n";
                    }
                }

                cn.Close();
            }
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                current.Visible = false;
            }
            current = group3;
            current.Visible = true;

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    $"AttachDbFilename={Directory.GetParent(Directory.GetCurrentDirectory())}\\Test.mdf;" +
                    "Integrated Security=True";
                cn.Open();

                string tablename = "各CT即時電量數據資料表";
                //string sqlcmd = $"SELECT*FROM {tablename}";
                string sqlcmd = $"SELECT ROW_NUMBER() OVER (ORDER BY 機台編號) AS ID, 機台編號, DATEDIFF(hour,MIN(時間),MAX(時間)) AS 使用時長, MIN(比流器編號) AS 比流器編號, AVG(電壓) AS 目前電壓, AVG(電流) AS 目前電流 " +
                    $"FROM {tablename} " +
                    $"GROUP BY 機台編號, 比流器編號";

                SqlDataAdapter sda = new SqlDataAdapter(sqlcmd, cn);
                DataSet ds = new DataSet();
                sda.Fill(ds, tablename);
                DataTable dt = ds.Tables[tablename];

                string addCol1 = "本日累計用電量", addCol2 = "本日累計碳排量";
                dt.Columns.Add(addCol1);
                dt.Columns.Add(addCol2);

                foreach (DataRow dr in dt.Rows)
                {
                    float valKWH = float.Parse(dr["目前電壓"].ToString()) * float.Parse(dr["目前電流"].ToString()) / 1000 * float.Parse(dr["使用時長"].ToString());
                    dr[addCol1] = valKWH;
                    dr[addCol2] = string.Format("{0:f3}", valKWH * 0.5);
                }
                comboBox2.DataSource = ds;
                comboBox2.DisplayMember = tablename + ".機台編號";
                comboBox3.DataSource = ds;
                comboBox3.DisplayMember = tablename + ".比流器編號";

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = tablename;
                dataGridView1.Visible = true;

                cn.Close();
            }
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                current.Visible = false;
            }
            current = group4_1;
            current.Visible = true;
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    $"AttachDbFilename={Directory.GetParent(Directory.GetCurrentDirectory())}\\Test.mdf;" +
                    "Integrated Security=True";
                cn.Open();

                string tablename = "機台健康度記錄表";
                SqlDataAdapter sda = new SqlDataAdapter($"SELECT * FROM {tablename}", cn);
                DataSet ds = new DataSet();
                sda.Fill(ds, tablename);
                DataTable dt = ds.Tables[tablename];
                string addCol = "機台健康度";
                dt.Columns.Add(addCol);

                foreach (DataRow dr in dt.Rows)
                {
                    if (!comboBox5.Items.Contains(dr["機台編號"]))
                    {
                        comboBox5.Items.Add(dr["機台編號"]);
                    }
                    float val = int.Parse(dr["建議保養時數"].ToString()) - int.Parse(dr["已運行時數"].ToString());
                    val /= int.Parse(dr["建議保養時數"].ToString());
                    dr[addCol] = string.Format("{0:f1}", val * 100);
                }

                dataGridView2.DataSource = ds.Tables[tablename];
                dataGridView2.Visible = true;

                cn.Close();
            }
        }
        private void BaoYang_Display(object sender, EventArgs e)
        {
            string cboSelect = comboBox5.SelectedItem.ToString();
            current.Visible = false;
            current = group4_2;
            current.Visible = true;

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    $"AttachDbFilename={Directory.GetParent(Directory.GetCurrentDirectory())}\\Test.mdf;" +
                    "Integrated Security=True";

                cn.Open();

                SqlDataAdapter sda = new SqlDataAdapter("SELECT*FROM 設備保養歷史清單", cn);
                DataSet ds = new DataSet();
                sda.Fill(ds, "設備保養歷史清單");

                By_display1.Text = "";
                By_display2.Text = "";
                By_display3.Text = "";
                By_display4.Text = "";
                By_display5.Text = "";
                foreach (DataRow dr in ds.Tables["設備保養歷史清單"].Rows)
                {
                    if (dr["編號"].ToString() == cboSelect)
                    {
                        DateTime day = (DateTime)dr["時間"];
                        By_display1.Text += day.ToString("yyyy年MM月dd日") + "\n";
                        By_display2.Text += cboSelect + "\n";
                        By_display3.Text += dr["保養人"].ToString() +"\n";
                        By_display4.Text += dr["料號"].ToString() + "\n";
                        By_display5.Text += dr["備註"].ToString() + "\n";
                    }
                }
                cn.Close();
            }
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            Total show = new Total();
            show.ShowDialog();
        }

    }
}
