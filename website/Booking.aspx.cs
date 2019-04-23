using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using WebApplication3.App_Code.Order;
using Twilio;
using Twilio.Clients;
using System.Web.Mvc;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace WebApplication3
{
    public partial class Booking : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;");
        // string _connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
        //string _connStr = "Server=TULON-PC\\SQLEXPRESS;Database=foodorder;User Id=sa ; password=tulon;";
        private SqlDataReader dr;
        OrderDAO OrderDao = new OrderDAO();
        Random rnd = new Random();
        String mobile;
        protected void Page_Load(object sender, EventArgs e)
        {
            String str = "SELECT mobile FROM  Users where userName = @search ";
            SqlCommand xp = new SqlCommand(str, con);
            xp.Parameters.Add("@search", SqlDbType.VarChar).Value = Session["passuser"].ToString();
            //xp.Parameters.Add("@search", SqlDbType.VarChar).Value = TextBox1.Text;

           // xp.Parameters.Add("@search", SqlDbType.VarChar).Value = "flo";
            con.Open();
            xp.ExecuteNonQuery();
            dr = xp.ExecuteReader();      // Executing Command & Reading Data

            if (dr.Read())
            {

                mobile = dr[0].ToString(); //  Use Data From Here

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Ordered_by = Session["passuser"].ToString();
            //  string Ordered_by = "sakiftahmid";
            
            // string Ordered_item = Session["passres"].ToString();
             string room = "501";
            // int Quantity = Convert.ToInt32(Session["passquan"].ToString());
            // int Quantity = 5;
            

            string Time = DateTime.Now.ToString("hh:mm:ss tt");
            string Date = DateTime.Now.ToString("dd/MM/yyyy");
            string TrxID = TrxInput.Text;
            int random = rnd.Next(540000, 1000000);
            String r = random.ToString();
            OrderDao.AddOrder(new OrderDTO(Ordered_by, room, Date, Time,r, TrxID));
            const string accountSid = "AC900d644eec9ccd410ded7e352256f7cc";
            const string authToken = "8be227142b2c17a62d1be370edb900fa";
            string x = "+88" + mobile;
            

            TwilioClient.Init(accountSid, authToken);
            MessageResource.Create(
                       to: new PhoneNumber(x),
                      // from: new PhoneNumber("+15852095333"),
                      from: new PhoneNumber("+15865719119"),
                       body: "Booking Successful for room no: " + room + "! Your Pin Code for this booking - " + r + ". We are eagerly waiting to welcome you at our grand hotel!");
            Response.Redirect("home1.html");
        }
    }
}