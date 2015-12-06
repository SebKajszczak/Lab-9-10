using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bazowa B = new Bazowa();
            Pochodna P = new Pochodna();          

            B.wypisz();
            P.wypisz();
            Bazowa bptr = P;                      
            bptr.wypisz();

            Console.ReadKey();


        }
    }
}
