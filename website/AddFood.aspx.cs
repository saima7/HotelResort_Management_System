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
    public partial class AddFood : System.Web.UI.Page
    {
        String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
                BindCategory();               
                ddlSubCat.Enabled = false;
               
            }
          
            

        }
        private void BindCategory()
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("select * from FCatagories", con);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    ddlCat.DataSource = dt;
                    ddlCat.DataSource = cmd.ExecuteReader();
                    ddlCat.DataTextField = "FCatName";
                    ddlCat.DataValueField = "FCatID";
                    ddlCat.DataBind();
                    ddlCat.Items.Insert(0, new ListItem("-Select-", "0"));
                }
            }
        }
        protected void ddlCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            int MainCategoryID = Convert.ToInt32(ddlCat.SelectedItem.Value);
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("select * from FSubCatagories where FCatID='" + MainCategoryID + "'", con);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    ddlSubCat.DataSource = dt;
                    ddlSubCat.DataTextField = "FSubCatName";
                    ddlSubCat.DataValueField = "FSubCatID";
                    ddlSubCat.DataBind();
                    ddlSubCat.Items.Insert(0, new ListItem("-Select-", "0"));
                    ddlSubCat.Enabled = true;
                }
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
               
               
                //Insert and upload Images
               if (fuImg01.HasFile)
                {
                    string SavePath = Server.MapPath("~/pic/Food/");
                    if (!Directory.Exists(SavePath))
                    {
                        Directory.CreateDirectory(SavePath);
                    }
                    string Extention = Path.GetExtension(fuImg01.PostedFile.FileName);
                    fuImg01.SaveAs(SavePath + "\\" + txtFName.Text.ToString().Trim() + Extention);

                    SqlCommand cmd = new SqlCommand("ProcFoodAdd", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FName", txtFName.Text);
                    cmd.Parameters.AddWithValue("@FPrice", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@FCatID", ddlCat.SelectedItem.Value);
                    cmd.Parameters.AddWithValue("@FSubID", ddlSubCat.SelectedItem.Value);
                    cmd.Parameters.AddWithValue("@FImg", txtFName.Text.ToString().Trim());
                    cmd.Parameters.AddWithValue("@FExtention", Extention);
                    cmd.Parameters.AddWithValue("@FDescrip", txtDesc.Text);
                    cmd.Parameters.AddWithValue("@Status", "available");
                    con.Open();
                    cmd.ExecuteNonQuery();
                    //Int64 FID1 = Convert.ToInt64(cmd.ExecuteScalar());

                    //if (FID1 != null)
                    //{
                      //  test.Text = FID1.ToString();
                    //}


                }
                
                txtFName.Text = string.Empty;
                txtPrice.Text = string.Empty;
                txtDesc.Text = string.Empty;
                ddlCat.ClearSelection();
                ddlSubCat.ClearSelection();
               


            }

        }

    }
}