using System;


namespace C__Directory
{
    class Kayitİslemleri
    {
        static public void Ekle(KayitVarlik p)
        {
            Kayitlar.kayitListe.Add(p);
        }

        static public bool Sil(KayitVarlik p)
        {
            while(true)
            {
                int onay = Giris.IntGiris("\nayıt siliniyor emin misiniz? Onayla = 1, İptal = 2");
                if(onay==1)
                {
                    Kayitlar.kayitListe.Remove(p);
                    Console.WriteLine("\nKayıt silindi!");
                    return true;
                }
                else if(onay==2)
                {
                    Console.WriteLine("\nİşlem iptal edildi");
                    return true;
                }
                Console.WriteLine("\nLütfen geçerli bir cevap girin!");
            }
        }

        static public bool Guncelle(KayitVarlik p, int konum)
        {
            int onay = Giris.IntGiris("Kayıt güncellenecek emin misiniz? Evet = 1, İptal =2");
            while(true)
            {
                if(onay == 1)
                {
                    Kayitlar.kayitListe[konum] = p;
                    Console.WriteLine("\nKayıt Güncellendi!");
                    return true;
                }
                else if(onay==2)
                {
                    Console.WriteLine("\nİşlem İptal Edildi");
                    return true;
                }                    
                Console.WriteLine("\nLütfen geçerli bir cevap girin!");
            }
        }
    }
}
