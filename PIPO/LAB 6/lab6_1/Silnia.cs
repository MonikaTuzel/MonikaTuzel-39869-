using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_1
{
    public class Silnia
    {
        public int n;
        public int oblicz()
        {
            if ((n == 0) || (n == 1)) return 1;
            else
            {
                if (n == 2) return 2;
                int i = 3;
                int n2 = 2;

                while (i <= n)
                {
                    n2 = n2 * i;
                    i++;
                }
                return n2;
            }
        }
    }
}
