using System.ComponentModel;
using System.Text.RegularExpressions;
using System;
using Microsoft.AspNetCore.Mvc;

namespace SquareRoot.Controllers
{
    public class SquareController : Controller
    {
        [HttpGet]
        public ActionResult SquareRoot()
        {
            return View();
        }

        [HttpPost]

        public ActionResult SquareRoot(string firstNumber, string secondNumber)
        {
            try
            {
                if (firstNumber is null || secondNumber is null)
                {
                    ViewBag.ErrorMessage = "Please enter a valid number";
                }
                int num1 = int.Parse(firstNumber);
                int num2 = int.Parse(secondNumber);
                double sqr_Root = Math.Sqrt(num1);
                double sqr_Root1 = Math.Sqrt(num2);
                double higherRoot = 0;

                ViewBag.Result = higherRoot;
                ViewBag.num1 = num1;
                ViewBag.num2 = num2;
                ViewBag.sqr_Root = sqr_Root;
                ViewBag.sqr_Root = sqr_Root1;

            }

            catch (FormatException ex)
            {
                var exceptionValue = ex.Message;
                ViewBag.ErrorMessage = "Please enter a valid input";
            }
            catch (ArgumentNullException ex)
            {
                var exceptionValueNullException = ex.Message;
                ViewBag.FormatErrorNullException = "Numbers have same square root. Please enter another number";
            }
            return View();
            
        }       
    }   
}
    

            return View();
        }
    }
}