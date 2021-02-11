using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class KullaniciAra : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void kitaplistele_Command(object sender, CommandEventArgs e)
    {
 
        Session["aranan_id"] = e.CommandArgument.ToString();
        Response.Redirect("KullaniciDetay.aspx");
    }

    protected void ara_Click(object sender, EventArgs e)
    {

        DataSet yazarlar = Kullaniciİslemler.KullaniciArama(aranan.Text);

        kitaplarim.DataSource = yazarlar.Tables[0];
        kitaplarim.DataBind();
    }
}