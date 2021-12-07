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
public partial class fabuxx : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["huiyuan"] == null)
        {
            Response.Write("<script laguage='javascript'>alert('请先登录！');window.location.href('login.aspx')</script>");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //string mname = this.TextBox1.Text;
        //string mclass = this.DropDownList1.SelectedValue.ToString();
        //string price = this.TextBox2.Text;
        
        if (Page.IsValid)
        {
            Boolean fileok1 = false;

            string path = Server.MapPath("UploadImages/");

            if (FileUpload1.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                string[] allowedExtensions = { ".gif", ".jpg", ".png", ".jpeg" };
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileok1 = true;
                    }
                }

            }


            if (fileok1)
            {
                try
                {
                    string Addtime = DateTime.Now.ToShortDateString().ToString();
                    FileUpload1.PostedFile.SaveAs(path + FileUpload1.FileName);
                    // FileUpload2.PostedFile.SaveAs(path1 + FileUpload2.FileName);
                    string picpath = "UploadImages/" + FileUpload1.FileName;
                    // string moviepath = "Movies/" + FileUpload2.FileName;
                    SqlConnection con = DB.getcon();
                    string sqlstr = "insert into house(bt , lx , xq , fx , dj ,zj , mj , lc ,tel , nd, cx ,zx ,cq ,addtime,contents , imgs,username)values('" + TextBox1.Text + "','" + DropDownList1.SelectedValue + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "','" + TextBox12.Text + "','" + Addtime + "','" + TextBox13.Text + "','" + picpath + "','" + Session["huiyuan"] + "')";
                    SqlCommand cmd = new SqlCommand(sqlstr, con);
                    con.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception e1)
                    {
                        Response.Write(e1.Message);
                        Response.Write("<script laguage='javascript'>alter('添加失败！')</script>");
                    }
                    Response.Redirect("guanlixx.aspx");
                    con.Close();
                }
                catch (Exception e2)
                {
                    Response.Write(e2.Message);
                    Response.Write("<script laguage='javascript'>alter('上传失败！')</script>");
                }
            }
            else
            {
                Response.Write("<script laguage='javascript'>alter('上传失败！')</script>");
            }

        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        TextBox8.Text = "";
        TextBox9.Text = "";
        TextBox10.Text = "";
        TextBox11.Text = "";
        TextBox12.Text = "";
        TextBox13.Text = "";
       
    }
}
