using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace WebApplication3
{
    public partial class ManageEmployees : System.Web.UI.Page { 
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

            if (!IsPostBack)
            {
                populateUsersGrid();
                lbl.Text = grdEmployees.Rows.Count.ToString();

            }
        }
        private void populateUsersGrid()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT EmployeeId, Name,Address, Num, Role FROM Employee,JobTitle Where Employee.JobId = JobTitle.JobId";
            SqlCommand command = new SqlCommand(query,sqlConnection);
            grdEmployees.DataSource = command.ExecuteReader();
            grdEmployees.DataBind();
        }

        protected void grdUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("EmployeeInfo.aspx?EmployeeId=" +
            grdEmployees.DataKeys[grdEmployees.SelectedIndex].Value.ToString());
        }
        protected void lnkCreateNewUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddEmployee.aspx");
        }

        protected void cmdMan_Click(object sender, EventArgs e)
        {
            //Response.Redirect("ViewManagers.aspx");
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT EmployeeID, Password, Name, Address, Num, Role FROM Employee,JobTitle Where Employee.JobId = JobTitle.JobId and Employee.JobId=1";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            grdEmployees.DataSource = command.ExecuteReader();
            grdEmployees.DataBind();
            lbl.Text = grdEmployees.Rows.Count.ToString();
        }
        protected void cmdRep_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT EmployeeID, Password, Name, Address, Num, Role FROM Employee,JobTitle Where Employee.JobId = JobTitle.JobId and Employee.JobId=2";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            grdEmployees.DataSource = command.ExecuteReader();
            grdEmployees.DataBind();
            lbl.Text = grdEmployees.Rows.Count.ToString();
        }
        protected void cmdMain_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT EmployeeID, Password, Name, Address, Num, Role FROM Employee,JobTitle Where Employee.JobId = JobTitle.JobId and Employee.JobId=3";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            grdEmployees.DataSource = command.ExecuteReader();
            grdEmployees.DataBind();
            lbl.Text = grdEmployees.Rows.Count.ToString();

        }
    }
}