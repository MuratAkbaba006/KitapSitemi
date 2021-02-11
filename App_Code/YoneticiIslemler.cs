using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


/// <summary>
/// Summary description for YoneticiIslemler
/// </summary>
public class YoneticiIslemler
{//Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\Users\sony\Documents\Visual Studio 2015\WebSites\Kutuphanem\App_Data\kutuphane.mdf";Integrated Security=True
    static string db = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sony\Documents\Visual Studio 2015\WebSites\Kutuphanem\App_Data\kutuphane.mdf;Integrated Security=True;Connect Timeout=30";

    public static void YazarEkle(string ad, string soyad, string dyeri, DateTime dtarih, DateTime? otarih)
    {
        SqlConnection conn = new SqlConnection(db);
        string sql = "insert into Yazar(yazar_adi,yazar_soyadi,yazar_dyeri,yazar_dtarih,yazar_ötarih,yazar_osayisi)";
        sql = sql + "values (@yazar_adi,@yazar_soyadi,@yazar_dyeri,@yazar_dtarih,@yazar_ötarih,@yazar_osayisi)";
        SqlCommand komut = new SqlCommand(sql, conn);
        komut.Parameters.AddWithValue("@yazar_adi", ad);
        komut.Parameters.AddWithValue("@yazar_soyadi", soyad);
        komut.Parameters.AddWithValue("@yazar_dyeri", dyeri);
        komut.Parameters.AddWithValue("@yazar_dtarih", dtarih);
        komut.Parameters.AddWithValue("@yazar_ötarih", otarih ?? (object)DBNull.Value);
        komut.Parameters.AddWithValue("@yazar_osayisi", 0);
        conn.Open();
        komut.ExecuteNonQuery();
        conn.Close();



    }
    public static DataSet YazarListe()
    {
        
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = db;
      
        string sql = "select * from Yazar";


        SqlCommand komut = new SqlCommand(sql, conn);

        
        DataSet yazarlar = new DataSet();

        SqlDataAdapter adaptor = new SqlDataAdapter(komut);
        conn.Open();
        adaptor.Fill(yazarlar);
        conn.Close();
        return yazarlar;
    }
    public static void KitapEkle(string isim, string resimyol, int yazar, string yayinev, string aciklama)
    {
        SqlConnection conn = new SqlConnection(db);
        string sql = "insert into Kitap(kitap_isim,kitap_resimyolu,kitap_yazarid,kitap_yayinevi,kitap_aciklama,kitap_okumasayisi)";
        sql = sql + "values (@kitap_isim,@kitap_resimyolu,@kitap_yazarid,@kitap_yayinevi,@kitap_aciklama,@kitap_okumasayisi)";
        SqlCommand komut = new SqlCommand(sql, conn);
        komut.Parameters.AddWithValue("@kitap_isim", isim);
        komut.Parameters.AddWithValue("@kitap_resimyolu", resimyol);
        komut.Parameters.AddWithValue("@kitap_yazarid", yazar);
        komut.Parameters.AddWithValue("@kitap_yayinevi", yayinev);
        komut.Parameters.AddWithValue("@kitap_aciklama", aciklama);
        komut.Parameters.AddWithValue("@kitap_okumasayisi", 0);
        conn.Open();
        komut.ExecuteNonQuery();
        conn.Close();



    }

    public static void KitapGuncelle(int kitap_id, string isim, string resimyol, int yazar, string yayinev, string aciklama)
    {

        SqlConnection conn = new SqlConnection(db);
        string sql = "update Kitap set kitap_isim = @kitap_isim , kitap_resimyolu = @kitap_resimyolu , kitap_yazarid = @kitap_yazarid , kitap_yayinevi = @kitap_yayinevi, kitap_aciklama = @kitap_aciklama where kitap_id= @pid";
        SqlCommand komut = new SqlCommand(sql, conn);
        komut.Parameters.AddWithValue("@kitap_isim", isim);
        komut.Parameters.AddWithValue("@kitap_resimyolu", resimyol);
        komut.Parameters.AddWithValue("@kitap_yazarid", yazar);
        komut.Parameters.AddWithValue("@kitap_yayinevi", yayinev);
        komut.Parameters.AddWithValue("@kitap_aciklama", aciklama);
        komut.Parameters.AddWithValue("@pid", kitap_id);
        conn.Open();
        komut.ExecuteNonQuery();
        conn.Close();

    }

    public static void KitapSil(int kitap_id)
    {
        SqlConnection conn = new SqlConnection(db);

        string sql1 = "delete from KitapAlinti where alinti_kitapid =" + kitap_id;

        SqlCommand komut1 = new SqlCommand(sql1, conn);

        conn.Open();

        komut1.ExecuteNonQuery();

        conn.Close();


        string sql2 = "delete from Kitapİnceleme where inceleme_kitapid=" + kitap_id;

        SqlCommand komut2 = new SqlCommand(sql2, conn);

        conn.Open();

        komut2.ExecuteNonQuery();

        conn.Close();


        string sql3 = "delete from KitapOkunma where okunma_kitapid=" + kitap_id;

        SqlCommand komut3 = new SqlCommand(sql3, conn);

        conn.Open();

        komut3.ExecuteNonQuery();

        conn.Close();


        string sql4 = "delete from KitapPuan where puan_kitapid=" + kitap_id;

        SqlCommand komut4 = new SqlCommand(sql4, conn);

        conn.Open();

        komut4.ExecuteNonQuery();

        conn.Close();



        string sql = "delete from Kitap where kitap_id =" + kitap_id;

        SqlCommand komut = new SqlCommand(sql, conn);

        conn.Open();

        komut.ExecuteNonQuery();

        conn.Close();



    }

    public static DataSet KitapListe()
    {

        
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = db;
   
        string sql = "select * from Kitap INNER JOIN Yazar ON Kitap.kitap_yazarid = Yazar.yazar_id";

        SqlCommand komut = new SqlCommand(sql, conn);

        
        DataSet kitaplar = new DataSet();
        
        SqlDataAdapter adaptor = new SqlDataAdapter(komut);
        conn.Open();
        adaptor.Fill(kitaplar);
        conn.Close();
        return kitaplar;
    }

    public static DataSet KitapGetir(int kitap_id)
    {

        
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = db;

        string sql = "select * from Kitap where kitap_id =" + kitap_id;

      
        SqlCommand komut = new SqlCommand(sql, conn);


        DataSet kitapg = new DataSet();

        SqlDataAdapter adaptor = new SqlDataAdapter(komut);
        conn.Open();
        adaptor.Fill(kitapg);
        conn.Close();
        return kitapg;
    }

    public static int YoneticiGiris(string k_ad, string pass)
    {

     
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = db;
     
        string sql = "select COUNT(*) from Yonetici where yonetici_kadi = '" + k_ad + "' AND yonetici_sifre='" + pass + "'";


        SqlCommand komut = new SqlCommand(sql, conn);



        conn.Open();
        Int32 count = (Int32)komut.ExecuteScalar();
        conn.Close();
        return count;
    }
    public YoneticiIslemler()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}