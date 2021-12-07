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
public partial class guanlixx : System.Web.UI.Page
{
    SqlConnection con = DB.getcon();
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["huiyuan"] == null)
        {
            Response.Write("<script laguage='javascript'>alert('请先登录！');window.location.href('login.aspx')</script>");
        }
        if (!IsPostBack)
        {
            this.BindGrid();
        }
    }
    private void BindGrid()
    {
        SqlDataAdapter sda = new SqlDataAdapter("select*from house where username='" + Session["huiyuan"] + "'", con);
        sda.Fill(ds, "house");
        this.GridView1.DataSource = ds.Tables["house"].DefaultView;
        this.GridView1.DataBind();

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = Convert.ToInt32(this.GridView1.Rows[e.RowIndex].Cells[0].Text);
        string strsql = "delete from house where ID='" + id + "'";
        SqlCommand cmd = new SqlCommand(strsql, con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        this.GridView1.EditIndex = -1;
        this.BindGrid();

    }
}
