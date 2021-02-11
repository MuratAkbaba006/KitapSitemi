using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class KitapGuncelleme : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            DataSet yazarlar = YoneticiIslemler.YazarListe();
            yazar.DataTextField = "yazar_adi";
            yazar.DataValueField = "yazar_id";
            yazar.DataSource = yazarlar.Tables[0];
            yazar.DataBind();
            DataSet kitap = YoneticiIslemler.KitapGetir(int.Parse(Session["kitap_id"].ToString()));


            kitap_isim.Text = kitap.Tables[0].Rows[0]["kitap_isim"].ToString();
            kitap_resimyolu.Text = kitap.Tables[0].Rows[0]["kitap_resimyolu"].ToString();
            kitap_yayinevi.Text = kitap.Tables[0].Rows[0]["kitap_yayinevi"].ToString();
            kitap_aciklama.Text = kitap.Tables[0].Rows[0]["kitap_aciklama"].ToString();

            yazar.SelectedItem.Value = kitap.Tables[0].Rows[0]["kitap_yazarid"].ToString();
        }
    }

    protected void Kaydet_Click(object sender, EventArgs e)
    {

        try
        {
            string isim = kitap_isim.Text;
            string resimyol = kitap_resimyolu.Text;
            string yayin = kitap_yayinevi.Text;
            int yazar_id = int.Parse(yazar.SelectedItem.Value);
            string aciklama = kitap_aciklama.Text;
            YoneticiIslemler.KitapGuncelle(int.Parse(Session["kitap_id"].ToString()), isim, resimyol, yazar_id, yayin, aciklama);

            Response.Redirect("KitapListeleme.aspx");
        }

        catch (Exception error)
        {
            errorlabel.Text = error.ToString();


        }


    }

    protected void resimyukle_Click(object sender, EventArgs e)
    {
        if (resim.HasFile)//Kullanıcı fileupload ile bir dosya seçmiş ise işlemleri gerçekleştir.
        {
            resim.SaveAs(Server.MapPath("~/kitapresimleri/") + resim.FileName);
            //Sunucuda ki resimler klasörünün içerisine resmi olduğu gibi yükledik.
            kitap_resimyolu.Text = "/kitapresimleri/" + resim.FileName;
        }
        else
            kitap_resimyolu.Text = "Lütfen bir dosya seçiniz.";


    }
}