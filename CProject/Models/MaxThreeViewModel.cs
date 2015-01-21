using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CProject.Models
{
    public class MaxThreeViewModel
    {
        public int number1 { get; set; }
        public int number2 { get; set; }
        public int number3 { get; set; }
        public int large { get; set; }

        public void FindLarge()
        {
            int[] arr = { number1, number2, number3 };
            int i = 0;
            large = arr[i];

            for (; i < arr.Length; i++)
			{
                if (large < arr[i])
                {
                    large = arr[i];
                }
            }
        }
    }
    public class MaxThreePostModel
    {
        public int number1 { get; set; }
        public int number2 { get; set; }
        public int number3 { get; set; }
    }
}