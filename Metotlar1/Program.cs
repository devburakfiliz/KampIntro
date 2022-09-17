using System;

namespace Metotlar1
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi+ "  "+urun.Fiyati+ "  "+urun.Aciklama);
            }



            Console.WriteLine("-----Metotlar --------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("ARMUT", "YEŞİL ARMUT", 18,11);
            sepetManager.Ekle2("AYVA", "YEŞİL AYVA", 12,12);

            sepetManager.Ekle2("NAR", "NAR ", 28,15);

        }
    }
}
