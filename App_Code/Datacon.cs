using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
/// <summary>
///Datacon 的摘要说明
/// </summary>
public class Datacon
{
	public Datacon()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}
    //==================数据库连接===========================
    public SqlConnection getcon()
    {

        SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["FczjServices"].ToString());
        return sqlCon;
    }
    public bool eccom(string sqlstr1)
    {
        SqlConnection con = this.getcon();
        con.Open();
        SqlCommand mycommand = new SqlCommand(sqlstr1, con);
        try
        {
            mycommand.ExecuteNonQuery();
            return true;
        }
        catch
        {
            return false;
        }
        finally
        {
            con.Close();
        }
    }
    public bool ecDropDownList(DropDownList DDL, string sqlstr3, string DTF, string DVF)
    {
        SqlConnection con = this.getcon();
        con.Open();
        SqlDataAdapter mydataadapter = new SqlDataAdapter(sqlstr3, con);
        DataSet mydataset = new DataSet();
        mydataadapter.Fill(mydataset);
        DDL.DataSource = mydataset;
        DDL.DataTextField = DTF;
        DDL.DataValueField = DVF;
        try
        {
            DDL.DataBind();
            return true;
        }
        catch
        {
            return false;
        }
        finally
        {
            con.Close();
        }
    }
    public bool ecadabind(GridView gv, string sqlstr4)
    {
        SqlConnection con = this.getcon();
        con.Open();
        SqlDataAdapter mydataadapter = new SqlDataAdapter(sqlstr4, con);
        DataSet mydataset = new DataSet();
        mydataadapter.Fill(mydataset);
        gv.DataSource = mydataset;
        try
        {
            gv.DataBind();
            return true;
        }
        catch
        {
            return false;
        }
        finally
        {
            con.Close();
        }
    }
    public bool ecadabindinfostring(GridView gv, string sqlstr5, string DNK)
    {
        SqlConnection con = this.getcon();
        con.Open();
        SqlDataAdapter mydataadapter = new SqlDataAdapter(sqlstr5, con);
        DataSet mydataset = new DataSet();
        mydataadapter.Fill(mydataset);
        gv.DataSource = mydataset;
        gv.DataKeyNames = new string[] { DNK };
        try
        {
            gv.DataBind();
            return true;
        }
        catch
        {
            return false;
        }
        finally
        {
            con.Close();
        }
    }
}
