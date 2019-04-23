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
    public partial class TableView : System.Web.UI.Page
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlConnection sqlConnection1 = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataAdapter sqlAdapter = new SqlDataAdapter();
        DataSet dataSet = new DataSet();
        String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            protected void Page_Load(object sender, EventArgs e)
            {
                if (Session["USERNAME"] != null)
                {

                    lblSuccess.Text = "hello " + Session["USERNAME"].ToString() + "";
                }
                if (!IsPostBack)
                {
                    SqlConnection sqlConnection = new SqlConnection(CS);
                    sqlConnection.Open();
                    string TableID = Request.QueryString["TableID"];
                    test.Text = TableID.ToString();
                    if (TableID != null)
                    {

                        populateEmployeeData(TableID);
                        populate(TableID);
                    }
                }
            }
        
        private void populateEmployeeData(string TableID)
        {

            int id = Convert.ToInt32(TableID);
            String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            using (SqlConnection con = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT  AddTable.TableID,NoOfSeat,time, TableCatName,Price FROM AddTable, TableCatagory Where AddTable.TableCatID = TableCatagory.TableCatID AND Status=0 AND TableID Like '" + int.Parse(test.Text) + "'", con))
                {

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dtBrand = new DataTable();
                        sda.Fill(dtBrand);
                        rptrProducts.DataSource = dtBrand;
                        rptrProducts.DataBind();
                    }

                }
            }
        }
        private void populate(string TableID)
        {
            int id = Convert.ToInt32(TableID);
            String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            using (SqlConnection con = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT  AddTable.TableID,NoOfSeat,time, TableCatName,Price FROM AddTable, TableCatagory Where AddTable.TableCatID = TableCatagory.TableCatID AND Status=0 AND TableID Like '" + int.Parse(test.Text) + "'", con))
                {

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dtBrand = new DataTable();
                        sda.Fill(dtBrand);
                        lblSeat.Text = dtBrand.Rows[0]["NoOfSeat"].ToString();
                        lbltime.Text = dtBrand.Rows[0]["time"].ToString();
                        lblprice.Text = dtBrand.Rows[0]["Price"].ToString();
                        lblTableID.Text= dtBrand.Rows[0]["TableID"].ToString();


                    }

                }
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["USERNAME"] != null)
            {

                String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                using (SqlConnection con = new SqlConnection(CS))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT  TableID,NoOfSeat,time,Price FROM AddTable  where TableID Like'" + int.Parse(test.Text) + "';", con))
                    {

                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dtBrand = new DataTable();
                            sda.Fill(dtBrand);
                            lblSeat.Text = dtBrand.Rows[0]["NoOfSeat"].ToString();
                            lbltime.Text = dtBrand.Rows[0]["time"].ToString();
                            lblprice.Text = dtBrand.Rows[0]["Price"].ToString();
                            lblTableID.Text = dtBrand.Rows[0]["TableID"].ToString();
                        }

                    }
                }
                SqlConnection con1 = new SqlConnection(CS);
                string query = " insert into TOrder(userName,NoOfSeat,time,Price,Status) values ('" + Session["USERNAME"].ToString() + "','"
                                                                + lblSeat.Text + "','"
                                                                + lbltime.Text + "','"
                                                                 + Convert.ToDouble(lblprice.Text) + "',0)";
                SqlCommand sqlCommand = new SqlCommand(query, con1);
                con1.Open();
                sqlCommand.ExecuteNonQuery();
                TableUpdate();
               // Session["TableID"] = lblTableID.Text;
                Response.Redirect("Cart.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Log In Please');</script>");
                //Response.Redirect("logIn.aspx");
            }

        }
        private void TableUpdate()
        {
            string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "UPDATE  AddTable SET  Status=1 where TableID='"+lblTableID.Text+"'";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.ExecuteNonQuery();
        }
        protected void rptrProducts_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}