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
public partial class upfcxx : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //this.databind();
            int id = Convert.ToInt32(Request.QueryString["id"]);
            SqlConnection con = DB.getcon();
            SqlCommand cmd = new SqlCommand("select*from house where ID='" + id + "'", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                this.TextBox1.Text = dr["bt"].ToString();
                this.DropDownList1.SelectedValue = dr["lx"].ToString();
                this.TextBox2.Text = dr["xq"].ToString();
                this.TextBox3.Text = dr["fx"].ToString();
                this.TextBox4.Text = dr["dj"].ToString();
                this.TextBox5.Text = dr["zj"].ToString();
                this.TextBox6.Text = dr["mj"].ToString();
                this.TextBox7.Text = dr["lc"].ToString();
                this.TextBox8.Text = dr["tel"].ToString();
                this.TextBox9.Text = dr["nd"].ToString();
                this.TextBox10.Text = dr["cx"].ToString();
                this.TextBox11.Text = dr["zx"].ToString();
                this.TextBox12.Text = dr["cq"].ToString();
                this.TextBox13.Text = dr["contents"].ToString();
            }
            dr.Close();
            con.Close();

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       // string mname = this.TextBox1.Text;
        //string mclass = this.DropDownList1.SelectedValue.ToString();
        //string mprice = this.TextBox2.Text;

        if (Page.IsValid)
        {
            Boolean fileok = false;
            string path = Server.MapPath("UploadImages/");
            if (FileUpload1.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                string[] allowedExtensions = { ".gif", ".jpg", ".png", ".jpeg" };
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileok = true;
                    }
                }
            }
            if (fileok)
            {
                try
                {
                    string Addtime = DateTime.Now.ToShortDateString().ToString();
                    FileUpload1.PostedFile.SaveAs(path + FileUpload1.FileName);
                    string picpath = "UploadImages/" + FileUpload1.FileName;
                    SqlConnection con = DB.getcon();
                    string sqlstr = "update  house  set bt='" + TextBox1.Text + "',lx='" + DropDownList1.SelectedValue + "',xq='" + TextBox2.Text + "',fx='" + TextBox3.Text + "',dj='" + TextBox4.Text + "',zj='" + TextBox5.Text + "',mj='" + TextBox6.Text + "',lc='" + TextBox7.Text + "',tel='" + TextBox8.Text + "',nd='" + TextBox9.Text + "',cx='" + TextBox10.Text + "',zx='" + TextBox11.Text + "',cq='" + TextBox12.Text + "',addtime='" + Addtime + "',contents='" + TextBox13.Text + "',imgs='" + picpath + "' where ID='" + Request.QueryString["id"] + "'";
                    SqlCommand cmd = new SqlCommand(sqlstr, con);
                    con.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        Response.Write("<script laguage='javascript'>alter('更新成功！');window.location.href('guanlixx.aspx')</script>");
                    }
                    catch (Exception e1)
                    {
                        Response.Write(e1.Message);
                    }
                    Response.Redirect("guanlixx.aspx");
                    con.Close();

                }
                catch (Exception e2)
                {
                    Response.Write(e2.Message);
                }
            }
            else
            {
                Response.Write("<script laguage='javascript'>alter('更新失败！');window.location.href('guanlixx.aspx')</script>");
            }

        }
    }
}
