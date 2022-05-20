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

            Kayitlar.Ekle(new KayitVarlik((ad, soyad, numara)));
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

    }
}