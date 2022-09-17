using System;

namespace daytwohomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Product u1 = new Product();
            u1.UrunAdi = "Bilgisayar";
            u1.Fiyat = 5490;
            u1.Stok = 20;
            Product u2 = new Product();
            u2.UrunAdi = "Telefon";
            u2.Fiyat = 4566;
            u2.Stok = 5;
            Product u3 = new Product();
            u3.UrunAdi = "tablet";
            u3.Fiyat = 1090;
            u3.Stok = 50;
            Product u4 = new Product();
            u4.UrunAdi = "çaycı";
            u4.Fiyat = 7766;
            u4.Stok = 25;

            Product[] x = new Product[] { u1, u2, u3, u4 };
            foreach (var item in x)
            {
                Console.WriteLine(item.UrunAdi + "  " + item.Fiyat + "  " + item.Stok);
            }

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i].UrunAdi+"  "+x[i].Fiyat+"  "+x[i].Stok);
                
            }

            int a = 0;
            while (a<x.Length)
            {
                Console.WriteLine(x[a].UrunAdi + "  " + x[a].Fiyat + "  " + x[a].Stok);
                a++;

            }

        }
    }

    class Product
    {
        public string UrunAdi { get; set; }
        public float Fiyat { get; set; }
        public int Stok { get; set; }


    }

}
