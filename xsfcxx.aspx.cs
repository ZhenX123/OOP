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
public partial class xsfcxx : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

        if (!IsPostBack)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);

            SqlConnection con = DB.getcon();
            SqlCommand cmd = new SqlCommand("select*from house where ID='" + id + "'", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                this.Label14.Text = dr["bt"].ToString();
                this.Image1.ImageUrl = dr["imgs"].ToString();
                this.Label1.Text = dr["zj"].ToString();
                this.Label2.Text = dr["dj"].ToString();
                this.Label3.Text = dr["mj"].ToString();
                this.Label4.Text = dr["fx"].ToString();
                this.Label5.Text = dr["tel"].ToString();
                this.Label6.Text = dr["nd"].ToString();
                this.Label7.Text = dr["lc"].ToString();
                this.Label8.Text = dr["cx"].ToString();
                this.Label9.Text = dr["zx"].ToString();
                this.Label10.Text = dr["cq"].ToString();
                this.Label11.Text = dr["addtime"].ToString();
                this.Label12.Text = dr["xq"].ToString();
                this.Label13.Text = dr["contents"].ToString();
                
            }
            dr.Close();
            con.Close();

        }
    }
}
