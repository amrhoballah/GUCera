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
    public partial class listcert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentHome.aspx?id=" + Request.QueryString["id"]);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            int id = Int16.Parse(Request.QueryString["id"]);
            int cid = Int16.Parse(course.Text);

            SqlCommand feedproc = new SqlCommand("viewCertificate", conn);
            feedproc.CommandType = CommandType.StoredProcedure;

            feedproc.Parameters.Add(new SqlParameter("@sid", id));
            feedproc.Parameters.Add(new SqlParameter("@cid", cid));

            conn.Open();
            try
            {
                SqlDataReader rdr = feedproc.ExecuteReader(CommandBehavior.CloseConnection);

                rdr.Read();

                string date = rdr.GetSqlDateTime(rdr.GetOrdinal("issueDate")).ToString();

                TableRow row = new TableRow();
                TableCell data1 = new TableCell();
                TableCell data2 = new TableCell();
                TableCell data3 = new TableCell();
                data1.Text = ""+id;
                data2.Text = ""+cid;
                data3.Text = date;

                row.Cells.Add(data1);
                row.Cells.Add(data2);
                row.Cells.Add(data3);

                Table1.Controls.Add(row);
            }
            catch(SqlException ex)
            {
                Response.Write("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
                course.Text = default;
            }
        }
    }
}