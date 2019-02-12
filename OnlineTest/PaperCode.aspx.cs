using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace OnlineTest
{
    public partial class PaperCode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsub_Click(object sender, EventArgs e)
        {
            if (txtcode.Text == "")
            {
                Response.Write("<script>alert('Pls Enter Paper Code..')</script>");
            }
            else
            {
                string path = ConfigurationManager.ConnectionStrings["sc"].ConnectionString;
                SqlConnection con = new SqlConnection(path);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from PaperCode";
                cmd.Connection = con;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    path = ConfigurationManager.ConnectionStrings["sc"].ConnectionString;
                    SqlConnection conn = new SqlConnection(path);
                    conn.Open();
                    SqlCommand cmdd = new SqlCommand();
                    cmdd.CommandText = "update PaperCode set code='" + txtcode.Text + "'";
                    cmdd.Connection = conn;
                    int i = cmdd.ExecuteNonQuery();
                    if (i > 0)
                        Response.Write("<script>alert('Success')</script>");
                }
                else
                {
                    path = ConfigurationManager.ConnectionStrings["sc"].ConnectionString;
                    SqlConnection conn = new SqlConnection(path);
                    conn.Open();
                    SqlCommand cmdd = new SqlCommand();
                    cmdd.CommandText = "insert into PaperCode values('" + txtcode.Text + "')";
                    cmdd.Connection = conn;
                    int i = cmdd.ExecuteNonQuery();
                    if (i > 0)
                        Response.Write("<script>alert('Success')</script>");
                }
            }
        }
    }
}