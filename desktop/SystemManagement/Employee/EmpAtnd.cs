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
    public partial class EmpAtnd : Form
    {
        private string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
        private SqlCommand sqlCommand = new SqlCommand();
        private SqlCommand sqlCommand1 = new SqlCommand();
        private SqlDataAdapter sqlAdapter = new SqlDataAdapter();
        private DataSet dataSet = new DataSet();
        private DataSet dataSet2 = new DataSet();

        private SqlConnection sqlConnection = new SqlConnection();
        public EmpAtnd()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool NoEmpName(string eID)
        {
            try
           {
                //sqlConnection.Open();
                sqlCommand.CommandText = " select * from Emp where E_ID = '" + eID + "'";
                sqlCommand.Connection = sqlConnection;

                sqlAdapter.SelectCommand = sqlCommand;
                sqlAdapter.Fill(dataSet, "Emp");
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    //Response.Redirect("home.aspx");
                    return false;
                }
                else
                {
                    return true;

                }
                //sqlConnection.Close();

            }
           catch (Exception ex)
            {
                // MessageBox.Show("Error");

           }

            return false;

        }
        private bool atndExist(string eID, string year, string mon)
        {
            try
            {
                bool result = false;
                //sqlConnection.Open();
                 sqlCommand.CommandText = " select * from EmpAtnd3 where E_ID = '" + eID + "' And Year = '" + year + "' And Month = '" + mon + "'";
             //   sqlCommand.CommandText = " select * from EmpAtnd where Year = '" + y + "'";
                sqlCommand.Connection = sqlConnection;

                sqlAdapter.SelectCommand = sqlCommand;
                sqlAdapter.Fill(dataSet, "EmpAtnd3");
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    //Response.Redirect("home.aspx");
                    result= true;
                }
                else
                {
                    result =  false;

                }

                //sqlConnection.Close();
                return result;

            }
             catch (Exception ex)
              {
            // MessageBox.Show("Error");

              }
            return false;
          



        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
              {
            if (atndExist(label7.Text, comboBox1.Text, comboBox2.Text) )
            {
                MessageBox.Show("Attendance Already Given!");
                ClearData();
                LoadData();
                Employee.EmpAtnd er = new Employee.EmpAtnd();
                //  ag.MdiParent = this ;
                er.StartPosition = FormStartPosition.CenterScreen;
                er.Show();
                this.Close();
                //   ClearData();

                //break;
            }
         //   else
          //  {
               /* if (NoEmpName(textBox3.Text) == true)
                {
                    MessageBox.Show("Employee Doesn't Exists!");
                    ClearData();
                    LoadData();
                    Employee.EmpAtnd er = new Employee.EmpAtnd();
                    //  ag.MdiParent = this ;
                    er.StartPosition = FormStartPosition.CenterScreen;
                    er.Show();
                    this.Close();
                }*/
                
                /*  else if (atndExist(textBox3.Text, comboBox1.Text, comboBox2.Text))
                      {
                          MessageBox.Show("Attendance Already Given!");
                         ClearData();
                         LoadData();
                         Employee.EmpAtnd er = new Employee.EmpAtnd();
                         //  ag.MdiParent = this ;
                         er.StartPosition = FormStartPosition.CenterScreen;
                         er.Show();
                        this.Close();
                         //   ClearData();

                         //break;
                     }*/
                else
                {
                    string query = " insert into EmpAtnd3(E_ID,Year,Month,WD,PD) values ('" + Int32.Parse(label7.Text) + "','"
                                                      + comboBox1.Text + "','"
                                                      + comboBox2.Text + "','"
                                                      + textBox1.Text + "','"
                                                      + textBox2.Text + "')";
                    // private SqlCommand sqlCommand;
                    sqlCommand = new SqlCommand(query, sqlConnection);

                        // sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        // sqlConnection.Close();
                        //LoadData();
                        MessageBox.Show("Data Added Successfully");

                        ClearData();
                        LoadData();
                    

                }
          //  }
        
                
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Error");
            }

        }
        private void ClearData()
        {
            textBox1.Clear();
            textBox2.Clear();
            label7.Text = "";
            comboBox1.ResetText();
            comboBox2.ResetText();
            

        }
        private void LoadData()

        {
            // sqlConnection.Open();
            String str = "SELECT E_ID,Year,Month,WD,PD FROM EmpAtnd3";
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
        private void LoadData2()

        {
            // sqlConnection.Open();
            String str = "SELECT E_ID FROM Emp";
            sqlCommand1 = new SqlCommand(str, sqlConnection);
            sqlCommand1.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlCommand1;

            DataSet ds = new DataSet();
            da.Fill(ds);
            //dataGridView1.DataSource = ds;
            //dataGridView1.DataBind();
            dataGridView2.DataSource = ds.Tables[0];

        }

        private void EmpAtnd_Load(object sender, EventArgs e)
        {
            //label7.Text = Login.ControlID.TextData;
            LoadData();
            LoadData2();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            String query = "SELECT * FROM EmpAtnd3 where E_ID like '%" + textBox4.Text.ToString() + "%'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label7.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
