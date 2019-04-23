using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.App_Code.Reg;
using WebApplication3.App_Code;
using System.Configuration;
using Twilio;
using Twilio.Clients;
using System.Web.Mvc;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace WebApplication3
{
    public partial class register : System.Web.UI.Page
    {
        RegDAO RegDao = new RegDAO();
        UserCheck UserChk = new UserCheck();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void reg_Click(object sender, EventArgs e)
        {
            string userName = usertxt.Text;
            string firstName = firsttxt.Text;
            string lastName = lasttxt.Text;
            string email = emailtxt.Text;
            string password = passtxt.Text;



            if (userName == "" || firstName == "" || lastName == "" || email == "" || password == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Please fill all the required field');</script>");

            }

            else
            {
                if (CheckEmail(email) == true)
                {
                    if (UserChk.ChkUser(userName) == true)
                    {
                        usertxt.Text = "";
                        Response.Write("<script language='javascript'>alert('This username already exists');</script>");
                    }
                    else
                    {
                        RegDao.RegUser(new RegDTO(userName, firstName, lastName, email, password));

                        //   Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Registration Successful');</script>");
                        
                        //  Response.Redirect("login.aspx");
                        //const string accountSid = "AC900d644eec9ccd410ded7e352256f7cc";
                        //const string authToken = "8be227142b2c17a62d1be370edb900fa";
                        //string x = "+88"+lasttxt.Text;

                       /* TwilioClient.Init(accountSid, authToken);
                        MessageResource.Create(
                                   to: new PhoneNumber(x),
                                   from: new PhoneNumber("+15852095333"),
                                   body: "Registration Successful!");
                                   */

                        usertxt.Text = "";
                        firsttxt.Text = "";
                        lasttxt.Text = "";
                        emailtxt.Text = "";
                        passtxt.Text = "";
                        Response.Write("<script language='javascript'>alert('Registration Successful');</script>");
                        Server.Transfer("logIN.aspx", true);
                        /* String connectionString = "Server=DESKTOP-5UHHJB2;Database=foodorder;User Id=sa ; password=sakif;";
                         SqlConnection con = new SqlConnection(connectionString);
                         String query = "insert into Users(userName,firstName,lastName,email,password)values('" + usertxt.Text + "','" + firsttxt.Text + "','" + lasttxt.Text + "','" + emailtxt.Text + "','" + passtxt.Text + "')";
                         SqlCommand cmd = new SqlCommand(query, con);
                         con.Open();
                         cmd.ExecuteNonQuery();
                         con.Close();
                         Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Registration Successful');</script>");
                         usertxt.Text = "";
                         firsttxt.Text = "";
                         lasttxt.Text = "";
                         emailtxt.Text = "";
                         passtxt.Text = "";
                         Response.Redirect("login.aspx");
                         */






                    }
                }
                else
                {
                    Response.Write("<script language='javascript'>alert('Invalid Email');</script>");
                }
            }
        }
        private bool CheckEmail(string EmailAddress)
        {


            string strPattern = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";


            if (System.Text.RegularExpressions.Regex.IsMatch(EmailAddress, strPattern))
            { return true; }
            return false;
        }

        protected void signbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("logIN.aspx");
        }

        protected void lasttxt_TextChanged(object sender, EventArgs e)
        {

        }

        protected void firsttxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}