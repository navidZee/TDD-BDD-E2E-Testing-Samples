using EvenOrOdd;
using Xunit;

namespace evenorodd
{
    public class evaluatortest
    {
        [Fact]
        public void evaluate_should_return_even()
        {
            int input = 5;
            var ev = new Evaluator();

            var res = ev.Evaluate(input);
            Assert.Equal("Even", res);

        }
    }
}
