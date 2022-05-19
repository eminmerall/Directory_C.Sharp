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

            Console.WriteLine("\"" + ad + "\"" + ", " + "\"" + soyad + "\"" + ", " + "\"" + numara + "\"");  // /" tırnak işareti yazdırmak için kullanılır.
        }

    }
}