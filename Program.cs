using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    static class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine(countMultiples(1000));
            // Console.WriteLine(Euler1(1000));
            // Console.WriteLine(Fibonacci1(10));
            // Console.WriteLine(Fibonacci2(10));

            Console.WriteLine(Euler2(4000000));
            //Console.WriteLine(Euler2(10));

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

        static long Euler1(this int n)
        {
            return Enumerable.Range(0, n).Where(i => i % 3 == 0 || i % 5 == 0).Sum();
        }

        public static int Fibonacci1(this int number)
        {

            if (number < 0)
                return -1;

            if (number == 0 || number == 1)
                return 1;
            else
            {
                int temp1 = number - 1;
                int temp2 = number - 2;

                return temp1.Fibonacci1() + temp2.Fibonacci1();
            }
        }

        public static int Fibonacci2(this int number)
        {
            var tuple = new Tuple<int, int>(1, 1);

            for (int i = 2; i < number; i++)
            {                                  
                tuple = new Tuple<int, int>(tuple.Item2, tuple.Item1 + tuple.Item2);       
            }
            return (tuple.Item1 + tuple.Item2);
        }

        public static long Euler2(this long number)
        {
            long res = 2;
            var fib1 = 1;
            var fib2 = 2;
            var aux = 0;

            while (fib2 < number )
            {
                aux = fib1;
                fib1 = fib2;
                fib2 = aux + fib1;
                if (fib2 % 2 == 0)
                {
                    res += fib2;
                }
                Console.WriteLine("fib1: " + fib1);
                Console.WriteLine("fib2: " + fib2);
                Console.WriteLine("res: " + res);

            }

            // 4613732
            return res;
        }
    }
}

