using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExamples
{
   public  class SayiKontrol
    {
       public static bool  asalmi(int sayi) {
            
            bool durum = false;

            int kontrol = 0;

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    kontrol = 1;
                    break;
                } 
            }
            if (kontrol==1)
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            
            return durum;
        }

    }
}
