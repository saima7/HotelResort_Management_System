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
    public partial class EmployeeInfo : System.Web.UI.Page
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlConnection sqlConnection1 = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        //SqlDataAdapter sqlAdapter = new SqlDataAdapter();
        DataSet dataSet = new DataSet();

        string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USERNAME"] != null)
            {

                lblSuccess.Text = " Welcome " + Session["USERNAME"].ToString() + "";
            }
            if (!IsPostBack)
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                jobid();
                string employeeID = Request.QueryString["EmployeeID"];
                test.Text = employeeID.ToString();
                if (employeeID != null)
                {
                    
                    populateEmployeeData(employeeID);
                    
                  
                }
                
             
            }
        }
        private void jobid()
        {
            SqlCommand cmd = new SqlCommand("Select Role,JobId from JobTitle", sqlConnection);
            lstRole.DataSource = cmd.ExecuteReader();
            lstRole.DataBind();
        }


        private void populateEmployeeData(string employeeID)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            int id = Convert.ToInt32(employeeID);
            SqlDataAdapter view = new SqlDataAdapter("SELECT EmployeeID, Name, Address, Num,ManagerID, Role,Cell,Password,Salary FROM Employee,JobTitle Where  Employee.EmployeeID= "+int.Parse(test.Text), sqlConnection);
            DataTable ss = new DataTable();
            view.Fill(ss);
            lblEmployeeID.Text = ss.Rows[0]["EmployeeID"].ToString();
            txtName.Text= ss.Rows[0]["Name"].ToString();
            txtAddress.Text = ss.Rows[0]["Address"].ToString();
            txtPhone.Text = ss.Rows[0]["Num"].ToString();
            txtMan.Text= ss.Rows[0]["ManagerID"].ToString();
            lstRole.SelectedValue = ss.Rows[0]["Role"].ToString();
            txtCell.Text = ss.Rows[0]["Cell"].ToString();
            txtPassword.Text = ss.Rows[0]["Password"].ToString();
            txtSalary.Text = ss.Rows[0]["Salary"].ToString();


        }
        protected void cmdUpdate_Click(object sender, EventArgs e)
        {
            sqlConnection1 = new SqlConnection(connectionString);
            sqlConnection1.Open();
            int emp = Convert.ToInt32(txtMan.Text);
            string query = null;

            if (emp == 0)
                query = "UPDATE  Employee SET  Name='" + txtName.Text + "',Address='"
                                                        + txtAddress.Text + "',Num='"
                                                        + txtPhone.Text + "',Cell='"
                                                        + txtCell.Text + "',Password='"
                                                        + txtPassword.Text + "',Salary='"
                                                        + float.Parse(txtSalary.Text) + "'WHERE EmployeeID='" + int.Parse(lblEmployeeID.Text) + "'";

            else
                query = " UPDATE  Employee SET  Name='" + txtName.Text + "',Address='"
                                                        + txtAddress.Text + "',Num='"
                                                        + txtPhone.Text + "',Cell='"
                                                        + txtCell.Text + "',Password='"
                                                        + txtPassword.Text + "',Salary='"
                                                        + float.Parse(txtSalary.Text) + "'WHERE EmployeeID='" + int.Parse(lblEmployeeID.Text)+"'";

            sqlCommand = new SqlCommand(query, sqlConnection1);
            // sqlConnection1.Open();
            sqlCommand.ExecuteNonQuery();
            Response.Redirect("AdminHome.aspx");

        }

        protected void cmdSuper_Click(object sender, EventArgs e)
        {
            Response.Redirect("SupervisedEmployees.aspx?ManagerId=" + lblEmployeeID.Text);

        }

        protected void cmdDelete_Click(object sender, EventArgs e)
        {
            sqlConnection1 = new SqlConnection(connectionString);
            sqlConnection1.Open();
            int emp = Convert.ToInt32(txtMan.Text);
            string query = null;
            query = "DELETE FROM Employee WHERE EmployeeID='" + int.Parse(lblEmployeeID.Text) + "'";
            sqlCommand = new SqlCommand(query, sqlConnection1);
            sqlCommand.ExecuteNonQuery();
            Response.Redirect("AdminHome.aspx");
        }
    }
}