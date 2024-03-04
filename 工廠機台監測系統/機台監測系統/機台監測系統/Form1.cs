using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 機台監測系統
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*string currentDirectory = Directory.GetCurrentDirectory();
            MessageBox.Show(currentDirectory);*/
        }

        private  Dictionary<string, string> machineImageMap = new Dictionary<string, string>
        {
            { "A01", Path.Combine("source", "picture", "Machine-A.png") },
            { "A02", Path.Combine("source", "picture", "Machine-A.png") },
            { "A03", Path.Combine("source", "picture", "Machine-A.png") },
            { "B01", Path.Combine("source", "picture", "Machine-B.png") },
            { "B02", Path.Combine("source", "picture", "Machine-B.png") },
            { "B03", Path.Combine("source", "picture", "Machine-B.png") },
            { "C01", Path.Combine("source", "picture", "Machine-C.png") },
            { "C02", Path.Combine("source", "picture", "Machine-C.png") },
            { "C03", Path.Combine("source", "picture", "Machine-C.png") },
        };


        private DataTable GetData(string query)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Test.mdf;Integrated Security=True";
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }

        private void SaveData(string sql, Dictionary<string, object> parameters)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Test.mdf;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                    }

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        private void CreateEquipTable()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Test.mdf;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string createTableQuery = @"
                    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = '設備保養歷史清單')
                    BEGIN
                    CREATE TABLE 設備保養歷史清單 (
                        ID INT PRIMARY KEY,
                        時間 DATETIME,
                        編號 CHAR(10),
                        保養人 CHAR(10),
                        料號 CHAR(20),
                        備註 NVARCHAR(100)
                    );
                    END";

                using (SqlCommand command = new SqlCommand(createTableQuery, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void efficiency_btn_Click(object sender, EventArgs e)
        {
            efficiency_panel.Visible = true;
            machine_panel.Visible = false;
            power_panel.Visible = false;
            maintain_panel.Visible = false;

            DataTable machineData = GetData("SELECT Id, 時間, 機台編號, 運作狀態, 製令單號 FROM 機台監測即時數據資料表");

            int workingCount = 0;
            int materialCount = 0;
            int malfunctionCount = 0;
            int repairCount = 0;
            int orderCount = 0;

            var status_cur = machineData.AsEnumerable()
            .GroupBy(row => row.Field<string>("機台編號"))
            .Select(group => group.OrderByDescending(row => row.Field<DateTime>("時間")).First());

            workingCount = status_cur.Count(row => row.Field<string>("運作狀態") == "正常生產");
            working_num.Text = workingCount.ToString();

            materialCount = status_cur.Count(row => row.Field<string>("運作狀態") == "待料中");
            material_num.Text = materialCount.ToString();

            malfunctionCount = status_cur.Count(row => row.Field<string>("運作狀態") == "故障");
            malfunction_num.Text = malfunctionCount.ToString();

            repairCount = status_cur.Count(row => row.Field<string>("運作狀態") == "維修中");
            repair_num.Text = repairCount.ToString();

            orderCount = status_cur.Count(row => row.Field<string>("運作狀態") == "待單停機");
            order_num.Text = orderCount.ToString();

        }

        private void working_btn_Click(object sender, EventArgs e)
        {
            DataTable machineData = GetData("SELECT Id, 時間, 機台編號, 運作狀態, 製令單號 FROM 機台監測即時數據資料表");

            var status_cur = machineData.AsEnumerable()
                .GroupBy(row => row.Field<string>("機台編號"))
                .Select(group => group.OrderByDescending(row => row.Field<DateTime>("時間")).First());

            var workingIDs = status_cur
                .Where(row => row.Field<string>("運作狀態") == "正常生產")
                .Select(row => row.Field<string>("機台編號"));


            string[] workingIDArr = workingIDs.ToArray();

            Label[] labels = { model_1, model_2, model_3 };
            PictureBox[] pictureBoxes = { machine_1, machine_2, machine_3 };



            for (int i = 0; i < labels.Length; i++)
            {
                if (i < workingIDArr.Length)
                {
                    labels[i].Text = workingIDArr[i];

                    if (machineImageMap.TryGetValue(workingIDArr[i], out string imagePath))
                    {
                        pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxes[i].Image = Image.FromFile(imagePath);
                    }
                }
                else
                {
                    labels[i].Text = string.Empty;
                    pictureBoxes[i].Image = null;
                }
            }


            DataTable rtProdData = GetData("SELECT Id, 時間, 機台編號, 生產數量, 製令單號 FROM 即時生產資訊表");

            var ProdData_cur = rtProdData.AsEnumerable()
                .Where(row => workingIDArr.Contains(row.Field<string>("機台編號")))
                .GroupBy(row => row.Field<string>("機台編號"))
                .Select(group => group.OrderByDescending(row => row.Field<DateTime>("時間")).First());

            string[] ordernumsArr = ProdData_cur
                .Select(row => row.Field<string>("製令單號"))
                .ToArray();

            DateTime[] latestTimeArr = rtProdData.AsEnumerable()
                .Where(row => workingIDArr.Contains(row.Field<string>("機台編號")))
                .GroupBy(row => row.Field<string>("機台編號"))
                .Select(group => group.OrderByDescending(row => row.Field<DateTime>("時間")).First())
                .Select(row => row.Field<DateTime>("時間"))
                .ToArray();

            DateTime[] startTimeArr = rtProdData.AsEnumerable()
                .Where(row => workingIDArr.Contains(row.Field<string>("機台編號")))
                .GroupBy(row => row.Field<string>("機台編號"))
                .Select(group => group.OrderBy(row => row.Field<DateTime>("時間")).First())
                .Select(row => row.Field<DateTime>("時間"))
                .ToArray();

            int[] actualProd = new int[workingIDArr.Length];

            for (int i = 0; i < workingIDArr.Length; i++)
            {
                string machineId = workingIDArr[i];
                DateTime startTime = startTimeArr[i];
                DateTime endTime = latestTimeArr[i];

                int sum = rtProdData.AsEnumerable()
                    .Where(row => row.Field<string>("機台編號") == machineId &&
                                  row.Field<DateTime>("時間") >= startTime &&
                                  row.Field<DateTime>("時間") <= endTime)
                    .Sum(row => row.Field<int>("生產數量"));

                actualProd[i] = sum;
            }

            DataTable heartProdData = GetData("SELECT Id, 開始生產時間, 機台編號, 製令單號, 作業人員, 目標數量, 實際數量, 生產週期, " +
                                            "生產效率, 直通率, 機台稼動率 FROM 生產製造心跳表");

            int[] goalProd = heartProdData.AsEnumerable()
                .Where(row => workingIDArr.Contains(row.Field<string>("機台編號")))
                .Select(row => row.Field<int>("目標數量"))
                .ToArray();

            float[] effProd = heartProdData.AsEnumerable()
                .Where(row => workingIDArr.Contains(row.Field<string>("機台編號")))
                .Select(row =>
                {

                    if (float.TryParse(row["生產週期"].ToString(), out float cycleTime))
                    {
                        return cycleTime;
                    }
                    else
                    {
                        return 0f;
                    }
                })
                .ToArray();

            DataTable qualProdData = GetData("SELECT Id, 時間, 機台編號, 良品數量, 不良品數量, 製令單號 FROM 即時生產品質記錄表");

            int[] goodProd = new int[workingIDArr.Length];

            for (int i = 0; i < workingIDArr.Length; i++)
            {
                string machineId = workingIDArr[i];
                DateTime startTime = startTimeArr[i];
                DateTime endTime = latestTimeArr[i];

                int sum = qualProdData.AsEnumerable()
                    .Where(row => row.Field<string>("機台編號") == machineId &&
                                  row.Field<DateTime>("時間") >= startTime &&
                                  row.Field<DateTime>("時間") <= endTime)
                    .Sum(row => row.Field<int>("良品數量"));

                goodProd[i] = sum;
            }

            TimeSpan[] orderTime = new TimeSpan[workingIDArr.Length];

            for (int i = 0; i < workingIDArr.Length; i++)
            {
                string orderNum = ordernumsArr[i];
                int count = machineData.AsEnumerable()
                    .Where(row => row.Field<string>("製令單號") == orderNum)
                    .Count();

                orderTime[i] = TimeSpan.FromSeconds(count * 5);
            }

            TimeSpan[] workingTime = new TimeSpan[workingIDArr.Length];

            for (int i = 0; i < workingIDArr.Length; i++)
            {
                string machineId = workingIDArr[i];
                int count = machineData.AsEnumerable()
                    .Where(row => row.Field<string>("機台編號") == machineId && row.Field<string>("運作狀態") == "正常生產")
                    .Count();

                workingTime[i] = TimeSpan.FromSeconds(count * 5);
            }

            double[] actRates = new double[workingIDArr.Length];
            for (int i = 0; i < workingIDArr.Length; i++)
            {
                if (orderTime[i].TotalSeconds > 0)
                {
                    actRates[i] = (workingTime[i].TotalSeconds / orderTime[i].TotalSeconds) * 100;
                }
                else
                {
                    actRates[i] = 0;
                }
            }

            Label[] stats = { md1_stat, md2_stat, md3_stat };
            Label[] nums = { md1_num, md2_num, md3_num };
            Label[] times = { md1_time, md2_time, md3_time };
            Label[] goals = { md1_goal, md2_goal, md3_goal };
            Label[] actuals = { md1_actual, md2_actual, md3_actual };
            Label[] progs = { md1_prog, md2_prog, md3_prog };
            Label[] effs = { md1_eff, md2_eff, md3_eff };
            Label[] fpys = { md1_fpy, md2_fpy, md3_fpy };
            Label[] acts = { md1_act, md2_act, md3_act };
            Label[] oees = { md1_oee, md2_oee, md3_oee };

            for (int i = 0; i < labels.Length; i++)
            {
                if (i < workingIDArr.Length)
                {
                    stats[i].Text = "生產中";
                    stats[i].BackColor = Color.Green;
                    stats[i].ForeColor = Color.Black;

                    nums[i].Text = ordernumsArr[i];
                    times[i].Text = startTimeArr[i].ToString("HH:mm:ss");
                    goals[i].Text = goalProd[i].ToString();
                    actuals[i].Text = actualProd[i].ToString();

                    double prog_per = (double)actualProd[i] / goalProd[i] * 100;
                    progs[i].Text = $"{prog_per:F2}%";

                    double totalTimeInSeconds = (latestTimeArr[i] - startTimeArr[i]).TotalSeconds;
                    double eff_per = actualProd[i] / (totalTimeInSeconds / effProd[i]) * 100;
                    if (eff_per >= 85)
                    {
                        effs[i].ForeColor = Color.Green;
                    }
                    else if (eff_per > 80 && eff_per < 85)
                    {
                        effs[i].ForeColor = Color.Yellow;
                    }
                    else
                    {
                        effs[i].ForeColor = Color.Red;
                    }
                    effs[i].Text = $"{eff_per:F2}%";

                    double fyp_per = (double)goodProd[i] / actualProd[i] * 100;
                    if (fyp_per >= 85)
                    {
                        fpys[i].ForeColor = Color.Green;
                    }
                    else if (fyp_per > 80 && fyp_per < 85)
                    {
                        fpys[i].ForeColor = Color.Yellow;
                    }
                    else
                    {
                        fpys[i].ForeColor = Color.Red;
                    }
                    fpys[i].Text = $"{fyp_per:F2}%";

                    if (actRates[i] >= 85)
                    {
                        acts[i].ForeColor = Color.Green;
                    }
                    else if (actRates[i] > 80 && actRates[i] < 85)
                    {
                        acts[i].ForeColor = Color.Yellow;
                    }
                    else
                    {
                        acts[i].ForeColor = Color.Red;
                    }
                    acts[i].Text = actRates[i].ToString("F2") + "%";

                    double oee_per = eff_per * fyp_per * actRates[i] / 10000;
                    if (oee_per >= 85)
                    {
                        oees[i].ForeColor = Color.Green;
                    }
                    else if (oee_per > 80 && oee_per < 85)
                    {
                        oees[i].ForeColor = Color.Yellow;
                    }
                    else
                    {
                        oees[i].ForeColor = Color.Red;
                    }
                    oees[i].Text = oee_per.ToString("F2") + "%";
                }
                else
                {
                    nums[i].Text = "-";
                    times[i].Text = "-";
                    goals[i].Text = "-";
                    actuals[i].Text = "-";
                    progs[i].Text = "-";
                    effs[i].Text = "-";
                    fpys[i].Text = "-";
                    acts[i].Text = "-";
                    oees[i].Text = "-";
                }
            }

            for (int i = 0; i < workingIDArr.Length; i++)
            {
                string machineId = workingIDArr[i];
                string orderNumber = ordernumsArr[i];
                DateTime productionStartTime = startTimeArr[i]; // Your start time value
                int actualProdNum = actualProd[i]; // Your actual production quantity
                double totalTimeInSeconds = (latestTimeArr[i] - startTimeArr[i]).TotalSeconds;
                double eff = actualProd[i] / (totalTimeInSeconds / effProd[i]) * 100; // Your production efficiency
                double fpy = (double)goodProd[i] / actualProd[i] * 100; ; // Your product throughput rate
                double actRate = actRates[i]; // Your machine utilization rate

                string sql = "UPDATE 生產製造心跳表 SET 製令單號 = @OrderNumber, 開始生產時間 = @StartTime, " +
                    "實際數量 = @ActualNumber, 生產效率 = @Efficiency, 直通率 = @FPY, 機台稼動率 = @act WHERE 機台編號 = @MachineId";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@MachineId", machineId },
                    { "@OrderNumber", orderNumber },
                    { "@StartTime", productionStartTime },
                    { "@ActualNumber", actualProdNum },
                    { "@Efficiency", eff },
                    { "@FPY", fpy },
                    { "@act", actRate }
                };

                SaveData(sql, parameters);
            }

        }

        private void material_btn_Click(object sender, EventArgs e)
        {
            DataTable machineData = GetData("SELECT Id, 時間, 機台編號, 運作狀態, 製令單號 FROM 機台監測即時數據資料表");

            var status_cur = machineData.AsEnumerable()
                .GroupBy(row => row.Field<string>("機台編號"))
                .Select(group => group.OrderByDescending(row => row.Field<DateTime>("時間")).First());

            var workingIDs = status_cur
                .Where(row => row.Field<string>("運作狀態") == "待料中")
                .Select(row => row.Field<string>("機台編號"));


            string[] workingIDArr = workingIDs.ToArray();

            Label[] labels = { model_1, model_2, model_3 };
            PictureBox[] pictureBoxes = { machine_1, machine_2, machine_3 };



            for (int i = 0; i < labels.Length; i++)
            {
                if (i < workingIDArr.Length)
                {
                    labels[i].Text = workingIDArr[i];

                    if (machineImageMap.TryGetValue(workingIDArr[i], out string imagePath))
                    {
                        pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxes[i].Image = Image.FromFile(imagePath);
                    }
                }
                else
                {
                    labels[i].Text = string.Empty;
                    pictureBoxes[i].Image = null;
                }
            }


            DataTable rtProdData = GetData("SELECT Id, 時間, 機台編號, 生產數量, 製令單號 FROM 即時生產資訊表");

            var ProdData_cur = rtProdData.AsEnumerable()
                .Where(row => workingIDArr.Contains(row.Field<string>("機台編號")))
                .GroupBy(row => row.Field<string>("機台編號"))
                .Select(group => group.OrderByDescending(row => row.Field<DateTime>("時間")).First());

            string[] ordernumsArr = ProdData_cur
                .Select(row => row.Field<string>("製令單號"))
                .ToArray();

            DateTime[] latestTimeArr = rtProdData.AsEnumerable()
                .Where(row => workingIDArr.Contains(row.Field<string>("機台編號")))
                .GroupBy(row => row.Field<string>("機台編號"))
                .Select(group => group.OrderByDescending(row => row.Field<DateTime>("時間")).First())
                .Select(row => row.Field<DateTime>("時間"))
                .ToArray();

            DateTime[] startTimeArr = rtProdData.AsEnumerable()
                .Where(row => workingIDArr.Contains(row.Field<string>("機台編號")))
                .GroupBy(row => row.Field<string>("機台編號"))
                .Select(group => group.OrderBy(row => row.Field<DateTime>("時間")).First())
                .Select(row => row.Field<DateTime>("時間"))
                .ToArray();

            int[] actualProd = new int[workingIDArr.Length];

            for (int i = 0; i < workingIDArr.Length; i++)
            {
                string machineId = workingIDArr[i];
                DateTime startTime = startTimeArr[i];
                DateTime endTime = latestTimeArr[i];

                int sum = rtProdData.AsEnumerable()
                    .Where(row => row.Field<string>("機台編號") == machineId &&
                                  row.Field<DateTime>("時間") >= startTime &&
                                  row.Field<DateTime>("時間") <= endTime)
                    .Sum(row => row.Field<int>("生產數量"));

                actualProd[i] = sum;
            }

            DataTable heartProdData = GetData("SELECT Id, 開始生產時間, 機台編號, 製令單號, 作業人員, 目標數量, 實際數量, 生產週期, " +
                                            "生產效率, 直通率, 機台稼動率 FROM 生產製造心跳表");

            int[] goalProd = heartProdData.AsEnumerable()
                .Where(row => workingIDArr.Contains(row.Field<string>("機台編號")))
                .Select(row => row.Field<int>("目標數量"))
                .ToArray();

            float[] effProd = heartProdData.AsEnumerable()
                .Where(row => workingIDArr.Contains(row.Field<string>("機台編號")))
                .Select(row =>
                {

                    if (float.TryParse(row["生產週期"].ToString(), out float cycleTime))
                    {
                        return cycleTime;
                    }
                    else
                    {
                        return 0f;
                    }
                })
                .ToArray();

            DataTable qualProdData = GetData("SELECT Id, 時間, 機台編號, 良品數量, 不良品數量, 製令單號 FROM 即時生產品質記錄表");

            int[] goodProd = new int[workingIDArr.Length];

            for (int i = 0; i < workingIDArr.Length; i++)
            {
                string machineId = workingIDArr[i];
                DateTime startTime = startTimeArr[i];
                DateTime endTime = latestTimeArr[i];

                int sum = qualProdData.AsEnumerable()
                    .Where(row => row.Field<string>("機台編號") == machineId &&
                                  row.Field<DateTime>("時間") >= startTime &&
                                  row.Field<DateTime>("時間") <= endTime)
                    .Sum(row => row.Field<int>("良品數量"));

                goodProd[i] = sum;
            }

            TimeSpan[] orderTime = new TimeSpan[workingIDArr.Length];

            for (int i = 0; i < workingIDArr.Length; i++)
            {
                string orderNum = ordernumsArr[i];
                int count = machineData.AsEnumerable()
                    .Where(row => row.Field<string>("製令單號") == orderNum)
                    .Count();

                orderTime[i] = TimeSpan.FromSeconds(count * 5);
            }

            TimeSpan[] workingTime = new TimeSpan[workingIDArr.Length];

            for (int i = 0; i < workingIDArr.Length; i++)
            {
                string machineId = workingIDArr[i];
                int count = machineData.AsEnumerable()
                    .Where(row => row.Field<string>("機台編號") == machineId && row.Field<string>("運作狀態") == "正常生產")
                    .Count();

                workingTime[i] = TimeSpan.FromSeconds(count * 5);
            }

            double[] actRates = new double[workingIDArr.Length];
            for (int i = 0; i < workingIDArr.Length; i++)
            {
                if (orderTime[i].TotalSeconds > 0)
                {
                    actRates[i] = (workingTime[i].TotalSeconds / orderTime[i].TotalSeconds) * 100;
                }
                else
                {
                    actRates[i] = 0;
                }
            }

            Label[] stats = { md1_stat, md2_stat, md3_stat };
            Label[] nums = { md1_num, md2_num, md3_num };
            Label[] times = { md1_time, md2_time, md3_time };
            Label[] goals = { md1_goal, md2_goal, md3_goal };
            Label[] actuals = { md1_actual, md2_actual, md3_actual };
            Label[] progs = { md1_prog, md2_prog, md3_prog };
            Label[] effs = { md1_eff, md2_eff, md3_eff };
            Label[] fpys = { md1_fpy, md2_fpy, md3_fpy };
            Label[] acts = { md1_act, md2_act, md3_act };
            Label[] oees = { md1_oee, md2_oee, md3_oee };

            for (int i = 0; i < labels.Length; i++)
            {
                if (i < workingIDArr.Length)
                {
                    stats[i].Text = "生產中";
                    stats[i].BackColor = Color.Yellow;
                    stats[i].ForeColor = Color.Black;

                    nums[i].Text = ordernumsArr[i];
                    times[i].Text = startTimeArr[i].ToString("HH:mm:ss");
                    goals[i].Text = goalProd[i].ToString();
                    actuals[i].Text = actualProd[i].ToString();

                    double prog_per = (double)actualProd[i] / goalProd[i] * 100;
                    progs[i].Text = $"{prog_per:F2}%";

                    double totalTimeInSeconds = (latestTimeArr[i] - startTimeArr[i]).TotalSeconds;
                    double eff_per = actualProd[i] / (totalTimeInSeconds / effProd[i]) * 100;
                    if (eff_per >= 85)
                    {
                        effs[i].ForeColor = Color.Green;
                    }
                    else if (eff_per > 80 && eff_per < 85)
                    {
                        effs[i].ForeColor = Color.Yellow;
                    }
                    else
                    {
                        effs[i].ForeColor = Color.Red;
                    }
                    effs[i].Text = $"{eff_per:F2}%";

                    double fyp_per = (double)goodProd[i] / actualProd[i] * 100;
                    if (fyp_per >= 85)
                    {
                        fpys[i].ForeColor = Color.Green;
                    }
                    else if (fyp_per > 80 && fyp_per < 85)
                    {
                        fpys[i].ForeColor = Color.Yellow;
                    }
                    else
                    {
                        fpys[i].ForeColor = Color.Red;
                    }
                    fpys[i].Text = $"{fyp_per:F2}%";

                    if (actRates[i] >= 85)
                    {
                        acts[i].ForeColor = Color.Green;
                    }
                    else if (actRates[i] > 80 && actRates[i] < 85)
                    {
                        acts[i].ForeColor = Color.Yellow;
                    }
                    else
                    {
                        acts[i].ForeColor = Color.Red;
                    }
                    acts[i].Text = actRates[i].ToString("F2") + "%";

                    double oee_per = eff_per * fyp_per * actRates[i] / 10000;
                    if (oee_per >= 85)
                    {
                        oees[i].ForeColor = Color.Green;
                    }
                    else if (oee_per > 80 && oee_per < 85)
                    {
                        oees[i].ForeColor = Color.Yellow;
                    }
                    else
                    {
                        oees[i].ForeColor = Color.Red;
                    }
                    oees[i].Text = oee_per.ToString("F2") + "%";
                }
                else
                {
                    nums[i].Text = "-";
                    times[i].Text = "-";
                    goals[i].Text = "-";
                    actuals[i].Text = "-";
                    progs[i].Text = "-";
                    effs[i].Text = "-";
                    fpys[i].Text = "-";
                    acts[i].Text = "-";
                    oees[i].Text = "-";
                }
            }
        }

        private void malfunction_btn_Click(object sender, EventArgs e)
        {
            DataTable machineData = GetData("SELECT Id, 時間, 機台編號, 運作狀態, 製令單號 FROM 機台監測即時數據資料表");

            var status_cur = machineData.AsEnumerable()
                .GroupBy(row => row.Field<string>("機台編號"))
                .Select(group => group.OrderByDescending(row => row.Field<DateTime>("時間")).First());

            var workingIDs = status_cur
                .Where(row => row.Field<string>("運作狀態") == "故障")
                .Select(row => row.Field<string>("機台編號"));


            string[] workingIDArr = workingIDs.ToArray();

            Label[] labels = { model_1, model_2, model_3 };
            PictureBox[] pictureBoxes = { machine_1, machine_2, machine_3 };

            Label[] stats = { md1_stat, md2_stat, md3_stat };
            Label[] nums = { md1_num, md2_num, md3_num };
            Label[] times = { md1_time, md2_time, md3_time };
            Label[] goals = { md1_goal, md2_goal, md3_goal };
            Label[] actuals = { md1_actual, md2_actual, md3_actual };
            Label[] progs = { md1_prog, md2_prog, md3_prog };
            Label[] effs = { md1_eff, md2_eff, md3_eff };
            Label[] fpys = { md1_fpy, md2_fpy, md3_fpy };
            Label[] acts = { md1_act, md2_act, md3_act };
            Label[] oees = { md1_oee, md2_oee, md3_oee };


            for (int i = 0; i < labels.Length; i++)
            {
                if (i < workingIDArr.Length)
                {
                    labels[i].Text = workingIDArr[i];

                    if (machineImageMap.TryGetValue(workingIDArr[i], out string imagePath))
                    {
                        pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxes[i].Image = Image.FromFile(imagePath);
                    }

                    stats[i].Text = "故障停機";
                    stats[i].BackColor = Color.Red;
                    stats[i].ForeColor = Color.Black;
                    nums[i].Text = "-";
                    nums[i].ForeColor = Color.White;
                    times[i].Text = "-";
                    times[i].ForeColor = Color.White;
                    goals[i].Text = "-";
                    goals[i].ForeColor = Color.White;
                    actuals[i].Text = "-";
                    actuals[i].ForeColor = Color.White;
                    progs[i].Text = "-";
                    progs[i].ForeColor = Color.White;
                    effs[i].Text = "-";
                    effs[i].ForeColor = Color.White;
                    fpys[i].Text = "-";
                    fpys[i].ForeColor = Color.White;
                    acts[i].Text = "-";
                    acts[i].ForeColor = Color.White;
                    oees[i].Text = "-";
                    oees[i].ForeColor = Color.White;

                }
                else
                {
                    labels[i].Text = string.Empty;
                    pictureBoxes[i].Image = null;
                }
            }
        }

        private void repair_btn_Click(object sender, EventArgs e)
        {
            DataTable machineData = GetData("SELECT Id, 時間, 機台編號, 運作狀態, 製令單號 FROM 機台監測即時數據資料表");

            var status_cur = machineData.AsEnumerable()
                .GroupBy(row => row.Field<string>("機台編號"))
                .Select(group => group.OrderByDescending(row => row.Field<DateTime>("時間")).First());

            var workingIDs = status_cur
                .Where(row => row.Field<string>("運作狀態") == "維修中")
                .Select(row => row.Field<string>("機台編號"));


            string[] workingIDArr = workingIDs.ToArray();

            Label[] labels = { model_1, model_2, model_3 };
            PictureBox[] pictureBoxes = { machine_1, machine_2, machine_3 };

            Label[] stats = { md1_stat, md2_stat, md3_stat };
            Label[] nums = { md1_num, md2_num, md3_num };
            Label[] times = { md1_time, md2_time, md3_time };
            Label[] goals = { md1_goal, md2_goal, md3_goal };
            Label[] actuals = { md1_actual, md2_actual, md3_actual };
            Label[] progs = { md1_prog, md2_prog, md3_prog };
            Label[] effs = { md1_eff, md2_eff, md3_eff };
            Label[] fpys = { md1_fpy, md2_fpy, md3_fpy };
            Label[] acts = { md1_act, md2_act, md3_act };
            Label[] oees = { md1_oee, md2_oee, md3_oee };


            for (int i = 0; i < labels.Length; i++)
            {
                if (i < workingIDArr.Length)
                {
                    labels[i].Text = workingIDArr[i];

                    if (machineImageMap.TryGetValue(workingIDArr[i], out string imagePath))
                    {
                        pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxes[i].Image = Image.FromFile(imagePath);
                    }

                    stats[i].Text = "維修中";
                    stats[i].BackColor = Color.Blue;
                    stats[i].ForeColor = Color.Black;
                    nums[i].Text = "-";
                    nums[i].ForeColor = Color.White;
                    times[i].Text = "-";
                    times[i].ForeColor = Color.White;
                    goals[i].Text = "-";
                    goals[i].ForeColor = Color.White;
                    actuals[i].Text = "-";
                    actuals[i].ForeColor = Color.White;
                    progs[i].Text = "-";
                    progs[i].ForeColor = Color.White;
                    effs[i].Text = "-";
                    effs[i].ForeColor = Color.White;
                    fpys[i].Text = "-";
                    fpys[i].ForeColor = Color.White;
                    acts[i].Text = "-";
                    acts[i].ForeColor = Color.White;
                    oees[i].Text = "-";
                    oees[i].ForeColor = Color.White;

                }
                else
                {
                    labels[i].Text = string.Empty;
                    pictureBoxes[i].Image = null;
                }
            }
        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            DataTable machineData = GetData("SELECT Id, 時間, 機台編號, 運作狀態, 製令單號 FROM 機台監測即時數據資料表");

            var status_cur = machineData.AsEnumerable()
                .GroupBy(row => row.Field<string>("機台編號"))
                .Select(group => group.OrderByDescending(row => row.Field<DateTime>("時間")).First());

            var workingIDs = status_cur
                .Where(row => row.Field<string>("運作狀態") == "待單停機")
                .Select(row => row.Field<string>("機台編號"));


            string[] workingIDArr = workingIDs.ToArray();

            Label[] labels = { model_1, model_2, model_3 };
            PictureBox[] pictureBoxes = { machine_1, machine_2, machine_3 };

            Label[] stats = { md1_stat, md2_stat, md3_stat };
            Label[] nums = { md1_num, md2_num, md3_num };
            Label[] times = { md1_time, md2_time, md3_time };
            Label[] goals = { md1_goal, md2_goal, md3_goal };
            Label[] actuals = { md1_actual, md2_actual, md3_actual };
            Label[] progs = { md1_prog, md2_prog, md3_prog };
            Label[] effs = { md1_eff, md2_eff, md3_eff };
            Label[] fpys = { md1_fpy, md2_fpy, md3_fpy };
            Label[] acts = { md1_act, md2_act, md3_act };
            Label[] oees = { md1_oee, md2_oee, md3_oee };


            for (int i = 0; i < labels.Length; i++)
            {
                if (i < workingIDArr.Length)
                {
                    labels[i].Text = workingIDArr[i];

                    if (machineImageMap.TryGetValue(workingIDArr[i], out string imagePath))
                    {
                        pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxes[i].Image = Image.FromFile(imagePath);
                    }

                    stats[i].Text = "待單停機";
                    stats[i].BackColor = Color.Gray;
                    stats[i].ForeColor = Color.Black;
                    nums[i].Text = "-";
                    nums[i].ForeColor = Color.White;
                    times[i].Text = "-";
                    times[i].ForeColor = Color.White;
                    goals[i].Text = "-";
                    goals[i].ForeColor = Color.White;
                    actuals[i].Text = "-";
                    actuals[i].ForeColor = Color.White;
                    progs[i].Text = "-";
                    progs[i].ForeColor = Color.White;
                    effs[i].Text = "-";
                    effs[i].ForeColor = Color.White;
                    fpys[i].Text = "-";
                    fpys[i].ForeColor = Color.White;
                    acts[i].Text = "-";
                    acts[i].ForeColor = Color.White;
                    oees[i].Text = "-";
                    oees[i].ForeColor = Color.White;

                }
                else
                {
                    labels[i].Text = string.Empty;
                    pictureBoxes[i].Image = null;
                }
            }
        }


        public class MachineInfo
        {
            public string Status { get; set; }
            public double ActivationRate { get; set; }
            public string OrderNumber { get; set; }
            public double Progress { get; set; }
            public TimeSpan ProductionTime { get; set; }
            public string OperatorName { get; set; }

            public string abOrderNumber { get; set; }
            public string abType { get; set; }
            public DateTime abTime { get; set; }
        }

        private Dictionary<string, MachineInfo> machineStatus = new Dictionary<string, MachineInfo>();

        private void machine_btn_Click(object sender, EventArgs e)
        {
            efficiency_panel.Visible = false;
            machine_panel.Visible = true;
            power_panel.Visible = false;
            maintain_panel.Visible = false;
            machineStatus.Clear();
            
            DataTable machineData = GetData("SELECT Id, 時間, 機台編號, 運作狀態, 製令單號 FROM 機台監測即時數據資料表");
            var status_cur = machineData.AsEnumerable()
                .GroupBy(row => row.Field<string>("機台編號"))
                .Select(group => group.OrderByDescending(row => row.Field<DateTime>("時間")).First());     

            foreach (var row in status_cur)
            {
                string machineId = row.Field<string>("機台編號");
                string status = row.Field<string>("運作狀態");
                machineStatus[machineId] = new MachineInfo
                {
                    Status = status
                };
            }

            DataTable heartProdData = GetData("SELECT Id, 開始生產時間, 機台編號, 製令單號, 作業人員, 目標數量, " +
                                              "實際數量, 生產週期, 生產效率, 直通率, 機台稼動率 FROM 生產製造心跳表");

            foreach (DataRow row in heartProdData.Rows)
            {
                string machineId = row.Field<string>("機台編號");
                double actRate = row.IsNull("機台稼動率") ? 0 : row.Field<double>("機台稼動率");
                string orderNum = row.IsNull("製令單號") ? "-" : row.Field<string>("製令單號");
                int goalProd = row.IsNull("目標數量") ? 0 : row.Field<int>("目標數量");
                int actualProd = row.IsNull("實際數量") ? 0 : row.Field<int>("實際數量");
                string opName = row.IsNull("作業人員") ? "-" : row.Field<string>("作業人員");

                if (machineStatus.ContainsKey(machineId))
                {
                    machineStatus[machineId].ActivationRate = actRate;
                    machineStatus[machineId].OrderNumber = orderNum;

                    if (goalProd != 0)
                    {
                        machineStatus[machineId].Progress = (double)actualProd / goalProd * 100;
                    }
                    else
                    {
                        machineStatus[machineId].Progress = 0;
                    }

                    if (!row.IsNull("開始生產時間"))
                    {
                        DateTime startTime = row.Field<DateTime>("開始生產時間");
                        TimeSpan duration = DateTime.Now - startTime;
                        machineStatus[machineId].ProductionTime = duration;
                    }
                    else
                    {
                        machineStatus[machineId].ProductionTime = TimeSpan.Zero;
                    }

                    machineStatus[machineId].OperatorName = opName;

                }
            }

            DataTable abnormalData = GetData("SELECT Id, 時間, 機台編號, 異常資訊, 製令單號 FROM 機台異常記錄表");

            foreach (DataRow row in abnormalData.Rows)
            {
                string machineId = row.Field<string>("機台編號");
                string aborderNum = row.IsNull("製令單號") ? "-" : row.Field<string>("製令單號");
                string abtype = row.IsNull("異常資訊") ? "-" : row.Field<string>("異常資訊");
                
                if (machineStatus.ContainsKey(machineId))
                {
                    machineStatus[machineId].abOrderNumber = aborderNum;
                    machineStatus[machineId].abType = abtype;

                    if (!row.IsNull("時間"))
                    {
                        DateTime abtime = row.Field<DateTime>("時間");
                        machineStatus[machineId].abTime = abtime;
                    }
                    else
                    {
                        machineStatus[machineId].abTime = DateTime.MinValue;
                    }
                }
            }

            comboBoxMachineIds.DataSource = new List<string>(machineStatus.Keys);

        }

        private void comboBoxMachineIds_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMachineId = comboBoxMachineIds.SelectedItem.ToString();


            if (machineImageMap.TryGetValue(selectedMachineId, out string imagePath))
            {
                machine_picturebox.Image = Image.FromFile(imagePath);
                machine_picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (machineStatus.TryGetValue(selectedMachineId, out MachineInfo info))
            {
                machine_model_label.Text = selectedMachineId + "(機台型號)";
                machine_status_label.Text = info.Status;

                if (info.ActivationRate >= 85)
                {
                    machine_act_label.ForeColor = Color.Green;
                }
                else if (info.ActivationRate > 80 && info.ActivationRate < 85)
                {
                    machine_act_label.ForeColor = Color.Yellow;
                }
                else
                {
                    machine_act_label.ForeColor = Color.Red;
                }
                machine_act_label.Text = info.ActivationRate.ToString("F2") + "%";

                machine_order_label.Text = info.OrderNumber;

                machine_progress_label.Text = info.Progress.ToString("F2") + "%";

                machine_time_label.Text = $"{info.ProductionTime.Hours}h {info.ProductionTime.Minutes}m";

                machine_opName_label.Text = info.OperatorName;

                ab_machine_order_label.Text = info.abOrderNumber;

                machine_ab_type_label.Text = info.abType;

                machine_ab_time_label.Text = info.abTime.ToString("M/d HH:mm");

                machine_ab_name_label.Text = info.OperatorName;
            }
        }

        private void power_btn_Click(object sender, EventArgs e)
        {
            efficiency_panel.Visible = false;
            machine_panel.Visible = false;
            power_panel.Visible = true;
            maintain_panel.Visible = false;

            DataTable powerData = GetData("SELECT Id, 時間, 機台編號, 比流器編號, 電壓, 電流 FROM 各CT即時電量數據資料表");

            id_combobox.DataSource = powerData.AsEnumerable()
                .Select(row => row.Field<string>("機台編號"))
                .Distinct()
                .ToList();

            transformer_combobox.DataSource = powerData.AsEnumerable()
                .Select(row => row.Field<string>("比流器編號"))
                .Distinct()
                .ToList();

            var groupedData = powerData.AsEnumerable()
                .GroupBy(row => row.Field<string>("機台編號"))
                .Select(group => new
                {
                    MachineId = group.Key,
                    LatestRecord = group.OrderByDescending(row => row.Field<DateTime>("時間")).First()
                });

            DataTable resultTable = new DataTable();
            resultTable.Columns.Add("Id", typeof(int));
            resultTable.Columns.Add("機台編號", typeof(string));
            resultTable.Columns.Add("比流器編號", typeof(string));
            resultTable.Columns.Add("目前電壓", typeof(double));
            resultTable.Columns.Add("目前電流", typeof(double));
            resultTable.Columns.Add("本日累計用電量", typeof(double));
            resultTable.Columns.Add("本日累計碳排量", typeof(double));

            int idCount = 1;

            foreach (var group in groupedData)
            {
                DataRow latestRow = group.LatestRecord;
                int id = latestRow.Field<int>("Id");
                string transformerId = latestRow.Field<string>("比流器編號");
                double voltage = latestRow.Field<int>("電壓");
                double current = latestRow.Field<int>("電流");
                DateTime latestTime = latestRow.Field<DateTime>("時間");

                DateTime startTime = latestTime.Date; 
                double usageDuration = (latestTime - startTime).TotalHours;

                double totalElectricityUsage = voltage * current / 1000 * usageDuration;
                totalElectricityUsage = Math.Round(totalElectricityUsage, 2);

                double totalCarbonEmissions = totalElectricityUsage * 0.5;
                totalCarbonEmissions = Math.Round(totalCarbonEmissions, 2);

                DataRow newRow = resultTable.NewRow();
                newRow["Id"] = idCount++;
                newRow["機台編號"] = group.MachineId;
                newRow["比流器編號"] = transformerId;
                newRow["目前電壓"] = voltage;
                newRow["目前電流"] = current;
                newRow["本日累計用電量"] = totalElectricityUsage;
                newRow["本日累計碳排量"] = totalCarbonEmissions;
                resultTable.Rows.Add(newRow);
            }

            power_dataGridView.DataSource = resultTable;

        }

        private void id_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectRowInDataGridView(id_combobox.SelectedItem.ToString(), "機台編號");

        }

        private void transformer_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectRowInDataGridView(transformer_combobox.SelectedItem.ToString(), "比流器編號");
        }

        private void SelectRowInDataGridView(string value, string columnName)
        {
            power_dataGridView.ClearSelection(); 

            foreach (DataGridViewRow row in power_dataGridView.Rows)
            {
                if (row.Cells[columnName].Value.ToString() == value)
                {

                    row.Cells[columnName].Selected = true;
                    break;
                }
            }
        }

        private void power_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = power_dataGridView.Rows[e.RowIndex];
                if (e.ColumnIndex == power_dataGridView.Columns["機台編號"].Index)
                {
                    string machineId = row.Cells["機台編號"].Value.ToString();
                    id_combobox.SelectedItem = machineId;
                }
                else if (e.ColumnIndex == power_dataGridView.Columns["比流器編號"].Index)
                {
                    string transformerId = row.Cells["比流器編號"].Value.ToString();
                    transformer_combobox.SelectedItem = transformerId;
                }
            }
        }

        private void power_dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.ForeColor = SystemColors.HotTrack; 
            e.CellStyle.BackColor = SystemColors.GradientActiveCaption;
            e.CellStyle.Font = new Font("微软雅黑", 12, FontStyle.Bold);
        }

        private void maintain_btn_Click(object sender, EventArgs e)
        {
            //CreateEquipTable();

            efficiency_panel.Visible = false;
            machine_panel.Visible = false;
            power_panel.Visible = false;
            maintain_panel.Visible = true;

            DataTable maintainData = GetData("SELECT Id, 機台編號, 已運行時數, 建議保養時數 FROM 機台健康度記錄表");

            maintain_datagrid.DataSource = maintainData;

            if (!maintain_datagrid.Columns.Contains("機台健康度"))
            {
                maintain_datagrid.Columns.Add("機台健康度", "機台健康度");
            }

            foreach (DataGridViewRow row in maintain_datagrid.Rows)
            {
                if (!row.IsNewRow)
                {
                    double recHours = Convert.ToDouble(row.Cells["建議保養時數"].Value);
                    double runHours = Convert.ToDouble(row.Cells["已運行時數"].Value);

                    double healthStatus = (recHours - runHours) / recHours * 100;
                    row.Cells["機台健康度"].Value = healthStatus.ToString("0.#");
                }
            }

        }

        private void maintain_datagrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.ForeColor = SystemColors.HotTrack;
            e.CellStyle.BackColor = SystemColors.GradientActiveCaption;
            e.CellStyle.Font = new Font("微软雅黑", 12, FontStyle.Bold);
        }

    }
}

