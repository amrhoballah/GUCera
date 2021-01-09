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
    public partial class issuepromos : System.Web.UI.Page
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
                int id = rdr.GetInt32(rdr.GetOrdinal("id"));

                String dataLine = rdr.GetString(rdr.GetOrdinal("firstName"));
                String last = rdr.GetString(rdr.GetOrdinal("lastName"));


                TableRow row = new TableRow();
                TableCell data1 = new TableCell();
                TableCell data2 = new TableCell();
                TableCell data3 = new TableCell();
                data1.Text = "" + id;
                data2.Text = dataLine;
                data3.Text = "" + last;
                row.Cells.Add(data1);
                row.Cells.Add(data2);
                row.Cells.Add(data3);
                table2.Controls.Add(row);
            }

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
            int id = Int16.Parse(Request.QueryString["id"]);
            conn.Open();
            try
            {
                issueproc.ExecuteNonQuery();
                conn.Close();
                Response.Write("Promocode issued successfully");
            }
            catch (SqlException ex)
            {
                conn.Close();
                Response.Write("Error: " + ex.Message);
            }
            finally
            {
                username.Text = "";
                issuedpromo.Text = "";
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            int id = Int16.Parse(Request.QueryString["id"]);
            Response.Redirect("AdminHome.aspx?id=" + id);
        }
    }
}