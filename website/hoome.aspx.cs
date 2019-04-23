using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;

namespace WebApplication3
{
    public partial class hoome : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                DataTable dt = this.GetData("SELECT ISNULL(AVG(Rating), 0) AverageRating, COUNT(Rating) RatingCount FROM tblrating");
                Rating1.CurrentRating = Convert.ToInt32(dt.Rows[0]["AverageRating"]);
                lbresult.Text = string.Format("{0} Users have rated. Average Rating {1}", dt.Rows[0]["RatingCount"], dt.Rows[0]["AverageRating"]);
            }
            update();
            findview();
            BindCartNumber();
            if (Session["USERNAME"] != null)
            {
                btnSignup.Visible = false;
                btnSignin.Visible = false;
                btnSignOut.Visible = true;
            }
            else
            {
                btnSignup.Visible = true;
                btnSignin.Visible = true;
                btnSignOut.Visible = false;

            }
        }

        public void BindCartNumber()
        {
            
        }

        protected void btnSignOut_Click(object sender, EventArgs e)
        {
            Session["USERNAME"] = null;
            Response.Redirect("~/hoome.aspx");
        }
        private void findview()
        {
            String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("select * from viewcounter", con);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.SelectCommand = cmd;
                DataSet dt = new DataSet();
                sda.Fill(dt);
                test1.Text ="Total View :"+dt.Tables[0].Rows[0]["counter"].ToString();
                con.Close();

            }
        }
        private void update()
        {
            String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            int result;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("UPDATE viewcounter SET counter = counter + 1", con);
                con.Open();
                result = cmd.ExecuteNonQuery();
            }
            
        }
        private DataTable GetData(string query)
        {
            DataTable dt = new DataTable();
            String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            SqlConnection con = new SqlConnection(CS);
            SqlCommand cmd = new SqlCommand(query);
            SqlDataAdapter sda = new SqlDataAdapter();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            sda.Fill(dt);
            return dt;
        }

        public void btnsubmit_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            SqlConnection con = new SqlConnection(CS);
            SqlCommand cmd = new SqlCommand("insert into tblrating values (@ratingvalue,@review)");
            SqlDataAdapter sda = new SqlDataAdapter();
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ratingvalue", Rating1.CurrentRating.ToString());
            cmd.Parameters.AddWithValue("@review", txtreview.Text);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect(Request.Url.AbsoluteUri);

        }
        protected void btnCart_Click(object sender, EventArgs e)
        {
            if (Session["USERNAME"] != null)
            {
                Response.Redirect("~/Cart.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Log In Please');</script>");
            }
        }
    }

}

