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
public partial class guest : System.Web.UI.Page
{
    string curPage;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.lblPageCur.Text = "1";//不能放到dataGridBind()后面,不然lblPageCur.Text没有被初始化,出错
            dataGridBind();
        }
    }
    public void dataGridBind()
    {
        curPage = this.lblPageCur.Text;
        SqlConnection conn = DB.createCon();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select * from guest order by postTime desc";
        cmd.Connection = conn;
        SqlDataAdapter sda = new SqlDataAdapter();
        sda.SelectCommand = cmd;
        DataSet ds = new DataSet();
        sda.Fill(ds, "guest");
        PagedDataSource pds = new PagedDataSource();
        pds.AllowPaging = true;
        pds.PageSize = 3;
        pds.DataSource = ds.Tables["guest"].DefaultView;
        pds.CurrentPageIndex = Convert.ToInt32(curPage) - 1;
        this.lblPageTotal.Text = pds.PageCount.ToString();
        this.Button1.Enabled = true;
        this.Button2.Enabled = true;
        if (curPage == "1")
        {
            this.Button1.Enabled = false;
        }
        if (curPage == pds.PageCount.ToString())
        {
            this.Button2.Enabled = false;
        }
        this.DataList1.DataSource = pds;
        this.DataList1.DataBind();

        cmd.CommandText = "select count(*) from guest";
        this.lblMesTotal.Text = Convert.ToString(cmd.ExecuteScalar());

        int a = pds.PageCount;
        for (int i = 1; i <= a; i++)
        {
            this.DropDownList1.Items.Add(i.ToString());
        }
    }

    protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        LinkButton dele = (LinkButton)(e.Item.FindControl("lbtnDelete"));
        if (dele != null)
        {
            dele.Attributes.Add("onclick", "return confirm('确定删除吗?')");
        }
    }

    protected void lbtnDelete_Command(object sender, CommandEventArgs e)
    {
        if (Session["UserName"] != null)
        {
            //string userID = Request.QueryString["userID"];      //不好传送,试了N遍  
            string userID = e.CommandArgument.ToString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DB.createCon();
            cmd.CommandText = "delete from guest where ID='" + userID + "'";
            if (cmd.ExecuteNonQuery() > 0)
            {
                Response.Write("<script>alert('删除成功！');window.location=window.location;</script>");
            }
            else
            {
                Response.Write("<script>alert('删除失败！');window.location=window.location;</script>");
            }
        }
        else
        {
            Response.Write("<script>alert('对不起,只有管理员才允许删除留言,如果你是管理员,请先登陆！');window.location.href='index.aspx';</script>");
        }
    }

    protected void lbtnReply_Command(object sender, CommandEventArgs e)
    {
        if (Session["UserName"] != null)
        {
            //string userID = Request.QueryString["userID"];      //这样通过页面来传送,不用e.CommandArgument,会出错,试了N遍  
            string userID = e.CommandArgument.ToString();
            Response.Redirect("reply.aspx?userID=" + userID + "");
        }
        else
        {
            Response.Write("<script>alert('对不起,只有管理员才允许回复留言,如果你是管理员,请先登陆！');window.location.href='index.aspx';</script>");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        this.lblPageCur.Text = Convert.ToString(Convert.ToInt32(this.lblPageCur.Text) - 1);
        dataGridBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        this.lblPageCur.Text = Convert.ToString(Convert.ToInt32(this.lblPageCur.Text) + 1);
        dataGridBind();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        this.lblPageCur.Text = "1";
        dataGridBind();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        this.lblPageCur.Text = this.lblPageTotal.Text;
        dataGridBind();
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.lblPageCur.Text = this.DropDownList1.SelectedValue;
            dataGridBind();
        }
    }
}
