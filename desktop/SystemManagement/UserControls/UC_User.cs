using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SystemManagement.UserControls
{
    public partial class UC_User : UserControl
    {
        //string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=SMorderDB;Integrated Security=True;";

        string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
        private SqlConnection sqlCon= new SqlConnection();
        private SqlCommand sqlCommand1 = new SqlCommand();

        // string connectionString = @"Data Source=DESKTOP-5UHHJB2\SQLEXPRESS;Initial Catalog=RHManagement;Integrated Security=True;User Id=sa ; password=sakif;";
        public UC_User()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  using (SqlConnection sqlCon = new SqlConnection(connectionString))
           // {
                sqlCon.Open();

            //SqlDataAdapter sqlDa = new SqlDataAdapter("Vl2", sqlCon);
            sqlCommand1 = new SqlCommand("Select Name,Type,Price,Date,Time,paymentMethod from Order2", sqlCon);
            sqlCommand1.ExecuteNonQuery();
            SqlDataAdapter sqlDa = new SqlDataAdapter();
            //  SqlDataAdapter sqlDa = new SqlDataAdapter("select * from room", sqlCon);
            //  sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand = sqlCommand1;
            DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvu.DataSource = dtbl;
            sqlCon.Close();
            // }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlCon.Open();

            //SqlDataAdapter sqlDa = new SqlDataAdapter("Vl2", sqlCon);
            sqlCommand1 = new SqlCommand("Select * from FOrder where DStatus=1", sqlCon);
            sqlCommand1.ExecuteNonQuery();
            SqlDataAdapter sqlDa = new SqlDataAdapter();
            //  SqlDataAdapter sqlDa = new SqlDataAdapter("select * from room", sqlCon);
            //  sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand = sqlCommand1;
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgvu.DataSource = dtbl;
            sqlCon.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlCon.Open();

            //SqlDataAdapter sqlDa = new SqlDataAdapter("Vl2", sqlCon);
            sqlCommand1 = new SqlCommand("Select * from ROrder where status = 1", sqlCon);
            sqlCommand1.ExecuteNonQuery();
            SqlDataAdapter sqlDa = new SqlDataAdapter();
            //  SqlDataAdapter sqlDa = new SqlDataAdapter("select * from room", sqlCon);
            //  sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand = sqlCommand1;
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgvu.DataSource = dtbl;
            sqlCon.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sqlCon.Open();

            //SqlDataAdapter sqlDa = new SqlDataAdapter("Vl2", sqlCon);
            sqlCommand1 = new SqlCommand("Select * from TOrder where status = 1", sqlCon);
            sqlCommand1.ExecuteNonQuery();
            SqlDataAdapter sqlDa = new SqlDataAdapter();
            //  SqlDataAdapter sqlDa = new SqlDataAdapter("select * from room", sqlCon);
            //  sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand = sqlCommand1;
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgvu.DataSource = dtbl;
            sqlCon.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sqlCon.Open();

            //SqlDataAdapter sqlDa = new SqlDataAdapter("Vl2", sqlCon);
            //sqlCommand1 = new SqlCommand("Select * from HOrder where status = 1", sqlCon);
            sqlCommand1.ExecuteNonQuery();
            SqlDataAdapter sqlDa = new SqlDataAdapter();
            //  SqlDataAdapter sqlDa = new SqlDataAdapter("select * from room", sqlCon);
            //  sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand = sqlCommand1;
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgvu.DataSource = dtbl;
            sqlCon.Close();
        }
    }
}
