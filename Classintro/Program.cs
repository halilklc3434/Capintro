using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Kurs kurs1 = new Kurs();//class tanımlamak için bun yapmak gerekiyor.(int gibi ama yeni bir kendi clasımız.
            kurs1.Kursadi = "c#";
            kurs1.KursunEgitmeni = "Halil Kilic";
            kurs1.Kursunizlenmeorani = 68;

            Kurs kurs2 = new Kurs();//class tanımlamak için bun yapmak gerekiyor.(int gibi ama yeni bir kendi clasımız.
            kurs2.Kursadi = "java";
            kurs2.KursunEgitmeni = "Mustafa";
            kurs2.Kursunizlenmeorani = 70;

            Kurs kurs3 = new Kurs();//class tanımlamak için bun yapmak gerekiyor.(int gibi ama yeni bir kendi clasımız.
            kurs3.Kursadi = "Phyton";
            kurs3.KursunEgitmeni = "mesut";
            kurs3.Kursunizlenmeorani = 90;

            Kurs kurs4 = new Kurs();//class tanımlamak için bun yapmak gerekiyor.(int gibi ama yeni bir kendi clasımız.
            kurs4.Kursadi = "C++";
            kurs4.KursunEgitmeni = "Yusuf";
            kurs4.Kursunizlenmeorani = 52;

            Console.WriteLine(kurs1.Kursadi + " : " + kurs1.KursunEgitmeni);
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };//dizinin içinde classs tutmak için kullanıyoruz.
           
            int ab = 1;
            while (ab<=kurslar.Length)
            {
                Console.WriteLine(kurslar[ab].Kursadi);
                ab++;
            }
        }
    }
    class Kurs
    {
        public string Kursadi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int Kursunizlenmeorani { get; set; }
    }
    
}
