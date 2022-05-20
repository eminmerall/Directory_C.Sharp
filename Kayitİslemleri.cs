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
            if(Giris.StringGiris($"{p.Adi} siliniyor emin misiniz? Evet = 1, Hayır = 0").ToLower() == "1")
            {
                Kayitlar.kayitListe.Remove(p);
            }
        }
    }
}