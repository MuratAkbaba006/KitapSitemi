using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HitKitaplar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet yazarlar = Kullaniciİslemler.EnYuksekPuan();

        kitaplarim.DataSource = yazarlar.Tables[0];
        kitaplarim.DataBind();

    }
}