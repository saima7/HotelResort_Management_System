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
    public partial class FoodView : System.Web.UI.Page
    {
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
                string FID = Request.QueryString["FID"];
                test.Text = FID.ToString();
                if (FID != null)
                {

                    populateEmployeeData(FID);
                    populate(FID);
                }
            }
        }
        private void populateEmployeeData(string FID)
        {
          
            int id = Convert.ToInt32(FID);
            String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            using (SqlConnection con = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT AddFood.FID, FName, FPrice, FCatName, FImg, FExtention, FDescrip FROM AddFood, FCatagories where AddFood.FCatID = FCatagories.FCatID AND FID Like '"+ int.Parse(test.Text) +"'", con))
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
                using (SqlCommand cmd = new SqlCommand("SELECT AddFood.FID, FName, FPrice FROM AddFood where FID Like '" + int.Parse(test.Text) + "'", con))
                {

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dtBrand = new DataTable();
                        sda.Fill(dtBrand);
                        lblname.Text = dtBrand.Rows[0]["FName"].ToString();
                        lblprice.Text = dtBrand.Rows[0]["FPrice"].ToString();
                       
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
                    using (SqlCommand cmd = new SqlCommand("SELECT AddFood.FID, FName, FPrice FROM AddFood where FID Like '" + int.Parse(test.Text) + "'", con))
                    {

                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dtBrand = new DataTable();
                            sda.Fill(dtBrand);
                            lblname.Text = dtBrand.Rows[0]["FName"].ToString();
                            lblprice.Text = dtBrand.Rows[0]["FPrice"].ToString();

                        }

                    }
                }
                SqlConnection con1 = new SqlConnection(CS);
                string query = " insert into FOrder(userName,FName,FPrice,Qnt,TotalPrice,status,DStatus) values ('" + Session["USERNAME"].ToString() + "','"
                                                                + lblname.Text + "','"
                                                                + Convert.ToDouble(lblprice.Text) + "',1,'"
                                                                 + Convert.ToDouble(lblprice.Text) + "',0,0)";
                SqlCommand sqlCommand = new SqlCommand(query, con1);
                con1.Open();
                sqlCommand.ExecuteNonQuery();
                Response.Redirect("Cart.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Log In Please');</script>");
                //Response.Redirect("logIn.aspx");
            }
           
        }
    }
}
