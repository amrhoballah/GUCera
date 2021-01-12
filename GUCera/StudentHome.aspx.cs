using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class StudentHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("studentprofile.aspx?id=" + Request.QueryString["id"]);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("mobileadd.aspx?src=2&id=" + Request.QueryString["id"]);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("availablecourses.aspx?id=" + Request.QueryString["id"]);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewpromos.aspx?id=" + Request.QueryString["id"]);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("creditcards.aspx?id=" + Request.QueryString["id"]);
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewassign.aspx?id=" + Request.QueryString["id"]);
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewgrades.aspx?id=" + Request.QueryString["id"]);
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("submitassign.aspx?id=" + Request.QueryString["id"]);
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("feedbackadd.aspx?id=" + Request.QueryString["id"]);
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Response.Redirect("listcert.aspx?id=" + Request.QueryString["id"]);
        }
    }
}