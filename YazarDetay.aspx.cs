using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class YazarDetay : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet yazarlar = Kullaniciİslemler.YazarKitaplar(int.Parse(Session["yazar_id"].ToString()));

        kitaplarim.DataSource = yazarlar.Tables[0];
        kitaplarim.DataBind();


        yazarad.Text = yazarlar.Tables[0].Rows[0]["yazar_adi"].ToString() + "  " + yazarlar.Tables[0].Rows[0]["yazar_soyadi"].ToString();
        dogumtarihi.Text = yazarlar.Tables[0].Rows[0]["yazar_dtarih"].ToString();
        dogumyeri.Text = yazarlar.Tables[0].Rows[0]["yazar_dyeri"].ToString();
        olumtarihi.Text = yazarlar.Tables[0].Rows[0]["yazar_ötarih"].ToString();

    }
}