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
    public partial class Id : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnback_Click(object sender, EventArgs e)
        {

            Response.Redirect("~/WelcomeAdmin.aspx?email="+Request.QueryString["email"]);
        }

        protected void btnlogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }

        protected void btnsub_Click(object sender, EventArgs e)
        {
            if (txtemail.Text == "" || txtname.Text == "" || txtpass.Text == "")
            {
                Response.Write("<script>alert('Some Field Empty..')</script>");
            }
            else
            {
                string path = ConfigurationManager.ConnectionStrings["sc"].ConnectionString;
                SqlConnection con = new SqlConnection(path);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "insert into Employee values('" + txtname.Text + "','" + txtemail.Text + "','" + txtpass.Text + "')";
                cmd.Connection = con;
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    Response.Write("<script>alert('Saved..')</script>");
                else
                    Response.Write("<script>alert('Some Error..')</script>");
            }
        }
       
    }
}