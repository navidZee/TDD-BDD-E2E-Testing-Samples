using System;

namespace EvenOrOdd
{
    public class Evaluator
    {
        public string Evaluate(int value)
        {
            return value % 2 == 0 ? "Even" : "Odd";
        }
    }
}
