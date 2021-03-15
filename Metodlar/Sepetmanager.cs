using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class Sepetmanager
    {
        //naming convention isimlendirme
        //syntax
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Aldın Aldın Sepete Eklendi :" + urun.Adi);
        
        }

        public void Ekle2(string urunAdi) 
        {
            Console.WriteLine("Aldın Aldın Sepete Eklendi :" + urunAdi);
        
        
        }
    }
}
