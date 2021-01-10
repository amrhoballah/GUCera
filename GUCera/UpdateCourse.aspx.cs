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
    public partial class UpdateCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("InstructorHome.aspx?id=" + Request.QueryString["id"]);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int cid = Int16.Parse(course.Text);
            int instrId = Int16.Parse(Request.QueryString["id"]);
            string content = con.Text;
            string description = des.Text;

            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand upcontent = new SqlCommand("UpdateCourseContent", conn);
            upcontent.CommandType = CommandType.StoredProcedure;
            upcontent.Parameters.Add(new SqlParameter("@content", content));
            upcontent.Parameters.Add(new SqlParameter("@courseId", cid));
            upcontent.Parameters.Add(new SqlParameter("@instrId", instrId));

            SqlCommand updescription = new SqlCommand("UpdateCourseDescription", conn);
            updescription.CommandType = CommandType.StoredProcedure;
            updescription.Parameters.Add(new SqlParameter("@instrId", instrId));
            updescription.Parameters.Add(new SqlParameter("@courseId", cid));
            updescription.Parameters.Add(new SqlParameter("@courseDescription", description));

            conn.Open();
            try
            {
                if(content != "")
                {
                    upcontent.ExecuteNonQuery();
                    Response.Write("Content Updated Successfully! ");
                }
                if(description != "")
                {
                    updescription.ExecuteNonQuery();
                    Response.Write("Description Updated Successfully! ");
                }
                if(content == "" && description == "")
                {
                    Response.Write("You have not updated the course!");
                }
            }
            catch(SqlException ex)
            {
                Response.Write("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
                course.Text = default;
                con.Text = default;
                des.Text = default;
            }

        }
    }
}