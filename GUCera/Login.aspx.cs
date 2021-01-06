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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            int id = Int16.Parse(username.Text);
            String pass = password.Text;

            SqlCommand loginproc = new SqlCommand("userLogin", conn);
            loginproc.CommandType = CommandType.StoredProcedure;
            loginproc.Parameters.Add(new SqlParameter("@id", id));
            loginproc.Parameters.Add(new SqlParameter("@password", pass));
            SqlParameter success = loginproc.Parameters.Add("@success", SqlDbType.Int);
            SqlParameter type = loginproc.Parameters.Add("@type", SqlDbType.Int);

            success.Direction = ParameterDirection.Output;
            type.Direction = ParameterDirection.Output;

            conn.Open();
            loginproc.ExecuteNonQuery();
            conn.Close();

            if (success.Value.ToString() == "1")
            {
                if(type.Value.ToString() == "1")
                {
                    Response.Redirect("AdminHome.aspx?id=" + id);
                }
                else if(type.Value.ToString() == "0")
                {
                    Response.Redirect("InstructorHome.aspx?id="+ id);                }
                else
                {
                    Response.Redirect("StudentHome.aspx?="+ id);
                }

            }
            else
            {
                Response.Write("Failed Login");
            }

        }

        protected void Studentregister(object sender, EventArgs e)
        {
            Response.Redirect("sRegister.aspx");
        }

        protected void Instructorregister(object sender, EventArgs e)
        {
            Response.Redirect("iRegister.aspx");
        }

        protected void mobile_Click(object sender, EventArgs e)
        {
            Response.Redirect("mobileadd.aspx");
        }
    }
}