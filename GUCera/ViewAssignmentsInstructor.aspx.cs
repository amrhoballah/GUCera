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
    public partial class ManageAssignments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Accept_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand viewproc = new SqlCommand("InstructorViewAssignmentsStudents", conn);
            viewproc.CommandType = CommandType.StoredProcedure;

            viewproc.Parameters.Add(new SqlParameter("@instrId", Int16.Parse(Request.QueryString["id"])));

            viewproc.Parameters.Add(new SqlParameter("@cid", Int16.Parse(courseid.Text)));

            conn.Open();
            try
            {
                SqlDataReader rdr = viewproc.ExecuteReader(CommandBehavior.CloseConnection);

                while (rdr.Read())
                {
                    //sid ,cid,assignmentNumber, assignmenttype, grade

                    int id = rdr.GetInt32(rdr.GetOrdinal("sid"));
                    int cid = rdr.GetInt32(rdr.GetOrdinal("cid"));
                    int ass = rdr.GetInt32(rdr.GetOrdinal("assignmentNumber"));
                    string type = rdr.GetString(rdr.GetOrdinal("assignmenttype"));
                    double grade;
                    if (rdr.IsDBNull(rdr.GetOrdinal("grade")))
                    {
                        grade = default;
                    }
                    else
                    {
                        grade = (Double) rdr.GetDecimal(rdr.GetOrdinal("grade"));
                    }


                    TableRow row = new TableRow();
                    TableCell data1 = new TableCell();
                    TableCell data2 = new TableCell();
                    TableCell data3 = new TableCell();
                    TableCell data4 = new TableCell();
                    TableCell data5 = new TableCell();
                    data1.Text = "" + id;
                    data2.Text = "" + cid;
                    data3.Text = "" + ass;
                    data4.Text = "" + type;
                    data5.Text = "" + grade;
                    row.Cells.Add(data1);
                    row.Cells.Add(data2);
                    row.Cells.Add(data3);
                    row.Cells.Add(data4);
                    row.Cells.Add(data5);
                    table2.Controls.Add(row);
                }

            }
            catch(SqlException ex)
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
            Response.Redirect("InstructorHome.aspx?id=" + Request.QueryString["id"]);
        }
    }
}