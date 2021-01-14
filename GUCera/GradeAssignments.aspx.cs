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
    public partial class GradeAssignments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            int id = Int16.Parse(Request.QueryString["id"]);
            int sid = Int16.Parse(student.Text);
            int cid = Int16.Parse(course.Text);
            int num = Int16.Parse(number.Text);
            string atype = type1.SelectedValue.ToString();
            double mark = Double.Parse(grade.Text);



            SqlCommand addgrade = new SqlCommand("InstructorgradeAssignmentOfAStudent", conn);
            addgrade.CommandType = CommandType.StoredProcedure;

            addgrade.Parameters.Add(new SqlParameter("@instrId", id));
            addgrade.Parameters.Add(new SqlParameter("@sid", sid));
            addgrade.Parameters.Add(new SqlParameter("@cid", cid));
            addgrade.Parameters.Add(new SqlParameter("@assignmentNumber", num));
            addgrade.Parameters.Add(new SqlParameter("@type", atype));
            addgrade.Parameters.Add(new SqlParameter("@grade", mark));


            conn.Open();
            try
            {
                addgrade.ExecuteNonQuery();
                Response.Write("Assignment Graded Successfully");
            }
            catch(SqlException ex)
            {
                Response.Write("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();

            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
                Response.Redirect("InstructorHome.aspx?id=" + Request.QueryString["id"]);
            
        }
    }
}
