using System;

namespace C__Directory
{
    class KayitVarlik
    {
        public KayitVarlik((string, string, string) p)
        {
            Adi = p.Item1;
            Soyadi = p.Item2;
            Telefon = p.Item3;
        }

        private string adi;
        public string Adi{ get => adi; set => adi = value; }

        private string soyadi;
        public string Soyadi{ get => soyadi; set => soyadi = value; }

        private string telefon;
        public string Telefon{ get=> telefon; set => telefon = value; }

    }
}