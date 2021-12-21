using Xunit;

namespace FizzBuzz
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Start_ShouldReturnAListWithGivenRoundsLength()
        {
            const int rounds = 100;

            var actual = FizzBuzz.Start(rounds);

            Assert.Equal(rounds, actual.Count);
        }

        [Theory]
        [InlineData("Fizz", 2)]
        [InlineData("Buzz", 4)]
        [InlineData("FizzBuzz", 29)]
        public void Start_ShouldReturnAListWithProperValuesAtGivenElements(string expected, int element)
        {
            const int rounds = 100;

            var actual = FizzBuzz.Start(rounds);

            Assert.Equal(expected, actual[element]);
        }

        //[Fact]
        //public void Start_ShouldReturnAListWithProperFizzValues()
        //{
        //    const int rounds = 100;

        //    var actual = FizzBuzz.Start(rounds);

        //    Assert.Equal("Fizz", actual[2]);
        //    Assert.Equal("Fizz", actual[8]);
        //}

        //[Fact]
        //public void Start_ShouldReturnAListWithProperBuzzValues()
        //{
        //    const int rounds = 100;

        //    var actual = FizzBuzz.Start(rounds);

        //    Assert.Equal("Buzz", actual[4]);
        //    Assert.Equal("Buzz", actual[9]);
        //}

        //[Fact]
        //public void Start_ShouldReturnAListWithProperFizzBuzzValues()
        //{
        //    const int rounds = 100;

        //    var actual = FizzBuzz.Start(rounds);

        //    Assert.Equal("FizzBuzz", actual[14]);
        //    Assert.Equal("FizzBuzz", actual[29]);
        //}
    }
}