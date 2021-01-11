using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{

    public partial class viewpromos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand viewproc = new SqlCommand("viewPromocode", conn);
            viewproc.CommandType = CommandType.StoredProcedure;
            viewproc.Parameters.Add(new SqlParameter("@sid", Int16.Parse(Request.QueryString["id"])));

            conn.Open();
            SqlDataReader rdr = viewproc.ExecuteReader(CommandBehavior.CloseConnection);

            while (rdr.Read())
            {
                
                String name = rdr.GetString(rdr.GetOrdinal("code"));
                String issue = rdr.GetSqlDateTime(rdr.GetOrdinal("isuueDate")).ToString();
                String expiry = rdr.GetSqlDateTime(rdr.GetOrdinal("expiryDate")).ToString();
                double discount = (Double) rdr.GetDecimal(rdr.GetOrdinal("discount"));


                TableRow row = new TableRow();
                TableCell data1 = new TableCell();
                TableCell data2 = new TableCell();
                TableCell data3 = new TableCell();
                TableCell data4 = new TableCell();
                data1.Text = name;
                data2.Text = issue;
                data3.Text = expiry;
                data4.Text = "" +discount;
                row.Cells.Add(data1);
                row.Cells.Add(data2);
                row.Cells.Add(data3);
                row.Cells.Add(data4);
                Table1.Controls.Add(row);
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentHome.aspx?id=" + Request.QueryString["id"]);
        }
    }
}
