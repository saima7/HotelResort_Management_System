using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class AdminNewOrder : System.Web.UI.Page
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlConnection sqlConnection1 = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataAdapter sqlAdapter = new SqlDataAdapter();
        DataSet dataSet = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {            
            if (Session["USERNAME"] != null)
            {

                lblSuccess.Text = "Login Success, Welcome " + Session["USERNAME"].ToString() + "";               
                FoodGrid();
            }

        }
        private void FoodGrid()
        {

            string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT *  FROM FOrder  Where  DStatus=0 ";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            GridView1.DataSource = command.ExecuteReader();
            GridView1.DataBind();
            lbll.Text = GridView1.Rows.Count.ToString();
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            string CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            using (SqlConnection con = new SqlConnection(CS))
            {
                int oidd = (Convert.ToInt32(e.CommandArgument.ToString()));
                using (SqlCommand cmd = new SqlCommand("UPDATE  FOrder SET  DStatus=1 where FOID='"+oidd+"';", con))
                {

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dtBrand = new DataTable();
                        sda.Fill(dtBrand);
                        GridView1.DataSource = dtBrand;
                        GridView1.DataBind();
                    }

                }

                con.Close();
            }
            FoodGrid();          
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}