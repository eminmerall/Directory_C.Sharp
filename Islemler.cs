using System;

namespace C__Directory
{
    static class Islemler
    {
        static private int KayitVarMi(string girdi)
        {
            foreach (var kayit in Kayitlar.kayitListe)
            {
                if( kayit.Adi.ToLower() == girdi.ToLower() || kayit.Soyadi.ToLower() == girdi.ToLower() || (kayit.Adi + kayit.Soyadi).ToLower() == girdi.Replace(" ","").ToLower() )
                {
                    return Kayitlar.kayitListe.IndexOf(kayit);
                }
            }
            Console.WriteLine("\n{0} bulunamadı \n",girdi);
            return -1;
        }

        static public void KayitOlustur()
        {
            Console.Clear();
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
            string girdi = Giris.StringGiris("Silincek Kullanıcının Adı veya Soyadı: ");
            int konum = KayitVarMi(girdi);
            if(konum == -1)
            {
                return false;
            }
            
            Console.Clear();
            KayitVarlik kayit = Kayitlar.kayitListe[konum];
            Console.WriteLine($"\nSilinecek Kayıt: {kayit.Adi} {kayit.Soyadi} {kayit.Telefon} ");
            Kayitİslemleri.Sil(kayit);
            return true;

        }

        static public bool KayitGuncelle()
        {
            string girdi = Giris.StringGiris("Güncellenecek kaydın adı veya soyadı");
            int konum = KayitVarMi(girdi);
            if(konum==-1)
            {
                return false;
            }

            Console.Clear();
            KayitVarlik kayit = Kayitlar.kayitListe[konum];
            Console.WriteLine($"\nGüncellenecek Kayıt: {kayit.Adi} {kayit.Soyadi} {kayit.Telefon} ");

            string ad = Giris.StringGiris("Yeni adı girin: ");
            string soyad = Giris.StringGiris("Yeni soyadı girin: ");
            string numara = Giris.StringGiris("Yeni telefonu girin: ");

            Kayitİslemleri.Guncelle(new KayitVarlik((ad, soyad, numara)),konum);
            return true;
        }

        static public bool KayitAra()
        {
            Console.Clear();
            string ara = "";
            while (true)
            {
                int girdi = Giris.IntGiris("[1] Ada Göre Ara \n[2] Soyada Göre Ara \n[3] İşlemi İptal Et \nYapacağınız İşlem: ");

                if(girdi==1)
                {
                    ara = Giris.StringGiris("Aranacak Kişinin Adı");
                    break;
                }
                else if(girdi==2)
                {
                    ara = Giris.StringGiris("Aranacak Kişinin Soyadı");
                    break;
                }
                else if(girdi==3)
                {
                    return false;
                }
                Console.WriteLine("Lütfen Geçerli Bir Cevap Girin!");
            }
            
            int konum = KayitVarMi(ara);
            if(konum==-1)
            {
                return false;
            }

            KayitVarlik kayit = Kayitlar.kayitListe[KayitVarMi(ara)];
            Console.WriteLine("\nAranan Kullanıcı: ");
            Console.WriteLine("Adı: {0} \nSoyadı: {1} \nTelefonu:{2}", kayit.Adi, kayit.Soyadi, kayit.Telefon);
            return true;
        }
        

           
    }
}