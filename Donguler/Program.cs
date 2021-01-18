using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kurs1 = "yazılım geliştirici kampı";
            //string kurs2 = "başlangıç temel kursu";
            //string kurs3 = "java kampı";
            //Console.WriteLine(kurs1);

            string[] kurslar = new string[] { "yazılım geliştirici kampı", "başlangıç temel kursu", "java kampı","python","c#"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]); 
            }
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu-footer");
        }
    }
}
