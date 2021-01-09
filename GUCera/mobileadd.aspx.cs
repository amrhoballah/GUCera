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
    public partial class mobileadd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            int id = Int16.Parse(Request.QueryString["id"]);
            String phone = number.Text;

            SqlCommand mobileproc = new SqlCommand("addMobile", conn);
            mobileproc.CommandType = CommandType.StoredProcedure;
            mobileproc.Parameters.Add(new SqlParameter("@ID", id));
            mobileproc.Parameters.Add(new SqlParameter("@mobile_number", phone));

            conn.Open();
            try
            {
                mobileproc.ExecuteNonQuery();
                Response.Write("Number added successfully");
            }
            catch (SqlException ex)
            {
                Response.Write("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
                number.Text = default;
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            int id = Int16.Parse(Request.QueryString["id"]);
            if (Request.QueryString["src"] == "1")
            {
                Response.Redirect("AdminHome.aspx?id=" + id);
            }
            else if (Request.QueryString["src"] == "0")
            {
                Response.Redirect("InstructorHome.aspx?id=" + id);
            }
            else
            {
                Response.Redirect("StudentHome.aspx?id=" + id);
            }
        }
    }
}