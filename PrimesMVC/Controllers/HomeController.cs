using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BasicMVC.Models;

namespace BasicMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Taking data from View
            var num1 = Request["text1"];
            var num2 = Request["text2"];

            //Creating an empty List
            List<int> miLista = new List<int>();

            //Creating an object Primes
            Primes misprimos = new Primes();

            int from, until;
            if ((int.TryParse(num1, out from)) && (int.TryParse(num2, out until)))
            {
                //Calling to the Model in order to get the list of Prime Numbers
                miLista = misprimos.CalculatePrimes(from, until);
            }

            //returning the list with the Prime Numbers to View
            return View(miLista);
        }
    }
}