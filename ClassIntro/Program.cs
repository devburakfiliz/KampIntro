using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C++";
            kurs1.Egitmen = "burak";
            kurs1.IzlenmeOrani = 68;
            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "ceren";
            kurs2.IzlenmeOrani = 77;
            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C+";
            kurs3.Egitmen = "ali";
            kurs3.IzlenmeOrani = 48;


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+" "+kurs.Egitmen+" "+kurs.IzlenmeOrani);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
