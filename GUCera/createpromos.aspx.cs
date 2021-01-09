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
    public partial class managepromos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void create_Click(object sender, EventArgs e)
        {
            
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            int id = Int16.Parse(Request.QueryString["id"]);
            String promo = promocode.Text;
            double disc = Double.Parse(discount.Text);
            String iss = issue.SelectedDate.ToString("yyyy/MM/dd");
            String exp = expiry.SelectedDate.ToString("yyyy/MM/dd");

            SqlCommand createproc = new SqlCommand("AdminCreatePromocode", conn);
            createproc.CommandType = CommandType.StoredProcedure;

            createproc.Parameters.Add(new SqlParameter("@code", promo));
            createproc.Parameters.Add(new SqlParameter("@isuueDate", iss));
            createproc.Parameters.Add(new SqlParameter("@expiryDate", exp));
            createproc.Parameters.Add(new SqlParameter("@discount", disc));
            createproc.Parameters.Add(new SqlParameter("@adminId", id));
            
            conn.Open();
            try
            {
                createproc.ExecuteNonQuery();
                conn.Close();
                Response.Write("Promocode created successfully");
            }
            catch (SqlException ex)
            {
                conn.Close();
                Response.Write("Error: " + ex.Message);
            }
            finally
            {
                promocode.Text = "";
                discount.Text = "";
                issue.SelectedDate = default;
                expiry.SelectedDate = default;
            }
           
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
           
                int id = Int16.Parse(Request.QueryString["id"]);
                Response.Redirect("AdminHome.aspx?id=" + id);
           
        }
    }
}