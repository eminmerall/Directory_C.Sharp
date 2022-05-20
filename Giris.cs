using System;

namespace C__Directory
{
    static class Giris
    {
        static public int IntGiris(string mesaj)
        {
            Console.Write(mesaj +": "); //mesaj değişkeni, MenuGiris metodundan geliyor, : mesajdan sonra ekleniyor.
            try
            {           
                return Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("Lütfen geçerli bir cevap girin");
                return -1;
            }
        }

         static public bool MenuGiris()
        {
            int islem = IntGiris("Lütfen Yapacağınız İşlemi Seçin"); // IntKontrol den gelen veriyi değişkene atıyor. Atamadan IntKontrol Metodunu çalıştırıyor.
            IslemCagir(islem); //is
            return true;
        }

        static private void IslemCagir(int i)
        {
            switch (i)
            {
                case 1:
                    Islemler.KayitOlustur();
                    break;
                case 2:
                    Islemler.KayitSil();
                    break;
                case 3:
                    Islemler.KayitGuncelle();
                    break;
                case 4:
                    Islemler.KayitListele();
                    break;
                case 6:
                    Console.Clear();
                    break;
            }
        }

        static public string StringGiris(string mesaj) //Kayıt, sil vb işlemleri için girdi alma
        {
            Console.Write(mesaj+": "); //mesaj değişkeni, MenuGiris metodundan geliyor, : mesajdan sonra ekleniyor.
            return Console.ReadLine();
        }
    }

}
