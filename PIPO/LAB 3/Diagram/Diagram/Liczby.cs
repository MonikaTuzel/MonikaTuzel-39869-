using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Diagram
{
    public class Liczby
    {
        protected int a;
        protected int b;
        protected int c;
        public int x;
        public int y;
        public int z;

        public Liczby()
        {
            a = 0; b = 0; c = 0;
        }
      
        

        public void pokaz(int x, int y, int z)
        {
            a = x; b = y; c = z;
            Console.WriteLine("Twoje liczby:");
            Console.WriteLine("Liczba a: "+a);
            Console.WriteLine("Liczba b: " + b);
            Console.WriteLine("Liczba c: " + c);
            Console.ReadKey();

        }

        public void suma()
        {
            int suma;
            suma = +a + b + c;
            Console.WriteLine("Suma liczb: " + suma);
            Console.ReadKey();

        }
    }
}