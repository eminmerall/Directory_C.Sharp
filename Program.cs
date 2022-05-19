using System;

namespace C__Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.Mesaj();

            Menu.MenuGoster();

            while(true)
            {
                Giris.MenuGiris();
            }            
        }
    }
}
