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
    public partial class DefineAssignments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void defass_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
            int id = Int16.Parse(Request.QueryString["id"]);
            int grade = Int16.Parse(full.Text);
            int course = Int16.Parse(cid.Text);
            double wei = Double.Parse(weight.Text);
            string cont = content.Text;
            string dead = deadline.SelectedDate.ToString("yyyy/MM/dd");
            string typea = type.Text;
            int num = Int16.Parse(number.Text);

            SqlCommand defAssign = new SqlCommand("DefineAssignmentOfCourseOfCertianType", conn);
            defAssign.CommandType = CommandType.StoredProcedure;
            defAssign.Parameters.Add(new SqlParameter("@instId", id));
            defAssign.Parameters.Add(new SqlParameter("@cid", course));
            defAssign.Parameters.Add(new SqlParameter("@fullGrade", grade));
            defAssign.Parameters.Add(new SqlParameter("@content", cont));
            defAssign.Parameters.Add(new SqlParameter("@type", typea));
            defAssign.Parameters.Add(new SqlParameter("@deadline", dead));
            defAssign.Parameters.Add(new SqlParameter("@number", num));
            defAssign.Parameters.Add(new SqlParameter("@weight", wei));

            conn.Open();
            try
            {
                defAssign.ExecuteNonQuery();
                conn.Close();
                Response.Write("Assignment defined successfully");
            }
            catch (SqlException ex)
            {
                conn.Close();
                Response.Write("Error: " + ex.Message);
            }
        }
    }
}