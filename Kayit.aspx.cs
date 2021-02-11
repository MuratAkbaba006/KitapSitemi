using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Kayit : System.Web.UI.Page
{

    protected void resimyukle_Click(object sender, EventArgs e)
    {
        if (resim.HasFile)//Kullanıcı fileupload ile bir dosya seçmiş ise işlemleri gerçekleştir.
        {
            resim.SaveAs(Server.MapPath("~/kullaniciresimleri/") + resim.FileName);
            //Sunucuda ki resimler klasörünün içerisine resmi olduğu gibi yükledik.
            kitap_resimyolu.Text = "/kullaniciresimleri/" + resim.FileName;
        }
        else
            kitap_resimyolu.Text = "Lütfen bir dosya seçiniz.";
    }

    protected void Kaydet_Click(object sender, EventArgs e)
    {

        try
        {

            string isim = ad.Text;
            string soyisim = soyad.Text;
            string kullaniciad = kullanici_ad.Text;
            string passw = parola.Text;
            byte cins = Convert.ToByte(cinsiyet.SelectedItem.Value.ToString());
            DateTime date = Convert.ToDateTime(dtarihi.Text);

            string resimyol = kitap_resimyolu.Text;

            Kullaniciİslemler.Kayit(isim, soyisim, kullaniciad, passw, cins, date, resimyol);
            Response.Redirect("Giris.aspx");
        }
        catch (Exception error)
        {


        }


    }
}