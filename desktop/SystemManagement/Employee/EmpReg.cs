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
using System.IO;

namespace SystemManagement.Employee
{
    public partial class EmpReg : Form
    {
        private string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";

        private SqlConnection sqlConnection = new SqlConnection();
        private SqlCommand sqlCommand = new SqlCommand();
        private SqlCommand sqlCommand1 = new SqlCommand();
        private SqlCommand sqlCommand2 = new SqlCommand();
        private SqlCommand sqlCommand3 = new SqlCommand();
        private SqlCommand sqlCommand4 = new SqlCommand();
        private SqlDataAdapter sqlAdapter = new SqlDataAdapter();
        private DataSet dataSet = new DataSet();
        private SqlDataReader myReader = null;
        public EmpReg()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EmpReg_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
            LoadData();
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

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox3.Text.Length > 0)
                {
                    comboBox1.Focus();
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
                if (comboBox1.Text.Length > 0)
                {
                    dateTimePicker1.Focus();
                }
                else
                {
                    comboBox1.Focus();
                }
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comboBox2.Text.Length > 0)
                {
                    richTextBox1.Focus();
                }
                else
                {
                    comboBox2.Focus();
                }
            }
        }

        private bool Validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox1, "Name Required");
            }

            else if (string.IsNullOrEmpty(textBox3.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox3, "Email Required");
            }


            else if (string.IsNullOrEmpty(comboBox1.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(comboBox1, "Post Required");
            }

            else if (string.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox2, "Mobile No Required");
            }
            else if (textBox2.Text.Length != 11)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox2, "Invalid Mobile No");
            }
            else if (string.IsNullOrEmpty(comboBox2.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(comboBox2, "Working Hour Required");
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        string fileName;
        private void picaddbtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    // label11.Text = fileName;
                    pictureBox1.Image = Image.FromFile(fileName);

                }
            }
        }

        private void picrmvbtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void LoadData()

        {
            try
            {   // sqlConnection.Open();
                String str = "SELECT E_ID, Name,Address,Mobile_No,Emp_Email,Emp_Role,JoinDate,DOB,Salary,duty , imgFile FROM Emp";
                sqlCommand1 = new SqlCommand(str, sqlConnection);
                sqlCommand1.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlCommand1;
                DataTable dt = new DataTable();

                //  DataSet ds = new DataSet();
                da.Fill(dt);
                //dataGridView1.DataSource = ds;
                //dataGridView1.DataBind();
                //  dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.DataSource = dt;
                //  dataGridView1.RowTemplate.Height = 500;
                //  DataGridViewImageColumn image = new DataGridViewImageColumn();
                // image.ImageLayout = DataGridViewImageCellLayout.Stretch;
                //  da.Dispose();
                /*    using (cmd)
                    {
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        adp.Fill(ds);

                    }
                    dataGridView1.DataSource = dt;
                    */

            }
            catch (Exception e)
            {

            }
        }
        byte[] ConvertImageToBinary(Image img)
        {
            using (System.IO.MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();

            }

        }

        String temp = "";
        private void SaveEmp_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation())
                {
                    String str1 = "SELECT TOP(1) salary FROM EmpSalary where EMP_role = @search";

                    sqlCommand2 = new SqlCommand(str1, sqlConnection);
                    sqlCommand2.Parameters.Add("@search", SqlDbType.VarChar).Value = comboBox1.Text;
                    sqlCommand2.ExecuteNonQuery();
                    myReader = sqlCommand2.ExecuteReader();
                    while (myReader.Read())
                    {
                        temp = (myReader["salary"].ToString());

                    }
                    sqlConnection.Close();

                    int m = Int32.Parse(temp);
                    string query = " insert into Emp(Name,Address,Mobile_No,Emp_Email,Emp_Role,JoinDate,DOB,Salary,Image,duty ,imgFile) values ('" + textBox1.Text + "','"
                                                                + richTextBox1.Text + "','"
                                                                + textBox2.Text + "','"
                                                                + textBox3.Text + "','"
                                                                + comboBox1.Text + "' ,'"
                                                                + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "','"
                                                                + dateTimePicker2.Value.ToString("MM/dd/yyyy") + "','"
                                                                + m + "','"
                                                                + ConvertImageToBinary(pictureBox1.Image) + "','"
                                                                + comboBox2.Text + "','"
                                                                + fileName + "')";
                    // private SqlCommand sqlCommand;
                    sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    //sqlConnection.Close();
                    //LoadData();
                    MessageBox.Show("Data Saved Successfully");

                    ClearData();
                    LoadData();



                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error!");
            }

        }
        private void ClearData()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.ResetText();
            comboBox2.ResetText();
            label10.Text = "";

            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            richTextBox1.Clear();
            pictureBox1.Image = null;
        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        String temp2 = "";
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            /*    String str2 = "SELECT  imgFile FROM Emp where E_ID = @search";

                sqlCommand3 = new SqlCommand(str2, sqlConnection);
                sqlCommand3.Parameters.Add("@search", SqlDbType.VarChar).Value = dataGridView1.CurrentRow.Cells[0].Value.ToString();
              sqlConnection.Open();
             sqlCommand3.ExecuteNonQuery();
                myReader = sqlCommand3.ExecuteReader();
                while (myReader.Read())
                {
                      temp2 = (myReader["imgFile"].ToString());
                    // byte[] PhotoByte = (byte[])myReader.GetValue(9);


                   // byte[] PhotoByte = (byte[])(myReader["Image"]);
                  //  MemoryStream ms = new MemoryStream(PhotoByte);
                  //  pictureBox1.Image = Image.FromStream(ms);
                    //  MemoryStream mem = new MemoryStream(PhotoByte, 0, PhotoByte.Length);
                    //but an error takes place on next line "Parameter is not valid."             
                     pictureBox1.Image = Image.FromFile(temp2);

                }
            sqlConnection.Close();
            */
            try
            {

                label10.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                //string firstCellText = dataGridview1.CurrentRow.Cells[1].value.toStrign();
                textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                richTextBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                comboBox2.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                pictureBox1.Image = Image.FromFile(dataGridView1.CurrentRow.Cells[10].Value.ToString());
            }
            catch (Exception ex)
            {

            }


        }

        private void updateEmp_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are You Sure You Want to Update", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string query = " update Emp set Name ='" + textBox1.Text + "', Address = '" + richTextBox1.Text + "', Mobile_No = '" + textBox2.Text + "', Emp_Email = '" + textBox3.Text + "' , Emp_Role = '" + comboBox1.Text + "' , JoinDate = '" + dateTimePicker2.Value.ToString("MM/dd/yyyy") + "' , DOB = '" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "'  , Image = '" + ConvertImageToBinary(pictureBox1.Image) + "'  , duty = '" + comboBox2.Text + "'  , imgFile = '" + fileName + "' where E_ID = '" + label10.Text + "'";
                sqlCommand4 = new SqlCommand(query, sqlConnection);

                sqlCommand4.ExecuteNonQuery();
                LoadData();
                ClearData();
                MessageBox.Show("Data Updated Successfully");
            }
        }

        private void delEmp_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string query = " delete from Emp where E_ID = '" + label10.Text + "'";
                sqlCommand3 = new SqlCommand(query, sqlConnection);
                sqlCommand3.ExecuteNonQuery();
                LoadData();
                ClearData();
                MessageBox.Show("Data Deleted Successfully");
            }
        }
    }
}
