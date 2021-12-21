using System;
using Xunit;

namespace EvenOrOdd_TDD
{
    public partial class EvaluatorTest
    {
        [Fact]
        public void Evaluate_should_return_even()
        {
            int input = 6; ;

            string res = Evaluator.Evaluate(input);

            Assert.Equal("Even", res);

        }

        [Fact]
        public void Evaluate_should_return_odd()
        {
            int input = 5;

            string res = Evaluator.Evaluate(input);

            Assert.Equal("Odd", res);
        }
    }
}
