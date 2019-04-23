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
    public partial class RoomConfirmation : System.Web.UI.Page
    {
        protected DataSet dscheckin;
        protected DataSet dscheckout;
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataAdapter sqlAdapter = new SqlDataAdapter();
        DataSet dataSet = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";

            if (Session["USERNAME"] != null)
            {

                lblSuccess.Text = " Welcome " + Session["USERNAME"].ToString() + "";
            }
            if (!IsPostBack)
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                if (Session["USERNAME"] != null)

                {
                    string RID = Session["room_id"].ToString();
                    rID.Text = RID.ToString();
                    populateEmployeeData();
                    Calendar1.Visible = false;
                    Calendar2.Visible = false;
                   // Calendar1.VisibleDate = DateTime.Today;
                    //Calendar2.VisibleDate = DateTime.Today;


                }


            }
            Getcheckin();
           

        }
        protected void Getcheckin()
        {
            string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlDataAdapter view = new SqlDataAdapter("select checkin,checkout from ROrder  where room_id like '" + Session["room_id"].ToString() + "';", sqlConnection);
            DataTable dt = new DataTable();
            view.Fill(dt);
            try
            {
                checkin.Text = dt.Rows[0]["checkin"].ToString();
                checkout.Text = dt.Rows[0]["checkout"].ToString();
                checkin1.Text = dt.Rows[1]["checkin"].ToString();
                checkout1.Text = dt.Rows[1]["checkout"].ToString();
                checkin2.Text = dt.Rows[2]["checkin"].ToString();
                checkout2.Text = dt.Rows[2]["checkout"].ToString();
                checkin3.Text = dt.Rows[3]["checkin"].ToString();
                checkout3.Text = dt.Rows[3]["checkout"].ToString();
            }
            catch
            {

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
        protected void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            if (Calendar2.Visible == false)
            {
                Calendar2.Visible = true;
            }
            else
            {
                Calendar2.Visible = false;
            }

        }
        private void populateEmployeeData()
        {
            string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlDataAdapter view = new SqlDataAdapter("select * from users where userName like '" + Session["USERNAME"].ToString() + "';", sqlConnection);
            DataTable ss = new DataTable();
            view.Fill(ss);
            CusName.Text = ss.Rows[0]["userID"].ToString();
            CusMail.Text = ss.Rows[0]["userName"].ToString();
            CusPhn.Text = ss.Rows[0]["mobile"].ToString();
            Rent.Text = Session["rent_fee"].ToString();




        }
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            tbDate.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;

        }
        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            tbDate2.Text = Calendar2.SelectedDate.ToShortDateString();
            Calendar2.Visible = false;

        }
        protected void btAdd_Click(object sender, EventArgs e)
        {
            if (Session["room_id"] != null)
            {
                String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                SqlConnection con1 = new SqlConnection(CS);
                string query = " insert into ROrder(room_id,user_name,price,checkin,checkout,Status,available) values ('" + Session["room_id"].ToString() + "','"
                                                                 + Session["USERNAME"].ToString() + "','"
                                                                 + Rent.Text + "','"
                                                                 + tbDate.Text + "','"
                                                                 + tbDate2.Text + "',0,'not available')";
                SqlCommand sqlCommand = new SqlCommand(query, con1);
                con1.Open();
                sqlCommand.ExecuteNonQuery();
                Response.Redirect("Cart.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Log In Please');</script>");
                //Response.Redirect("logIn.aspx");
            }
        }
        protected void Calendar1DayRender(object sender, DayRenderEventArgs e)
        {


            try
            {
                // e.Cell.BackColor= System.Drawing.Color.White;
                if ((checkin.Text).ToString() != null && (checkout.Text).ToString() != null)
                {
                    DateTime checkinDate = DateTime.Parse(checkin.Text);
                    DateTime checkoutDate = DateTime.Parse(checkout.Text);

                    if (checkinDate.Date <= e.Day.Date && checkoutDate >= e.Day.Date)
                    {
                        e.Day.IsSelectable = false;
                        e.Cell.BackColor = System.Drawing.Color.DarkRed;

                    }

                }
                if ((checkin1.Text).ToString() != null && (checkout1.Text).ToString() != null)
                {
                    DateTime checkinDate1 = DateTime.Parse(checkin1.Text);
                    DateTime checkoutDate1 = DateTime.Parse(checkout1.Text);

                    if (checkinDate1.Date <= e.Day.Date && checkoutDate1 >= e.Day.Date)
                    {
                        e.Day.IsSelectable = false;
                        e.Cell.BackColor = System.Drawing.Color.DarkRed;

                    }
                }
            }
            catch
            {
                e.Day.IsSelectable = true;
                //e.Cell.BackColor = System.Drawing.Color.Blue;
            }
            try
            {
                if ((checkin2.Text).ToString() != null && (checkout2.Text).ToString() != null)
                {
                    DateTime checkinDate2 = DateTime.Parse(checkin2.Text);
                    DateTime checkoutDate2 = DateTime.Parse(checkout2.Text);

                    if (checkinDate2.Date <= e.Day.Date && checkoutDate2 >= e.Day.Date)
                    {
                        e.Day.IsSelectable = false;
                        e.Cell.BackColor = System.Drawing.Color.DarkRed;

                    }
                }
                if ((checkin3.Text).ToString() != null && (checkout3.Text).ToString() != null)
                {
                    DateTime checkinDate3 = DateTime.Parse(checkin3.Text);
                    DateTime checkoutDate3 = DateTime.Parse(checkout3.Text);

                    if (checkinDate3.Date <= e.Day.Date && checkoutDate3 >= e.Day.Date)
                    {
                        e.Day.IsSelectable = false;
                        e.Cell.BackColor = System.Drawing.Color.DarkRed;

                    }
                }
            }
            catch
            {
                //e.Day.IsSelectable = true;
                //e.Cell.BackColor = System.Drawing.Color.Blue;
            }
        }
        protected void Calendar2DayRender(object sender, DayRenderEventArgs e)
        {

            try
            {
                // e.Cell.BackColor= System.Drawing.Color.White;
                if ((checkin.Text).ToString() != null && (checkout.Text).ToString() != null)
                {
                    DateTime checkinDate = DateTime.Parse(checkin.Text);
                    DateTime checkoutDate = DateTime.Parse(checkout.Text);

                    if (checkinDate.Date <= e.Day.Date && checkoutDate >= e.Day.Date)
                    {
                        e.Day.IsSelectable = false;
                        e.Cell.BackColor = System.Drawing.Color.DarkRed;

                    }

                }
                if ((checkin1.Text).ToString() != null && (checkout1.Text).ToString() != null)
                {
                    DateTime checkinDate1 = DateTime.Parse(checkin1.Text);
                    DateTime checkoutDate1 = DateTime.Parse(checkout1.Text);

                    if (checkinDate1.Date <= e.Day.Date && checkoutDate1 >= e.Day.Date)
                    {
                        e.Day.IsSelectable = false;
                        e.Cell.BackColor = System.Drawing.Color.DarkRed;

                    }
                }               
            }
            catch
            {
                e.Day.IsSelectable = true;
                //e.Cell.BackColor = System.Drawing.Color.Blue;
            }
            try
            {
                if ((checkin2.Text).ToString() != null && (checkout2.Text).ToString() != null)
                {
                    DateTime checkinDate2 = DateTime.Parse(checkin2.Text);
                    DateTime checkoutDate2 = DateTime.Parse(checkout2.Text);

                    if (checkinDate2.Date <= e.Day.Date && checkoutDate2 >= e.Day.Date)
                    {
                        e.Day.IsSelectable = false;
                        e.Cell.BackColor = System.Drawing.Color.DarkRed;

                    }
                }
                if ((checkin3.Text).ToString() != null && (checkout3.Text).ToString() != null)
                {
                    DateTime checkinDate3 = DateTime.Parse(checkin3.Text);
                    DateTime checkoutDate3 = DateTime.Parse(checkout3.Text);

                    if (checkinDate3.Date <= e.Day.Date && checkoutDate3 >= e.Day.Date)
                    {
                        e.Day.IsSelectable = false;
                        e.Cell.BackColor = System.Drawing.Color.DarkRed;

                    }
                }
            }
            catch
            {
                //e.Day.IsSelectable = true;
                //e.Cell.BackColor = System.Drawing.Color.Blue;
            }
        }
    }
}