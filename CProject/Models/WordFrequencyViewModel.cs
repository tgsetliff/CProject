using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CProject.Models
{
    public class WordFrequencyViewModel
    {
        public string text { get; set; }
        public Dictionary<string, int> frequencies { get; set;}
    }
}