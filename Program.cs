using System;

namespace C__Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.Mesaj();

            Console.WriteLine("Program Başlatıldı");

            while(true)
            {
                Menu.MenuGoster();

                Giris.MenuGiris();
            }            
        }
    }
}
