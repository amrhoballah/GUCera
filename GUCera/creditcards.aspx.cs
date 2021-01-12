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
    public partial class creditcards : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void create_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            int id = Int16.Parse(Request.QueryString["id"]);
            String num = number.Text;
            string cvv = code.Text;
            String nom = name.Text;
            String exp = expiry.SelectedDate.ToString("yyyy/MM/dd");

            SqlCommand createproc = new SqlCommand("addCreditCard", conn);
            createproc.CommandType = CommandType.StoredProcedure;

            createproc.Parameters.Add(new SqlParameter("@sid", id));
            createproc.Parameters.Add(new SqlParameter("@number", num));
            createproc.Parameters.Add(new SqlParameter("@expiryDate", exp));
            createproc.Parameters.Add(new SqlParameter("@cardHolderName", nom));
            createproc.Parameters.Add(new SqlParameter("@cvv", cvv));

            conn.Open();
            try
            {
                createproc.ExecuteNonQuery();
                conn.Close();
                Response.Write("Credit Card added successfully");
            }
            catch (SqlException ex)
            {
                conn.Close();
                Response.Write("Error: " + ex.Message);
            }
            finally
            {
                number.Text = "";
                code.Text = "";
                name.Text = default;
                expiry.SelectedDate = default;
            }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

            int id = Int16.Parse(Request.QueryString["id"]);
            Response.Redirect("StudentHome.aspx?id=" + id);

        }

    }
}