using System;

namespace ReverseString
{

    class Program
    {
        static string ReverseFirst(string s)
        {
            string reverseString = string.Empty;

            for (int i =0; i< s.Length; i++)
            {
                reverseString = s[i] + reverseString;
            }

            return reverseString;
        }

        static string ReverseSecond(string s)
        {
            char[] stringArray = s.ToCharArray();
            Array.Reverse(stringArray);
            string reverseString = new string(stringArray);
            return reverseString;
        }
        static void Main(string[] args)
        {
            string s = "this";
            Console.WriteLine($"Reverse first: {ReverseFirst(s)}");
            Console.WriteLine($"Reverse second: {ReverseSecond(s)}");
        }
    }
}
