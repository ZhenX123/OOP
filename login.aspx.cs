using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
public partial class login : System.Web.UI.Page
{
    public string username;
    public string password;
    public string strpwd;
    SqlConnection conn = DB.getcon();
    protected void Page_Load(object sender, EventArgs e)
    {
        this.kefang();
        Session["huiyuan"] = null;
        Session["name"] = null;
        Session["dj"] = null;
    }
    public void kefang()
    {
        SqlConnection con = DB.getcon();
        DataSet ds = new DataSet();
        SqlDataAdapter sda = new SqlDataAdapter("select  top 4 * from house", con);
        sda.Fill(ds, "mclass");
        this.XRepeater.DataSource = ds.Tables["mclass"].DefaultView;
        this.XRepeater.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        username = TextBox1.Text;
        password = TextBox2.Text;
        strpwd = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(password.Trim(), "md5").ToString().ToLower().Substring(8, 16);
        int a = int.Parse(RadioButtonList1.SelectedValue);
        if (username == String.Empty || password == String.Empty)
        {
            Response.Write("<script>");
            Response.Write("alert('管理名/密码 不能为空!!!');");
            Response.Write("</script>");
            return;
        }
        else
        {

            if (a == 1)
            {
                this.getcom(1);
            }
            if (a == 2)
            {
                this.getcom(2);
            }
            

        }
    }

    private void getcom(int i)
    {

        switch (i)
        {
            case 1:
                string mySql = "select * from users where username='" + username + "' and password='" + strpwd + "' and  typename=1 ";
                conn.Open();
                SqlCommand cmd = new SqlCommand(mySql, conn);


                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {


                    //Session["RoleID"] = dr["Roles"];
                    Session["huiyuan"] = username;
                    Session["dj"] = 1;
                    Session["name"] = dr["name"];
                    Response.Redirect("mycenter.aspx");
                }

                else
                {
                    Response.Write("<script lanuage=javascript>alert('用户名或密码有误！');location='javascript:history.go(-1)'</script>");
                    return;

                }
                conn.Close();

                break;

            case 2:
                string mySql5 = "select * from users where username='" + username + "' and password='" + strpwd + "' and typename=2 ";
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(mySql5, conn);


                SqlDataReader dr1 = cmd1.ExecuteReader();

                if (dr1.Read())
                {


                    //Session["RoleID"] = dr["Roles"];
                    Session["huiyuan"] = username;
                    Session["dj"] = 2;
                    Session["name"] = dr1["name"];
                    // Session["UserID"] = dr["ID"];
                    Response.Redirect("mycenter.aspx");
                }

                else
                {
                    Response.Write("<script lanuage=javascript>alert('用户名或密码有误！');location='javascript:history.go(-1)'</script>");
                    return;

                }

                conn.Close();
                break;
           



        }

    }
}
