using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SystemManagement.Forms
{
    public partial class Form_Bl : Form
    {
        //string connectionString = @"Data Source=DESKTOP-5UHHJB2\SQLEXPRESS;Initial Catalog=RHManagement;Integrated Security=True;User Id=sa ; password=sakif;";
       // string connectionString = "Server=DESKTOP-5UHHJB2;Database=RHManagement;User Id=sa ; password=sakif;";
        string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
        private SqlCommand sqlCommand = new SqlCommand();
        int Id = 0;
        public Form_Bl()
        {
            InitializeComponent();
        }
        DataTable transactiondt = new DataTable();
        private int b;
        private int a;
        private int c;

        private void button5_Click(object sender, EventArgs e)
        {
            /* using (SqlConnection sqlCon = new SqlConnection(connectionString))
             {
                 sqlCon.Open();
                 string s = "select * from Room";
                 SqlDataAdapter sqlDa = new SqlDataAdapter("Vl2", sqlCon);
                // SqlDataAdapter sqlDa = new SqlDataAdapter(s, sqlCon);
                 sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                 DataTable dtbl = new DataTable();
                 sqlDa.Fill(dtbl);
                 dataGridView1.DataSource = dtbl;
             }*/

            SqlConnection sqlCon = new SqlConnection(connectionString);
            // using (SqlConnection sqlCon = new SqlConnection(connectionString))
            // {
            sqlCon.Open();
            String query = "SELECT FID,FName, FDescrip,FPrice,Status FROM AddFood";
            SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
            // SqlDataAdapter sqlDa = new SqlDataAdapter("Vm2", sqlCon);
            // sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            /*  using (SqlConnection sqlCon = new SqlConnection(connectionString))
              {
                  sqlCon.Open();
                  SqlDataAdapter sqlDa = new SqlDataAdapter("Sv4", sqlCon);
                  sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                  sqlDa.SelectCommand.Parameters.AddWithValue("@Sv4", txtsearch.Text.Trim());
                  DataTable dtbl = new DataTable();
                  sqlDa.Fill(dtbl);
                  dataGridView1.DataSource = dtbl;
              }
              */
            SqlConnection con = new SqlConnection(connectionString);
            // using (SqlConnection sqlCon = new SqlConnection(connectionString))
            // {
            con.Open();
            
            String query = "SELECT FID,FName, FDescrip,FPrice,Status FROM addFood where FName like '%" + txtsearch.Text.ToString() + "%'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                
                txtnamme.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtrate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                
                
                
            }
        }
        private bool Validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(txtqty.Text))
            {
                result = false;

            }
            else
            {
                result = true;
            }
            return result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                string name = txtnamme.Text;
                string rate = txtrate.Text;
                int r = Int32.Parse(rate);
                string qty = txtqty.Text;
                int q = Int32.Parse(qty);
                int total = r * q;
                if (name == "")
                {
                    MessageBox.Show("Please fill");
                }
                else
                {
                    transactiondt.Rows.Add(name, r, q, total);
                    dataGridView2.DataSource = transactiondt;
                }
            }
            else
            {
                MessageBox.Show("Please fill Quantity");
            }
        }
        void Clear()
        {
            txtnamme.Text = txtrate.Text = txtqty.Text = "";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < transactiondt.Rows.Count; i++)
            {
                DataRow recRow = transactiondt.Rows[i];
                if (recRow[0].ToString() == txtnamme.Text)
                {
                    
                        recRow.Delete();
                        transactiondt.AcceptChanges();
                    
                }
            }
            Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value);
            }
            txttotal.Text = (sum.ToString());
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtdiscount.Text.Length > 0)

                {
                    a = Convert.ToInt32(txttotal.Text);
                    b = Convert.ToInt32(txtdiscount.Text);
                    c = a - b;
                    txtnet.Text = Convert.ToString(c);
                    txtau.Text = Convert.ToString(c);
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                txtbalance.Text = (Convert.ToInt32(textBox1.Text) - Convert.ToInt32(txtnet.Text)).ToString();
            }
        }

        private void btnsavve_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnu.Text.Trim() != "" && txtau.Text.Trim() != "" && cmbpu.Text.Trim() != "" && cmbsu.Text.Trim() != "")
                {
                    /* using (SqlConnection sqlCon = new SqlConnection(connectionString))
                     {
                         sqlCon.Open();
                         SqlCommand sqlCmd = new SqlCommand("Ado", sqlCon);
                         sqlCmd.CommandType = CommandType.StoredProcedure;
                         sqlCmd.Parameters.AddWithValue("@Id", Id);
                         sqlCmd.Parameters.AddWithValue("@Uname", txtnu.Text.Trim());
                         sqlCmd.Parameters.AddWithValue("@Uamount", txtau.Text.Trim());
                         sqlCmd.Parameters.AddWithValue("@Pmethod", cmbpu.Text.Trim());
                         sqlCmd.Parameters.AddWithValue("@Ustatus", cmbsu.Text.Trim());
                         sqlCmd.Parameters.AddWithValue("@Udate", dtpu.Value.ToString());
                         sqlCmd.ExecuteNonQuery();
                         MessageBox.Show("Submitted");
                         Clear1();

                     }*/
                    SqlConnection sqlCon = new SqlConnection(connectionString);
                    // using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    // {
                    sqlCon.Open();
                    string s = "Dine in";
                    string Time = DateTime.Now.ToString("hh:mm:ss tt");
                    string Date = DateTime.Now.ToString("dd/MM/yyyy");
                    string query = " insert into Order2(Name, type,price,paymentMethod,date,time) values ('" + txtnu.Text.Trim() + "','"
                                                                    + s + "','"
                                                                    + txtau.Text.Trim() + "','"
                                                                    + cmbpu.Text.Trim() + "','"
                                                                    + Date + "','"
                                                                    + Time + "')";
                    // private SqlCommand sqlCommand;
                    sqlCommand = new SqlCommand(query, sqlCon);
                    // sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    // sqlConnection.Close();
                    //LoadData();
                    MessageBox.Show("Data Saved Successfully");

                    Clear();
                    Clear1();
                    dataGridView2.DataSource = null;
                    dataGridView2.Rows.Clear();
                    transactiondt.Clear();

                    sqlCon.Close();
                }
                else
                    MessageBox.Show("Please fill up");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error!");
            }
        }
        void Clear1()
        {
            txtnu.Text = txtau.Text = txttotal.Text= txtdiscount.Text= txtnet.Text= textBox1.Text= txtbalance.Text= cmbpu.Text = cmbsu.Text = "";
            Id = 0;
            btnsavve.Text = "Save";

        }

        private void btnclearr_Click(object sender, EventArgs e)
        {
            Clear1();
        }

        private void Form_Bl_Load(object sender, EventArgs e)
        {
            transactiondt.Columns.Add("Name");
            transactiondt.Columns.Add("Price");
            transactiondt.Columns.Add("Quantity");
            transactiondt.Columns.Add("Total");
        }

        private void label15_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtnamme_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView2.CurrentRow.Index != -1)
            {

                txtnamme.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                txtrate.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                txtqty.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();



            }
        }
    }
}
