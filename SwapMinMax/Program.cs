using System;

namespace SwapMinMax
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

        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 45, 5, 1, 2, 60, 60 };
            
            DisplayArray(array);
            
            int max = int.MinValue;
            int min = int.MaxValue;

            foreach (var elem in array)
            {
                if (elem<min)
                {
                    min = elem;
                }
                if (elem >max)
                {
                    max = elem;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    array[i] = min;
                    continue;
                } 

                if (array[i] == min)
                {
                    array[i] = max;
                }
            }

            DisplayArray(array);
        }
    }
}
