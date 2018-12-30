using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Count = ");
            Console.WriteLine(countMultiples(1000));
            Console.ReadKey();
        }

        static int countMultiples(int n)
        {
            int res = 0;
            for (int i = 1; i < n; i++)
                if (i % 3 == 0 || i % 5 == 0)
                    res += i;

            return res;
        }
    }
}
