using System;

namespace EvenOrOdd
{
    public class Evaluator
    {
        public static string Evaluate(int value)
        {
            return value % 2 == 0 ? "Even" : "Odd";
        }
    }
}
