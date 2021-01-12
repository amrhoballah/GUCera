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
    public partial class viewgrades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            int id = Int16.Parse(Request.QueryString["id"]);
            int cid = Int16.Parse(course.Text);
            int num = Int16.Parse(number.Text);
            string atype = type.SelectedValue.ToString();



            SqlCommand addgrade = new SqlCommand("viewAssignGrades", conn);
            addgrade.CommandType = CommandType.StoredProcedure;

            addgrade.Parameters.Add(new SqlParameter("@sid", id));
            addgrade.Parameters.Add(new SqlParameter("@cid", cid));
            addgrade.Parameters.Add(new SqlParameter("@assignnumber", num));
            addgrade.Parameters.Add(new SqlParameter("@assignType", atype));
            SqlParameter grade = addgrade.Parameters.Add("@assignGrade", SqlDbType.Int);
            grade.Direction = ParameterDirection.Output;

            conn.Open();
            try
            {
                addgrade.ExecuteNonQuery();
                TableRow row = new TableRow();
                TableCell data = new TableCell();
                data.Text = grade.Value.ToString();
                row.Cells.Add(data);
                Table1.Controls.Add(row);
            }
            catch (SqlException ex)
            {
                Response.Write("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
                course.Text = default;
                number.Text = default;
                type.SelectedValue = default;
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentHome.aspx?id=" + Request.QueryString["id"]);

        }
    }
}