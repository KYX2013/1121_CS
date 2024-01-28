using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data;
using System.Data .SqlClient ;

namespace DataBindingDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static DataSet ds = new DataSet();

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|ch19DB.mdf;" +
                    "Integrated Security=True";
                SqlDataAdapter daEmployee = new SqlDataAdapter("SELECT * FROM 員工 ORDER BY 編號 DESC", cn);
                daEmployee.Fill(ds, "員工");
                // ComboBox控制項資料繫結
                cboId.DataSource = ds;
                cboId.DisplayMember = "員工.編號";
                // TextBox控制項資料繫結
                txtName.DataBindings.Add("Text", ds, "員工.姓名");
                txtTel.DataBindings.Add("Text", ds, "員工.電話");
                txtPosition.DataBindings.Add("Text", ds, "員工.職稱");
                txtSalary.DataBindings.Add("Text", ds, "員工.薪資");
                // DataGridView控制項資料繫結
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "員工";
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            DataTable dt = ds.Tables["員工"];
            int max = 0;
            foreach(DataRow dr in dt.Rows)
            {
                if (int.Parse(dr["編號"].ToString()) > max)
                    max = int.Parse(dr["編號"].ToString());
            }

            DataRow newRow = dt.NewRow();
            newRow["編號"] = (max+1);
            dt.Rows.InsertAt(newRow,0);
        }

        private void remove_Click(object sender, EventArgs e)
        {
            DataTable dt = ds.Tables["員工"];
            DataRow[] delRow = dt.Select(string.Format($"編號 = {cboId.Text}"));

            foreach (DataRow row in delRow)
            {
                row.Delete();
            }
        }
    }
}
