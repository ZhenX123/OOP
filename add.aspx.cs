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
public partial class add : System.Web.UI.Page
{
    string imageUrl;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            for (int i = 1; i <= 10; i++)
            {
                this.ddlPic.Items.Add("pic" + i.ToString() + ".gif");
            }
            this.Image1.ImageUrl = "Images/face/" + ddlPic.SelectedValue;
            //imageUrl = ddlPic.SelectedValue;   //protected是私有方法,里面的变量在外部无法访问,imageUrl应放到Button1_Click里去
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string sex;
        //string postTime; //时间为数据库更新时自动根据系统时间设置 
        //string imageUrl;
        string userName = this.txtUserName.Text;
        string url = this.txtUrl.Text;
        string qq = this.txtQq.Text;
        string email = this.txtEmail.Text;
        string content = this.txtContent.Text;
        string imageUrl = ddlPic.SelectedValue;
        if (this.rbtnNv.Checked == true)
        {
            sex = "女";
        }
        else
        {
            sex = "男";
        }

        SqlConnection conn = DB.createCon();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "insert into guest(userName,sex,url,qq,email,content,imageUrl,faceUrl) values('" + userName + "','" + sex + "','" + url + "','" + qq + "','" + email + "','" + content + "','" + imageUrl + "','" + imageUrl + "')";
        if (cmd.ExecuteNonQuery() > 0)
        {
            Response.Write("<script>alert('留言成功！');location.href='guest.aspx';</script>");
        }
        else
        {
            Response.Write("<script>alert('留言失败！');window.location = window.location;</script>");
        }
    }
    protected void ddlPic_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.Image1.ImageUrl = "Images/face/" + ddlPic.SelectedValue;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        this.txtUserName.Text = "";
        this.txtUrl.Text = "";
        this.txtQq.Text = "";
        this.txtEmail.Text = "";
        this.txtContent.Text = "";
    }
}
