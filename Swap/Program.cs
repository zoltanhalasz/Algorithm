using System;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 56, b = 101;
            Console.WriteLine($"a: {a} - b: {b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a: {a} - b: {b}");
        }
    }
}
