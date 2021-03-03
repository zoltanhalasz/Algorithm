using System;

namespace Divisor
{
    class Program
    {
        static int Gcd(int a, int b)
        {
            
            if (a == b) return a;
            
            int gcd = 1;
            int max = Math.Max(a, b);
            int min = Math.Min(a, b);
            min = Math.Min(min, max / 2);
            for (int k = min; k>0; k --)
            {
                if (max % k == 0)
                {
                    gcd = k;
                    break;
                }
            }

            return gcd;
        }

        static int Lcm(int a, int b)
        {
            return a * b / Gcd(a, b);
        }
        static void Main(string[] args)
        {
            int a = 139999, b = 18666666;
            Console.WriteLine("GCD " + Gcd(a, b));
            Console.WriteLine("LCM " + Lcm(a, b));
        }
    }
}
