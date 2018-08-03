using System;

namespace CodingExercises
{
    public class FizzBuzz
    {
        public string ParseNumber(int input)
        {
            if (input % 3 == 0 && input % 5 == 0)
            {
                return "FizzBuzz";
            }

            if (input % 3 == 0)
            {
                return "Fizz";
            }

            if (input % 5 == 0)
            {
                return "Buzz";
            }

            return input.ToString();
        }
    }
}
