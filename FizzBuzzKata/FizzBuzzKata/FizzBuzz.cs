using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public string DoAllFizzBuzz(int howHighToGo)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < howHighToGo; i++)
            {
                sb.AppendFormat("{0} ", GetTextForNumber(i));
            }
            return sb.ToString().Trim();
        }
        public bool IsDivisableByThree(int input)
        {
            return (input % 3 == 0);
        }

        public bool IsDivisibleByFive(int input)
        {
            return (input % 5 == 0);
        }

        public string GetTextForNumber(int input)
        {
            if (IsDivisibleByFive(input) && IsDivisableByThree(input))
            {
                return "FizzBuzz";
            }
            if (IsDivisibleByFive(input))
            {
                return "Buzz";
            }
            if (IsDivisableByThree(input))
            {
                return "Fizz";
            }
            return input.ToString();
        }


    }
}
