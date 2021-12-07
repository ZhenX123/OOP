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
public partial class shfcxx : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = DB.getcon();
        string sqlstr = "update  house  set sp='" + DropDownList1.SelectedValue + "' where ID='" + Request.QueryString["id"] + "'";
        SqlCommand cmd = new SqlCommand(sqlstr, con);
        con.Open();
        try
        {
            cmd.ExecuteNonQuery();
            Response.Write("<script laguage='javascript'>alter('操作成功！');window.location.href('Managesh.aspx')</script>");
        }
        catch (Exception e1)
        {
            Response.Write(e1.Message);
        }
        Response.Redirect("Managesh.aspx");
        con.Close();
    }
}
