using CProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CProject.Controllers
{
    public class ExercisesController : Controller
    {
        [HttpGet]
        public ActionResult Sum()
        {
            int number1 = 0;
            int number2 = 0;
            return View();
        }
        
        [HttpPost]
        public ActionResult Sum(SumPostModel model)
        {
            var responseModel = new SumViewModel
            {
                number1 = model.number1,
                number2 = model.number2
            };

            responseModel.SetSum();
            return View(responseModel);
        }

        [HttpGet]
        public ActionResult MaxThree()
        {
            int number = 0;
            int large = 0;

            return View();
        }

        [HttpPost]
        public ActionResult MaxThree(string number)
        {
            var mathinator = new Mathinator(number);

            var responseModel = new MaxThreeViewModel
            {
                number = number,
                large = mathinator.MaxThree()
            };

            return View(responseModel);
        }

        [HttpGet]
        public ActionResult SumMult()
        {
            int number = 0;
            int result = 0;

            return View();
        }

        [HttpPost]
        public ActionResult SumMult(string number)
        {
            var mathinator = new Mathinator(number);

            var responseModel = new SumMultViewModel
            {
                number = number,
                result = mathinator.SumMult()
            };

            return View(responseModel);
        }

        [HttpGet]
        public ActionResult FindLongestWord()
        {
            string text = "";
            string longest = "";

            return View();
        }

        [HttpPost]
        public ActionResult FindLongestWord(string text)
        {
            var wordinator = new Wordinator(text);
            var responseModel = new LongestWordViewModel
            {
                text = text,
                longest = wordinator.findLongestWord()
            };

            return View(responseModel);
        }

        [HttpGet]
        public ActionResult CountAlice()
        {
            string text = "";
            int appearances = 0;

            return View();
        }

        [HttpPost]
        public ActionResult CountAlice(string text)
        {
            var wordinator = new Wordinator(text);

            var responseModel = new CountAliceViewModel
            {
                text = text,
                appearances = wordinator.CountAlice()
            };
            return View(responseModel);
        }

        [HttpGet]
        public ActionResult Palindrome()
        {
            string text = "";
            string result = "";

            return View();
        }

        [HttpPost]
        public ActionResult Palindrome(string text)
        {
            var wordinator = new Wordinator(text);

            var responseModel = new PalindromeViewModel
            {
                text = text,
                result = wordinator.findPalindrome()
            };
            return View(responseModel);
        }
    }
}