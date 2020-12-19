using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicMVC.Models
{
    public class Primes
    {
        public Primes(){
        }

        public List<int> CalculatePrimes(int from, int until)
        {

            // Create an empty List of Primes
            List<int> Primes = new List<int>();

            for (int i = from; i <= until; i++)
                {
                    if (EsPrimo(i))
                    {
                        Primes.Add(i);
                    }
            }
            //return the List of Found Primes
            return (Primes);
        }

        private bool EsPrimo(int x)
        {
    
            if (x < 0)
                throw new ArgumentOutOfRangeException("x ", x, "Never over negatives values");

            if (x <= 3)
                return true;
            else
                for (int i = 2; i <= x - 1; i++)
                    //el porcentaje es el resto
                    if (x % i == 0)
                        return false;
            return true;
        }
    }
}