using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CProject.Models
{
    public class filterLongWordsViewModel
    {
        public string text {get; set;}
        public int number { get; set; }
        public List<string> longWords { get; set; }
    }
}