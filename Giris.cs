using System;

namespace C__Directory
{
    static class Giris
    {
         static public bool MenuGiris()
        {
            int input = IntKontrol("Lütfen Yapacağınız İşlemi Seçin");
            CallOperation(input);
            return true;
        }
        
        static public int IntKontrol(string mesaj)
        {
            Console.Write(mesaj +": ");
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

        /*static public string StringGiris(string mesaj)
        {
            Console.Write(mesaj +": ");
            return Console.ReadLine();
        }*/

        static private void CallOperation(int i)
        {
            switch (i)
            {
                case 1:
                    Console.WriteLine("Bir");
                    break;
                case 2:
                    Console.WriteLine("İki");
                    break;
                case 3:
                    Console.WriteLine("Üç");
                    break;
                case 4:
                    Console.WriteLine("Dört");
                    break;
                case 5:
                    Console.WriteLine("Beş");
                    break;
            }
        }
    }

}
