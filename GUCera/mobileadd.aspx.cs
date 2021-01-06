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

            int id = Int16.Parse(username.Text);
            String phone = number.Text;

            SqlCommand mobileproc = new SqlCommand("addMobile", conn);
            mobileproc.CommandType = CommandType.StoredProcedure;
            mobileproc.Parameters.Add(new SqlParameter("@ID", id));
            mobileproc.Parameters.Add(new SqlParameter("@mobile_number", phone));

            conn.Open();
            mobileproc.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("Login.aspx");
        }
    }
}