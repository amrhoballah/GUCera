using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class feedbackadd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentHome.aspx?id=" + Request.QueryString["id"]);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            int id = Int16.Parse(Request.QueryString["id"]);
            int cid = Int16.Parse(course.Text);
            string comment = comm.Text;

            SqlCommand feedproc = new SqlCommand("addFeedback", conn);
            feedproc.CommandType = CommandType.StoredProcedure;

            feedproc.Parameters.Add(new SqlParameter("@comment", comment));
            feedproc.Parameters.Add(new SqlParameter("@sid", id));
            feedproc.Parameters.Add(new SqlParameter("@cid", cid));

            conn.Open();
            try
            {
                feedproc.ExecuteNonQuery();
                Response.Write("Feedback Added Successully");
            }
            catch(SqlException ex)
            {
                Response.Write("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
                course.Text = default;
                comm.Text = default;
            }
        }
    }
}