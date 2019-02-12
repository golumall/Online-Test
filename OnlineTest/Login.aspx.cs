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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click1(object sender, EventArgs e)
        {
            //Response.Redirect("~/Home.aspx");
        }

        protected void btnsub_Click(object sender, EventArgs e)
        {
            if (txtemail.Text == "" || txtpassword.Text == "")
            {
                Response.Write("<script>alert('Some Field Empty..')</script>");
            }
            else
            {
                try
                {
                    string path = ConfigurationManager.ConnectionStrings["sc"].ConnectionString;
                    SqlConnection con = new SqlConnection(path);
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select * from Registration where Email='" + txtemail.Text + "' and Password='" + txtpassword.Text + "'";
                    cmd.Connection = con;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {

                        con.Close();
                        Response.Redirect("~/Welcome.aspx?email=" + txtemail.Text);


                    }
                    else
                        Response.Write("<script>alert('Email or Password Incorrect..')</script>");
                    con.Close();
                }
                catch
                {
                    Response.Write("<script>alert('Some Error Occure..')</script>");
                }

            }
        }
    }
}