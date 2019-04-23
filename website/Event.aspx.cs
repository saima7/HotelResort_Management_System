using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Event : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USERNAME"] != null)
            {

                lblSuccess.Text = " Welcome " + Session["USERNAME"].ToString() + "";
            }
        }
        protected void btnevent_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHall.aspx");
        }
    }
}