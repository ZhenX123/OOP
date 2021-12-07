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
public partial class reply : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string reply = this.txtReply.Text;
        string userID = Request.QueryString["userID"].ToString();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = DB.createCon();
        cmd.CommandText = "update guest set reply='" + reply + "' where ID='" + userID + "'";
        if (Convert.ToInt32(cmd.ExecuteNonQuery()) > 0)
        {
            Response.Write("<script>alert('回复成功！');location.href='guest.aspx';</script>");
        }
        else
        {
            Response.Write("<script>alert('回复失败！');location.href=location.href;</script>");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        this.txtReply.Text = ""; 
    }
}
