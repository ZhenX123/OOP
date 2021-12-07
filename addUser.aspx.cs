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
public partial class addUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] == null)
        {
            Response.Write("<script laguage='javascript'>alert('您没有此权限！');window.location.href('right1.aspx')</script>");
        } 
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string uname = this.TextBox1.Text;
        string pwd = this.TextBox2.Text;
        string strpwd = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(pwd.Trim(), "md5").ToString().ToLower().Substring(8, 16);
        SqlConnection conn = DB.createCon();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "insert into admin(UserName,Pwd) values('" + uname + "','" + strpwd + "')";
        if (cmd.ExecuteNonQuery() > 0)
        {
            Response.Write("<script>alert('添加成功！');location.href='ManageUser.aspx';</script>");
        }
        else
        {
            Response.Write("<script>alert('添加失败！');window.location = window.location;</script>");
        }
    }
}
