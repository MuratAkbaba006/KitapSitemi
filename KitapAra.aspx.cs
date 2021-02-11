using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class KitapAra : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ara_Click(object sender, EventArgs e)
    {

        DataSet yazarlar = Kullaniciİslemler.KitapArama(aranan.Text);

        kitaplarim.DataSource = yazarlar.Tables[0];
        kitaplarim.DataBind();
    }

    protected void kitapdetay_Command(object sender, CommandEventArgs e)
    {
       
        Session["kitap_id"] = e.CommandArgument.ToString();
        Response.Redirect("KitapDetay.aspx");
    }
}