
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace WebApplication3
{
    public partial class AddEmployee : System.Web.UI.Page
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlConnection sqlConnection1 = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataAdapter sqlAdapter = new SqlDataAdapter();
        DataSet dataSet = new DataSet();
        string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USERNAME"] != null)
            {

                lblSuccess.Text = "Welcome " + Session["USERNAME"].ToString() + "";
            }
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            if (!IsPostBack)
            {
                SqlCommand cmd = new SqlCommand("Select Role,JobId from JobTitle", sqlConnection);
                lstRole.DataSource = cmd.ExecuteReader();
                lstRole.DataBind();
                //sqlConnection.Close();
            }
            
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //string connectionString1 = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            //sqlConnection1 = new SqlConnection(connectionString1);
            int EmployeeID = Convert.ToInt32(txtMan.Text);
            string query = null;
              
              if (EmployeeID == 0)
                  query = " insert into Employee(Name,Address,Num,JobID,Cell,Password,Salary,ManagerId) values ('" + txtName.Text + "','"
                                                              + txtAddress.Text + "','"
                                                              + txtPhone.Text + "','"
                                                              + lstRole.SelectedValue + "','"
                                                              + txtCell.Text + "','"
                                                              + txtPassword.Text + "','"
                                                              + txtSalary.Text + "','"
                                                              + txtMan.Text + "')";
            else
                  query = " insert into Employee(Name,Address,Num,JobId,Cell,Password,Salary,ManagerId) values ('" + txtName.Text + "','"
                                                                + txtAddress.Text + "','"
                                                                + txtPhone.Text + "','"
                                                                + lstRole.SelectedValue + "','"
                                                                + txtCell.Text + "','"
                                                                + txtPassword.Text + "','"
                                                                + txtSalary.Text + "','"
                                                                + txtMan.Text + "')";

            sqlCommand = new SqlCommand(query, sqlConnection);
           // sqlConnection1.Open();
            sqlCommand.ExecuteNonQuery();
            Response.Redirect("AdminHome.aspx");
        }
    }
}