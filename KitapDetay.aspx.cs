using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class KitapDetay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["kullanici_id"] == null)
        {

            Response.Redirect("Giris.aspx");
        }

        else if (Session["kitap_id"] == null)
        {
            Response.Redirect("KitapArama.aspx");

        }
        int kullanici_id = int.Parse(Session["kullanici_id"].ToString());

        DataSet yazarlar = Kullaniciİslemler.KitapDetay(int.Parse(Session["kitap_id"].ToString()));



        yazarad.Text = yazarlar.Tables[0].Rows[0]["yazar_adi"].ToString() + "  " + yazarlar.Tables[0].Rows[0]["yazar_soyadi"].ToString();
        kitapad.Text = yazarlar.Tables[0].Rows[0]["kitap_isim"].ToString();
        okumasayisi.Text = yazarlar.Tables[0].Rows[0]["kitap_okumasayisi"].ToString();
        yayınevi.Text = yazarlar.Tables[0].Rows[0]["kitap_yayinevi"].ToString();
        kitapresim.ImageUrl = yazarlar.Tables[0].Rows[0]["kitap_resimyolu"].ToString();
        aciklama.Text = yazarlar.Tables[0].Rows[0]["kitap_aciklama"].ToString();
        Session["yazar_id"] = yazarlar.Tables[0].Rows[0]["kitap_yazarid"].ToString();

        DataSet inceleme = Kullaniciİslemler.Kitapİncelemeler(int.Parse(Session["kitap_id"].ToString()));
        incelemeler.DataSource = inceleme.Tables[0];
        incelemeler.DataBind();

        DataSet alintilar = Kullaniciİslemler.KitapAlintilar(int.Parse(Session["kitap_id"].ToString()));
        alintilarim.DataSource = alintilar.Tables[0];
        alintilarim.DataBind();

        if (Kullaniciİslemler.OkudumKontrol(kullanici_id, int.Parse(Session["kitap_id"].ToString())) > 0)
        {

            okudum.Visible = false;
        }
        ortalamapuan.Text = Kullaniciİslemler.OrtalamaPuan(int.Parse(Session["kitap_id"].ToString())).ToString();
    }

    protected void okudum_Click(object sender, EventArgs e)
    {
        int kullanici_id = int.Parse(Session["kullanici_id"].ToString());


        Kullaniciİslemler.OkudumEkle(kullanici_id, int.Parse(Session["kitap_id"].ToString()), int.Parse(Session["yazar_id"].ToString()));
        if (Kullaniciİslemler.OkudumKontrol(kullanici_id, int.Parse(Session["kitap_id"].ToString())) > 0)
        {

            okudum.Visible = false;
        }
    }

    protected void yorumgir_Click(object sender, EventArgs e)
    {
        int kullanici_id = int.Parse(Session["kullanici_id"].ToString());

        Kullaniciİslemler.İncelemeEkle(kullanici_id, int.Parse(Session["kitap_id"].ToString()), yorum.Text);

        DataSet inceleme = Kullaniciİslemler.Kitapİncelemeler(int.Parse(Session["kitap_id"].ToString()));
        incelemeler.DataSource = inceleme.Tables[0];
        incelemeler.DataBind();
    }

    protected void alintigir_Click(object sender, EventArgs e)
    {
        int kullanici_id = int.Parse(Session["kullanici_id"].ToString());

        Kullaniciİslemler.AlintiEkle(kullanici_id, int.Parse(Session["kitap_id"].ToString()), alinti.Text, int.Parse(sayfa.Text));

        DataSet alintilar = Kullaniciİslemler.KitapAlintilar(int.Parse(Session["kitap_id"].ToString()));
        alintilarim.DataSource = alintilar.Tables[0];
        alintilarim.DataBind();

    }

    protected void puanver_Click(object sender, EventArgs e)
    {
        int kullanici_id = int.Parse(Session["kullanici_id"].ToString());

        Kullaniciİslemler.PuanVer(kullanici_id, int.Parse(Session["kitap_id"].ToString()), int.Parse(puan.SelectedItem.Value));


    }
}