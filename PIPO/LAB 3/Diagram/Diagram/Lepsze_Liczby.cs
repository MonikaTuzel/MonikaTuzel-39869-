using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diagram
{
    public class Lepsze_Liczby : Liczby
    {
        protected int d;

       public Lepsze_Liczby()
        {
            d = 0;
            Console.WriteLine("WSZYSTKIE LEPSZE LICZBY");
            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("C = " + c);
            Console.WriteLine("D = " + d);
            Console.ReadKey();
        }

    }
}