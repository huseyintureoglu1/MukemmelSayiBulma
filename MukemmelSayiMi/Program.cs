using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MukemmelSayiMi
{
    class Program
    {
        static void Main(string[] args)
        {
            Methodlarim m = new Methodlarim();
            // m.PozitifBolenlertoplami(20);
            // m.MukemmelSayiMi(28);
            m.AraliktakiMukemmelSayilariBul(1, 10000);
           
            Console.ReadLine();
        }
    }
}
