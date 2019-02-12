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
    
    public partial class Result : System.Web.UI.Page
    {
        int var1 = 0,var2=0,i;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                String path = ConfigurationManager.ConnectionStrings["sc"].ConnectionString;
                lblemail.Text = Request.QueryString["email"].ToString();
                for (i = 1; i <= 18; i++)
                {

                    SqlConnection conn = new SqlConnection(path);
                    conn.Open();
                    SqlCommand cmdd = new SqlCommand();
                    cmdd.CommandText = "select * from Answer where Email='" + lblemail.Text + "' and QuestionNo=" + i + "";
                    cmdd.Connection = conn;
                    SqlDataReader dr = cmdd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (i == 1)
                            lbly1.Text = dr["Answer"].ToString();
                        if (i == 2)
                            lbly2.Text = dr["Answer"].ToString();
                        if (i == 3)
                            lbly3.Text = dr["Answer"].ToString();
                        if (i == 4)
                            lbly4.Text = dr["Answer"].ToString();
                        if (i == 5)
                            lbly5.Text = dr["Answer"].ToString();
                        if (i == 6)
                            lbly6.Text = dr["Answer"].ToString();
                        if (i == 7)
                            lbly7.Text = dr["Answer"].ToString();
                        if (i == 8)
                            lbly8.Text = dr["Answer"].ToString();
                        if (i == 9)
                            lbly9.Text = dr["Answer"].ToString();
                        if (i == 10)
                            lbly10.Text = dr["Answer"].ToString();
                        if (i == 11)
                            lbly11.Text = dr["Answer"].ToString();
                        if (i == 12)
                            lbly12.Text = dr["Answer"].ToString();
                        if (i == 13)
                            lbly13.Text = dr["Answer"].ToString();
                        if (i == 14)
                            lbly14.Text = dr["Answer"].ToString();
                        if (i == 15)
                            lbly15.Text = dr["Answer"].ToString();
                        if (i == 16)
                            lbly16.Text = dr["Answer"].ToString();
                        if (i == 17)
                            lbly17.Text = dr["Answer"].ToString();
                        if (i == 18)
                            lbly18.Text = dr["Answer"].ToString();

                    }
                    conn.Close();
                }
                for (i = 1; i <= 18; i++)
                {

                    SqlConnection conn = new SqlConnection(path);
                    conn.Open();
                    SqlCommand cmdd = new SqlCommand();
                    cmdd.CommandText = "select * from Questions where QuestionNo=" + i + "";
                    cmdd.Connection = conn;
                    SqlDataReader dr = cmdd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (i == 1)
                            lblc1.Text = dr["TrueAnswer"].ToString();
                        if (i == 2)
                            lblc2.Text = dr["TrueAnswer"].ToString();
                        if (i == 3)
                            lblc3.Text = dr["TrueAnswer"].ToString();
                        if (i == 4)
                            lblc4.Text = dr["TrueAnswer"].ToString();
                        if (i == 5)
                            lblc5.Text = dr["TrueAnswer"].ToString();
                        if (i == 6)
                            lblc6.Text = dr["TrueAnswer"].ToString();
                        if (i == 7)
                            lblc7.Text = dr["TrueAnswer"].ToString();
                        if (i == 8)
                            lblc8.Text = dr["TrueAnswer"].ToString();
                        if (i == 9)
                            lblc9.Text = dr["TrueAnswer"].ToString();
                        if (i == 10)
                            lblc10.Text = dr["TrueAnswer"].ToString();
                        if (i == 11)
                            lblc11.Text = dr["TrueAnswer"].ToString();
                        if (i == 12)
                            lblc12.Text = dr["TrueAnswer"].ToString();
                        if (i == 13)
                            lblc13.Text = dr["TrueAnswer"].ToString();
                        if (i == 14)
                            lblc14.Text = dr["TrueAnswer"].ToString();
                        if (i == 15)
                            lblc15.Text = dr["TrueAnswer"].ToString();
                        if (i == 16)
                            lblc16.Text = dr["TrueAnswer"].ToString();
                        if (i == 17)
                            lblc17.Text = dr["TrueAnswer"].ToString();
                        if (i == 18)
                            lblc18.Text = dr["TrueAnswer"].ToString();

                    }
                    conn.Close();
                }
                /*SqlConnection a = new SqlConnection(path);
                a.Open();
                SqlCommand aa = new SqlCommand();
                aa.CommandText = "select * from Answer where Email='" + lblemail.Text + "' and QuestionNo=2";
                aa.Connection = a;
                SqlDataReader aaa = aa.ExecuteReader();
                while (aaa.Read())
                {
                    lbly2.Text = aaa["Answer"].ToString();
                }
                SqlConnection b = new SqlConnection(path);
                b.Open();
                SqlCommand bb = new SqlCommand();
                bb.CommandText = "select * from Answer where Email='" + lblemail.Text + "' and QuestionNo=3";
                bb.Connection = b;
                SqlDataReader bbb = bb.ExecuteReader();
                while (bbb.Read())
                {
                    lbly3.Text = bbb["Answer"].ToString();
                }
                SqlConnection c = new SqlConnection(path);
                c.Open();
                SqlCommand cc = new SqlCommand();
                cc.CommandText = "select * from Answer where Email='" + lblemail.Text + "' and QuestionNo=4";
                cc.Connection = c;
                SqlDataReader ccc = cc.ExecuteReader();
                while (ccc.Read())
                {
                    lbly4.Text = ccc["Answer"].ToString();
                }
                SqlConnection d = new SqlConnection(path);
                d.Open();
                SqlCommand dd = new SqlCommand();
                dd.CommandText = "select * from Answer where Email='" + lblemail.Text + "' and QuestionNo=5";
                dd.Connection = d;
                SqlDataReader ddd = dd.ExecuteReader();
                while (ddd.Read())
                {
                    lbly5.Text = ddd["Answer"].ToString();
                }
                SqlConnection eg = new SqlConnection(path);
                eg.Open();
                SqlCommand ee = new SqlCommand();
                ee.CommandText = "select * from Answer where Email='" + lblemail.Text + "' and QuestionNo=6";
                ee.Connection = eg;
                SqlDataReader eee = ee.ExecuteReader();
                while (eee.Read())
                {
                    lbly6.Text = eee["Answer"].ToString();
                }
                SqlConnection f = new SqlConnection(path);
                f.Open();
                SqlCommand ff = new SqlCommand();
                ff.CommandText = "select * from Answer where Email='" + lblemail.Text + "' and QuestionNo=7";
                ff.Connection = f;
                SqlDataReader fff = ff.ExecuteReader();
                while (fff.Read())
                {
                    lbly7.Text = fff["Answer"].ToString();
                }
                SqlConnection g = new SqlConnection(path);
                g.Open();
                SqlCommand gg = new SqlCommand();
                gg.CommandText = "select * from Answer where Email='" + lblemail.Text + "' and QuestionNo=8";
                gg.Connection = g;
                SqlDataReader ggg = gg.ExecuteReader();
                while (ggg.Read())
                {
                    lbly8.Text = ggg["Answer"].ToString();
                }
                SqlConnection h = new SqlConnection(path);
                h.Open();
                SqlCommand hh = new SqlCommand();
                hh.CommandText = "select * from Answer where Email='" + lblemail.Text + "' and QuestionNo=9";
                hh.Connection = h;
                SqlDataReader hhh = hh.ExecuteReader();
                while (hhh.Read())
                {
                    lbly9.Text = hhh["Answer"].ToString();
                }
                SqlConnection i = new SqlConnection(path);
                i.Open();
                SqlCommand ii = new SqlCommand();
                ii.CommandText = "select * from Answer where Email='" + lblemail.Text + "' and QuestionNo=10";
                ii.Connection = i;
                SqlDataReader iii = ii.ExecuteReader();
                while (iii.Read())
                {
                    lbly10.Text = iii["Answer"].ToString();
                }
                SqlConnection j = new SqlConnection(path);
                j.Open();
                SqlCommand jj = new SqlCommand();
                jj.CommandText = "select * from Answer where Email='" + lblemail.Text + "' and QuestionNo=11";
                jj.Connection = j;
                SqlDataReader jjj = jj.ExecuteReader();
                while (jjj.Read())
                {
                    lbly11.Text = jjj["Answer"].ToString();
                }
                SqlConnection k = new SqlConnection(path);
                k.Open();
                SqlCommand kk = new SqlCommand();
                kk.CommandText = "select * from Answer where Email='" + lblemail.Text + "' and QuestionNo=12";
                kk.Connection = k;
                SqlDataReader kkk = kk.ExecuteReader();
                while (kkk.Read())
                {
                    lbly12.Text = kkk["Answer"].ToString();
                }
                SqlConnection l = new SqlConnection(path);
                l.Open();
                SqlCommand ll = new SqlCommand();
                ll.CommandText = "select * from Answer where Email='" + lblemail.Text + "' and QuestionNo=13";
                ll.Connection = l;
                SqlDataReader lll = ll.ExecuteReader();
                while (lll.Read())
                {
                    lbly13.Text = lll["Answer"].ToString();
                }
                SqlConnection m = new SqlConnection(path);
                m.Open();
                SqlCommand mm = new SqlCommand();
                mm.CommandText = "select * from Answer where Email='" + lblemail.Text + "' and QuestionNo=14";
                mm.Connection = m;
                SqlDataReader mmm = mm.ExecuteReader();
                while (mmm.Read())
                {
                    lbly14.Text = mmm["Answer"].ToString();
                }
                SqlConnection n = new SqlConnection(path);
                n.Open();
                SqlCommand nn = new SqlCommand();
                nn.CommandText = "select * from Answer where Email='" + lblemail.Text + "' and QuestionNo=15";
                nn.Connection = n;
                SqlDataReader nnn = nn.ExecuteReader();
                while (nnn.Read())
                {
                    lbly15.Text = nnn["Answer"].ToString();
                }
                SqlConnection o = new SqlConnection(path);
                o.Open();
                SqlCommand oo = new SqlCommand();
                oo.CommandText = "select * from Answer where Email='" + lblemail.Text + "' and QuestionNo=16";
                oo.Connection = o;
                SqlDataReader ooo = oo.ExecuteReader();
                while (ooo.Read())
                {
                    lbly16.Text = ooo["Answer"].ToString();
                }
                SqlConnection p = new SqlConnection(path);
                p.Open();
                SqlCommand pp = new SqlCommand();
                pp.CommandText = "select * from Answer where Email='" + lblemail.Text + "' and QuestionNo=17";
                pp.Connection = p;
                SqlDataReader ppp = pp.ExecuteReader();
                while (ppp.Read())
                {
                    lbly17.Text = ppp["Answer"].ToString();
                }
                SqlConnection q = new SqlConnection(path);
                q.Open();
                SqlCommand qq = new SqlCommand();
                qq.CommandText = "select * from Answer where Email='" + lblemail.Text + "' and QuestionNo=18";
                qq.Connection = q;
                SqlDataReader qqq = qq.ExecuteReader();
                while (qqq.Read())
                {
                    lbly18.Text = qqq["Answer"].ToString();
                }
                SqlConnection r = new SqlConnection(path);
                r.Open();
                SqlCommand rr = new SqlCommand();
                rr.CommandText = "select * from Questions where QuestionNo=1";
                rr.Connection = r;
                SqlDataReader rrr = rr.ExecuteReader();
                while (rrr.Read())
                {
                    lblc1.Text = rrr["TrueAnswer"].ToString();
                }
                SqlConnection s = new SqlConnection(path);
                s.Open();
                SqlCommand ss = new SqlCommand();
                ss.CommandText = "select * from Questions where QuestionNo=2";
                ss.Connection = s;
                SqlDataReader sss = ss.ExecuteReader();
                while (sss.Read())
                {
                    lblc2.Text = sss["TrueAnswer"].ToString();
                }
                SqlConnection t = new SqlConnection(path);
                t.Open();
                SqlCommand tt = new SqlCommand();
                tt.CommandText = "select * from Questions where QuestionNo=3";
                tt.Connection = t;
                SqlDataReader ttt = tt.ExecuteReader();
                while (ttt.Read())
                {
                    lblc3.Text = ttt["TrueAnswer"].ToString();
                }
                SqlConnection u = new SqlConnection(path);
                u.Open();
                SqlCommand uu = new SqlCommand();
                uu.CommandText = "select * from Questions where QuestionNo=4";
                uu.Connection = u;
                SqlDataReader uuu = uu.ExecuteReader();
                while (uuu.Read())
                {
                    lblc4.Text = uuu["TrueAnswer"].ToString();
                }
                SqlConnection v = new SqlConnection(path);
                v.Open();
                SqlCommand vv = new SqlCommand();
                vv.CommandText = "select * from Questions where QuestionNo=5";
                vv.Connection = v;
                SqlDataReader vvv = vv.ExecuteReader();
                while (vvv.Read())
                {
                    lblc5.Text = vvv["TrueAnswer"].ToString();
                }
                SqlConnection w = new SqlConnection(path);
                w.Open();
                SqlCommand ww = new SqlCommand();
                ww.CommandText = "select * from Questions where QuestionNo=6";
                ww.Connection = w;
                SqlDataReader www = ww.ExecuteReader();
                while (www.Read())
                {
                    lblc6.Text = www["TrueAnswer"].ToString();
                }
                SqlConnection x = new SqlConnection(path);
                x.Open();
                SqlCommand xx = new SqlCommand();
                xx.CommandText = "select * from Questions where QuestionNo=7";
                xx.Connection = x;
                SqlDataReader xxx = xx.ExecuteReader();
                while (xxx.Read())
                {
                    lblc7.Text = xxx["TrueAnswer"].ToString();
                }
                SqlConnection y = new SqlConnection(path);
                y.Open();
                SqlCommand yy = new SqlCommand();
                yy.CommandText = "select * from Questions where QuestionNo=8";
                yy.Connection = y;
                SqlDataReader yyy = yy.ExecuteReader();
                while (yyy.Read())
                {
                    lblc8.Text = yyy["TrueAnswer"].ToString();
                }
                SqlConnection z = new SqlConnection(path);
                z.Open();
                SqlCommand zz = new SqlCommand();
                zz.CommandText = "select * from Questions where QuestionNo=9";
                zz.Connection = z;
                SqlDataReader zzz = zz.ExecuteReader();
                while (zzz.Read())
                {
                    lblc9.Text = zzz["TrueAnswer"].ToString();
                }
                SqlConnection zzzz = new SqlConnection(path);
                zzzz.Open();
                SqlCommand zzzzz = new SqlCommand();
                zzzzz.CommandText = "select * from Questions where QuestionNo=10";
                zzzzz.Connection = zzzz;
                SqlDataReader zzzzzz = zzzzz.ExecuteReader();
                while (zzzzzz.Read())
                {
                    lblc10.Text = zzzzzz["TrueAnswer"].ToString();
                }
                SqlConnection yyyy = new SqlConnection(path);
                yyyy.Open();
                SqlCommand yyyyy = new SqlCommand();
                yyyyy.CommandText = "select * from Questions where QuestionNo=11";
                yyyyy.Connection = yyyy;
                SqlDataReader yyyyyy = yyyyy.ExecuteReader();
                while (yyyyyy.Read())
                {
                    lblc11.Text = yyyyyy["TrueAnswer"].ToString();
                }
                SqlConnection xxxx = new SqlConnection(path);
                xxxx.Open();
                SqlCommand xxxxx = new SqlCommand();
                xxxxx.CommandText = "select * from Questions where QuestionNo=12";
                xxxxx.Connection = xxxx;
                SqlDataReader xxxxxx = xxxxx.ExecuteReader();
                while (xxxxxx.Read())
                {
                    lblc12.Text = xxxxxx["TrueAnswer"].ToString();
                }
                SqlConnection wwww = new SqlConnection(path);
                wwww.Open();
                SqlCommand wwwww = new SqlCommand();
                wwwww.CommandText = "select * from Questions where QuestionNo=13";
                wwwww.Connection = wwww;
                SqlDataReader wwwwww = wwwww.ExecuteReader();
                while (wwwwww.Read())
                {
                    lblc13.Text = wwwwww["TrueAnswer"].ToString();
                }
                SqlConnection vvvv = new SqlConnection(path);
                vvvv.Open();
                SqlCommand vvvvv = new SqlCommand();
                vvvvv.CommandText = "select * from Questions where QuestionNo=14";
                vvvvv.Connection = vvvv;
                SqlDataReader vvvvvv = vvvvv.ExecuteReader();
                while (vvvvvv.Read())
                {
                    lblc14.Text = vvvvvv["TrueAnswer"].ToString();
                }
                SqlConnection uuuu = new SqlConnection(path);
                uuuu.Open();
                SqlCommand uuuuu = new SqlCommand();
                uuuuu.CommandText = "select * from Questions where QuestionNo=15";
                uuuuu.Connection = uuuu;
                SqlDataReader uuuuuu = uuuuu.ExecuteReader();
                while (uuuuuu.Read())
                {
                    lblc15.Text = uuuuuu["TrueAnswer"].ToString();
                }
                SqlConnection tttt = new SqlConnection(path);
                tttt.Open();
                SqlCommand ttttt = new SqlCommand();
                ttttt.CommandText = "select * from Questions where QuestionNo=16";
                ttttt.Connection = tttt;
                SqlDataReader tttttt = ttttt.ExecuteReader();
                while (tttttt.Read())
                {
                    lblc16.Text = tttttt["TrueAnswer"].ToString();
                }
                SqlConnection ssss = new SqlConnection(path);
                ssss.Open();
                SqlCommand sssss = new SqlCommand();
                sssss.CommandText = "select * from Questions where QuestionNo=17";
                sssss.Connection = ssss;
                SqlDataReader ssssss = sssss.ExecuteReader();
                while (ssssss.Read())
                {
                    lblc17.Text = ssssss["TrueAnswer"].ToString();
                }
                SqlConnection rrrr = new SqlConnection(path);
                rrrr.Open();
                SqlCommand rrrrr = new SqlCommand();
                rrrrr.CommandText = "select * from Questions where QuestionNo=18";
                rrrrr.Connection = rrrr;
                SqlDataReader rrrrrr = rrrrr.ExecuteReader();
                while (rrrrrr.Read())
                {
                    lblc18.Text = rrrrrr["TrueAnswer"].ToString();
                }*/
                if (lbly1.Text == lblc1.Text)
                    var1++;
                else
                    var2++;
                if (lbly2.Text == lblc2.Text)
                    var1++;
                else
                    var2++;
                if (lbly3.Text == lblc3.Text)
                    var1++;
                else
                    var2++;
                if (lbly4.Text == lblc4.Text)
                    var1++;
                else
                    var2++;
                if (lbly5.Text == lblc5.Text)
                    var1++;
                else
                    var2++;
                if (lbly6.Text == lblc6.Text)
                    var1++;
                else
                    var2++;
                if (lbly7.Text == lblc7.Text)
                    var1++;
                else
                    var2++;
                if (lbly8.Text == lblc8.Text)
                    var1++;
                else
                    var2++;
                if (lbly9.Text == lblc9.Text)
                    var1++;
                else
                    var2++;
                if (lbly10.Text == lblc10.Text)
                    var1++;
                else
                    var2++;
                if (lbly11.Text == lblc11.Text)
                    var1++;
                else
                    var2++;
                if (lbly12.Text == lblc12.Text)
                    var1++;
                else
                    var2++;
                if (lbly13.Text == lblc13.Text)
                    var1++;
                else
                    var2++;
                if (lbly14.Text == lblc14.Text)
                    var1++;
                else
                    var2++;
                if (lbly15.Text == lblc15.Text)
                    var1++;
                else
                    var2++;
                if (lbly16.Text == lblc16.Text)
                    var1++;
                else
                    var2++;
                if (lbly17.Text == lblc17.Text)
                    var1++;
                else
                    var2++;
                if (lbly18.Text == lblc18.Text)
                    var1++;
                else
                    var2++;

                lblyourcorrect.Text = var1.ToString();
                lblyourIncoreect.Text = var2.ToString();
                //string path = ConfigurationManager.ConnectionStrings["sc"].ToString();
                SqlConnection aaaa = new SqlConnection(path);
                aaaa.Open();
                SqlCommand aaaaa = new SqlCommand();
                aaaaa.CommandText = "select * from PaperCode";
                aaaaa.Connection = aaaa;
                SqlDataReader aaaaaa = aaaaa.ExecuteReader();
                while (aaaaaa.Read())
                {
                    lblpapercode.Text = aaaaaa["code"].ToString();
                }
                aaaa.Close();
                if (!IsPostBack)
                {
                    path = ConfigurationManager.ConnectionStrings["sc"].ConnectionString;
                    SqlConnection con = new SqlConnection(path);
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "insert into Result1 values('" + lblemail.Text + "','" + lblyourcorrect.Text + "','" + lblyourIncoreect.Text + "','" + DateTime.Now + "','" + lblpapercode.Text + "','" + Session["time"] + "') ";
                    cmd.Connection = con;
                    int j = cmd.ExecuteNonQuery();
                    if (j > 0)
                    {
                        //
                    }
                    con.Close();
                }
            }
            catch
            {
                Response.Redirect("~/Login.aspx");
            }

        }

        protected void btnloout_Click(object sender, EventArgs e)
        {
            Application["x"] = 0;
            Application["y"] = 0;
           /* string path = ConfigurationManager.ConnectionStrings["sc"].ConnectionString;
            SqlConnection con = new SqlConnection(path);
            con.Open();s
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into Result1 values('" + lblemail.Text + "','"+lblyourcorrect.Text+"','"+lblyourIncoreect.Text+"','"+DateTime.Now+"','"+lblpapercode.Text+"','"+Session["time"]+"') ";
            cmd.Connection = con;
            int i = cmd.ExecuteNonQuery();
            if (i > 0)*/
                Response.Redirect("~/Login.aspx");


        }
    }
}