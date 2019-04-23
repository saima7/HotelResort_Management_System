using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Twilio;
using Twilio.Clients;
using System.Web.Mvc;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace WebApplication3
{
    public partial class Payment : System.Web.UI.Page
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlConnection sqlConnection1 = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataAdapter sqlAdapter = new SqlDataAdapter();
        DataSet dataSet = new DataSet();
        Random rnd = new Random();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
               try
                {
                    string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";                 
                    SqlConnection con = new SqlConnection(connectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT MAX(Order_ID) FROM Order2;",con);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        OiD.Text = reader[0].ToString();
                    }
                    con.Close();

                 }
                catch
                {
                  OiD.Text = "empty";
                }

            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=TULON-PC\\SQLEXPRESS;Database=abc;User Id=sa ; password=tulon;";
            sqlConnection1 = new SqlConnection(connectionString);
            sqlConnection1.Open();
            //int emp = Convert.ToInt32(ID.Text);
            string query = null;
            query = "UPDATE  Order2 SET  paymentID='" +(TrxInput.Text).ToString() + "',paymentMethod='"
                                                   + (DropDownList1.SelectedValue).ToString()+ "'WHERE Order_ID like '" + int.Parse(OiD.Text) + "'";

            sqlCommand = new SqlCommand(query, sqlConnection1);
            sqlCommand.ExecuteNonQuery();
             const string accountSid = "AC900d644eec9ccd410ded7e352256f7cc";
             const string authToken = "8be227142b2c17a62d1be370edb900fa";
             //string x = "+88" + mobile;
             string x = "+8801766537263";
             int random = rnd.Next(540000, 1000000);
             String r = random.ToString();


             TwilioClient.Init(accountSid, authToken);
             MessageResource.Create(
                        to: new PhoneNumber(x),
                       // from: new PhoneNumber("+15852095333"),
                       from: new PhoneNumber("+15865719119"),
                        body: "Payment Successful for your purchase! Your Pin Code for this booking - " + r + ". We are eagerly waiting to welcome you at our grand hotel!");
             
            Response.Redirect("Hoome.aspx");
        }
    }
}