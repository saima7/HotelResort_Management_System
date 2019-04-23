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
    public partial class Form_Order : Form
    {
        string connectionString = @"Data Source = DESKTOP - 5UHHJB2\SQLEXPRESS;Initial Catalog = RHMANAGEMENT; Persist Security Info=True;User ID = sa; Password=sakif";
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5UHHJB2\SQLEXPRESS;Initial Catalog=RHMANAGEMENT;Persist Security Info=True;User ID=sa;Password=sakif");
        int Id = 0;
        public Form_Order()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if ( txtby.Text.Trim() != "" && txtfrom.Text.Trim() != "" && txtaddress.Text.Trim() != "" && dtpdate.Value.ToString() != "")
            {
               using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("AddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Id", Id);
                    
                    sqlCmd.Parameters.AddWithValue("@Oby", txtby.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Ofrom", txtfrom.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Address", txtaddress.Text.Trim());

                    sqlCmd.Parameters.AddWithValue("@Date", dtpdate.Value.ToString());

                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("submitted");
                    Clear();
                    GridFill();


                }


            }
            else
                MessageBox.Show("Please fill");
        }
        void Clear()
        {
            txtby.Text = txtfrom.Text = txtaddress.Text = "";
            Id = 0;
            btnsave.Text = "Save";
            btndelete.Enabled = false;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void GridFill()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                String query = "SELECT * FROM AddFood";
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
               // SqlDataAdapter sqlDa = new SqlDataAdapter("Viewall", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvorder.DataSource = dtbl;
            }
        }

        private void Form_Order_Load(object sender, EventArgs e)
        {
            GridFill();
            btndelete.Enabled = false;
        }

        private void dgvorder_DoubleClick(object sender, EventArgs e)
        {
            if (dgvorder.CurrentRow.Index != -1)
            {
                
                txtby.Text = dgvorder.CurrentRow.Cells[1].Value.ToString();
                txtfrom.Text = dgvorder.CurrentRow.Cells[2].Value.ToString();
                txtaddress.Text = dgvorder.CurrentRow.Cells[3].Value.ToString();
                dtpdate.Value = (DateTime)dgvorder.CurrentRow.Cells[4].Value;

                Id = Convert.ToInt32(dgvorder.CurrentRow.Cells[0].Value.ToString());
                btnsave.Text = ("Update");
                btndelete.Enabled = true;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("Deletebyid", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Id", Id);

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("deleted");
                Clear();
                GridFill();
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Searchbyvalue", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@Searchvalue", txtsearch.Text.Trim());
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvorder.DataSource = dtbl;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
