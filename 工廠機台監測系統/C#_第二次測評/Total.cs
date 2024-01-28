using Microsoft.VisualBasic.FileIO;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace C__第二次測評
{
    public partial class Total : Form
    {
        public Total()
        {
            InitializeComponent();
            this.Load += Total_Load;
        }

        DataSet ds = new DataSet();
        private void Total_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    $"AttachDbFilename={Directory.GetParent(Directory.GetCurrentDirectory())}\\Test.mdf;" +
                    "Integrated Security=True";

                string table = "設備保養歷史清單";

                DataTable csv = ReadCSVIntoDataTable(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.ToString()+"\\Source\\設備保養歷史清單.csv");
                cn.Open();

                string deleteQuery = $"DELETE FROM {table}";
                SqlCommand command = new SqlCommand(deleteQuery, cn);
                command.ExecuteNonQuery();

                foreach (DataRow row in csv.Rows)
                {
                    command = new SqlCommand($"INSERT INTO {table} VALUES (@Param1, @Param2, @Param3, @Param4, @Param5, @Param6)", cn);

                    command.Parameters.AddWithValue("@Param1", row["ID"]);
                    command.Parameters.AddWithValue("@Param2", row["時間"]);
                    command.Parameters.AddWithValue("@Param3", row["編號"]);
                    command.Parameters.AddWithValue("@Param4", row["保養人"]);
                    command.Parameters.AddWithValue("@Param5", row["料號"]);
                    command.Parameters.AddWithValue("@Param6", row["備註"]);

                    command.ExecuteNonQuery();
                }

                //讀取確認
                SqlDataAdapter sda = new SqlDataAdapter($"SELECT*FROM {table}",cn);

                sda.Fill(ds,table);

                dataGridView1.DataSource = ds.Tables[table];
                cn.Close();
            }

            static DataTable ReadCSVIntoDataTable(string filePath)
            {
                DataTable dt = new DataTable();

                using (TextFieldParser parser = new TextFieldParser(filePath, Encoding.GetEncoding(65001)))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    string[] headers = ["ID", "時間", "編號", "保養人", "料號", "備註"];
                    foreach (string header in headers)
                    {
                        dt.Columns.Add(header);
                    }

                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();
                        dt.Rows.Add(fields);
                    }
                }

                return dt;
            }
        }
    }
}
