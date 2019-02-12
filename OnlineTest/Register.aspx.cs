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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            if(txtname.Text==""||txtemail.Text==""||txtmobile.Text==""||txtpass.Text==""||txtconpass.Text==""||(radiofemale.Checked==false&&radiomale.Checked==false))
            {
                Response.Write("<script>alert('Some Field Empty.Pls Fill and Try Again')</script>");
            }
            else
            {
                if(txtpass.Text!=txtconpass.Text)
                {
                    Response.Write("<script>alert('Password and Confirm Password is Mismatch..')</script>");
                }
                else
                {
                    try
                    {
                        string path = ConfigurationManager.ConnectionStrings["sc"].ConnectionString;
                        SqlConnection con = new SqlConnection(path);
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        if (radiomale.Checked == true)
                            cmd.CommandText = "insert into Registration values('" + txtname.Text + "','" + txtemail.Text + "','" + txtmobile.Text + "','Male','" + txtpass.Text + "')";
                        else
                            cmd.CommandText = "insert into Registration values('" + txtname.Text + "','" + txtemail.Text + "','" + txtmobile.Text + "','FeMale','" + txtpass.Text + "')";
                        cmd.Connection = con;
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            Response.Write("<script>alert('Success...')</script>");
                        }
                        else
                            Response.Write("<script>alert('Not Saved..')</script>");
                   }
                    catch
                    {
                        Response.Write("<script>alert('Email is Already Exist..')</script>");
                    }
                }
            }
        }

        protected void btnsubmit_Click1(object sender, EventArgs e)
        {

        }

        protected void btnsub_Click(object sender, EventArgs e)
        {

        }
    }
}