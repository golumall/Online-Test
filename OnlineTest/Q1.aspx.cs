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
    public partial class Q1 : System.Web.UI.Page
    {
        int y = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (IsPostBack)
                {
                    btn1.BackColor = System.Drawing.Color.Green;
                }
                lblemail.Text = Request.QueryString["email"].ToString();
                string path = ConfigurationManager.ConnectionStrings["sc"].ConnectionString;
                SqlConnection con = new SqlConnection(path);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from Questions where QuestionNo=1";
                cmd.Connection = con;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lbl1.Text = dr["Question"].ToString();
                    radioa.Text = dr["optiona"].ToString();
                    radiob.Text = dr["optionb"].ToString();
                    radioc.Text = dr["optionc"].ToString();
                    radiod.Text = dr["optiond"].ToString();

                }
                con.Close();
            }
            catch
            {
                Response.Write("<script>alert('Some Error Occured...')</script>");
            }
        }

        protected void btnsub_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioa.Checked == false && radiob.Checked == false && radioc.Checked == false && radiod.Checked == false)
                    Response.Write("<script>alert('Please Select an option')</script>");
                else
                {
                    string path = ConfigurationManager.ConnectionStrings["sc"].ConnectionString;
                    SqlConnection con = new SqlConnection(path);
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select * from Answer where QuestionNo=1 and Email='" + lblemail.Text + "'";
                    cmd.Connection = con;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                        y = 1;
                    if (radioa.Checked)
                        lblans.Text = radioa.Text;
                    if (radiob.Checked)
                        lblans.Text = radiob.Text;
                    if (radioc.Checked)
                        lblans.Text = radioc.Text;
                    if (radiod.Checked)
                        lblans.Text = radiod.Text;
                    if (y == 1)
                    {
                        path = ConfigurationManager.ConnectionStrings["sc"].ConnectionString;
                        SqlConnection conn = new SqlConnection(path);
                        conn.Open();
                        SqlCommand cmdd = new SqlCommand();
                        cmdd.CommandText = "update Answer set Answer='" + lblans.Text + "' where QuestionNo=1 and Email='" + lblemail.Text + "'";
                        cmdd.Connection = conn;
                        int i = cmdd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        conn.Close();
                        Response.Redirect("~/Q2.aspx?email=" + lblemail.Text);
                    }
                    }
                    else
                    {
                        string x = ConfigurationManager.ConnectionStrings["sc"].ConnectionString;
                        SqlConnection conn = new SqlConnection(x);
                        conn.Open();
                        SqlCommand cmdd = new SqlCommand();
                        cmdd.CommandText = "insert into Answer values( '" + lblemail.Text + "',1,'" + lblans.Text + "')";
                        cmdd.Connection = conn;
                        int i = cmdd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        conn.Close();
                        Response.Redirect("~/Q2.aspx?email=" + lblemail.Text);
                    }
                    }
                }
            }
            catch
            {
                Response.Redirect("~/Q2.aspx?email=" + lblemail.Text);
            }


            // btn1.BackColor = System.Drawing.Color.Green;
        }
        protected void Timer1_Tick(object sender, EventArgs e)
        {
            //lblmin.Text = DateTime.Now.ToString();
            if (Convert.ToInt32(Application["x"]) == 60)
            {
                (Application["x"]) = 0;
                (Application["z"]) = (Convert.ToInt32(Application["z"])) + 1;

            }


            lblmin.Text = Application["z"] + ":" + Application["x"];
            Application["x"] = Convert.ToInt32(Application["x"]) + 1;
            if (Convert.ToInt32(Application["z"]) == 31)
                Response.Redirect("~/Login.aspx");


        }

        protected void btn1_Click(object sender, EventArgs e)
        {
           
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Q2.aspx?email="+lblemail.Text);
        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Q3.aspx?email="+lblemail.Text);
        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Q4.aspx?email="+lblemail.Text);
        }

        protected void btn5_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Q5.aspx?email="+lblemail.Text);
        }

        protected void btn6_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Q6.aspx?email="+lblemail.Text);
        }

        protected void btn7_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Q7.aspx?email="+lblemail.Text);
        }

        protected void btn8_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Q8.aspx?email="+lblemail.Text);
        }

        protected void btn9_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Q9.aspx?email="+lblemail.Text);
        }

        protected void btn10_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Q10.aspx?email="+lblemail.Text);
        }

        protected void btn11_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Q11.aspx?email="+lblemail.Text);
        }

        protected void btn12_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Q12.aspx?email="+lblemail.Text);
        }

        protected void btn13_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Q13.aspx?email="+lblemail.Text);
        }

        protected void btn14_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Q14.aspx?email="+lblemail.Text);
        }

        protected void btn15_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Q15.aspx?email="+lblemail.Text);
        }

        protected void btn16_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Q16.aspx?email="+lblemail.Text);
        }

        protected void btn17_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Q17.aspx?email="+lblemail.Text);
        }

        protected void btn18_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Q18.aspx?email="+lblemail.Text);
        }

        protected void btnskip_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioa.Checked == false && radiob.Checked == false && radioc.Checked == false && radiod.Checked == false)
                {
                    Response.Write("<script>alert('Q No 1 should do required.')</script>");
                }
                else
                {
                    Response.Redirect("~/Q2.aspx?email=" + lblemail.Text);

                    btn1.BackColor = System.Drawing.Color.Gray;
                }
            }
            catch
            {
                Response.Redirect("~/Q2.aspx?email=" + lblemail.Text);
            }
        }

        protected void btnreview_Click(object sender, EventArgs e)
        {
           
            }
        }
    }