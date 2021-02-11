using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Giris : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void giris_Click(object sender, EventArgs e)
    {
        if (YoneticiIslemler.YoneticiGiris(k_ad.Text, pass.Text) > 0)
        {
            Response.Redirect("KitapListeleme.aspx");


        }
        

    }
}