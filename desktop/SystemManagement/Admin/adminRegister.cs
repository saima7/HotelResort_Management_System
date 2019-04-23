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
    public partial class adminRegister : Form
    {
        private string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";

        private SqlConnection sqlConnection = new SqlConnection();
        private SqlCommand sqlCommand = new SqlCommand();
        private SqlCommand sqlCommand1 = new SqlCommand();
        private SqlCommand sqlCommand2 = new SqlCommand();
        private SqlCommand sqlCommand3 = new SqlCommand();
        private SqlDataAdapter sqlAdapter = new SqlDataAdapter();
        private DataSet dataSet = new DataSet();



        public adminRegister()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text.Length > 0)
                {
                    textBox2.Focus();
                }
                else
                {
                    textBox1.Focus();
                }
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox2.Text.Length > 0)
                {
                    textBox3.Focus();
                }
                else
                {
                    textBox2.Focus();
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox3.Text.Length > 0)
                {
                    textBox4.Focus();
                }
                else
                {
                    textBox3.Focus();
                }
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox4.Text.Length > 0)
                {
                    textBox5.Focus();
                }
                else
                {
                    textBox4.Focus();
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox5.Text.Length > 0)
                {
                    textBox6.Focus();
                }
                else
                {
                    textBox5.Focus();
                }
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox6.Text.Length > 0)
                {
                    textBox7.Focus();
                }
                else
                {
                    textBox6.Focus();
                }
            }
        }

        private void adminRegister_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
            LoadData();
        }

        private void ClearData()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            dateTimePicker1.Value = DateTime.Now;
            richTextBox1.Clear();

        }
        private bool Validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox1, "Admin ID Required");
            }
            else if (string.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox2, "Name Required");
            }
            else if (string.IsNullOrEmpty(textBox3.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox3, "Password Required");
            }

            else if (textBox3.Text.Length < 5)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox3, "Password Minimum 5 Character Required");
            }
            else if (string.IsNullOrEmpty(textBox4.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox4, "Pin Required");
            }
            else if (textBox4.Text.Length < 4)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox4, "Pin Minimum 4 Character Required");
            }
            else if (string.IsNullOrEmpty(textBox5.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox5, "Mobile No Required");
            }
            else if (textBox5.Text.Length != 11)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox5, "Invalid Mobile No");
            }
            else if (string.IsNullOrEmpty(textBox6.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox6, "Email Required");
            }
            else if (string.IsNullOrEmpty(textBox7.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox7, "E_ID Required");
            }
            else if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(richTextBox1, "Address  Required");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }

        private bool ifUserNameExists(string userName, string eID)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand.CommandText = " select * from Admin where A_ID = '" + userName + "' or E_ID = '" + eID + "'";
                sqlCommand.Connection = sqlConnection;

                sqlAdapter.SelectCommand = sqlCommand;
                sqlAdapter.Fill(dataSet, "Admin");
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

        private void adminsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation())
                {
                    if (ifUserNameExists(textBox1.Text, textBox7.Text))
                    {
                        MessageBox.Show("Admin Id or Employee ID Already Exists!");
                    }
                    else
                    {
                        string query = " insert into Admin(A_ID,Name,Address,Password,Pin_Code,Mobile_No,Email_ID,E_ID,DOB) values ('" + textBox1.Text + "','"
                                                                + textBox2.Text + "','"
                                                                + richTextBox1.Text + "','"
                                                                + textBox3.Text + "','"
                                                                + textBox4.Text + "' ,'"
                                                                + textBox5.Text + "','"
                                                                + textBox6.Text + "','"
                                                                + textBox7.Text + "','"
                                                                + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "')";
                        // private SqlCommand sqlCommand;
                        sqlCommand = new SqlCommand(query, sqlConnection);
                        // sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        // sqlConnection.Close();
                        //LoadData();
                        MessageBox.Show("Data Saved Successfully");

                        ClearData();
                        LoadData();


                    }
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Error");
            }
        }
        private void LoadData()

        {
            // sqlConnection.Open();
            String str = "SELECT A_ID,Name,Address,Mobile_No,Email_ID,E_ID,DOB FROM Admin";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }



        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // DataGridViewRow row = dataGridView1.SelectedRow;

            // And you respective cell's value
            // textBox1.Text = row.Cells[1].Text;
            // textBox1.Text = dataGridView1.SelectedRows.Cells[3].Text;
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //string firstCellText = dataGridview1.CurrentRow.Cells[1].value.toStrign();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            richTextBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void adminupdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want to Update", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (result == DialogResult.Yes)
                {
                    string query = " update Admin set A_ID ='" + textBox1.Text + "', Name = '" + textBox2.Text + "', Address = '" + richTextBox1.Text + "', Mobile_No = '" + textBox5.Text + "' , Email_ID = '" + textBox6.Text + "' , E_ID = '" + textBox7.Text + "' , DOB = '" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "' where A_ID = '" + textBox1.Text + "'";
                    sqlCommand2 = new SqlCommand(query, sqlConnection);
                    sqlCommand2.ExecuteNonQuery();
                    LoadData();
                    ClearData();
                    MessageBox.Show("Data Updated Successfully");
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void admindelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                string query = " delete from Admin where A_ID = '" + textBox1.Text + "'";
                sqlCommand3 = new SqlCommand(query, sqlConnection);
                sqlCommand3.ExecuteNonQuery();
                LoadData();
                ClearData();
                MessageBox.Show("Data Deleted Successfully");
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
