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
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Forget.aspx?e="+"e");
        }

        protected void btnsub_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtemail.Text == "" || txtpassword.Text == "")
                {
                    Response.Write("<script>alert('Some Fields Empty..')</script>");
                }
                else
                {
                    string path = ConfigurationManager.ConnectionStrings["sc"].ConnectionString;
                    SqlConnection con = new SqlConnection(path);
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select * from Employee where Email='" + txtemail.Text + "' and Password='" + txtpassword.Text + "'";
                    cmd.Connection = con;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Response.Redirect("~/WelcomeEmployee.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('You are not Employee..')</script>");
                    }

                }
            }
            catch
            {
                Response.Write("<script>alert('Some Error Occured..')</script>");
            }
        }
    }
}