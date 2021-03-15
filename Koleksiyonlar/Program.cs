using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Halil", "Mustafa", "Mesut" }; //ctrl +k ctrl+c(comment satırına alır)
            //Console.WriteLine(isimler[0]);//ctrl +k ctrl+u(uncomment satırına alır)
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //isimler[2] = "Zalım";
            //Console.WriteLine(isimler[2]);
            //isimler = new string[4];
            //isimler[3] = "Kerem";
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[1]);

            List<string> isimler2= new List<string> {"Halil","Mustafa","Mesut" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Zalım");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);
            
            



        }
    }
}
