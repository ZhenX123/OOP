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
public partial class xiugaimy : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["huiyuan"] == null)
        {
            Response.Write("<script laguage='javascript'>alert('请先登录！');window.location.href('login.aspx')</script>");
        }
        
        if (!IsPostBack)
        {
            //string username = Session["huiyuan"].ToString();
           
            SqlConnection con = DB.getcon();
            SqlCommand cmd = new SqlCommand("select*from users where username='" + Session["huiyuan"] + "'", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                this.TextBox1.Text = dr["username"].ToString();
                this.TextBox3.Text = dr["name"].ToString();

                this.DropDownList1.SelectedValue = dr["sex"].ToString();
                this.TextBox4.Text = dr["tel"].ToString();
                this.TextBox5.Text = dr["email"].ToString();
                this.TextBox6.Text = dr["qq"].ToString();

            }
            dr.Close();
            con.Close();

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //string username = Session["huiyuan"].ToString();
        string pwd = this.TextBox2.Text;
        string strpwd = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(pwd.Trim(), "md5").ToString().ToLower().Substring(8, 16);
        SqlConnection conn = DB.createCon();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "update  users set username='" + TextBox1.Text + "',password='" + strpwd + "',name='" + TextBox3.Text + "',sex='" + DropDownList1.SelectedValue + "',tel='" + TextBox4.Text + "',email='" + TextBox5.Text + "',qq='" + TextBox6.Text + "' where username='" + Session["huiyuan"] + "'";
        if (cmd.ExecuteNonQuery() > 0)
        {
            Response.Write("<script>alert('修改成功！');location.href='mycenter.aspx';</script>");
        }
        else
        {
            Response.Write("<script>alert('修改失败！');window.location = window.location;</script>");
        }
        conn.Close();

    }
}
