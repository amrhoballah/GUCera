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
    public partial class ViewFeedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void viewf_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            int id = Int16.Parse(Request.QueryString["id"]);
            int course = Int16.Parse(cid.Text);

            SqlCommand viewproc = new SqlCommand("ViewFeedbacksAddedByStudentsOnMyCourse", conn);
            viewproc.CommandType = CommandType.StoredProcedure;
            viewproc.Parameters.Add(new SqlParameter("@cid", course));
            viewproc.Parameters.Add(new SqlParameter("@instrId", id));


            conn.Open();
            try
            {
                SqlDataReader rdr = viewproc.ExecuteReader(CommandBehavior.CloseConnection);
                form1.Controls.Add(new LiteralControl("Feedback Found"));
                while (rdr.Read())
                {
                    String dataLine =""+ rdr.GetInt32(rdr.GetOrdinal("number"));
                    string credit = rdr.GetString(rdr.GetOrdinal("comment"));
                    double price = rdr.GetInt32(rdr.GetOrdinal("numberOfLikes"));

                    dataLine += " " + credit + " " + price;

                    Label data = new Label();
                    data.Text = dataLine;
                    form1.Controls.Add(data);
                    form1.Controls.Add(new LiteralControl("<br />"));
                }
            }catch(SqlException ex)
            {
                conn.Close();
                Response.Write("Error: " + ex.Message);
            }
        }
    }
}