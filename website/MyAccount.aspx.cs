using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;

namespace WebApplication3
{
    public partial class MyAccount : System.Web.UI.Page
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlConnection sqlConnection1 = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        //SqlDataAdapter sqlAdapter = new SqlDataAdapter();
        DataSet dataSet = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
           
             if (Session["USERNAME"] != null)
             {
                 if (!IsPostBack)
                {
                      lblSuccess.Text = " Welcome " + Session["USERNAME"].ToString() + "";
                      populateEmployeeData();
                }    
                   
             }
            else
            {
                Response.Redirect("~/logIN.aspx");
            }
        }
        private void populateEmployeeData()
        {
            string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlDataAdapter view = new SqlDataAdapter("SELECT userID,userName,fullName,mobile,email,password,address FROM users Where userName like '"+ Session["USERNAME"].ToString()+"';", sqlConnection);
            DataTable ss = new DataTable();
            view.Fill(ss);
            lblUserID.Text = ss.Rows[0]["userID"].ToString();
            txtNam.Text = ss.Rows[0]["userName"].ToString();
            txtFullName.Text = ss.Rows[0]["fullName"].ToString();
            txtPhone.Text = ss.Rows[0]["mobile"].ToString();
            txtEmail.Text = ss.Rows[0]["email"].ToString();
            txtPassword.Text = ss.Rows[0]["Password"].ToString();
            txtAddress.Text = ss.Rows[0]["address"].ToString();                  
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            sqlConnection1 = new SqlConnection(connectionString);
            sqlConnection1.Open();
            string query = null;
                     query = "UPDATE  users SET  fullName='" + txtFullName.Text + "',mobile='"
                                                        + txtPhone.Text + "',email='"
                                                        + txtEmail.Text + "',Password='"
                                                        + txtPassword.Text + "',address='"
                                                        + txtAddress.Text + "'WHERE userID='" + int.Parse(lblUserID.Text) + "'";
            sqlCommand = new SqlCommand(query, sqlConnection1);
            // sqlConnection1.Open();
            sqlCommand.ExecuteNonQuery();
            populateEmployeeData();
        }

    }
}