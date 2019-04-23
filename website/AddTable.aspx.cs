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
    public partial class AddTable : System.Web.UI.Page
    {
       

            String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            protected void Page_Load(object sender, EventArgs e)
            {
                if (!IsPostBack)
                {

                    BindCategory();
                   

                }



            }
        private void BindCategory()
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("select * from TableCatagory", con);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    ddlCat.DataSource = dt;
                    ddlCat.DataSource = cmd.ExecuteReader();
                    ddlCat.DataTextField = "TableCatName";
                    ddlCat.DataValueField = "TableCatID";
                    ddlCat.DataBind();
                    ddlCat.Items.Insert(0, new ListItem("-Select-", "0"));
                }
            }
        }
        protected void btnAdd1_Click(object sender, EventArgs e)
        {
            string CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            using (SqlConnection con = new SqlConnection(CS))
            {


                SqlCommand cmd = new SqlCommand("ProcTableAdd", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NoOfSeat", txtSeat.Text);
                cmd.Parameters.AddWithValue("@time", txtTime.Text);
                cmd.Parameters.AddWithValue("@TableCatID", ddlCat.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@Status", 0);


                con.Open();
                cmd.ExecuteNonQuery();
                //Int64 FID1 = Convert.ToInt64(cmd.ExecuteScalar());

                //if (FID1 != null)
                //{
                //  test.Text = FID1.ToString();
                //}
            }

            txtSeat.Text = string.Empty;
            txtTime.Text = string.Empty;
            txtPrice.Text = string.Empty;
            ddlCat.ClearSelection();

        }

    }
}