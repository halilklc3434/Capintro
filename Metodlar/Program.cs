using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun uruclist in urunler)
            {
                Console.WriteLine(uruclist.Adi);
                Console.WriteLine(uruclist.Fiyati);
                Console.WriteLine(uruclist.Aciklama);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("-------------MEtotlar--------------------");


            //encapsulation


            Sepetmanager sepetmanager = new Sepetmanager();
            sepetmanager.Ekle(urun1);//reusebility tekrar tekrar kullanabilme özelliği
            sepetmanager.Ekle(urun2);
            sepetmanager.Ekle2("armut");
           



        }
    }
}



//Dont repeat yourself  kendini tekrar etme!!!!!!!
//Clean Code  temiz kod yazımı
// Best Practice 
