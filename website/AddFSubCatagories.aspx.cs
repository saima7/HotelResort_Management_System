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
    public partial class AddFSubCatagories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindMainCategory();
            BindBrandsRptr();
        }
        private void BindBrandsRptr()
        {
            String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            using (SqlConnection con = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand("select A.*,B.* from FSubCatagories A inner join FCatagories B on B.FCatID=A.FCatID", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dtBrands = new DataTable();
                        sda.Fill(dtBrands);
                        rptrCategory.DataSource = dtBrands;
                        rptrCategory.DataBind();
                    }

                }
            }
        }

        private void BindMainCategory()
        {
            String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
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
                    ddlCat.DataTextField = "FCatName";
                    ddlCat.DataValueField = "FCatID";
                    ddlCat.DataBind();
                    ddlCat.Items.Insert(0, new ListItem("-Select-", "0"));
                }
            }
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("insert into FSubCatagories values('" + txtSubCatName.Text + "','" + ddlCat.SelectedItem.Value + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                txtSubCatName.Text = string.Empty;
                ddlCat.ClearSelection();
                ddlCat.Items.FindByValue("0").Selected = true;
            }

            BindBrandsRptr();

        }

    }
}