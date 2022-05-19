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
            Console.WriteLine("Kayıtlar:");
            Console.WriteLine("Ad " + " " + " \t| Soyad " + " " + " \t| Telefon " + " ");
            foreach (var item in Kayitlar.kayitListe)
            {
                //Console.WriteLine("\"" + item.Adi + "\"" + ", " + "\"" + item.Soyadi + "\"" + ", " + "\"" + item.Telefon + "\"");
                Console.WriteLine("Adı: " + item.Adi + " \t| Soyadı: " + item.Soyadi + " \t| Telefon: " + item.Telefon);
            }
        }

    }
}