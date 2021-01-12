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
    public partial class viewassign : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand viewproc = new SqlCommand("viewAssign", conn);
            viewproc.CommandType = CommandType.StoredProcedure;

            viewproc.Parameters.Add(new SqlParameter("@Sid", Int16.Parse(Request.QueryString["id"])));

            viewproc.Parameters.Add(new SqlParameter("@courseId", Int16.Parse(courseid.Text)));

            conn.Open();
            try
            {
                SqlDataReader rdr = viewproc.ExecuteReader(CommandBehavior.CloseConnection);

                while (rdr.Read())
                {
                    string content = rdr.GetString(rdr.GetOrdinal("content"));
                    int cid = rdr.GetInt32(rdr.GetOrdinal("cid"));
                    int ass = rdr.GetInt32(rdr.GetOrdinal("number"));
                    int full = rdr.GetInt32(rdr.GetOrdinal("fullGrade"));
                    string type = rdr.GetString(rdr.GetOrdinal("type"));
                    double weight = (Double)rdr.GetDecimal(rdr.GetOrdinal("weight"));
                    string deadline = rdr.GetSqlDateTime(rdr.GetOrdinal("deadline")).ToString();
                    

                    
                    TableRow row = new TableRow();
                    TableCell data1 = new TableCell();
                    TableCell data2 = new TableCell();
                    TableCell data3 = new TableCell();
                    TableCell data4 = new TableCell();
                    TableCell data5 = new TableCell();
                    TableCell data6 = new TableCell();
                    TableCell data7 = new TableCell();
                    data1.Text = "" + cid;
                    data2.Text = "" + ass;
                    data3.Text = "" + type;
                    data4.Text = "" + full;
                    data5.Text = "" + weight;
                    data6.Text = deadline;
                    data7.Text = content;
                    row.Cells.Add(data1);
                    row.Cells.Add(data2);
                    row.Cells.Add(data3);
                    row.Cells.Add(data4);
                    row.Cells.Add(data5);
                    row.Cells.Add(data6);
                    row.Cells.Add(data7);
                    Table1.Controls.Add(row);
                }

            }
            catch (SqlException ex)
            {
                Response.Write("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
                courseid.Text = default;
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentHome.aspx?id=" + Request.QueryString["id"]);
        }
    }
}