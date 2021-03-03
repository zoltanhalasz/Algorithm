
using System;

namespace Factorial
{
    class Program
    {
        static int FactorialRecursive(int k)
        {
            if (k <= 1) return 1;
            return k * FactorialRecursive(k - 1);
        }

        static int FactorialNonRec(int k)
        {
           int rez = k;
           for (int i = k - 1; i > 0; i--)
           {
                rez = rez * i;           
           }
            return rez;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FactorialRecursive(9));
            Console.WriteLine(FactorialNonRec(9));
        }
    }
}
