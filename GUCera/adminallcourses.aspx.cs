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
    public partial class adminallcourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand viewproc = new SqlCommand("AdminViewAllCourses", conn);
            viewproc.CommandType = CommandType.StoredProcedure;

            conn.Open();
            SqlDataReader rdr = viewproc.ExecuteReader(CommandBehavior.CloseConnection);
            
            while(rdr.Read())
            {
                String dataLine = rdr.GetString(rdr.GetOrdinal("name"));
                int credit = rdr.GetInt32(rdr.GetOrdinal("creditHours"));
                double price = (double) rdr.GetDecimal(rdr.GetOrdinal("price"));
                String content;
                if (rdr.IsDBNull(rdr.GetOrdinal("content")))
                {
                    content = "NoContent";
                }
                else
                {
                    content = rdr.GetString(rdr.GetOrdinal("content"));
                }
                bool accepted;
                if (rdr.IsDBNull(rdr.GetOrdinal("accepted")))
                {
                    accepted = false;
                }
                else
                {
                    accepted = rdr.GetBoolean(rdr.GetOrdinal("accepted"));
                }
                    

                dataLine += " " + credit + " " + price+" "+content+ " " + accepted;

                Label data = new Label();
                data.Text = dataLine;
                form1.Controls.Add(data);
                form1.Controls.Add(new LiteralControl("<br />"));
            }
        }
    }
}