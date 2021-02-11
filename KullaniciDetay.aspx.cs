using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class KullaniciDetay : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["kullanici_id"] == null)
        {

            Response.Redirect("Giris.aspx");
        }

        else if (Session["aranan_id"] == null)
        {
            Response.Redirect("KullaniciArama.aspx");

        }
        int kullanici_id = int.Parse(Session["kullanici_id"].ToString());

        DataSet yazarlar = Kullaniciİslemler.KullaniciDetay(int.Parse(Session["aranan_id"].ToString()));



        adsoyad.Text = yazarlar.Tables[0].Rows[0]["kullanici_adi"].ToString() + "  " + yazarlar.Tables[0].Rows[0]["kullanici_soyadi"].ToString();
        kullaniciad.Text = yazarlar.Tables[0].Rows[0]["kullanici_kadi"].ToString();

        kullaniciresim.ImageUrl = yazarlar.Tables[0].Rows[0]["kullanici_resimyolu"].ToString();

        DataSet inceleme = Kullaniciİslemler.KullaniciKitapİncelemeler(int.Parse(Session["aranan_id"].ToString()));
        incelemeler.DataSource = inceleme.Tables[0];
        incelemeler.DataBind();

        DataSet alintilar = Kullaniciİslemler.KullaniciKitapAlintilar(int.Parse(Session["aranan_id"].ToString()));
        alintilarim.DataSource = alintilar.Tables[0];
        alintilarim.DataBind();
        DataSet okunanlar = Kullaniciİslemler.KullaniciOkunanKitaplar(int.Parse(Session["aranan_id"].ToString()));
        kitaplarim.DataSource = okunanlar.Tables[0];
        kitaplarim.DataBind();
        DataSet puanverilen = Kullaniciİslemler.KullaniciVerdigiPuan(int.Parse(Session["aranan_id"].ToString()));
        puanlar.DataSource = puanverilen.Tables[0];
        puanlar.DataBind();
    }
    protected void kitapdetay_Command(object sender, CommandEventArgs e)

    {


        Session["kitap_id"] = e.CommandArgument.ToString();

        Response.Redirect("KitapDetay.aspx");

    }


    protected void okudum_Click(object sender, EventArgs e)
    {
        Session["alan_id"] = Session["aranan_id"];
        Session["alan_kadi"] = kullaniciad.Text;
        Response.Redirect("Chat.aspx");

    }


}