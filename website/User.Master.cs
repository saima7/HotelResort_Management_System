using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class User : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

            if (Session["USERNAME"] != null)
            {
                btnSignOut.Visible = true;
                btnSignIn.Visible = false;
            }
            else
            {
                btnSignOut.Visible = false;
                btnSignIn.Visible = true;
            }
        }
        protected void btnSignOut_Click(object sender, EventArgs e)
        {
            Session["USERNAME"] = null;
            Response.Redirect("~/hoome.aspx");
        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/logIN.aspx");
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