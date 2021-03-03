using System;
using System.Linq;

namespace Anagram
{
    class Program
    {
        static bool isAnagram(string s1, string s2)
        {
            s1 = s1.Replace(" ", string.Empty);
            s2 = s2.Replace(" ", string.Empty);
            char[] characters1 = s1.ToArray();
            char[] characters2 = s2.ToArray();
            Array.Sort(characters1);
            Array.Sort(characters2);
            string news1 = new string(characters1);
            string news2 = new string(characters2);

            if (news1.Trim().Equals(news2.Trim())) return true;
            return false;
        }
        static void Main(string[] args)
        {
            string s1 = "abc", s2 = "bca";
            Console.WriteLine($"{s1} and {s2} are anagram pairs {isAnagram(s1,s2)}");
        }
    }
}
