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
///DB 的摘要说明
/// </summary>
public class DB
{
	public DB()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}
    public static SqlConnection createCon()
    {
        string conString = System.Configuration.ConfigurationManager.AppSettings["FczjServices"];
        SqlConnection conn = new SqlConnection(conString);
        if (conn.State.Equals(ConnectionState.Closed))
        {
            conn.Open();
        }
        return conn;
    }
    public static SqlConnection getcon()
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FczjServices"].ToString());

        return conn;
    }


    public static bool ExSql(string P_str_cmdtxt)
    {
        SqlConnection con = DB.getcon();//连接数据库
        con.Open();//打开连接
        SqlCommand cmd = new SqlCommand(P_str_cmdtxt, con);
        try
        {
            cmd.ExecuteNonQuery();//执行SQL 语句并返回受影响的行数
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
        finally
        {
            con.Dispose();//释放连接对象资源
        }
    }
    public static DataSet reDs(string P_str_cmdtxt)
    {
        SqlConnection con = DB.getcon();//连接上数据库
        SqlDataAdapter da = new SqlDataAdapter(P_str_cmdtxt, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;//返回DataSet对象
    }
}
