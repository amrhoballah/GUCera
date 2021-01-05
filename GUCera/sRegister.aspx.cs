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
    public partial class sRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void register_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            String first = fname.Text;
            String last = lname.Text;
            String password = pass.Text;
            String emailat = email.Text;
            int gen = Int16.Parse(gender.Text);
            String address = add.Text;

            SqlCommand sreg = new SqlCommand("studentRegister", conn);
            sreg.CommandType = CommandType.StoredProcedure;

            sreg.Parameters.Add(new SqlParameter("@first_name", first));
            sreg.Parameters.Add(new SqlParameter("@last_name", last));
            sreg.Parameters.Add(new SqlParameter("@password", password));
            sreg.Parameters.Add(new SqlParameter("@email", emailat));
            sreg.Parameters.Add(new SqlParameter("@gender", gen));
            sreg.Parameters.Add(new SqlParameter("@address", address));

            conn.Open();
            sreg.ExecuteNonQuery();
            conn.Close();
           
            Response.Write("Successful Register");
            Response.Redirect("Login.aspx");
            

        }
    }
}