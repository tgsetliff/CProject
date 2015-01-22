using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CProject.Models
{
    public class Mathinator
    {
        public string number { get; set; }
        private string[] numbers { get; set; }

        public Mathinator(string number)
        {
            this.number = number;
            numbers = number.Split(',');
        }

        // MaxThree
        public string MaxThree()
        {
            int i = 0;
            int big = int.Parse(numbers[i]);

            for (; i < numbers.Length; i++)
            {
                if (big < int.Parse(numbers[i]))
                {
                    big = int.Parse(numbers[i]);
                }
            }

            string large = big.ToString();
            return large.ToString();
        }

        // SumMult
        public string SumMult()
        {
            int i = 0;
            int sum = 0;
            string result = "";

            for (; i < numbers.Length; i++)
            {
                sum = sum + int.Parse(numbers[i]);
            }
           
            int mult = int.Parse(numbers[0]);

            for (i = 1; i < numbers.Length; i++)
            {
                mult = mult * int.Parse(numbers[i]);
            }

            return result = (sum.ToString() + ',' + mult.ToString());
        }

        // Factorial
        public string findFactorial()
        {
            int i = int.Parse(number);
            string result = "";

            int prodTot = int.Parse(number);

            for (i = prodTot - 1; i > 1; i--)
            {
                prodTot = prodTot * i;

            }

            return result = (prodTot.ToString());
        }

        // FizzBuzz
        public List<string> FizzBuzz()
        {
            var output = new List<string>();
            string nada = "";

            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    output.Add("FizzBuzz");
                }
                else
                {
                    if (i % 5 == 0)
                    {
                        output.Add("Buzz");
                    }
                    else
                    {
                        if (i % 3 == 0)
                        {
                            output.Add("Fizz");
                        }
                        else
                        {
                            output.Add(i.ToString());
                        }
                    }
                }                
            }

            return output;
        }
    }
}