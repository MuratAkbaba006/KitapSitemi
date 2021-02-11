using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Giris : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void giris_Click(object sender, EventArgs e)
    {

        var kullanici = Kullaniciİslemler.Giris(k_ad.Text, pass.Text);
        var a = kullanici.Tables[0].Rows;
        if (a.Count > 0)
        {
            Session["kullanici_id"] = int.Parse(a[0]["kullanici_id"].ToString());

            Response.Redirect("OneriiEkrani.aspx");

        }

    }
}