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

            for (int i = 1; i <=100; i++)
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

        // Find if number is perfect
        public string PerfectNumber()
        {
            // find if number is perfect
            string result = "";
            string tempnum = "";
            string num = number;

            if (number != null && number != "0" && number != "")
            {
                tempnum = prfnum(number);
                number = "";
            }
            return (int.Parse(tempnum) == int.Parse(num)) ? "True" : "False";
        }
 
        // PerfectNumbers
        public string PerfectNumbers()
        {   
            // find perfect numbers between 1 and 1000000

            string tempNum = "";
            int num = 0;
            string output = "";

            for (var i = 1; i <= 1000; i++) {
                num += i;
                tempNum = prfnum(num.ToString());

                if (int.Parse(tempNum) == num) {
                    if(output == ""){
                        output = tempNum;
                    }
                    else{
                        output = output + "," + tempNum;
                    }
                }
            }
            return output;
        }

        public string HappyNumbers()
        {
            int cnt = 0;
            int number = 1;
            string output = "";
            int n = 0;
            int[] chk = new int[10];
            string [] arrHappy = new string[5];

            // while number is not 1
            while (cnt <= 4) {
                // on first pass, n will be 0 so set to 1
                if (n == 0) {
                    n = number;
                }
                var digits = getDigits(n.ToString(), 2);      // get computed power for each digit
                //n = int.Parse(sum(digits));                    // sum the computed powers
                n = int.Parse(digits);

                if (int.Parse(digits) != 1) {
                    int x = Array.IndexOf(chk,n);       // look for number in array
                    if (x < 0){                         // if not found
                        x = Array.IndexOf(chk,0);       // look for first empty element
                        if(x >= 0){                     // if found
                            chk[x] = n;                 // place value
                        }
                        else{
                        Array.Resize(ref chk,chk.Length+1);     // else, resize array
                        var i = chk.Length-1;                   // set index
                        chk[i] = n;                             // place value
                        }
                    }
                    else {                                  // number was found so repeat has occurred
                        Array.Clear(chk, 0, chk.Length);    // clear array and go to next number to check
                        number++;
                        n = number;
                    }
                }
                else {
                    if (cnt < 4)
                        output = output + number.ToString() + ",";
                    else
                        output = output + number.ToString();
                    cnt++;
                    number++;
                    n = number;
                }                
            }
            return output;
        }

        // ArmstrongNumbers
        public string ArmstrongNumbers()
        {            
            string output = "";

            for (var i = 100; i <= 1000; i++)
            {
                var digits = getDigits(i.ToString(), 3);               // get total of digits to given power
               // var n = int.Parse(sum(digits));             // sum the computed powers
                if (i == int.Parse(digits))
                {
                    if (output == "")
                    {
                        output = i.ToString();
                    }
                    else
                    {
                        output = output + "," + i.ToString();
                    }
                }
            }
            return output;
        }

        // calculate perfect number
        public string prfnum(string num)
        {
            int temp = 0;
            int n = int.Parse(num);

            for (var i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    temp += i;
                }
            }
            return temp.ToString();
        }

        // calculate power of digits
        public string getDigits(string number, int power) 
        {
            int num = int.Parse(number);
            int[] n;
            string digit = "";
            int sumTot = 0;

            n = num.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            // loop through n and get the power of each digit
            for (var i = 0; i < n.Length; i++) {
                n[i] = Convert.ToInt32(Math.Pow(Convert.ToDouble(n[i]), power));
            }

            for (var i = 0; i < n.Length; i++)
            {
                sumTot = sumTot + n[i];
            }

            return sumTot.ToString();
        }

        // sum digits
        //public string sum(string nArray)
        //{
        //    var sumTot = 0;
        //    string [] numArray = nArray.Split().ToArray();
        //    for (var i = 0; i < numArray.Length; i++) {
        //        sumTot = sumTot + int.Parse(numArray[i]);
        //    }

        //    return sumTot.ToString();
        //}

    }
}