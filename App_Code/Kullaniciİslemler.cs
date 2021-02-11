using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
/// <summary>
/// Summary description for Kullaniciİslemler
/// </summary>
public class Kullaniciİslemler
{
    static string db = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sony\Documents\Visual Studio 2015\WebSites\Kutuphanem\App_Data\kutuphane.mdf;Integrated Security=True;Connect Timeout=30";
    public Kullaniciİslemler()
    {
        
    }
    public static DataSet Giris(string k_ad, string pass)
    {
      
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = db;
        string sql = "select * from Kullanici where kullanici_kadi = '" + k_ad + "' AND kullanici_sifre='" + pass + "'";
        SqlCommand komut = new SqlCommand(sql, conn);
        DataSet kullanici = new DataSet();
      
        SqlDataAdapter adaptor = new SqlDataAdapter(komut);
        conn.Open();
        adaptor.Fill(kullanici);
        conn.Close();
        return kullanici;
    }
    public static void Kayit(string ad, string soyad, string kullaniciad, string pass, byte cinsiyet, DateTime dtarih, string resim)
    {
        SqlConnection conn = new SqlConnection(db);
        string sql = "insert into Kullanici(kullanici_adi,kullanici_soyadi,kullanici_kadi,kullanici_sifre,kullanici_cinsiyet,kullanici_dtarih,kullanici_resimyolu)";
        sql = sql + "values (@kullanici_adi,@kullanici_soyadi,@kullanici_kadi,@kullanici_sifre,@kullanici_cinsiyet,@kullanici_dtarih,@kullanici_resimyolu)";
        SqlCommand komut = new SqlCommand(sql, conn);
        komut.Parameters.AddWithValue("@kullanici_adi", ad);
        komut.Parameters.AddWithValue("@kullanici_soyadi", soyad);
        komut.Parameters.AddWithValue("@kullanici_kadi", kullaniciad);
        komut.Parameters.AddWithValue("@kullanici_sifre", pass);
        komut.Parameters.AddWithValue("@kullanici_cinsiyet", cinsiyet);
        komut.Parameters.AddWithValue("@kullanici_dtarih", dtarih);
        komut.Parameters.AddWithValue("@kullanici_resimyolu", resim);
        conn.Open();
        komut.ExecuteNonQuery();
        conn.Close();
    }
    public static void MesajEkle(int gonderen, int alan, string konu, string mesaj)
    {
        SqlConnection conn = new SqlConnection(db);
        string sql = "insert into Mesaj(mesaj_gonderenid,mesaj_gidenid,mesaj_baslik,mesaj_mesaj,mesaj_tarih)";
        sql = sql + "values (@mesaj_gonderenid,@mesaj_gidenid,@mesaj_baslik,@mesaj_mesaj,@mesaj_tarih)";
        SqlCommand komut = new SqlCommand(sql, conn);
        komut.Parameters.AddWithValue("@mesaj_gonderenid", gonderen);
        komut.Parameters.AddWithValue("@mesaj_gidenid", alan);
        komut.Parameters.AddWithValue("@mesaj_baslik", konu);
        komut.Parameters.AddWithValue("@mesaj_mesaj", mesaj);
        komut.Parameters.AddWithValue("@mesaj_tarih", DateTime.Now);
        
        conn.Open();
        komut.ExecuteNonQuery();
        conn.Close();
    }
    public static DataSet PopulerYazarlar()
    {
      
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = db;
        string sql = "select * from Yazar ORDER BY yazar_osayisi DESC";
        SqlCommand komut = new SqlCommand(sql, conn);
        DataSet popyazarlar = new DataSet();
      
        SqlDataAdapter adaptor = new SqlDataAdapter(komut);
        conn.Open();
        adaptor.Fill(popyazarlar);
        conn.Close();
        return popyazarlar;
    }
    public static DataSet PopulerKitaplar()
    {
      
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = db;
        string sql = "select * from Kitap  INNER JOIN Yazar ON Kitap.kitap_yazarid = Yazar.yazar_id ORDER BY kitap_okumasayisi DESC";
        SqlCommand komut = new SqlCommand(sql, conn);
        DataSet popkitaplar = new DataSet();
      
        SqlDataAdapter adaptor = new SqlDataAdapter(komut);
        conn.Open();
        adaptor.Fill(popkitaplar);
        conn.Close();
        return popkitaplar;
    }
    public static DataSet YazarKitaplar(int id)
    {
      
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = db;
        string sql = "select * from Kitap  INNER JOIN Yazar ON Kitap.kitap_yazarid = Yazar.yazar_id WHERE  kitap_yazarid = '" + id + "'";
        SqlCommand komut = new SqlCommand(sql, conn);
        DataSet yazarkitaplar = new DataSet();
      
        SqlDataAdapter adaptor = new SqlDataAdapter(komut);
        conn.Open();
        adaptor.Fill(yazarkitaplar);
        conn.Close();
        return yazarkitaplar;
    }
    public static DataSet YazarArama(string ad)
    {
      
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = db;
        string sql = "select * from Yazar where yazar_adi like '%" + ad + "%'";
        SqlCommand komut = new SqlCommand(sql, conn);
        DataSet yazarlarsearch = new DataSet();
      
        SqlDataAdapter adaptor = new SqlDataAdapter(komut);
        conn.Open();
        adaptor.Fill(yazarlarsearch);
        conn.Close();
        return yazarlarsearch;
    }
    public static DataSet KitapArama(string ad)
    {
      
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = db;
        string sql = "select * from Kitap  INNER JOIN Yazar ON Kitap.kitap_yazarid = Yazar.yazar_id where kitap_isim like '%" + ad + "%'";
        SqlCommand komut = new SqlCommand(sql, conn);
        DataSet kitapsearch = new DataSet();
      
        SqlDataAdapter adaptor = new SqlDataAdapter(komut);
        conn.Open();
        adaptor.Fill(kitapsearch);
        conn.Close();
        return kitapsearch;
    }
    public static DataSet KullaniciArama(string ad)
    {
      
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = db;
        string sql = "select * from Kullanici where kullanici_kadi like '%" + ad + "%'";
        SqlCommand komut = new SqlCommand(sql, conn);
        DataSet kullaniciarama = new DataSet();
      
        SqlDataAdapter adaptor = new SqlDataAdapter(komut);
        conn.Open();
        adaptor.Fill(kullaniciarama);
        conn.Close();
        return kullaniciarama;
    }
    public static DataSet KitapDetay(int id)
    {
      
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = db;
        string sql = "select * from Kitap  INNER JOIN Yazar ON Kitap.kitap_yazarid = Yazar.yazar_id  where kitap_id =" + id;
        SqlCommand komut = new SqlCommand(sql, conn);
        DataSet kitapdetail = new DataSet();
      
        SqlDataAdapter adaptor = new SqlDataAdapter(komut);
        conn.Open();
        adaptor.Fill(kitapdetail);
        conn.Close();
        return kitapdetail;
    }
    public static DataSet MesajGetir(int id)
    {
      
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = db;
        string sql = "select * from  Mesaj inner join Kullanici on Mesaj.mesaj_gonderenid=Kullanici.kullanici_id where mesaj_gidenid=" + id;
        SqlCommand komut = new SqlCommand(sql, conn);
        DataSet mesajlar = new DataSet();
      
        SqlDataAdapter adaptor = new SqlDataAdapter(komut);
        conn.Open();
        adaptor.Fill(mesajlar);
        conn.Close();
        return mesajlar;
    }
    public static DataSet MesajDetay(int id)
    {
      
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = db;
        string sql = "select * from  Mesaj inner join Kullanici on Mesaj.mesaj_gonderenid=Kullanici.kullanici_id where mesaj_id=" + id;
        SqlCommand komut = new SqlCommand(sql, conn);
        DataSet mesajlar = new DataSet();
      
        SqlDataAdapter adaptor = new SqlDataAdapter(komut);
        conn.Open();
        adaptor.Fill(mesajlar);
        conn.Close();
        return mesajlar;
    }
    public static DataSet KullaniciDetay(int id)
    {
      
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = db;
        string sql = "select * from Kullanici  where kullanici_id =" + id;
        SqlCommand komut = new SqlCommand(sql, conn);
        DataSet kullanicidetail = new DataSet();
      
        SqlDataAdapter adaptor = new SqlDataAdapter(komut);
        conn.Open();
        adaptor.Fill(kullanicidetail);
        conn.Close();
        return kullanicidetail;
    }
    public static DataSet Kitapİncelemeler(int id)
    {
      
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = db;
        string sql = "select * from Kitapİnceleme  INNER JOIN Kullanici ON Kitapİnceleme.inceleme_kullaniciid = Kullanici.kullanici_id  where inceleme_kitapid =" + id;
        SqlCommand komut = new SqlCommand(sql, conn);
        DataSet kitapinc = new DataSet();
      
        SqlDataAdapter adaptor = new SqlDataAdapter(komut);
        conn.Open();
        adaptor.Fill(kitapinc);
        conn.Close();
        return kitapinc;
    }
    public static DataSet KullaniciKitapİncelemeler(int id)
    {
      
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = db;
        string sql = "select * from Kitapİnceleme  INNER JOIN Kullanici ON Kitapİnceleme.inceleme_kullaniciid = Kullanici.kullanici_id INNER JOIN Kitap ON Kitapİnceleme.inceleme_kitapid = Kitap.kitap_id  where kullanici_id =" + id;
        SqlCommand komut = new SqlCommand(sql, conn);
        DataSet kki = new DataSet();
      
        SqlDataAdapter adaptor = new SqlDataAdapter(komut);
        conn.Open();
        adaptor.Fill(kki);
        conn.Close();
        return kki;
    }
    public static DataSet KitapAlintilar(int id)
    {
      
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = db;
        string sql = "select * from KitapAlinti  INNER JOIN Kullanici ON KitapAlinti.alinti_kullaniciid = Kullanici.kullanici_id   where alinti_kitapid =" + id;
        SqlCommand komut = new SqlCommand(sql, conn);
        DataSet alintilar = new DataSet();
      
        SqlDataAdapter adaptor = new SqlDataAdapter(komut);
        conn.Open();
        adaptor.Fill(alintilar);
        conn.Close();
        return alintilar;
    }
    public static DataSet KullaniciKitapAlintilar(int id)
    {
      
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = db;
        string sql = "select * from KitapAlinti  INNER JOIN Kullanici ON KitapAlinti.alinti_kullaniciid = Kullanici.kullanici_id INNER JOIN Kitap ON KitapAlinti.alinti_kitapid = Kitap.kitap_id where kullanici_id =" + id;
        SqlCommand komut = new SqlCommand(sql, conn);
        DataSet kka = new DataSet();
      
        SqlDataAdapter adaptor = new SqlDataAdapter(komut);
        conn.Open();
        adaptor.Fill(kka);
        conn.Close();
        return kka;
    }
    public static DataSet KullaniciVerdigiPuan(int id)
    {
      
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = db;
        string sql = "select * from KitapPuan  INNER JOIN Kullanici ON KitapPuan.puan_kullaniciid = Kullanici.kullanici_id INNER JOIN Kitap ON KitapPuan.puan_kitapid = Kitap.kitap_id where kullanici_id =" + id;
        SqlCommand komut = new SqlCommand(sql, conn);
        DataSet puan = new DataSet();
      
        SqlDataAdapter adaptor = new SqlDataAdapter(komut);
        conn.Open();
        adaptor.Fill(puan);
        conn.Close();
        return puan;
    }
    public static DataSet KullaniciOkunanKitaplar(int id)
    {
      
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = db;
        string sql = "SELECT * FROM dbo.KitapOkunma INNER JOIN dbo.Kitap ON Kitap.kitap_id = KitapOkunma.okunma_kitapid INNER JOIN dbo.Kullanici ON Kullanici.kullanici_id = KitapOkunma.okunma_kullaniciid WHERE kullanici_id=" + id;
        SqlCommand komut = new SqlCommand(sql, conn);
        DataSet kko = new DataSet();
      
        SqlDataAdapter adaptor = new SqlDataAdapter(komut);
        conn.Open();
        adaptor.Fill(kko);
        conn.Close();
        return kko;
    }
    public static void İncelemeEkle(int kullanici, int kitap, string inceleme)
    {
        SqlConnection conn = new SqlConnection(db);
        string sql = "insert into Kitapİnceleme(inceleme_kullaniciid,inceleme_kitapid,inceleme_inceleme)";
        sql = sql + "values (@inceleme_kullaniciid,@inceleme_kitapid,@inceleme_inceleme)";
        SqlCommand komut = new SqlCommand(sql, conn);
        komut.Parameters.AddWithValue("@inceleme_kullaniciid", kullanici);
        komut.Parameters.AddWithValue("@inceleme_kitapid", kitap);
        komut.Parameters.AddWithValue("@inceleme_inceleme", inceleme);
        conn.Open();
        komut.ExecuteNonQuery();
        conn.Close();
    }
    public static void AlintiEkle(int kullanici, int kitap, string alinti, int sayfa)
    {
        SqlConnection conn = new SqlConnection(db);
        string sql = "insert into KitapAlinti(alinti_kullaniciid,alinti_kitapid,alinti_cumle,alinti_sayfa)";
        sql = sql + "values (@alinti_kullaniciid,@alinti_kitapid,@alinti_cumle,@alinti_sayfa)";
        SqlCommand komut = new SqlCommand(sql, conn);
        komut.Parameters.AddWithValue("@alinti_kullaniciid", kullanici);
        komut.Parameters.AddWithValue("@alinti_kitapid", kitap);
        komut.Parameters.AddWithValue("@alinti_cumle", alinti);
        komut.Parameters.AddWithValue("@alinti_sayfa", sayfa);
        conn.Open();
        komut.ExecuteNonQuery();
        conn.Close();
    }
    public static void OkudumEkle(int kullanici, int kitap, int yazar)
    {
        SqlConnection conn = new SqlConnection(db);
        string sql = "insert into KitapOkunma(okunma_kullaniciid,okunma_kitapid)";
        sql = sql + "values (@okunma_kullaniciid,@okunma_kitapid)";
        SqlCommand komut = new SqlCommand(sql, conn);
        komut.Parameters.AddWithValue("@okunma_kullaniciid", kullanici);
        komut.Parameters.AddWithValue("@okunma_kitapid", kitap);
        conn.Open();
        komut.ExecuteNonQuery();
        conn.Close();
        string sqla = "update Kitap set kitap_okumasayisi = kitap_okumasayisi+1 where kitap_id=" + kitap;
        SqlCommand komuta = new SqlCommand(sqla, conn);
        conn.Open();
        komuta.ExecuteNonQuery();
        conn.Close();
        string sqlb = "update Yazar set yazar_osayisi = yazar_osayisi+1 where yazar_id=" + yazar;
        SqlCommand komutb = new SqlCommand(sqlb, conn);
        conn.Open();
        komutb.ExecuteNonQuery();
        conn.Close();
    }
    public static void PuanVer(int kullanici, int kitap, int puan)
    {
        SqlConnection conn = new SqlConnection(db);
        string sql = "insert into KitapPuan(puan_kullaniciid,puan_kitapid,puan_puan)";
        sql = sql + "values (@okunma_kullaniciid,@okunma_kitapid,@puan_puan)";
        SqlCommand komut = new SqlCommand(sql, conn);
        komut.Parameters.AddWithValue("@okunma_kullaniciid", kullanici);
        komut.Parameters.AddWithValue("@okunma_kitapid", kitap);
        komut.Parameters.AddWithValue("@puan_puan", puan);
        conn.Open();
        komut.ExecuteNonQuery();
        conn.Close();
    }
    public static int OkudumKontrol(int kullanici, int kitap)
    {
      
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = db;
        string sql = "select COUNT(*) from KitapOkunma where okunma_kullaniciid = " + kullanici + " AND okunma_kitapid=" + kitap + "";
        SqlCommand komut = new SqlCommand(sql, conn);
        conn.Open();
        Int32 count = (Int32)komut.ExecuteScalar();
        conn.Close();
        return count;
    }
    public static int OrtalamaPuan(int kitap)
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = db;
        string sqlA = "select COUNT(*) from KitapPuan where puan_kitapid=" + kitap;
        SqlCommand komutA = new SqlCommand(sqlA, conn);
        conn.Open();
        Int32 countA = (Int32)komutA.ExecuteScalar();
        conn.Close();
        if (countA > 0)
        {
            string sql = "select AVG(puan_puan) from KitapPuan where puan_kitapid=" + kitap;
            SqlCommand komut = new SqlCommand(sql, conn);
            conn.Open();
            Int32 count = (Int32)komut.ExecuteScalar();
            conn.Close();
            return count;
        }
        else
        {
            return 0;
        }
    }
    public static DataSet EnYuksekPuan()
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = db;
        string sql = "select AVG(puan_puan) as ortalama,kitap_isim,kitap_id,kitap_resimyolu,kitap_yayinevi,kitap_okumasayisi from KitapPuan  INNER JOIN Kitap ON KitapPuan.puan_kitapid = Kitap.kitap_id GROUP BY Kitap.kitap_id,kitap_isim,kitap_resimyolu,kitap_yayinevi,kitap_okumasayisi ORDER BY ortalama DESC ";
        SqlCommand komut = new SqlCommand(sql, conn);
        DataSet hitpuan = new DataSet();
      
        SqlDataAdapter adaptor = new SqlDataAdapter(komut);
        conn.Open();
        adaptor.Fill(hitpuan);
        conn.Close();
        return hitpuan;
    }
    public static DataSet Oneri1(int id)
    {
      
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = db;
        string sql = "SELECT kullanici_id, kullanici_adi,kullanici_soyadi, COUNT(*) AS ortak FROM dbo.KitapOkunma INNER JOIN dbo.Kullanici ON Kullanici.kullanici_id = KitapOkunma.okunma_kullaniciid WHERE okunma_kitapid IN (SELECT okunma_kitapid FROM dbo.KitapOkunma WHERE okunma_kullaniciid=" + id + " ) AND okunma_kullaniciid!=" + id + "   GROUP BY kullanici_id,kullanici_adi,kullanici_soyadi";
        SqlCommand komut = new SqlCommand(sql, conn);
        DataSet on1 = new DataSet();
      
        SqlDataAdapter adaptor = new SqlDataAdapter(komut);
        conn.Open();
        adaptor.Fill(on1);
        conn.Close();
        return on1;
    }
    public static DataSet Oneri2(int id)
    {
      
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = db;
        string sql = "SELECT kullanici_id, kullanici_adi,kullanici_soyadi, COUNT(*)  AS ortak  FROM dbo.KitapPuan A INNER JOIN dbo.Kullanici ON Kullanici.kullanici_id = A.puan_kullaniciid  WHERE  EXISTS (SELECT puan_kitapid FROM dbo.KitapPuan B WHERE puan_kullaniciid=" + id + " AND A.puan_kitapid=B.puan_kitapid AND  A.puan_puan=B.puan_puan  ) AND puan_kullaniciid!=" + id + "   GROUP BY kullanici_id,kullanici_adi,kullanici_soyadi";
        SqlCommand komut = new SqlCommand(sql, conn);
        DataSet on2 = new DataSet();
      
        SqlDataAdapter adaptor = new SqlDataAdapter(komut);
        conn.Open();
        adaptor.Fill(on2);
        conn.Close();
        return on2;
    }
}