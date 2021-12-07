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
public partial class rentsearch : System.Web.UI.Page
{
    string curPage;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.kefang();
            this.lblPageCur.Text = "1";//不能放到dataGridBind()后面,不然lblPageCur.Text没有被初始化,出错
            dataGridBind();
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
    public void dataGridBind()
    {
        String K = Request.QueryString["K"].ToString();
        curPage = this.lblPageCur.Text;
        SqlConnection conn = DB.createCon();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select * from house where bt like '" + K + "' or xq like '" + K + "' order by ID desc";
        cmd.Connection = conn;
        SqlDataAdapter sda = new SqlDataAdapter();
        sda.SelectCommand = cmd;
        DataSet ds = new DataSet();
        sda.Fill(ds, "house");
        PagedDataSource pds = new PagedDataSource();
        pds.AllowPaging = true;
        pds.PageSize = 8;
        pds.DataSource = ds.Tables["house"].DefaultView;
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

        cmd.CommandText = "select count(*) from house where bt like '" + K + "' or xq like '" + K + "'";
        this.lblMesTotal.Text = Convert.ToString(cmd.ExecuteScalar());

        int a = pds.PageCount;
        for (int i = 1; i <= a; i++)
        {
            this.DropDownList1.Items.Add(i.ToString());
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
