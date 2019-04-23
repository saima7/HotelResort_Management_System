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
    public partial class Report : System.Web.UI.Page
    {

        SqlConnection sqlConnection = new SqlConnection();
        SqlConnection sqlConnection1 = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataAdapter sqlAdapter = new SqlDataAdapter();
        DataSet dataSet = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                BindUser();

            }
            lbl.Text = "";
        }

        private void BindUser()
        {
            String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("select * from users ", con);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    ddluser.DataSource = dt;
                    ddluser.DataTextField = "userName";
                    ddluser.DataValueField = "userName";
                    ddluser.DataBind();
                    ddluser.Items.Insert(0, new ListItem("-Select-", "0"));
                }
            }
        }
        protected void btnselect_Click(object sender, EventArgs e)
        {
            if (ddluser.SelectedIndex == 0)
            {
                lbl.Text = "Select Email";
            }
            else
            {
                string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string query = "SELECT *  FROM Order2  Where user_name= '" + (ddluser.SelectedItem.Text).ToString() + "' ; ";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                GridView1.DataSource = command.ExecuteReader();
                GridView1.DataBind();
                lbl.Text = "Total Record = " + GridView1.Rows.Count.ToString();
            }
        }
    }
}