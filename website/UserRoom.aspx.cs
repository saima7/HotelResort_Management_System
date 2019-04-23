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
    public partial class UserRoom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string idd = Request.QueryString["id"].ToString();
                if (idd == "1")
                {

                    String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT * from room where room_type Like 'Single Standard'", con))
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
                else if (idd == "2")
                {

                    String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT * from room where room_type Like 'Double Standard'", con))
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
                else if (idd == "3")
                {

                    String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT * from room where room_type Like 'Triple Standard'", con))
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
                else if (idd == "4")
                {

                    String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT * from room where room_type Like 'Single Deluxe'", con))
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
                else if (idd == "5")
                {

                    String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT * from room where room_type Like 'Double Deluxe'", con))
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
                else if (idd == "6")
                {

                    String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT * from room where room_type Like 'Triple Deluxe'", con))
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
                else if (idd == "7")
                {

                    String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT * from room where room_type Like 'Honeymoon suite'", con))
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
                else if (idd == "8")
                {

                    String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT * from room where room_type Like 'Exclusive suite'", con))
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
                else
                {
                    String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT * from room ", con))
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
            }
        }
        protected void btnnSearch_Click(object sender, EventArgs e)
        {
           // try
            {
                String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                using (SqlConnection con = new SqlConnection(CS))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT  * from room Where (room_type Like '%" + search.Text + "%') OR (room_category LIKE '%" + search.Text + "%');", con))
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
            //catch
            {
                //Response.Redirect("RoomHome.aspx");
            }
        }

    }
}