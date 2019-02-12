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
    public partial class Forget : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtemail.Text == "" || txtpassword.Text == "" || txtconpass.Text == "")
                {
                    Response.Write("<script>alert('Some Field Empty..')</script>");
                }
                else
                {
                    if (txtpassword.Text != txtconpass.Text)
                    {
                        Response.Write("<script>alert('Password and Confirm Password Mismatch...')</script>");
                    }
                    else
                    {
                        if (Request.QueryString["a"] == "a")
                        {
                            string path = ConfigurationManager.ConnectionStrings["sc"].ConnectionString;
                            SqlConnection con = new SqlConnection(path);
                            con.Open();
                            SqlCommand cmd = new SqlCommand();
                            cmd.CommandText = "update Admin set Password='" + txtpassword.Text + "' where Email='" + txtemail.Text + "'";
                            cmd.Connection = con;
                            int i = cmd.ExecuteNonQuery();
                            if (i > 0)
                                Response.Write("<script>alert('Success..')</script>");
                            else
                                Response.Write("<script>alert('Email not Exist..')</script>");
                            
                        }
                        else if(Request.QueryString["e"]=="e")
                        {
                            string path = ConfigurationManager.ConnectionStrings["sc"].ConnectionString;
                            SqlConnection con = new SqlConnection(path);
                            con.Open();
                            SqlCommand cmd = new SqlCommand();
                            cmd.CommandText = "update Employee set Password='" + txtpassword.Text + "' where Email='" + txtemail.Text + "'";
                            cmd.Connection = con;
                            int i = cmd.ExecuteNonQuery();
                            if (i > 0)
                                Response.Write("<script>alert('Success..')</script>");
                            else
                                Response.Write("<script>alert('Email not Exist..')</script>");

                        }
                        else
                        {
                            string path = ConfigurationManager.ConnectionStrings["sc"].ConnectionString;
                             SqlConnection con = new SqlConnection(path);
                             con.Open();
                             SqlCommand cmd = new SqlCommand();
                             cmd.CommandText = "update Registration set Password='" + txtpassword.Text + "' where Email='" + txtemail.Text + "'";
                             cmd.Connection = con;
                             int i = cmd.ExecuteNonQuery();
                             if (i > 0)
                                 Response.Write("<script>alert('Success..')</script>");
                             else
                                 Response.Write("<script>alert('Email not Exist..')</script>");
                        }
                    }
                }
            }
            catch
            {
                Response.Write("<script>alert('Email Not Exist..')</script>");
            }

        }
    }
}