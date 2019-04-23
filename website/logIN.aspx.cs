using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication3
{
    public partial class logIN : System.Web.UI.Page
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataAdapter sqlAdapter = new SqlDataAdapter();
        DataSet dataSet = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
        }

        protected void loginbtn_Click(object sender, EventArgs e)
        {

            sqlCommand.CommandText = " select * from users where userName = '" + usernametxt.Text+ "' and password = '" + passwordtxt.Text + "'";
            sqlCommand.Connection = sqlConnection;
            sqlAdapter.SelectCommand = sqlCommand;
            sqlAdapter.Fill(dataSet, "Users");
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                string Utype;
                Utype = dataSet.Tables[0].Rows[0][6].ToString().Trim();

                if (Utype == "u")
                {
                    Session["USERNAME"] = usernametxt.Text;
                    Response.Redirect("UserHome.aspx");
                }
                if (Utype == "a")
                {

                    Session["USERNAME"] = usernametxt.Text;
                    Response.Redirect("~/AdminHome.aspx");
                }
              
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Username & password Does not Match');</script>");
            }
            
        }

        protected void regbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }
    }
}