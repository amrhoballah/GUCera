﻿using System;
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
    public partial class adminnonaccepted : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand viewproc = new SqlCommand("AdminViewNonAcceptedCourses", conn);
            viewproc.CommandType = CommandType.StoredProcedure;

            conn.Open();
            SqlDataReader rdr = viewproc.ExecuteReader(CommandBehavior.CloseConnection);

            while (rdr.Read())
            {
                int id = rdr.GetInt32(rdr.GetOrdinal("id"));
                String name = rdr.GetString(rdr.GetOrdinal("name"));
                int credit = rdr.GetInt32(rdr.GetOrdinal("creditHours"));
                double price = (double)rdr.GetDecimal(rdr.GetOrdinal("price"));
                String content;
                if (rdr.IsDBNull(rdr.GetOrdinal("content")))
                {
                    content = "NoContent";
                }
                else
                {
                    content = rdr.GetString(rdr.GetOrdinal("content"));
                }


                TableRow row = new TableRow();
                TableCell data1 = new TableCell();
                TableCell data2 = new TableCell();
                TableCell data3 = new TableCell();
                TableCell data4 = new TableCell();
                TableCell data5 = new TableCell();
                data1.Text = "" + id;
                data2.Text = name;
                data3.Text = "" + credit;
                data4.Text = "" + price;
                data5.Text = content;
                row.Cells.Add(data1);
                row.Cells.Add(data2);
                row.Cells.Add(data3);
                row.Cells.Add(data4);
                row.Cells.Add(data5);
                table2.Controls.Add(row);
            }
        }

        protected void Accept_Click(object sender, EventArgs e)
        {
            int id = Int16.Parse(Request.QueryString["id"]);
            int course = Int16.Parse(courseid.Text);

            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand acceptproc = new SqlCommand("AdminAcceptRejectCourse", conn);
            acceptproc.CommandType = CommandType.StoredProcedure;

            acceptproc.Parameters.Add(new SqlParameter("@adminid", id));
            acceptproc.Parameters.Add(new SqlParameter("@courseId", course));

            conn.Open();
            try
            {
                acceptproc.ExecuteNonQuery();
                Response.Redirect("adminnonaccepted.aspx?id=" + id);
                
            }
            catch (SqlException ex)
            {
                Response.Write("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
                courseid.Text = "";
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            int id = Int16.Parse(Request.QueryString["id"]);
            Response.Redirect("AdminHome.aspx?id=" + id);
        }
    }
}