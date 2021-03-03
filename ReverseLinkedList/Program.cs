using System;
using System.Collections.Generic;

namespace ReverseLinkedList
{
    class Program
    {
        static void Display(LinkedList<string> sentence)
        {
            foreach(string val in sentence)
            {
                Console.Write($"{val} - ");
            }
            Console.WriteLine("\n------------- ");
        }

        static LinkedList<string> ReverseLL(LinkedList<string> sentence)
        {
            LinkedList<string> returnList = new LinkedList<string>();
            for (LinkedListNode<string> mark = sentence.Last; mark != sentence.First; mark = mark.Previous)
            {
                returnList.AddLast(mark.Value);               
            }
            returnList.AddLast(sentence.First.Value);
            return returnList;
        }

        static LinkedList<string> RemoveDuplicate(LinkedList<string> sentence)
        {
            LinkedList<string> returnList = new LinkedList<string>();
            foreach (string val in sentence)
            {
                if (!returnList.Contains(val)) returnList.AddLast(val);
            }

            return returnList;
        }

        static LinkedList<string> MergeTwoSortedLinkedLists(LinkedList<string> sentence1, LinkedList<string> sentence2)
        {
            LinkedList<string> returnList = new LinkedList<string>();
            foreach (string val in sentence1)
            {
                returnList.AddLast(val);
            }
            foreach (string val in sentence2)
            {
                returnList.AddLast(val);
            }

            var array = LLToArray(returnList);
            Array.Sort(array);

            return new LinkedList<string>(array);
        }

        static string[] LLToArray(LinkedList<string> sentence)
        {
            var result = new string[sentence.Count];
            var index = 0;
            var node = sentence.First;
            while (node != null)
            {
                result[index] = node.Value;
                node = node.Next;
                index++;
            }
            return result;
        }


        static void Main(string[] args)
        {
            //reverse a linked list
            string[] words =
               { "the", "fox", "jumps", "over", "the", "dog" };
            LinkedList<string> sentence = new LinkedList<string>(words);

            Display(sentence);

            Display(ReverseLL(sentence));

            //remove duplicate from a sorted linked list
            string[] wordswithduplicate =
               { "the", "fox", "jumps", "over", "the", "dog" , "the" , "dog", "over", "dog", "fox" };
            Array.Sort(wordswithduplicate, StringComparer.InvariantCulture);
            LinkedList<string> duplicatesentence = new LinkedList<string>(wordswithduplicate);
            Display(duplicatesentence);

            Display(RemoveDuplicate(duplicatesentence));

            //merge 2 sorted linked lists
            string[] sentence1string = { "a", "b", "c", "d", "a"};
            Array.Sort(sentence1string, StringComparer.InvariantCulture);

            string[] sentence2string = { "c", "d", "e", "f", "a" };
            Array.Sort(sentence2string, StringComparer.InvariantCulture);

            LinkedList<string> LL1 = new LinkedList<string>(sentence1string);
            LinkedList<string> LL2 = new LinkedList<string>(sentence2string);
            
            Display(LL1);
            Display(LL2);

            Display(MergeTwoSortedLinkedLists(LL1,LL2));

        }
    }
}
