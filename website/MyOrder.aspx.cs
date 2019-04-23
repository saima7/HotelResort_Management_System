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
    public partial class MyOrder : System.Web.UI.Page
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
                if (Page.IsPostBack == false)
                {
                    OrderGrid();
                }
            }
            else
            {
                Response.Redirect("~/logIN.aspx");
            }
        }
        private void OrderGrid()
        {

            string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT *  FROM Order2  Where user_name = '" + Session["UserName"].ToString() + "'";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            GridView1.DataSource = command.ExecuteReader();
            GridView1.DataBind();
  
        }
    }
}