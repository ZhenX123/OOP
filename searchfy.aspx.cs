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
public partial class searchfy : System.Web.UI.Page
{
    Datacon dataconn = new Datacon();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dataconn.ecadabindinfostring(gvAdminInfo, "select * from house  ORDER BY ID DESC", "ID");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtSelect.Text == "")
        {
            dataconn.ecadabindinfostring(gvAdminInfo, "select * from house  ORDER BY ID DESC", "ID");
        }
        else
        {
            dataconn.ecadabind(gvAdminInfo, "Select * From house Where "
                + ddlAdminName.SelectedValue + "  Like  '%" + txtSelect.Text + "%' ");
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvAdminInfo.PageIndex = e.NewPageIndex;
        dataconn.ecadabind(gvAdminInfo, "Select * From house Where "
                + ddlAdminName.SelectedValue + "  Like  '%" + txtSelect.Text + "%'");
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Cells[8].Text = Convert.ToString(Convert.ToDateTime(e.Row.Cells[8].Text).ToShortDateString());
        }
    }
    protected void gvAdminInfo_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
