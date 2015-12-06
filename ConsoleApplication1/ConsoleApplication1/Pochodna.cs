using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Pochodna : Bazowa
    {
        public void wypisz()
        {
            Console.WriteLine("Pochodna");
        }

        public virtual void wypisz1()
        {
            Console.WriteLine("Pochodna");
        }

        public void wypisz2()
        {
            Console.WriteLine("Pochodna");
        }
    }
}


