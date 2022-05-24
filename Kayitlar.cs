using System;
using System.Collections;
using System.Collections.Generic;


namespace C__Directory
{
    static class Kayitlar
    {
        public static List<KayitVarlik> kayitListe;
        static Kayitlar()
        {
            kayitListe = new List<KayitVarlik>();

            KayitVarlik kayit1 = new KayitVarlik(("Candan", "Sumaktaş", "123"));
            KayitVarlik kayit2 = new KayitVarlik(("Oğuzhan", "Yalçınkaya", "456"));
            KayitVarlik kayit3 = new KayitVarlik(("Batuhan", "Ayçiçek","789"));
            KayitVarlik kayit4 = new KayitVarlik(("Ebru", "Arslan", "135"));
            KayitVarlik kayit5 = new KayitVarlik(("Emin", "Meral","246"));

            Kayitİslemleri.Ekle(kayit1); 
            Kayitİslemleri.Ekle(kayit2);
            Kayitİslemleri.Ekle(kayit3);
            Kayitİslemleri.Ekle(kayit4);
            Kayitİslemleri.Ekle(kayit5);
        }       
    }
}