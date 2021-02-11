using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HitYazarlar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        DataSet yazarlar = Kullaniciİslemler.PopulerYazarlar();

        kitaplarim.DataSource = yazarlar.Tables[0];
        kitaplarim.DataBind();
    }

    protected void kitaplistele_Command(object sender, CommandEventArgs e)
    {
        Session["yazar_id"] = e.CommandArgument.ToString();
        Response.Redirect("YazarDetay.aspx");
    }
}