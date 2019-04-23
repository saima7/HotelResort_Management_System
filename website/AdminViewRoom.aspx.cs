using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class AdminViewRoom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USERNAME"] != null)
            {

                lblSuccess.Text = "Welcome " + Session["USERNAME"].ToString() + "";
            }
            if (!IsPostBack)
            {
                populate();
            }
        }

        private void populate()
        {
            string CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            using (SqlConnection con = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * from room;", con))
                {

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dtBrand = new DataTable();
                        sda.Fill(dtBrand);
                        GridView1.DataSource = dtBrand;
                        GridView1.DataBind();
                    }

                }
            }
            // lblcnt.Text = GridView1.Rows.Count.ToString();
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e) { }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e) { }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e) { }
    }

}