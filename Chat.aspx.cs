using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Chat : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["kullanici_id"] == null)
        {

            Response.Redirect("Giris.aspx");
        }
        alici.Text = Session["alan_kadi"].ToString();
        

    }

    protected void gonder_Click(object sender, EventArgs e)
    {
        if (Session["kullanici_id"] == null)
        {

            Response.Redirect("Giris.aspx");
        }

        int alan_id = int.Parse(Session["alan_id"].ToString());
        int kullanici_id = int.Parse(Session["kullanici_id"].ToString());
        string konum = konu.Text;
        string mesajj = mesaj.Text;
        Kullaniciİslemler.MesajEkle(kullanici_id, alan_id, konum, mesajj);


    }
}