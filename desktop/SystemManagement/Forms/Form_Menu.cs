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

namespace SystemManagement.Forms
{
    public partial class Form_Menu : Form
    {
        // string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=SMorderDB;Integrated Security=True;";
        //string connectionString = @"Data Source=TULON-PC\\SQLEXPRESS;Initial Catalog = abc; Persist Security Info=True;User ID = sa; Password=tulon";
        string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
        private SqlCommand sqlCommand1 = new SqlCommand();
        private SqlCommand sqlCommand = new SqlCommand();
        private SqlCommand sqlCommand2 = new SqlCommand();
        int Id = 0;
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
            // using (SqlConnection sqlCon = new SqlConnection(connectionString))
            // {
            sqlCon.Open();
            DialogResult result = MessageBox.Show("Are You Sure You Want to Update", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string query = " update AddFood set FName ='" + txtname.Text + "', FDescrip = '" + txtdescription.Text + "', FPrice = '" + txtprice.Text + "', Status = '" + cmbstatus.Text + "' where FID = '" + label7.Text + "'";
                sqlCommand2 = new SqlCommand(query, sqlCon);
                sqlCommand2.ExecuteNonQuery();
                GridFill();
                Clear();
                MessageBox.Show("Data Updated Successfully");
                sqlCon.Close();
            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try {
                // if (label7.Text.Trim() != "" && txtname.Text.Trim() != "" && txtdescription.Text.Trim() != "" && cmbstatus.Text.Trim() != "" && txtprice.Text.Trim() != "" )
                // {
                /*  using (SqlConnection sqlCon = new SqlConnection(connectionString))
                  {
                      sqlCon.Open();
                      SqlCommand sqlCmd = new SqlCommand("AddEdit", sqlCon);
                      sqlCmd.CommandType = CommandType.StoredProcedure;
                      sqlCmd.Parameters.AddWithValue("@Id", Id);
                      sqlCmd.Parameters.AddWithValue("@Menuid", txtid.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@Name", txtname.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@Description", txtdescription.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@Status", cmbstatus.Text.Trim());
                      sqlCmd.Parameters.AddWithValue("@Price", txtprice.Text.Trim());

                      sqlCmd.ExecuteNonQuery();
                      MessageBox.Show("submitted");
                      Clear();
                      GridFill();


                  }
                  */
                SqlConnection sqlCon = new SqlConnection(connectionString);
                // using (SqlConnection sqlCon = new SqlConnection(connectionString))
                // {
                sqlCon.Open();
                string query = " insert into AddFood(FName, FDescrip,FPrice,Status) values ('" + txtname.Text.Trim() + "','"
                                                                + txtdescription.Text.Trim() + "','"
                                                                + txtprice.Text.Trim() + "','"
                                                                + cmbstatus.Text.Trim() + "')";
                // private SqlCommand sqlCommand;
                sqlCommand = new SqlCommand(query, sqlCon);
                // sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                // sqlConnection.Close();
                //LoadData();
                MessageBox.Show("Data Saved Successfully");

                Clear();
                GridFill();
                sqlCon.Close();



            }
            //else
            //  MessageBox.Show("Please fill");
            catch (Exception ex)
            {
                MessageBox.Show("Error!");
            }
        }
        
        //}
        void Clear()
        {
            label7.Text = txtname.Text = txtdescription.Text = cmbstatus.Text = txtprice.Text =  "";
            Id = 0;
            btnsave.Text = "Save";
            btndelete.Enabled = false;
        }
        void GridFill()
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
           // using (SqlConnection sqlCon = new SqlConnection(connectionString))
           // {
            sqlCon.Open();
                String query = "SELECT FID,FName, FDescrip, FPrice, Status FROM AddFood";
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
               // SqlDataAdapter sqlDa = new SqlDataAdapter("Vm2", sqlCon);
               // sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvmenu.DataSource = dtbl;
          //  }
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {
            GridFill();
            btndelete.Enabled = false;
        }

        private void dgvmenu_DoubleClick(object sender, EventArgs e)
        {
            if (dgvmenu.CurrentRow.Index != -1)
            {
                label7.Text = dgvmenu.CurrentRow.Cells[0].Value.ToString();
                txtname.Text = dgvmenu.CurrentRow.Cells[1].Value.ToString();
                txtdescription.Text = dgvmenu.CurrentRow.Cells[2].Value.ToString();
                cmbstatus.Text = dgvmenu.CurrentRow.Cells[4].Value.ToString();
                txtprice.Text = dgvmenu.CurrentRow.Cells[3].Value.ToString();
                
                Id = Convert.ToInt32(dgvmenu.CurrentRow.Cells[0].Value.ToString());
              //  btnsave.Text = ("Update");
                btndelete.Enabled = true;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            /* using (SqlConnection sqlCon = new SqlConnection(connectionString))
             {
                 sqlCon.Open();
                 SqlCommand sqlCmd = new SqlCommand("Did", sqlCon);
                 sqlCmd.CommandType = CommandType.StoredProcedure;
                 sqlCmd.Parameters.AddWithValue("@Id", Id);

                 sqlCmd.ExecuteNonQuery();
                 MessageBox.Show("Deleted");
                 Clear();
                 GridFill();


             }
             */
            SqlConnection sqlCon = new SqlConnection(connectionString);
            
            sqlCon.Open();
            DialogResult result = MessageBox.Show("Are You Sure You Want to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string query = " delete from AddFood where FID = '" + label7.Text + "'";
                sqlCommand1 = new SqlCommand(query, sqlCon);
                sqlCommand1.ExecuteNonQuery();
               // LoadData();
                Clear();
                GridFill();
                MessageBox.Show("Data Deleted Successfully");
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Sv4", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@Sv4", txtsearch.Text.Trim());
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvmenu.DataSource = dtbl;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void dgvmenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
