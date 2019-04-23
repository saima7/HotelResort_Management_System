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
    public partial class AdminViewHall : System.Web.UI.Page
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlConnection sqlConnection1 = new SqlConnection();
        SqlDataAdapter sqlAdapter = new SqlDataAdapter();
        SqlCommand sqlCommand = new SqlCommand();

        DataSet dataSet = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {

            string CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            if (Session["USERNAME"] != null)
            {

                lblSuccess.Text = "Welcome " + Session["USERNAME"].ToString() + "";
            }

            if (!IsPostBack)
            {
                using (SqlConnection con = new SqlConnection(CS))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT  AddHalls.HallID,HallName,price, HallCatName,Purpose,Capacity,Descrip,AvailableDate FROM AddHalls, HallCatagories Where AddHalls.HallCatID = HallCatagories.HallCatID;", con))
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
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            using (SqlConnection con = new SqlConnection(CS))
            {
                int HallID = (Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value));
                using (SqlCommand cmd = new SqlCommand("DELETE FROM AddHalls WHERE HallID = '" + HallID + "';", con))
                {

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dtBrand = new DataTable();
                        sda.Fill(dtBrand);
                        GridView1.DataSource = dtBrand;
                        GridView1.DataBind();
                    }

                }

                //lblcnt.Text = GridView1.Rows.Count.ToString();
            }

        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            string CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            using (SqlConnection con = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT  AddHalls.HallID,HallName,price, HallCatName,Purpose,Capacity,Descrip,AvailableDate FROM AddHalls, HallCatagories Where AddHalls.HallCatID = HallCatagories.HallCatID;", con))
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

        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("AdminHallUpdate.aspx?HallID=" + GridView1.DataKeys[GridView1.SelectedIndex].Value.ToString());

        }

    }
}