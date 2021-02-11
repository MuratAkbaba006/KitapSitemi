using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChatDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet yazarlar = Kullaniciİslemler.MesajDetay(int.Parse(Session["mesaj_id"].ToString()));



        gonderen.Text = yazarlar.Tables[0].Rows[0]["kullanici_adi"].ToString() + "  " + yazarlar.Tables[0].Rows[0]["kullanici_soyadi"].ToString();
        konu.Text = yazarlar.Tables[0].Rows[0]["mesaj_baslik"].ToString();
        tarih.Text = yazarlar.Tables[0].Rows[0]["mesaj_tarih"].ToString();
        mesaj.Text = yazarlar.Tables[0].Rows[0]["mesaj_mesaj"].ToString();
        Session["alan_id"] = yazarlar.Tables[0].Rows[0]["mesaj_gonderenid"].ToString();
        Session["alan_kadi"] = yazarlar.Tables[0].Rows[0]["kullanici_kadi"].ToString();
    }

    protected void cevapla_Click(object sender, EventArgs e)
    {

        Response.Redirect("Chat.aspx");

    }
}