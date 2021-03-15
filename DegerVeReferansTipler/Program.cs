using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
          

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);


            int[] sayilar1 = new int[] { 10,20,30};
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar1[0] = 999;
            Console.WriteLine(sayilar1[0]);

            // değer tipler = int , decinal , fload,double,bool(0,1 tutar true folse)
            //referans tipler=  array,class,inteface

            //Bellekte stack ve heap 2 alan var değişken tanımlmak için
            // değer tipler stackda gerçekleşir.

        }
    }
}
