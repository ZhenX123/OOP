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

public partial class mycenter : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["huiyuan"] == null)
        {
            Response.Write("<script laguage='javascript'>alert('请先登录！');window.location.href('login.aspx')</script>");
        }
        else
        {
            Label2.Text = Session["name"].ToString();
            if ((int)Session["dj"] == 1)
            {
                Label1.Text = "个人会员";
            }
            else
            {
                Label1.Text = "中介(经纪人)会员";
            }
        }

    }
}
