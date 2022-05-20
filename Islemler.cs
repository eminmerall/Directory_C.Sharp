using System;

namespace C__Directory
{
    static class Islemler
    {
        static public void KayitOlustur()
        {
            string ad = Giris.StringGiris("Adı"); 
            string soyad = Giris.StringGiris("Soyadı");
            string numara = Giris.StringGiris("Telefon");

            Kayitİslemleri.Ekle(new KayitVarlik((ad, soyad, numara)));
        }

        static public void KayitListele()
        {
            Console.Clear();
            Console.WriteLine("Telefon Rehberi \n");
            Console.WriteLine("********************************************** \n");
            foreach (var item in Kayitlar.kayitListe)
            {
                Console.WriteLine("Adı: {0} \nSoyadı: {1} \nNumarası: {2}",item.Adi,item.Soyadi,item.Telefon);
                Console.WriteLine("--");
            }
        }

        static public bool KayitSil()
        {
            string girdi = Giris.StringGiris("Silincek Kullanıcı Adı veya Soyadı: ");
            int konum = KayitVarMi(girdi);
            if(konum == -1)
            {
                return false;
            }
            KayitVarlik kayit = Kayitlar.kayitListe[konum];
            Console.Clear();
            Console.WriteLine($"\n Silinecek Kayıt: {kayit.Adi} {kayit.Soyadi} {kayit.Telefon} ");
            Kayitİslemleri.Sil(kayit);
            return true;

        }
        
        static private int KayitVarMi(string girdi)
        {
            foreach (var kayit in Kayitlar.kayitListe)
            {
                if( kayit.Adi.ToLower() == girdi.ToLower() || kayit.Soyadi.ToLower() == girdi.ToLower() || (kayit.Adi + kayit.Soyadi).ToLower() == girdi.Replace(" ","").ToLower() )
                {
                    return Kayitlar.kayitListe.IndexOf(kayit);
                }
            }
            Console.WriteLine("\n {0} bulunamadı \n",girdi);
            return -1;
        }   
    }
}