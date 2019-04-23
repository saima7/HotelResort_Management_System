
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication3
{
    public partial class AddFCatagories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindCatRptr();
        }
        private void BindCatRptr()
        {
            String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";

            using (SqlConnection con = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand("select * from FCatagories", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dtCat= new DataTable();
                        sda.Fill(dtCat);
                        rptrCat.DataSource = dtCat;
                        rptrCat.DataBind();
                    }

                }
            }
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("insert into FCatagories (FCatName) values('" + txtCatName.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                txtCatName.Text = string.Empty;
            }
            BindCatRptr();

        }
    }
}