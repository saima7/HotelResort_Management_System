using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;


namespace WebApplication3
{
    public partial class Review : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            
                if (!IsPostBack)
                {
                    BindCategory();
   
                }
        }
        private void BindCategory()
        {
            if (Session["USERNAME"] != null)
            {


                string CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                using (SqlConnection con = new SqlConnection(CS))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT userID from users where userName like '" + Session["USERNAME"].ToString() + "';", con))
                    {

                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dtBrand = new DataTable();
                            sda.Fill(dtBrand);
                            Label2.Text = dtBrand.Rows[0]["userID"].ToString();

                        }

                    }
                }
            }

        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (Session["USERNAME"] != null)
            {


                string CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("ProcReview", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userID", Label2.Text);
                    cmd.Parameters.AddWithValue("@Subject", txtSub.Text);
                    cmd.Parameters.AddWithValue("@Details", txtDet.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();

                }

                txtSub.Text = string.Empty;
                txtDet.Text = string.Empty;
            }
            else
            {
                Response.Redirect("~/logIN.aspx");

            }
        }


        
    }
}