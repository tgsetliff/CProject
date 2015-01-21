using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CProject.Models
{
    public class SumViewModel
    {
        public int number1 { get; set; }
        public int number2 { get ; set; }
        public int sum { get; set; }

        public void SetSum (){
            sum = number1 + number2;
        }
    }
    public class SumPostModel{
        public int number1{get; set;}
        public int number2{get; set;}
    }
}