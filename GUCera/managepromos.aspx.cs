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
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand viewproc = new SqlCommand("AdminListAllStudents", conn);
            viewproc.CommandType = CommandType.StoredProcedure;

            conn.Open();
            SqlDataReader rdr = viewproc.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                String dataLine = rdr.GetString(rdr.GetOrdinal("firstName"));
                dataLine += " "+rdr.GetString(rdr.GetOrdinal("lastName"));
                

                Label data = new Label();
                data.Text = dataLine;
                form1.Controls.Add(data);
                form1.Controls.Add(new LiteralControl("<br />"));
            }
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
            createproc.ExecuteNonQuery();
            conn.Close();

            Response.Redirect("managepromos.aspx?id=" + id);
        }

        protected void Issuep_Click(object sender, EventArgs e)
        {
            int sid = Int16.Parse(username.Text);
            String code = issuedpromo.Text;

            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand issueproc = new SqlCommand("AdminIssuePromocodeToStudent", conn);
            issueproc.CommandType = CommandType.StoredProcedure;

            issueproc.Parameters.Add(new SqlParameter("@sid", sid));
            issueproc.Parameters.Add(new SqlParameter("@pid", code));

            conn.Open();
            issueproc.ExecuteNonQuery();
            conn.Close();

            Response.Redirect("managepromos.aspx?id=" + Request.QueryString["id"]);
        }
    }
}