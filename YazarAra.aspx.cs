using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class YazarAra : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void kitaplistele_Command(object sender, CommandEventArgs e)
    {

        Session["yazar_id"] = e.CommandArgument.ToString();
        Response.Redirect("YazarDetay.aspx");
    }

    protected void ara_Click(object sender, EventArgs e)
    {

        DataSet yazarlar = Kullaniciİslemler.YazarArama(aranan.Text);

        kitaplarim.DataSource = yazarlar.Tables[0];
        kitaplarim.DataBind();
    }
}