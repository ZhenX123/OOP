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
public partial class Managehy : System.Web.UI.Page
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
            else
            {
            }
            this.GridBind();
        }
    }

    public void GridBind()
    {
        SqlDataAdapter sda = new SqlDataAdapter("select * from users", con);
        sda.Fill(ds, "mclass");
        this.GridView1.DataSource = ds.Tables["mclass"].DefaultView;
        this.GridView1.DataBind();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int managerid = Convert.ToInt32(this.GridView1.Rows[e.RowIndex].Cells[0].Text);
        string strsql = "delete from users where ID='" + managerid + "'";
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
        int managerid = Convert.ToInt32(this.GridView1.Rows[e.RowIndex].Cells[0].Text);
        string a1 = ((TextBox)this.GridView1.Rows[e.RowIndex].Cells[1].FindControl("TextBox2")).Text;
        string a2 = ((TextBox)this.GridView1.Rows[e.RowIndex].Cells[2].FindControl("TextBox3")).Text;
        string a3 = ((TextBox)this.GridView1.Rows[e.RowIndex].Cells[3].FindControl("TextBox4")).Text;
        string a4 = ((TextBox)this.GridView1.Rows[e.RowIndex].Cells[4].FindControl("TextBox5")).Text;
        string a5 = ((TextBox)this.GridView1.Rows[e.RowIndex].Cells[5].FindControl("TextBox6")).Text;
        string a6 = ((TextBox)this.GridView1.Rows[e.RowIndex].Cells[6].FindControl("TextBox7")).Text;
        string a7 = ((TextBox)this.GridView1.Rows[e.RowIndex].Cells[7].FindControl("TextBox8")).Text;
        string strsql = "update users set  username='" + a1 + "',name='" + a2 + "',sex='" + a3 + "',tel='" + a4 + "',email='" + a5 + "',qq='" + a6 + "',typename='" + a7 + "' where ID='" + managerid + "'";
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
