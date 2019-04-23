
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
    public partial class AddHall : System.Web.UI.Page
    {



        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataAdapter sqlAdapter = new SqlDataAdapter();
        DataSet dataSet = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            
            //sqlConnection.Open();
            if (!IsPostBack)
            {
                BindCategory();
                Calendar1.Visible = false;
            }
        }
        protected void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            if (Calendar1.Visible == false)
            {
                Calendar1.Visible = true;
            }
            else
            {
                Calendar1.Visible = false;
            }
        }
        private void BindCategory()
        {
            string CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("select * from HallCatagories", con);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    ddlCat.DataSource = dt;
                    ddlCat.DataSource = cmd.ExecuteReader();
                    ddlCat.DataTextField = "HallCatName";
                    ddlCat.DataValueField = "HallCatID";
                    ddlCat.DataBind();
                    ddlCat.Items.Insert(0, new ListItem("-Select-", "0"));
                }
            }
        }
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            tbDate.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;

        }
        protected void btAdd_Click(object sender, EventArgs e)
        {
            string CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            using (SqlConnection con = new SqlConnection(CS))
            {


                    SqlCommand cmd = new SqlCommand("ProcHallAdd", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@HallName", tbHname.Text);
                    cmd.Parameters.AddWithValue("@HallCatID", ddlCat.SelectedItem.Value);
                    cmd.Parameters.AddWithValue("@price", tbPrice.Text);
                    cmd.Parameters.AddWithValue("@Purpose", tbPur.Text);
                    cmd.Parameters.AddWithValue("@Capacity", tbCap.Text);
                    cmd.Parameters.AddWithValue("@Descrip", tbDes.Text);
                    cmd.Parameters.AddWithValue("@AvailableDate", tbDate.Text);
                    cmd.Parameters.AddWithValue("@Status",0);


                con.Open();
                    cmd.ExecuteNonQuery();
                    //Int64 FID1 = Convert.ToInt64(cmd.ExecuteScalar());

                    //if (FID1 != null)
                    //{
                    //  test.Text = FID1.ToString();
                    //}


                }

                tbHname.Text = string.Empty;
                tbDate.Text = string.Empty;
                tbPur.Text = string.Empty;
                tbCap.Text = string.Empty;
                tbPrice.Text = string.Empty;
                tbDes.Text = string.Empty;
                ddlCat.ClearSelection();

            }
        }

       
    }





            
    
