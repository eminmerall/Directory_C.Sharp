using System;


namespace C__Directory
{
    class Kayitİslemleri
    {
        static public void Ekle(KayitVarlik p)
        {
            Kayitlar.kayitListe.Add(p);
        }

        static public void Sil(KayitVarlik p)
        {
            if(Giris.StringGiris($"{p.Adi} siliniyor emin misiniz? Evet = 1").ToLower() == "1")
            {
                Kayitlar.kayitListe.Remove(p);
                Console.WriteLine("\nKayıt Silindi!");
            }
            else
                Console.WriteLine("\nİşlem İptal Edildi");
        }

        static public void Guncelle(KayitVarlik p, int konum)
        {
            if(Giris.StringGiris("Kayıt güncellenecek emin misiniz? Evet = 1").ToLower() == "1")
            {
                Kayitlar.kayitListe[konum] = p;
                Console.WriteLine("\nKayıt Güncellendi!");
            }
            else
                Console.WriteLine("\nİşlem İptal Edildi");
        }
    }
}