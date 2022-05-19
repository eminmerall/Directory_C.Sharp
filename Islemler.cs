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
            foreach (var item in Kayitlar.kayitListe)
            {
                Console.WriteLine("-- " + item.Adi + " \t| " + item.Soyadi + " \t| " + item.Telefon);
            }
        }

    }
}