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
    public partial class AddCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addc_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);
            int id = Int16.Parse(Request.QueryString["id"]);
            int hours = Int16.Parse(credit.Text);
            string course = name.Text;
            double cashmoney = Double.Parse(price.Text);


            SqlCommand addCourse = new SqlCommand("InstAddCourse", conn);
            addCourse.CommandType = CommandType.StoredProcedure;
            addCourse.Parameters.Add(new SqlParameter("@instructorId", id));
            addCourse.Parameters.Add(new SqlParameter("@name", course));
            addCourse.Parameters.Add(new SqlParameter("@creditHours", hours));
            addCourse.Parameters.Add(new SqlParameter("@price", cashmoney));
            SqlParameter courseid = addCourse.Parameters.Add("@cid", SqlDbType.Int);

            courseid.Direction = ParameterDirection.Output;

            conn.Open();
            try
            {
                addCourse.ExecuteNonQuery();
                conn.Close();
                Response.Write("Course ID " + courseid.Value.ToString() +" added successfully");
            }
            catch(SqlException ex)
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