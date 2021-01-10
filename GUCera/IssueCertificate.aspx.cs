using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class IssueCertificate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void isscer_click(object sender, EventArgs e)
        {
            string connStr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
            int id = Int16.Parse(Request.QueryString["id"]);
            int student = Int16.Parse(sid.Text);
            int course = Int16.Parse(cid.Text);
            string iss = issue.SelectedDate.ToString("yyyy/MM/dd");

            SqlCommand calcProc = new SqlCommand("calculateFinalGrade", conn);
            calcProc.CommandType = CommandType.StoredProcedure;
            calcProc.Parameters.Add(new SqlParameter("@insId", id));
            calcProc.Parameters.Add(new SqlParameter("@cid", course));
            calcProc.Parameters.Add(new SqlParameter("@sid", student));

            conn.Open();
            try
            {
                calcProc.ExecuteNonQuery();
                conn.Close();
                Response.Write("Assignment defined successfully");
            }
            catch (SqlException ex)
            {
                conn.Close();
                Response.Write("Error: " + ex.Message);
            }

            SqlCommand issproc = new SqlCommand("InstructorIssueCertificateToStudent", conn);
            issproc.CommandType = CommandType.StoredProcedure;
            issproc.Parameters.Add(new SqlParameter("@insId", id));
            issproc.Parameters.Add(new SqlParameter("@cid", course));
            issproc.Parameters.Add(new SqlParameter("@sid", student));
            issproc.Parameters.Add(new SqlParameter("@issueDate", iss));



            conn.Open();
            try
            {
                issproc.ExecuteNonQuery();
                conn.Close();
                Response.Write("Assignment defined successfully");
            }
            catch (SqlException ex)
            {
                conn.Close();
                Response.Write("Error: " + ex.Message);
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("InstructorHome.aspx?id=" + Request.QueryString["id"]);

        }
    }
}