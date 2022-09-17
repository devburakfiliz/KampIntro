using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("AZALIŞ");


            }else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("ARTIŞ");
            }
            else
            {
                Console.WriteLine("EŞİT");
            }

            if (sistemeGirisYapmisMi== true)
            {
                Console.WriteLine("SANADA GİREN GİRENE");
            }
            else
            {
                Console.WriteLine("Giriş yap");
            }

               
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
