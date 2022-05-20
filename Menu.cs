using System;

namespace C__Directory
{
    static class Menu
    {
        static public void Mesaj() 
        //Nesne oluşturmadan çağırabilmek için static,
        //dışardan erişilebilmesi için public, 
        //değer döndümediği için void olarak açıldı.
        {
            Console.WriteLine("Telefon Rehberine Hoşgeldiniz! \n");
        }

        public static void MenuGoster()
        {
            Console.WriteLine("\nAşağıdaki İşlemleri Yapabilirsiniz!\n"); // \n bir satır boşluk bırakır.
            
            Console.WriteLine("[1] Yeni Kayıt Oluşur \n[2] Kayıt Sil \n[3] Kayıt Güncelle \n[4] Kayıtları Listele \n[5] Kayıt Ara \n[6] Ekranı Temizle");

        }
        
    }
}