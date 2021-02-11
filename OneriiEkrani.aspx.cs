using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OneriiEkrani : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["kullanici_id"] == null)
        {

            Response.Redirect("Giris.aspx");
        }


        int kullanici_id = int.Parse(Session["kullanici_id"].ToString());
        DataSet ortokm = Kullaniciİslemler.Oneri1(kullanici_id);

        ortakokuma.DataSource = ortokm.Tables[0];
        ortakokuma.DataBind();


        DataSet ortpuan = Kullaniciİslemler.Oneri2(kullanici_id);

        ortakpuan.DataSource = ortpuan.Tables[0];
        ortakpuan.DataBind();
    }
}