using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class InstructorHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addcourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCourse.aspx?id=" + Int16.Parse(Request.QueryString["id"]));
        }

        protected void defineass_Click(object sender, EventArgs e)
        {
            Response.Redirect("DefineAssignments.aspx?id=" + Int16.Parse(Request.QueryString["id"]));
        }

        protected void manageass_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageAssignments.aspx?id=" + Int16.Parse(Request.QueryString["id"]));
        }

        protected void viewfeed_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewFeedback.aspx?id=" + Int16.Parse(Request.QueryString["id"]));
        }

        protected void issuecert_Click(object sender, EventArgs e)
        {
            Response.Redirect("IssueCertificate.aspx?id=" + Int16.Parse(Request.QueryString["id"]));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("mobileadd.aspx?src=0&id=" + Int16.Parse(Request.QueryString["id"]));

        }
    }
}