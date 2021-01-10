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
                while (rdr.Read())
                {
                    String dataLine =""+ rdr.GetInt32(rdr.GetOrdinal("number"));
                    string credit = rdr.GetString(rdr.GetOrdinal("comment"));
                    double price = rdr.GetInt32(rdr.GetOrdinal("numberOfLikes"));


                    TableRow row = new TableRow();
                    TableCell data1 = new TableCell();
                    TableCell data2 = new TableCell();
                    TableCell data3 = new TableCell();
                    data1.Text = "" + dataLine;
                    data2.Text = "" + credit;
                    data3.Text = "" + price;
                    row.Cells.Add(data1);
                    row.Cells.Add(data2);
                    row.Cells.Add(data3);
                    table2.Controls.Add(row);
                }
            }catch(SqlException ex)
            {
                conn.Close();
                Response.Write("Error: " + ex.Message);
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("InstructorHome.aspx?id=" + Request.QueryString["id"]);

        }
    }
}