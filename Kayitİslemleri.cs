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
            if(Giris.StringGiris($"{p.Adi} siliniyor emin misiniz? Evet = 1") == "1")
            {
                Kayitlar.kayitListe.Remove(p);
            }
            else
                Console.WriteLine("\nİşlem İptal Edildi");
        }

        static public void Guncelle(KayitVarlik p, int konum)
        {
            if(Giris.StringGiris("Kayıt güncellenecek emin misiniz? Evet = 1") == "1")
            {
                Kayitlar.kayitListe[konum] = p;
            }
            else
                Console.WriteLine("\nİşlem İptal Edildi");
        }
    }
}