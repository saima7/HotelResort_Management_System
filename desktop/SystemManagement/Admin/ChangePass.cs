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

namespace SystemManagement.Admin
{
    public partial class ChangePass : Form
    {
        private string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
        private SqlCommand sqlCommand = new SqlCommand();
        private SqlCommand sqlCommand1 = new SqlCommand();
        private SqlConnection sqlConnection = new SqlConnection();
        private SqlDataAdapter sqlAdapter = new SqlDataAdapter();
        private DataSet dataSet = new DataSet();
        private DataSet dataSet2 = new DataSet();
        public ChangePass()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ChangePass_Load(object sender, EventArgs e)
        {
            label3.Text = Login.ControlID.TextData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Valid())
                {
                    if (AdminExist(label3.Text, textBox1.Text, textBox2.Text))
                    {
                        string query = " update Admin set Password ='" + textBox3.Text + "' where A_ID = '" + label3.Text + "'";
                        sqlCommand = new SqlCommand(query, sqlConnection);

                        // sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Password changed!");
                        ClearData();



                    }

                    else
                    {

                        MessageBox.Show("Old Password or Pin Code Doesn't Match");

                        ClearData();



                    }
                    //  }
                }
                else
                {
                    MessageBox.Show("Error!");
                    ClearData();
                }


            }
            catch (Exception ex)
            {
                // MessageBox.Show("Error");
            }
        }
        private bool AdminExist(string aID, string pass, string pin)
        {
            try
            {
                //sqlConnection.Open();
                sqlCommand.CommandText = " select * from Admin where A_ID = '" + aID + "' And Password = '" + pass + "' And Pin_Code = '" + pin + "' ";
                sqlCommand.Connection = sqlConnection;

                sqlAdapter.SelectCommand = sqlCommand;
                sqlAdapter.Fill(dataSet, "Emp");
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    //Response.Redirect("home.aspx");
                    return true;
                }
                else
                {
                    return false;

                }
                //sqlConnection.Close();

            }
            catch (Exception ex)
            {
                // MessageBox.Show("Error");

            }

            return false;

        }
        private bool Valid()
        {
            bool result = false;
            if (textBox3.Text.Equals(textBox4.Text))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        private void ClearData()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();


        }
    }
}
