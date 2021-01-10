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
    public partial class studentprofile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Int16.Parse(Request.QueryString["id"]);

            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand viewproc = new SqlCommand("viewMyProfile", conn);

            viewproc.CommandType = CommandType.StoredProcedure;
            viewproc.Parameters.Add(new SqlParameter("@id", id));

            conn.Open();
            SqlDataReader rdr = viewproc.ExecuteReader(CommandBehavior.CloseConnection);

            rdr.Read();
            string fname = rdr.GetString(rdr.GetOrdinal("firstName"));
            String lname = rdr.GetString(rdr.GetOrdinal("lastName"));
            string pass = rdr.GetString(rdr.GetOrdinal("password"));
            Boolean gender = rdr.GetBoolean(rdr.GetOrdinal("gender"));
            double gpa = (double)rdr.GetDecimal(rdr.GetOrdinal("gpa"));
            String email= rdr.GetString(rdr.GetOrdinal("email"));
            String address = rdr.GetString(rdr.GetOrdinal("address"));

            TableRow row = new TableRow();
            TableCell data1 = new TableCell();
            TableCell data2 = new TableCell();
            TableCell data3 = new TableCell();
            TableCell data4 = new TableCell();
            TableCell data5 = new TableCell();
            TableCell data6 = new TableCell();
            TableCell data7 = new TableCell();

            data1.Text = "" + fname;
            data2.Text = lname;
            data3.Text = "" + pass;
            data4.Text = "" + email;
            data5.Text = address;
            data6.Text = "" + gpa;
            data7.Text = gender == false ? "Male" : "Female";
            row.Cells.Add(data1);
            row.Cells.Add(data2);
            row.Cells.Add(data3);
            row.Cells.Add(data7);
            row.Cells.Add(data4);
            row.Cells.Add(data5);
            row.Cells.Add(data6);
            Table1.Controls.Add(row);

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentHome.aspx?id=" + Request.QueryString["id"]);
        }
    }
}