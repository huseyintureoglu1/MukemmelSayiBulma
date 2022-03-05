using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MukemmelSayiMi
{
   public class Methodlarim
    {
        public int PozitifBolenlertoplami(int sayi)
        {
            int toplam = 0;
            for (int i = 1; i <= sayi; i++)
            {
                if (sayi%i==0)
                {
                    toplam = toplam + i;
                   // Console.WriteLine(i);
                }
            }
            return toplam;
        }
        public bool MukemmelSayiMi(int sayi)
        {
            bool sonuc = false;
            int toplam= PozitifBolenlertoplami(sayi);
            if (sayi*2==toplam)
            {
                //Console.WriteLine(sayi + " mükemmel sayıdır");
                sonuc = true;
            }
            else
            {
               // Console.WriteLine("Mükemmel sayı değildir.");
            }
            return sonuc;
        }
        public void AraliktakiMukemmelSayilariBul(int baslangic, int bitis)
        {
            for (int i = baslangic; i < bitis; i++)
            {
                bool sonuc = MukemmelSayiMi(i);
                if (sonuc)
                {
                    Console.WriteLine("("+i+")"+" sayısı mükemmel sayıdır.");
                }
            }
        }
      
    }
}
