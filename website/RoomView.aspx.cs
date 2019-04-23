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
    public partial class RoomView : System.Web.UI.Page
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
                string RID = Request.QueryString["room_id"];
                test.Text = RID.ToString();
                if (RID != null)
                {

                    populateEmployeeData(RID);
                    populate(RID);
                    Detail(RID);
                }
            }
        }
        private void populateEmployeeData(string RID)
        {

            int id = Convert.ToInt32(RID);
            String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            using (SqlConnection con = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * from room where room_id Like '" + int.Parse(test.Text) + "'", con))
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
        private void populate(string RID)
        {
            int id = Convert.ToInt32(RID);
            String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            using (SqlConnection con = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT room_id,rent_fee,room_type FROM room where room_id Like '" + int.Parse(test.Text) + "'", con))
                {

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dtBrand = new DataTable();
                        sda.Fill(dtBrand);
                        lblname.Text = dtBrand.Rows[0]["room_type"].ToString();
                        lblprice.Text = dtBrand.Rows[0]["rent_fee"].ToString();
                        lbltest.Text = dtBrand.Rows[0]["room_id"].ToString();
                        Session["room_id"] = lbltest.Text;
                        Session["rent_fee"] = lblprice.Text;

                    }

                }
            }
        }
        private void Detail(string RID)
        {
            int id = Convert.ToInt32(RID);
            String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            using (SqlConnection con = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand("Select room_id,ROrder.checkin,ROrder.checkout,available from ROrder where  ROrder.room_id = '" + RID + "'", con))
                {

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dtBrand = new DataTable();
                        sda.Fill(dtBrand);
                        // lbltest1.Text = dtBrand.Rows[0]["room_id"].ToString();
                        //int idd = Convert.ToInt32(lbltest1.Text);
                        // if(idd != null)
                        try
                        {
                            if (dtBrand.Rows[0]["room_id"] != null)
                            {
                                Repeater1.DataSource = dtBrand;
                                Repeater1.DataBind();
                            }
                            else
                            {
                                lbl1.Text = "Available";

                            }
                        }
                        catch
                        {
                            lbl1.Text = "Available";
                        }



                    }

                }
            }
        }
            protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["USERNAME"] != null)
            {

               /* String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                using (SqlConnection con = new SqlConnection(CS))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM AddFood where room_id Like '" + int.Parse(test.Text) + "'", con))
                    {

                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                           // DataTable dtBrand = new DataTable();
                            //sda.Fill(dtBrand);
                            //lblname.Text = dtBrand.Rows[0]["FName"].ToString();
                            //lblprice.Text = dtBrand.Rows[0]["FPrice"].ToString();

                        }

                    }

                }
                SqlConnection con1 = new SqlConnection(CS);
                 string query = " insert into FOrder(userName,FName,FPrice,Qnt,TotalPrice,status) values ('" + Session["USERNAME"].ToString() + "','"
                  + lblname.Text + "','"
                 + Convert.ToDouble(lblprice.Text) + "',1,'"
                 + Convert.ToDouble(lblprice.Text) + "',0)";
                 SqlCommand sqlCommand = new SqlCommand(query, con1);
                con1.Open();
                sqlCommand.ExecuteNonQuery();
                 Response.Redirect("Cart.aspx");*/
                Response.Redirect("RoomConfirmation.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Log In Please');</script>");
                //Response.Redirect("logIn.aspx");
            }

        }
    }
}