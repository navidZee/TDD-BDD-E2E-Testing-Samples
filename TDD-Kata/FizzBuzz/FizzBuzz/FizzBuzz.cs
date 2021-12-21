using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static List<string> Start(int rounds)
        {
            var result = new List<string>();

            for (var i = 1; i <= rounds; i++)
            {
                var output = i % 3 == 0 ? "Fizz" : "";
                output += i % 5 == 0 ? "Buzz" : "";
                output += output == string.Empty ? i.ToString() : string.Empty;

                result.Add(output);
            }

            return result;
        }
    }
}