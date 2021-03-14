using System;

namespace Doguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirme";
            string kurs2 = "Programlamaya Giriş";
            string kurs3 = "Java Kursu";

            //array diziler aşşagıdaki gibi tanımlanır.
            string[] kurslar = new string[] {kurs1,kurs2,kurs3};
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");
            foreach (string kurs in kurslar)//dizilere uygulanır kursları dolaş
            {
                Console.WriteLine(kurs);
            }


           for (int i = 1; i <= 2; i+=1) // Döngüler 
            
            {
                Console.WriteLine(i);
            }
        }
    }
}
