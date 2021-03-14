using System;

namespace Capintro
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 100;
            {
                return sayi % 2 == 0 ? "çift" : "Tek";
                Console.WriteLine(sayi);
            }
            
            //ty safety tip güvenliği 
            string kategorietiketi = "kategori";
            int sayı1 = 26;  //sayıalrı tutmak için
            double faizorani = 1.45; // double ondalık sayıları tutmak için kullanılır
            bool sistemeGirisYamisi = true;
            Console.WriteLine(kategorietiketi);
            Console.WriteLine(sayı1+1);
            Console.WriteLine(faizorani);
            double dolarDun = 7.45;
            double dolarBugun = 7.45;
            if (dolarDun > dolarBugun) //ilk şart
            {
                Console.WriteLine("Azalış");
            }
            else if (dolarDun < dolarBugun) //ikinci şart
            {
                Console.WriteLine("Artış");
            }
            else // değilse
            {
                Console.WriteLine("Deişmedi");
            }
            if (sistemeGirisYamisi==false)//eğer sisteme giriş yapıysa
            {
                Console.WriteLine(faizorani);
            }
            else
            {
                Console.WriteLine(sayı1+5);
            }

        }
    }
}
