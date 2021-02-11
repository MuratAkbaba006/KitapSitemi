using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Chats : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["kullanici_id"] == null)
        {

            Response.Redirect("Giris.aspx");
        }

     
        int kullanici_id = int.Parse(Session["kullanici_id"].ToString());
        DataSet yazarlar = Kullaniciİslemler.MesajGetir(kullanici_id);

        mesajlar.DataSource = yazarlar.Tables[0];
        mesajlar.DataBind();

    }

    protected void detay_Command(object sender, CommandEventArgs e)
    {
        Session["mesaj_id"] = e.CommandArgument.ToString();
        Response.Redirect("ChatDetail.aspx");
    }
}