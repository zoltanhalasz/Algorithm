using System;
using System.Collections.Generic;
using System.Linq;

namespace FindMissing
{
    class Program
    {
        static void DisplayArray(int[] array)
        {
            Console.WriteLine("Display array: -------");
            foreach (int a in array)
                Console.Write(a + " ");
            Console.WriteLine("-------");
        }

        static int[] Sort(int[] array)
        {
            IEnumerable<int> query = array.OrderBy(num => num);
            var sortedArr = query.ToArray();
            return sortedArr;
        }
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 3, 45, 5, 1, 2, 50, 60 };
            var newArray = Sort(array1);
            DisplayArray(newArray);
            for (int i = 1; i < 101; i++)
            {
                if (!newArray.Contains(i))
                {
                    Console.WriteLine($"Original array does not contain {i}");
                }
            }
        }
    }
}
