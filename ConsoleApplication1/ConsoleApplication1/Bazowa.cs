using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Bazowa
    {
        public void wypisz()
        {
            Console.WriteLine("Bazowa");
        }

        public virtual void wypisz1()
        {
            Console.WriteLine("Bazowa");
        }

        public virtual void wypisz2()
        {
            Console.WriteLine("Bazowa");
        }
    }
}
