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
    public partial class Cart : System.Web.UI.Page
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlConnection sqlConnection1 = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataAdapter sqlAdapter = new SqlDataAdapter();
        DataSet dataSet = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {  
                FoodGrid();
                HallGrid();
                TableGrid();
                RoomGrid();
                lbl1.Text = GridView1.Rows.Count.ToString();
                lbl2.Text = GridView2.Rows.Count.ToString();
                lbl3.Text = GridView3.Rows.Count.ToString();
                lbl4.Text = GridView4.Rows.Count.ToString();

                if (GridView1.Rows.Count == 0)
                {

                    btnchckout.Visible = false;
                    Button1.Visible = false;
                }
                else
                {
                    btnchckout.Visible = true;
                    Button1.Visible = true;


                }
                if (GridView2.Rows.Count == 0)
                {

                    btn2chkout.Visible = false;
                    Button2.Visible = false;
                }
                else
                {
                    btn2chkout.Visible = true;
                    Button2.Visible = true;


                }
                if (GridView3.Rows.Count == 0)
                {

                    btn3chkout.Visible = false;
                    Button3.Visible = false;
                }
                else
                {
                    btn3chkout.Visible = true;
                    Button3.Visible = true;


                }
                if (GridView4.Rows.Count == 0)
                {

                    btn4chkout.Visible = false;
                    Button4.Visible = false;
                }
                else
                {
                    btn4chkout.Visible = true;
                    Button4.Visible = true;


                }
                if ((GridView1.Rows.Count == 0) && (GridView2.Rows.Count == 0) && (GridView3.Rows.Count==0) && (GridView4.Rows.Count==0))
                {

                    btnAllchkout.Visible = false;
                    Button5.Visible = false;
                }
                else
                {
                    btnAllchkout.Visible = true;
                    Button5.Visible = true;


                }



            }
        }
        private void FoodGrid()
        {

            string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT *  FROM FOrder  Where UserName = '" + Session["UserName"].ToString() + "' AND status=0 ";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            GridView1.DataSource = command.ExecuteReader();
            GridView1.DataBind();
            computePriceFood();
        }
        private void HallGrid()
        {

            string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT HOID,HallName, Price  FROM HOrder  Where HOrder.UserName = '" + Session["UserName"].ToString() + "' AND status=0 ";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            GridView2.DataSource = command.ExecuteReader();
            GridView2.DataBind();
            computePriceHall();
        }
        private void TableGrid()
        {

            string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT TOID,NoOfSeat,time, Price  FROM TOrder  Where TOrder.UserName = '" + Session["UserName"].ToString() + "' AND status=0 ";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            GridView3.DataSource = command.ExecuteReader();
            GridView3.DataBind();
            computePriceTable();
        }
        private void RoomGrid()
        {
            string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT ROID,room_id,Price,checkin,checkout  FROM ROrder  Where user_name= '" + Session["UserName"].ToString() + "'AND status=0 ";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            GridView4.DataSource = command.ExecuteReader();
            GridView4.DataBind();
            computePriceRoom();
        }
        private void computePriceFood()
        {
            try
            {
                DataTable dt = new DataTable();
                string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                String myquery = "Select * from FOrder where Status=0";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = myquery;
                cmd.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                con.Close();
                GridView1.FooterRow.Cells[2].Text = "Total Amount";
                GridView1.FooterRow.Cells[3].Text = dt.Compute("Sum(Totalprice)", "").ToString();
                Label1.Text= dt.Compute("Sum(Totalprice)", "").ToString();
            }
            catch
            {
                lbl1.Text = "empty";
            }

        }
        private void computePriceHall()
        {
            try
            {
                DataTable dt = new DataTable();
                string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                String myquery = "Select * from HOrder where Status=0";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = myquery;
                cmd.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(dt);
                GridView2.DataSource = dt;
                GridView2.DataBind();
                con.Close();
                GridView2.FooterRow.Cells[0].Text = "Total Amount";
                GridView2.FooterRow.Cells[1].Text = dt.Compute("Sum(Price)", "").ToString();
                Label2.Text = dt.Compute("Sum(Price)", "").ToString();
            }
            catch
            {
                lbl2.Text = "empty";
            }
        }
        private void computePriceTable()
        {
            try
            {
                DataTable dt = new DataTable();
                string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                String myquery = "Select * from TOrder where Status=0";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = myquery;
                cmd.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(dt);
                GridView3.DataSource = dt;
                GridView3.DataBind();
                con.Close();
                GridView3.FooterRow.Cells[1].Text = "Total Amount";
                GridView3.FooterRow.Cells[2].Text = dt.Compute("Sum(Price)", "").ToString();
                Label3.Text = dt.Compute("Sum(Price)", "").ToString();
            }
            catch
            {
                lbl3.Text = "empty";
            }

        }
        private void computePriceRoom()
        {
            try
            {
                DataTable dt = new DataTable();
                string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                String myquery = "Select * from ROrder where Status=0";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = myquery;
                cmd.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(dt);
                GridView4.DataSource = dt;
                GridView4.DataBind();
                con.Close();
                GridView4.FooterRow.Cells[0].Text = "Total Amount";
                GridView4.FooterRow.Cells[1].Text = dt.Compute("Sum(price)", "").ToString();
                Label4.Text = dt.Compute("Sum(price)", "").ToString();
            }
            catch
            {
                lbl4.Text = "empty";
            }

        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            using (SqlConnection con = new SqlConnection(CS))
            {
                int oidd = (Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value));
                using (SqlCommand cmd = new SqlCommand("DELETE FROM FOrder WHERE FOID = '" + oidd + "'AND Status=0;", con))
                {

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dtBrand = new DataTable();
                        sda.Fill(dtBrand);
                        GridView1.DataSource = dtBrand;
                        GridView1.DataBind();
                    }

                }

                con.Close();
            }
            FoodGrid();
            lbl1.Text = GridView1.Rows.Count.ToString();

        }
        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            using (SqlConnection con = new SqlConnection(CS))
            {
                int Hidd = (Convert.ToInt32(GridView2.DataKeys[e.RowIndex].Value));
                using (SqlCommand cmd = new SqlCommand("DELETE FROM HOrder WHERE HOID = '" + Hidd + "'AND Status=0;", con))
                {

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dtBrand = new DataTable();
                        sda.Fill(dtBrand);
                        GridView2.DataSource = dtBrand;
                        GridView2.DataBind();
                    }

                }

                con.Close();
            }
            HallGrid();
            lbl2.Text = GridView2.Rows.Count.ToString();

        }
        protected void GridView3_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            using (SqlConnection con = new SqlConnection(CS))
            {
                int Tidd = (Convert.ToInt32(GridView3.DataKeys[e.RowIndex].Value));
                using (SqlCommand cmd = new SqlCommand("DELETE FROM TOrder WHERE TOID = '" + Tidd + "'AND Status=0;", con))
                {

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dtBrand = new DataTable();
                        sda.Fill(dtBrand);
                        GridView3.DataSource = dtBrand;
                        GridView3.DataBind();
                    }

                }

                con.Close();
            }
            TableGrid();
            lbl3.Text = GridView3.Rows.Count.ToString();

        }


        protected void GridView4_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            using (SqlConnection con = new SqlConnection(CS))
            {
                int Ridd = (Convert.ToInt32(GridView4.DataKeys[e.RowIndex].Value));
                using (SqlCommand cmd = new SqlCommand("DELETE FROM ROrder WHERE ROID = '" + Ridd + "'AND Status=0;", con))
                {

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dtBrand = new DataTable();
                        sda.Fill(dtBrand);
                        GridView4.DataSource = dtBrand;
                        GridView4.DataBind();
                    }

                }

                con.Close();
            }
            TableGrid();
            lbl4.Text = GridView3.Rows.Count.ToString();


        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            using (SqlConnection con = new SqlConnection(CS))
            {
                int oidd = (Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value));
                TextBox txtqq = GridView1.Rows[e.RowIndex].Cells[2].FindControl("txtq") as TextBox;
                string pricee = GridView1.Rows[e.RowIndex].Cells[1].Text;
                int tpricee = Convert.ToInt32(pricee) * Convert.ToInt32(txtqq.Text);
                // int b = Convert.ToInt32(txtqq.Text);
                //int tprice = a * b;
                // int tpricee = Convert.ToInt32(pricee) * Convert.ToInt32(txtqq.Text);
                using (SqlCommand cmd = new SqlCommand("UPDATE  FOrder SET  Qnt = '" + Convert.ToInt32(txtqq.Text) + "', TotalPrice = '"
                                                        + tpricee +  "'WHERE FOID='" + oidd + "'AND Status=0;", con))
                {

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dtBrand = new DataTable();
                        sda.Fill(dtBrand);
                        
                    }

                }

                con.Close();
            }
            FoodGrid();
        }

    

    protected void btnchckout_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lbl1.Text)!=0)
            {
                String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                string food = "food";
                //int a = 5; 
                SqlConnection con1 = new SqlConnection(CS);
                string query = " insert into Order2(user_name,type,price,date,time) values ('" + Session["USERNAME"].ToString() + "','"
                                                                 + food + "','"
                                                                 + Label1.Text + "','"
                                                                 + DateTime.Today.ToString() + "','"
                                                                 + DateTime.Now.ToString() + "')";
                //string query = "select * from Order2";
                SqlCommand sqlCommand = new SqlCommand(query, con1);
                con1.Open();
                sqlCommand.ExecuteNonQuery();

                FoodStatusUpdate();
                FoodGrid();
                Response.Redirect("Payment.aspx");
            }
            else
            {
                Response.Redirect("hoome.aspx");
            }
           
        }
        private void FoodStatusUpdate()
        {

            string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "UPDATE  FOrder SET  Status=1";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.ExecuteNonQuery();

        }

        protected void btn2chkout_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lbl2.Text) != 0)
            {
                String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                SqlConnection con1 = new SqlConnection(CS);
                string query = " insert into Order2(user_name,type,price,date,time) values ('" + Session["USERNAME"].ToString() + "','"
                                                                 + "hall" + "','"
                                                                 + Label2.Text + "','"
                                                                 + DateTime.Today.ToString() + "','"
                                                                 + DateTime.Now.ToString() + "')";
                SqlCommand sqlCommand = new SqlCommand(query, con1);
                con1.Open();
                sqlCommand.ExecuteNonQuery();
                HallStatusUpdate();
                HallGrid();
                Response.Redirect("Payment.aspx");
            }
            else
            {
                Response.Redirect("hoome.aspx");
            }

        }
      
            private void HallStatusUpdate()
        {

            string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "UPDATE  HOrder SET  Status=1";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.ExecuteNonQuery();

        }
        protected void btn3chkout_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lbl3.Text) != 0)
            {
                String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                SqlConnection con1 = new SqlConnection(CS);
                string query = " insert into Order2(user_name,type,price,date,time) values ('" + Session["USERNAME"].ToString() + "','"
                                                                 + "table" + "','"
                                                                 + Label3.Text + "','"
                                                                 + DateTime.Today.ToString() + "','"
                                                                 + DateTime.Now.ToString() + "')";
                SqlCommand sqlCommand = new SqlCommand(query, con1);
                con1.Open();
                sqlCommand.ExecuteNonQuery();
                TableStatusUpdate();
                TableGrid();
                Response.Redirect("Payment.aspx");
            }
            else
            {
                Response.Redirect("hoome.aspx");
            }
        }
        
            private void TableStatusUpdate()
        {

            string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "UPDATE  TOrder SET  Status=1";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.ExecuteNonQuery();

        }
        protected void btn4chkout_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lbl4.Text) != 0)
            {
                String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                SqlConnection con1 = new SqlConnection(CS);
                string query = " insert into Order2(user_name,type,price,date,time) values ('" + Session["USERNAME"].ToString() + "','"
                                                                 + "room" + "','"
                                                                 + Label4.Text + "','"
                                                                 + DateTime.Today.ToString() + "','"
                                                                 + DateTime.Now.ToString() + "')";
                SqlCommand sqlCommand = new SqlCommand(query, con1);
                con1.Open();
                sqlCommand.ExecuteNonQuery();
                RoomStatusUpdate();
                RoomGrid();
                Response.Redirect("Payment.aspx");
            }
            else
            {
                Response.Redirect("hoome.aspx");
            }
        }
        private void RoomStatusUpdate()
        {

            string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "UPDATE  ROrder SET  Status=1";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.ExecuteNonQuery();

        }
        protected void btnAllchkout_Click(object sender, EventArgs e)
        {
            try
            {
                Label5.Text = (int.Parse(Label1.Text) + int.Parse(Label2.Text) + int.Parse(Label3.Text) + int.Parse(Label4.Text)).ToString();
                String CS = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
                SqlConnection con1 = new SqlConnection(CS);
                string query = " insert into Order2(user_name,type,price,date,time) values ('" + Session["USERNAME"].ToString() + "','"
                                                                 + "all" + "','"
                                                                 + Label5.Text + "','"
                                                                 + DateTime.Today.ToString() + "','"
                                                                 + DateTime.Now.ToString() + "')";
                SqlCommand sqlCommand = new SqlCommand(query, con1);
                con1.Open();
                sqlCommand.ExecuteNonQuery();
                FoodStatusUpdate();
                HallStatusUpdate();
                TableStatusUpdate();
                RoomStatusUpdate();
                FoodGrid();
                HallGrid();
                TableGrid();
                RoomGrid();
                Response.Redirect("Payment.aspx");
            }
            catch
            {
                Response.Redirect("hoome.aspx");
            }
           
        }
            protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
        protected void Button2_Click(object sender, EventArgs e)
        {

        }
        protected void Button3_Click(object sender, EventArgs e)
        {

        }
        protected void Button4_Click(object sender, EventArgs e)
        {

        }
        protected void Button5_Click(object sender, EventArgs e)
        {

        }


        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}