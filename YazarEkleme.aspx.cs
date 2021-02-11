using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class YazarEkleme : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void Kaydet_Click(object sender, EventArgs e)
    {

        try
        {
            string ad = yazar_ad.Text;
            string soyad = yazar_soyad.Text;
            string dyeri = yazar_dyeri.Text;

            DateTime? otarih = new DateTime();

            if (yazar_otarih.Text != "")
            {

                otarih = Convert.ToDateTime(yazar_otarih.Text);
            }

            else
            {

                otarih = null;

            }
            DateTime dtarih = Convert.ToDateTime(yazar_dtarih.Text);
            YoneticiIslemler.YazarEkle(ad, soyad, dyeri, dtarih, otarih);
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }

        }
        catch (Exception error)

        {

            errorlabel.Text = error.Message;

        }


    }
}