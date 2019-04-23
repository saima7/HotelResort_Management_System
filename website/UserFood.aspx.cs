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
    public partial class UserFood : System.Web.UI.Page
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
                        using (SqlCommand cmd = new SqlCommand("SELECT AddFood.FID,FName,FPrice,FCatName,FImg,FExtention,FDescrip FROM AddFood,FCatagories where AddFood.FCatID = FCatagories.FCatID AND FCatagories.FCatName Like 'Pizza'", con))
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
                        using (SqlCommand cmd = new SqlCommand("SELECT AddFood.FID,FName,FPrice,FCatName,FImg,FExtention,FDescrip FROM AddFood,FCatagories where AddFood.FCatID = FCatagories.FCatID AND FCatagories.FCatName  Like 'Pasta'", con))
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
                        using (SqlCommand cmd = new SqlCommand("SELECT AddFood.FID,FName,FPrice,FCatName,FImg,FExtention,FDescrip FROM AddFood,FCatagories where AddFood.FCatID = FCatagories.FCatID AND FCatagories.FCatName  Like 'Burger'", con))
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
                        using (SqlCommand cmd = new SqlCommand("SELECT AddFood.FID,FName,FPrice,FCatName,FImg,FExtention,FDescrip FROM AddFood,FCatagories where AddFood.FCatID = FCatagories.FCatID AND FCatagories.FCatName  Like 'Sandwich'", con))
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
                    
                    String CS = "Server = TULON - PC\\SQLEXPRESS; Database = abc; User Id = sa; password = tulon; ";
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT AddFood.FID,FName,FPrice,FCatName,FImg,FExtention,FDescrip FROM AddFood,FCatagories where AddFood.FCatID = FCatagories.FCatID AND FCatagories.FCatName  Like 'Steak'", con))
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
                        using (SqlCommand cmd = new SqlCommand("SELECT AddFood.FID,FName,FPrice,FCatName,FImg,FExtention,FDescrip FROM AddFood,FCatagories where AddFood.FCatID = FCatagories.FCatID AND FCatagories.FCatName  Like 'Beef Items'", con))
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
                        using (SqlCommand cmd = new SqlCommand("SELECT AddFood.FID,FName,FPrice,FCatName,FImg,FExtention,FDescrip FROM AddFood,FCatagories where AddFood.FCatID = FCatagories.FCatID AND FCatagories.FCatName  Like 'Duck'", con))
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
                        using (SqlCommand cmd = new SqlCommand("SELECT AddFood.FID,FName,FPrice,FCatName,FImg,FExtention,FDescrip FROM AddFood,FCatagories where AddFood.FCatID = FCatagories.FCatID AND FCatagories.FCatName  Like 'Chicken'", con))
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
                else if (idd == "9")
                {
                    String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT AddFood.FID,FName,FPrice,FCatName,FImg,FExtention,FDescrip FROM AddFood,FCatagories where AddFood.FCatID = FCatagories.FCatID AND FCatagories.FCatName  Like 'Rice and Noodles'", con))
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
                else if (idd == "10")
                {
                    String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT AddFood.FID,FName,FPrice,FCatName,FImg,FExtention,FDescrip FROM AddFood,FCatagories where AddFood.FCatID = FCatagories.FCatID AND FCatagories.FCatName  Like 'Mutton'", con))
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
                else if (idd == "11")
                {
                    
                    String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT AddFood.FID,FName,FPrice,FCatName,FImg,FExtention,FDescrip FROM AddFood,FCatagories where AddFood.FCatID = FCatagories.FCatID AND FCatagories.FCatName  Like 'Sea Food'", con))
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
                else if (idd == "12")
                {
                   
                    String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT AddFood.FID,FName,FPrice,FCatName,FImg,FExtention,FDescrip FROM AddFood,FCatagories where AddFood.FCatID = FCatagories.FCatID AND FCatagories.FCatName  Like 'Soup'", con))
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
                else if (idd == "13")
                {
                 
                    String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT AddFood.FID,FName,FPrice,FCatName,FImg,FExtention,FDescrip FROM AddFood,FCatagories where AddFood.FCatID = FCatagories.FCatID AND FCatagories.FCatName  Like 'Coffee & Tea Items'", con))
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
                else if (idd == "14")
                {
            
                    String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT AddFood.FID,FName,FPrice,FCatName,FImg,FExtention,FDescrip FROM AddFood,FCatagories where AddFood.FCatID = FCatagories.FCatID AND FCatagories.FCatName  Like 'Chaap & Kabab'", con))
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
                else if (idd == "15")
                {
                    
                    String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT AddFood.FID,FName,FPrice,FCatName,FImg,FExtention,FDescrip FROM AddFood,FCatagories where AddFood.FCatID = FCatagories.FCatID AND FCatagories.FCatName  Like 'Set Menu'", con))
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
                else if (idd == "16")
                {
                    String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT AddFood.FID,FName,FPrice,FCatName,FImg,FExtention,FDescrip FROM AddFood,FCatagories where AddFood.FCatID = FCatagories.FCatID AND FCatagories.FCatName  Like 'Drinks & Juice'", con))
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
                        using (SqlCommand cmd = new SqlCommand("SELECT AddFood.FID,FName,FPrice,FCatName,FImg,FExtention,FDescrip FROM AddFood,FCatagories where AddFood.FCatID = FCatagories.FCatID ", con))
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
       
    }
}