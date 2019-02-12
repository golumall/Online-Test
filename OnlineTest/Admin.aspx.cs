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
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsub_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtemail.Text==""||txtpassword.Text=="")
                {
                    Response.Write("<script>alert('Some Fields Empty..')</script>");
                }
                else
                {
                    string path = ConfigurationManager.ConnectionStrings["sc"].ConnectionString;
                    SqlConnection con = new SqlConnection(path);
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select * from Admin where Email='"+txtemail.Text+"' and Password='"+txtpassword.Text+"'";
                    cmd.Connection = con;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if(dr.Read())
                    {
                        Response.Redirect("~/WelcomeAdmin.aspx?email="+txtemail.Text);
                    }
                    else
                    {
                        Response.Write("<script>alert('You are not Admin..')</script>");
                    }

                }
            }
            catch
            {
                Response.Write("<script>alert('Some Error Occured..')</script>");
            }
                
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Forget.aspx?a="+"a");
                
        }
    }
}