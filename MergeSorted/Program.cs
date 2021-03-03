using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeSorted
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

        static int [] MergeArrays(int [] array1, int [] array2)
        {
            int[] returnArray = new int[array1.Length + array2.Length];
            
            for (int i = 0; i<array1.Length; i++)
            {
                returnArray[i] = array1[i];
            }
            
            for (int j = array1.Length; j < array2.Length + array1.Length; j++)
            {
                returnArray[j] = array2[j-array1.Length];
            }

            return Sort(returnArray);
        }
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 3, 45, 5, 1, 2 };
            int[] array2 = new int[] { 23, 14, 15, 441, 22, 666 };
            int[] array1sorted = Sort(array1);
            int[] array2sorted = Sort(array2);
            DisplayArray(array1sorted);
            DisplayArray(array2sorted);
            DisplayArray(MergeArrays(array1sorted, array2sorted));
        }
    }
}
