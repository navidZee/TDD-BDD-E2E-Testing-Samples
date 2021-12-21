namespace EvenOrOdd_TDD
{
    public partial class EvaluatorTest
    {
        class Evaluator
        {
            public static string Evaluate(int input)
            {
                return input % 2 == 0 ? "Even" : "Odd";
            }
        }
    }
}
