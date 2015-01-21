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
            this.text = text;
            var tempText = text.Replace('\n', ' ');
            tempText = tempText.Replace('.', ' ');
            words = tempText.Split(' ');       
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
    }
}