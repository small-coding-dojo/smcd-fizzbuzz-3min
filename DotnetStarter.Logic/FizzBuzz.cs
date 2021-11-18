using System;
using System.Globalization;

namespace DotnetStarter.Logic
{
    public class FizzBuzz
    {
        public static string Evaluate(int value)
        {
            var fizzbuzz = "";
            if (IsMultipleOf3(value))
            {
                fizzbuzz += "Fizz";
            }

            if (IsMultipleOf5(value))
            {
                fizzbuzz += "Buzz";
            }

            if (fizzbuzz == "")
            {
                fizzbuzz = value.ToString(CultureInfo.CurrentCulture);
            }

            return fizzbuzz;
        }
        
        private static bool IsMultipleOf5(int value) => value % 5 == 0;

        private static bool IsMultipleOf3(int value) => value % 3 == 0;
    }
}