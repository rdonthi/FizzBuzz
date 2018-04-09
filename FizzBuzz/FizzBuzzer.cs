using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public string Generate(int num)

        {
            string result = num.ToString();
            Console.Read();
            {
                if ((num % 3 == 0) && (num % 5 == 0))
                    return "FizzBuzz";
                if (num % 3 == 0)
                    return "Fizz";
                if (num % 5 == 0)
                    return "Buzz";

            }
            return result;
        }

    }
}
