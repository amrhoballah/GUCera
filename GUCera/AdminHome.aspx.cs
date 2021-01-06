using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class AdminHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void allcourses(object sender, EventArgs e)
        {
            Response.Redirect("adminallcourses.aspx");
        }

        protected void nonaccepted(object sender, EventArgs e)
        {
            int id = Int16.Parse(Request.QueryString["id"]);
            Response.Redirect("adminnonaccepted.aspx?id=" + id);
        }

        protected void promos(object sender, EventArgs e)
        {
            int id = Int16.Parse(Request.QueryString["id"]);
            Response.Redirect("managepromos.aspx?id=" + id);
        }
    }
}