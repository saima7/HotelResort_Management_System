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
    public partial class UserTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            using (SqlConnection con = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT  AddTable.TableID,NoOfSeat,time, TableCatName,Price FROM AddTable, TableCatagory Where AddTable.TableCatID = TableCatagory.TableCatID AND Status=0;", con))
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
        protected void btnnSearch_Click(object sender, EventArgs e)
        {
            String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            using (SqlConnection con = new SqlConnection(CS))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT  AddTable.TableID,NoOfSeat,time, TableCatName,Price FROM AddTable, TableCatagory Where (AddTable.TableCatID = TableCatagory.TableCatID AND Status=0) AND (AddTable.NoOfSeat Like '" + search.Text + "' OR AddTable.time LIKE'" + search.Text + "');", con))
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