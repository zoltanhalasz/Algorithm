using System;
using System.Collections.Generic;

namespace HighestOcurring
{
    class Program
    {       
        static Dictionary<string,int> GetWords(string sentence)
        {
            string[] wordsarray = sentence.Split(new string[] { " " }, StringSplitOptions.None);
            Dictionary<string, int> returnDict = new Dictionary<string, int>();
            foreach  (string word in wordsarray)
            {
                if (returnDict.ContainsKey(word))
                {
                    returnDict[word]++;
                }
                else
                {
                    returnDict[word] = 0;
                }
            }
            return returnDict;
        }

        static List<string> GetMostFrequent(Dictionary<string, int> words)
        {
            int maxWordFreq = int.MinValue;
            var returnWords = new List<string>() ;
            foreach (var word in words.Keys)
            {
                if (words[word] > maxWordFreq)
                {
                    maxWordFreq = words[word];
                }
            }
            foreach (var word in words.Keys)
            {
                if (words[word] == maxWordFreq)
                {
                    returnWords.Add(word);
                }
            }
            return returnWords;
        }
        static void Main(string[] args)
        {
            string Sentence = "abc abc cde cde abc cde";
            var returnWords = GetMostFrequent(GetWords(Sentence));
            Console.WriteLine("Most frequent words are");
            foreach (var word in returnWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
