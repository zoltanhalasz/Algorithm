using System;

namespace PalindromeString
{
    class Program
    {
        static bool isPalindrome(string Init)
        {
            if (Init.Equals(ReverseString(Init))) return true;
            return false;
        }

        static string ReverseString(string s)
        {
            char[] stringArray = s.ToCharArray();
            Array.Reverse(stringArray);
            string reverseString = new string(stringArray);
            return reverseString;
        }
        static void Main(string[] args)
        {
            string InitialString = "homoh";
            Console.WriteLine($"{InitialString} is Palindrome: {isPalindrome(InitialString)}");
        }
    }
}
