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
public partial class managexw : System.Web.UI.Page
{
    SqlConnection con = DB.getcon();
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["UserName"] == null)
            {
                Response.Write("<script laguage='javascript'>alert('您没有此权限！');window.location.href('right1.aspx')</script>");
            }

            this.GridBind();
        }
    }
    public void GridBind()
    {
        SqlDataAdapter sda = new SqlDataAdapter("select ID,title,addtime from news", con);
        sda.Fill(ds, "mclass");
        this.GridView1.DataSource = ds.Tables["mclass"].DefaultView;
        this.GridView1.DataBind();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = Convert.ToInt32(this.GridView1.Rows[e.RowIndex].Cells[0].Text);
        string strsql = "delete from news where ID='" + id + "'";
        SqlCommand cmd = new SqlCommand(strsql, con);
        con.Open();
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch (Exception e1)
        {
            Response.Write("<script laguage='javascript'>altert('删除失败!'" + e1.Message + "'')</script>");
        }
        con.Close();
        this.GridView1.EditIndex = -1;
        this.GridBind();

    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        this.GridView1.EditIndex = e.NewEditIndex;
        this.GridBind();

    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

        int id = Convert.ToInt32(this.GridView1.Rows[e.RowIndex].Cells[0].Text);
        string title = ((TextBox)this.GridView1.Rows[e.RowIndex].Cells[1].FindControl("TextBox2")).Text;
        string addtime = ((TextBox)this.GridView1.Rows[e.RowIndex].Cells[2].FindControl("TextBox3")).Text;



        string strsql = "update news set title='" + title + "', addtime='" + addtime + "'  where ID='" + id + "'";
        SqlCommand cmd = new SqlCommand(strsql, con);
        con.Open();
        try { cmd.ExecuteNonQuery(); }
        catch (Exception e1)
        {
            Response.Write(e1.Message);
        }
        con.Close();
        this.GridView1.EditIndex = -1;
        this.GridBind();

    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        this.GridView1.EditIndex = -1;
        this.GridBind();

    }
}
