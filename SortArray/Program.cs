using System;
using System.Collections.Generic;
using System.Linq;

namespace SortArray
{
    class Program
    {
        static void DisplayArray(int [] array)
        {
            Console.WriteLine("Display array: -------");
            foreach (int a in array)
                Console.Write(a + " ");
            Console.WriteLine("-------");
        }

        static int[] SortOne(int [] array)
        {
            int[] returnArray = new int[array.Length];
            Array.Copy(array, returnArray, array.Length);

            for (int i = 0; i< returnArray.Length-1; i++)
            {
                for (int j = i + 1; j < returnArray.Length; j++)
                {
                    if (returnArray[j]< returnArray[i])
                    {
                        int tmp = returnArray[i];
                        returnArray[i] = returnArray[j];
                        returnArray[j] = tmp;
                    }
                }
            }
            
            return returnArray;
                
        }

        static int[] Reverse(int[] array)
        {
            int[] returnArray = new int[array.Length];
            Array.Copy(array, returnArray, array.Length);

            for (int i = 0; i < returnArray.Length /2; i++)
            {               
                int tmp = returnArray[i];
                returnArray[i] = returnArray[array.Length-i -1];
                returnArray[returnArray.Length - i - 1] = tmp;
            }
            return returnArray;
        }

        static int[] SortTwo(int[] array)
        {
            int[] returnArray = new int[array.Length];
            Array.Copy(array, returnArray, array.Length);
            Array.Sort(returnArray);
            return returnArray;
        }

        static int[] SortThree(int[] array)
        {
            IEnumerable<int> query = array.OrderBy(num => num);
            var sortedArr = query.ToArray();
            return sortedArr;
        }
        static void Main(string[] args)
        {
            int[] a = { 5, 7, 10, 11, 15, 9 };
            DisplayArray(a);
            DisplayArray(Reverse(a));            
            DisplayArray(SortOne(a));            
            DisplayArray(SortTwo(a));
            DisplayArray(SortThree(a));
            DisplayArray(Reverse(a));

        }
    }
}
