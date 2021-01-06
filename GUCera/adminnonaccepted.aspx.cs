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
    public partial class adminnonaccepted : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand viewproc = new SqlCommand("AdminViewNonAcceptedCourses", conn);
            viewproc.CommandType = CommandType.StoredProcedure;

            conn.Open();
            SqlDataReader rdr = viewproc.ExecuteReader(CommandBehavior.CloseConnection);

            while (rdr.Read())
            {
                String dataLine = rdr.GetString(rdr.GetOrdinal("name"));
                int credit = rdr.GetInt32(rdr.GetOrdinal("creditHours"));
                double price = (double)rdr.GetDecimal(rdr.GetOrdinal("price"));
                String content;
                if (rdr.IsDBNull(rdr.GetOrdinal("content")))
                {
                    content = "NoContent";
                }
                else
                {
                    content = rdr.GetString(rdr.GetOrdinal("content"));
                }


                dataLine += " " + credit + " " + price + " " + content;

                Label data = new Label();
                data.Text = dataLine;
                form1.Controls.Add(data);
                form1.Controls.Add(new LiteralControl("<br />"));
            }
        }

        protected void Accept_Click(object sender, EventArgs e)
        {
            int id = Int16.Parse(Request.QueryString["id"]);
            int course = Int16.Parse(courseid.Text);

            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand acceptproc = new SqlCommand("AdminAcceptRejectCourse", conn);
            acceptproc.CommandType = CommandType.StoredProcedure;

            acceptproc.Parameters.Add(new SqlParameter("@adminid", id));
            acceptproc.Parameters.Add(new SqlParameter("@courseId", course));

            conn.Open();
            acceptproc.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("adminnonaccepted.aspx?id=" + id);
        }
    }
}