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
public partial class listnews : System.Web.UI.Page
{
    SqlConnection con = DB.getcon();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            this.kefang();
            int id = Convert.ToInt32(Request.QueryString["id"]);

            //SqlConnection con = DB.getcon();
            SqlCommand cmd = new SqlCommand("select*from news where ID='" + id + "'", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
               
                this.Label1.Text = dr["title"].ToString();
                this.Label2.Text = dr["content"].ToString();
                this.Label3.Text = dr["addtime"].ToString();
                

            }
            dr.Close();
            con.Close();

        }
    }
    public void kefang()
    {
        DataSet ds = new DataSet();
        SqlDataAdapter sda = new SqlDataAdapter("select  top 4 * from house", con);
        sda.Fill(ds, "mclass");
        this.XRepeater.DataSource = ds.Tables["mclass"].DefaultView;
        this.XRepeater.DataBind();
    }
}
