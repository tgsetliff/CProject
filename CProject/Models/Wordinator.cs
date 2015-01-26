using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CProject.Models
{
    public class Wordinator
    {
        public string text { get; set; }
        private string[] words { get; set; }

        public Wordinator(string text)     
        {
            this.text = text.ToLower();
            var tempText = text.Replace('\n', ' ');
            tempText = tempText.Replace('.', ' ');
            words = tempText.Split(' ').Where(s=> s != "" && s != " ").ToArray();
        }

        public static int Factorial(int n)
        {
            return n > 2 ? n * Factorial(n - 1) : 2;
        }

        public string findLongestWord()
        {
            string longestWord = "";

            foreach (var word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            return longestWord;
        }

        public int CountAlice()
        {
            int appearances = 0;
            foreach (var word in words)
            {
                if (word.ToLower().Contains("alice"))
                {
                    appearances++;

                }
            }
            return appearances;
        }

        public string findPalindrome()
        {
            string palWord;
            char[] inpalArr = text.ToCharArray();
            Array.Reverse(inpalArr);
            palWord = new string(inpalArr);

            string result = "";

            return result = (palWord == text) ? "True" : "False"; ;
        }

        public Dictionary<string, int> WordFrequency()
        {
            var frequencies = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (frequencies.Keys.Contains(word))
                    frequencies[word]++;
                else
                    frequencies[word] = 1;
            }


            return frequencies;
        }

        public List<string> filterLongWords(int number)
        {
            var longWords = new List<string>();

            foreach (var word in words)
            {
                if (word.Length > number)
                {
                    if (!longWords.Contains(word))
                        longWords.Add(word);
                }
            }
            return longWords;
        }
    }
}