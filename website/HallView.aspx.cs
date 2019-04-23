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
    public partial class HallView : System.Web.UI.Page
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
                string HallID = Request.QueryString["HallID"];
                test.Text = HallID.ToString();
                if (HallID != null)
                {

                    populateEmployeeData(HallID);
                    populate(HallID);
                }
            }
        }
        private void populateEmployeeData(string FID)
        {

            int id = Convert.ToInt32(FID);
            String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            using (SqlConnection con = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT  AddHalls.HallID,HallName,price, HallCatName,Capacity,Purpose,AvailableDate,Descrip FROM AddHalls, HallCatagories Where AddHalls.HallCatID = HallCatagories.HallCatID AND Status=0 AND HallID Like '" + int.Parse(test.Text) + "'", con))
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
        private void populate(string FID)
        {
            int id = Convert.ToInt32(FID);
            String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            using (SqlConnection con = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT AddHalls.HallID, HallName, price,AvailableDate,Descrip FROM AddHalls where HallID Like '" + int.Parse(test.Text) + "'", con))
                {

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dtBrand = new DataTable();
                        sda.Fill(dtBrand);
                        lblname.Text = dtBrand.Rows[0]["HallName"].ToString();
                        lblprice.Text = dtBrand.Rows[0]["price"].ToString();
                        lbldate.Text = dtBrand.Rows[0]["AvailableDate"].ToString();
                        lblID.Text= dtBrand.Rows[0]["HallID"].ToString();


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
                    using (SqlCommand cmd = new SqlCommand("SELECT AddHalls.HallID, HallName, price,AvailableDate FROM AddHalls where HallID Like'" + int.Parse(test.Text) + "'", con))
                    {

                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dtBrand = new DataTable();
                            sda.Fill(dtBrand);
                            lblname.Text = dtBrand.Rows[0]["HallName"].ToString();
                            lblprice.Text = dtBrand.Rows[0]["price"].ToString();
                            lbldate.Text = dtBrand.Rows[0]["AvailableDate"].ToString();

                        }

                    }
                }
                SqlConnection con1 = new SqlConnection(CS);
                string query = " insert into HOrder(userName,HallName,Price,Date,Status) values ('" + Session["USERNAME"].ToString() + "','"
                                                                + lblname.Text + "','"
                                                                + Convert.ToDouble(lblprice.Text) + "','"
                                                                 + lbldate.Text + "',0)";
                SqlCommand sqlCommand = new SqlCommand(query, con1);
                con1.Open();
                sqlCommand.ExecuteNonQuery();
                HallUpdate();
                Response.Redirect("Cart.aspx");
            }
            else
            {
                Response.Redirect("logIN.aspx");
            }
        }
        private void HallUpdate()
        {
            string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "UPDATE  AddHalls SET  Status=1 where HallID ='"+ lblID.Text+"'";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.ExecuteNonQuery();
        }
        protected void rptrProducts_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}