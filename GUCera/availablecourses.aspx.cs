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
    public partial class availablecourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand viewproc = new SqlCommand("availableCourses", conn);
            viewproc.CommandType = CommandType.StoredProcedure;

            conn.Open();
            SqlDataReader rdr = viewproc.ExecuteReader(CommandBehavior.CloseConnection);

            while (rdr.Read())
            {
                int id = rdr.GetInt32(rdr.GetOrdinal("id"));
                String name = rdr.GetString(rdr.GetOrdinal("name"));
                
                TableRow row = new TableRow();
                TableCell data1 = new TableCell();
                TableCell data2 = new TableCell();
                data1.Text = "" + id;
                data2.Text = name;
                row.Cells.Add(data1);
                row.Cells.Add(data2);
                Table1.Controls.Add(row);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int sid = Int16.Parse(Request.QueryString["id"]);
            int course = Int16.Parse(cid.Text);
            int inst = Int16.Parse(iid.Text);
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

           
            try
            {
                SqlCommand viewproc = new SqlCommand("enrollInCourse", conn);
                viewproc.CommandType = CommandType.StoredProcedure;
                viewproc.Parameters.Add(new SqlParameter("@sid",sid));
                viewproc.Parameters.Add(new SqlParameter("@cid", course));
                viewproc.Parameters.Add(new SqlParameter("@instr", inst));

                conn.Open();
                viewproc.ExecuteNonQuery();
                Response.Write("Enrolled in Course Successfully.");
            }
            catch(SqlException ex)
            {
                Response.Write("Error: " + ex.Message);
            }
            finally
            {
                cid.Text = default;
                iid.Text = default;
                conn.Close();
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentHome.aspx?id=" + Request.QueryString["id"]);
        }
    }
}