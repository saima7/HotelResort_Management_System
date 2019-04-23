using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SystemManagement.Employee
{
    public partial class EmpList : Form
    {
        private string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
        private SqlCommand sqlCommand1 = new SqlCommand();
        private SqlCommand sqlCommand2 = new SqlCommand();
        private SqlConnection sqlConnection = new SqlConnection();
        string salary;
        public EmpList()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
        }
        private void LoadData()

        {
            // sqlConnection.Open();
            String str = "SELECT E_ID, Name,Address,Mobile_No,Emp_Email,Emp_Role,JoinDate,DOB,Salary,duty FROM Emp";
            sqlCommand1 = new SqlCommand(str, sqlConnection);
            sqlCommand1.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlCommand1;

            DataSet ds = new DataSet();
            da.Fill(ds);
            //dataGridView1.DataSource = ds;
            //dataGridView1.DataBind();
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void EmpList_Load(object sender, EventArgs e)
        {
            LoadData();
            // button2.Enabled == false;
        }

        private void EmpList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //label1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            // label2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData2();
            button2.Enabled = true;


        }
        private void LoadData2()

        {
            // sqlConnection.Open();
            String str = "SELECT Year , Month , WD, PD FROM EmpAtnd3 where E_ID = '" + label2.Text + "' order by sl Desc";
            sqlCommand1 = new SqlCommand(str, sqlConnection);
            sqlCommand1.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlCommand1;

            DataSet ds = new DataSet();
            da.Fill(ds);
            //dataGridView1.DataSource = ds;
            //dataGridView1.DataBind();
            dataGridView1.DataSource = ds.Tables[0];


        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            salary = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            button1.Enabled = true;



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int sum2 = 0;
            int dif = 0;
            double final = 0;
            double inc = 0.05;
            double final2 = 0;
            int final3 = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                sum2 += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
          //  label3.Text = sum.ToString();
            //label4.Text = sum2.ToString();
           // label4.Text = salary;
            final = inc * Convert.ToDouble(salary);
            // final2 = Convert.ToDouble(salary) + final;

            final3 = Convert.ToInt32(final);
            final3 = Convert.ToInt32(salary) + final3;


            dif = sum - sum2;
            if (dif < 40 && sum > 300)
            {
                string query = " update Emp set Salary ='" + final3 + "' where E_ID = '" + label2.Text + "'";
                sqlCommand2 = new SqlCommand(query, sqlConnection);

                sqlCommand2.ExecuteNonQuery();
                LoadData();

                MessageBox.Show("Data Updated Successfully");

            }
            else
            {
                MessageBox.Show("Not elligible for salary increment");
            }

        }
    }
}
