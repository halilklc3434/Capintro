using System;

namespace Denemeler
{
    class Program
    {
        static void Main(string[] args)
        {
            int caseSwintch = 10;
            switch (caseSwintch)
            {
                case 1:
                    Console.WriteLine("Case 1");
              
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("default case");
                    break;



            }
            int i = 1;
            while (i<=10)
            {
                Console.WriteLine("Merhaba dünya");
                i++;
                
            }

            int [] a = new int[] {1,2,3,4,5,6 };
            int b = 1;
            while (b<=a.Length)
            {
                Console.WriteLine(a[b]);
                b=b+2;


            }
            for (int c = 0; c < a.Length; c++)
            {
                Console.WriteLine(a[c]);
            }
            foreach (var sayi in a)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}
