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
    public partial class WelcomeEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           
                
        }

        protected void btnsub_Click(object sender, EventArgs e)
        {
            try
            {
                string path = ConfigurationManager.ConnectionStrings["sc"].ConnectionString;
                SqlConnection con = new SqlConnection(path);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "update  Questions set Question='" + txtquestion.Text + "',optiona='" + txtopa.Text + "',optionb='" + txtopb.Text + "',optionc='" + txtopc.Text + "',optiond='" + txtopd.Text + "',TrueAnswer='"+txttrueanswer.Text+"' where QuestionNo=" + dropqueno.SelectedItem + "";
                cmd.Connection = con;
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                    Response.Write("<script>alert('Question Updated..')</script>");
                else
                    Response.Write("<script>alert('Some Error..')</script>");
                con.Close();
            }

            catch
            {
                Response.Write("<script>alert('Some Error..')</script>");
            }
        }

        protected void dropqueno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropqueno.SelectedIndex == 0)
            {
                Response.Write("<script>alert('Pls Select a Valid Number..')</script>");
            }
            else
            {
                if (dropqueno.SelectedIndex > 0 && dropqueno.SelectedIndex <= 6)
                {
                    lblsub.Text = "Web Technology";
                }
                else if (dropqueno.SelectedIndex > 6 && dropqueno.SelectedIndex <= 12)
                {
                    lblsub.Text = "C Programming";
                }
                else if (dropqueno.SelectedIndex > 12 && dropqueno.SelectedIndex <= 18)
                {
                    lblsub.Text = "Java Programming";
                }
                string path = ConfigurationManager.ConnectionStrings["sc"].ConnectionString;
                SqlConnection con = new SqlConnection(path);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from Questions where QuestionNo=" + dropqueno.SelectedItem + "";
                cmd.Connection = con;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txtquestion.Text = dr["Question"].ToString();
                    txtopa.Text = dr["optiona"].ToString();
                    txtopb.Text = dr["optionb"].ToString();
                    txtopc.Text = dr["optionc"].ToString();
                    txtopd.Text = dr["optiond"].ToString();
                    txttrueanswer.Text = dr["TrueAnswer"].ToString();

                }
                con.Close();
            }
        }
    }
    }

