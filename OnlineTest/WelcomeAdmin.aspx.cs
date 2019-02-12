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
    public partial class WelcomeAdmin : System.Web.UI.Page
    {
        int x = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string path = ConfigurationManager.ConnectionStrings["sc"].ConnectionString;
            SqlConnection con = new SqlConnection(path);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Result";
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                x++;
            }
            lblstudent.Text = x.ToString();
            con.Close();
        }

        protected void btnsub_Click(object sender, EventArgs e)
        {
            if (txtemail.Text == "")
            {
                Response.Write("<script>alert('Please Enter Email...')</script>");
            }
            else
            {
                string path = ConfigurationManager.ConnectionStrings["sc"].ConnectionString;
                SqlConnection con = new SqlConnection(path);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from Result1 where Email='"+txtemail.Text+"'";
                cmd.Connection = con;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    con.Close();
                    Response.Redirect("~/AdminScore.aspx?email=" + txtemail.Text);
                }
                else
                {
                    Response.Write("<script>alert('This Student not attempt Exam.')</script>");
                }
            }
        }

        protected void btnid_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Id.aspx?email="+Request.QueryString["email"]);
        }

        protected void btnemp_Click(object sender, EventArgs e)
        {
            if (txtemployee.Text == "")
            {
                Response.Write("<script>alert('Enter Employee Email..')</script>");
            }
            else
            {
                string path = ConfigurationManager.ConnectionStrings["sc"].ConnectionString;
                SqlConnection con = new SqlConnection(path);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "delete Employee where Email='" + txtemployee.Text + "'";
                cmd.Connection = con;
                int i = cmd.ExecuteNonQuery();
                if(i>0)
                    Response.Write("<script>alert('Success..')</script>");
                else
                    Response.Write("<script>alert(' Employee Email does not Exist..')</script>");

                con.Close();
            }

        }
    }
}