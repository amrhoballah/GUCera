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
    public partial class iRegister : System.Web.UI.Page
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

            SqlCommand ireg = new SqlCommand("InstructorRegister", conn);
            ireg.CommandType = CommandType.StoredProcedure;

            ireg.Parameters.Add(new SqlParameter("@first_name", first));
            ireg.Parameters.Add(new SqlParameter("@last_name", last));
            ireg.Parameters.Add(new SqlParameter("@password", password));
            ireg.Parameters.Add(new SqlParameter("@email", emailat));
            ireg.Parameters.Add(new SqlParameter("@gender", gen));
            ireg.Parameters.Add(new SqlParameter("@address", address));
            SqlParameter id = ireg.Parameters.Add("@id", SqlDbType.Int);
            id.Direction = ParameterDirection.Output;
            conn.Open();
            try
            {
                ireg.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("Default.aspx?id=" + id.Value.ToString()) ;
            }
            catch(SqlException ex)
            {
                conn.Close();
                Response.Write("Error: " + ex.Message);
            }
        }
    }
}