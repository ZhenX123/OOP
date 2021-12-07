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
public partial class reg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.kefang();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string uname = this.TextBox1.Text;
        string pwd = this.TextBox2.Text;
        string strpwd = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(pwd.Trim(), "md5").ToString().ToLower().Substring(8, 16);
        SqlConnection conn = DB.createCon();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "insert into users(username,password,name,sex,tel,email,qq,typename) values('" + uname + "','" + strpwd + "','" + TextBox3.Text + "','" + DropDownList1.SelectedValue + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + RadioButtonList1.SelectedValue + "')";
        if (cmd.ExecuteNonQuery() > 0)
        {
            Response.Write("<script>alert('注册成功！');location.href='login.aspx';</script>");
        }
        else
        {
            Response.Write("<script>alert('添加失败！');window.location = window.location;</script>");
        }
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
}
