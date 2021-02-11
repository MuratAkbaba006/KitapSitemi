using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class KitapListeleme : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet yazarlar = YoneticiIslemler.KitapListe();

        kitaplarim.DataSource = yazarlar.Tables[0];
        kitaplarim.DataBind();
    }

    protected void Sil_Command(object sender, CommandEventArgs e)
    {
        YoneticiIslemler.KitapSil(int.Parse(e.CommandArgument.ToString()));
        Response.Redirect("KitapListeleme.aspx");

    }

    protected void Guncelle_Command(object sender, CommandEventArgs e)
    {
        Session["kitap_id"] = e.CommandArgument.ToString();
        Response.Redirect("KitapGuncelleme.aspx");
    }
}