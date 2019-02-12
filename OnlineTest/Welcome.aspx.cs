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
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                lblemail.Text = Request.QueryString["email"].ToString();
                string path = ConfigurationManager.ConnectionStrings["sc"].ConnectionString;
                SqlConnection con = new SqlConnection(path);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from Registration where Email='" + lblemail.Text + "'";
                cmd.Connection = con;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                    lblname.Text = dr["Name"].ToString();

                con.Close();
            }
            catch
            {
                Response.Write("<script>alert('Some Error...')</script>");
            }            
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int x = 0;
                string path = ConfigurationManager.ConnectionStrings["sc"].ConnectionString;
                SqlConnection connn = new SqlConnection(path);
                connn.Open();
                SqlCommand cmddd = new SqlCommand();
                cmddd.CommandText = "select * from Result1 where Email='" + lblemail.Text + "'";
                cmddd.Connection = connn;
                SqlDataReader drr = cmddd.ExecuteReader();
                while (drr.Read())
                {
                    x++;
                }
                connn.Close();
                if (x < 5)
                {
                    lblemail.Text = Request.QueryString["email"].ToString();
                    path = ConfigurationManager.ConnectionStrings["sc"].ConnectionString;
                    SqlConnection con = new SqlConnection(path);
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select * from Answer where Email='" + lblemail.Text + "'";
                    cmd.Connection = con;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        con.Close();
                        path = ConfigurationManager.ConnectionStrings["sc"].ConnectionString;
                        SqlConnection conn = new SqlConnection(path);
                        conn.Open();
                        SqlCommand cmdd = new SqlCommand();
                        cmdd.CommandText = "delete Answer where Email='" + lblemail.Text + "'";
                        cmdd.Connection = conn;
                        int i = cmdd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            conn.Close();
                            Response.Redirect("~/Q1.aspx?email=" + lblemail.Text);
                        }
                    }
                    else
                    {

                        Response.Redirect("~/Q1.aspx?email=" + lblemail.Text);
                    }
                }
                else
                {
                    Response.Write("<script>alert('You already attempt 5 times...')</script>");
                }
            }
            catch
            {
                Response.Redirect("~/Q1.aspx?email=" + lblemail.Text);
            }
            }
    }
}