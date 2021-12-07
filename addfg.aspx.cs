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
public partial class addfg : System.Web.UI.Page
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
        string Addtime = DateTime.Now.ToShortDateString().ToString();
        SqlConnection con = DB.getcon();
        DataSet ds = new DataSet();
        string strsql = "insert into fagui(title,[content],addtime)values( '" + TextBox1.Text + "','" + TextBox2.Text + "','" + Addtime + "') ";
        SqlCommand cmd = new SqlCommand(strsql, con);
        con.Open();
        try { cmd.ExecuteNonQuery(); }
        catch (Exception e1)
        {
            Response.Write(e1.Message);
        }
        con.Close();
        Response.Write("<script>alert('添加成功');;location.href='Managefg.aspx';</script>");
    }
}
