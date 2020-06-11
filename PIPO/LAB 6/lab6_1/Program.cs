using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Silnia S1 = new Silnia();
            S1.n = 6;
            Console.WriteLine(S1.oblicz());
            Console.ReadKey();

        }
    }
}
