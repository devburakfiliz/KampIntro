using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kurs1 = "yazılım geliştirici";
            //string kurs2 = "temel kurs";
            //string kurs3 = "java";

            string[] x = new string[] { "yazılım geliş","temel","java"};

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
            foreach (var kurs in x)
            {
                Console.WriteLine(kurs);

            }
        }
    }
}
