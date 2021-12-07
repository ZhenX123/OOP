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
public partial class adminlogin : System.Web.UI.Page
{
    public string username;
    public string password;
    public string strpwd;
    SqlConnection conn = DB.getcon();
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["UserName"] = null;

        Session["dj"] = null;
    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        username = txtid.Text;
        password = txtpsw.Text;
        strpwd = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(password.Trim(), "md5").ToString().ToLower().Substring(8, 16);
        //int a = int.Parse(RadioButtonList1.SelectedValue);
        if (username == String.Empty || password == String.Empty)
        {
            Response.Write("<script>");
            Response.Write("alert('管理名/密码 不能为空!!!');");
            Response.Write("</script>");
            return;
        }
        else
        {

            string mySql5 = "select * from admin where UserName='" + username + "' and Pwd='" + strpwd + "' ";
            conn.Open();
            SqlCommand cmd1 = new SqlCommand(mySql5, conn);


            SqlDataReader dr1 = cmd1.ExecuteReader();

            if (dr1.Read())
            {


                //Session["RoleID"] = dr["Roles"];
                Session["UserName"] = username;
                Session["dj"] = 0;
                // Session["UserID"] = dr["ID"];
                Response.Redirect("Manage.aspx");
            }

            else
            {
                Response.Write("<script lanuage=javascript>alert('用户名或密码有误！');location='javascript:history.go(-1)'</script>");
                return;

            }

            conn.Close();

        }
    }
}
