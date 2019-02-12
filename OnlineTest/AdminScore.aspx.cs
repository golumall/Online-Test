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
    public partial class AdminScore : System.Web.UI.Page
    {
        int x = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            string path = ConfigurationManager.ConnectionStrings["sc"].ConnectionString;
            SqlConnection con = new SqlConnection(path);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Result1 where Email='"+Request.QueryString["email"]+"'";
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblattempt.Text += x.ToString() + "<br /><br />";
                lblcorrect.Text += dr["Correct"].ToString() + "<br /><br />";
                lblincorrect.Text += dr["InCorrect"].ToString() + "<br /><br />";
               
                lbldate.Text += dr["Date"].ToString()+ "<br /><br />";
                lblpapercode.Text += dr["PaperCode"].ToString() + "<br /><br />";
                lbltime.Text += dr["Time"].ToString() + "<br /><br />";
                x++;
            }
        }

        protected void btnback_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WelcomeAdmin.aspx?email="+Request.QueryString["email"]);
        }

        protected void btnlogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }
    }
}