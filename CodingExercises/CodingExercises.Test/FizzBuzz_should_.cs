using Xunit;

namespace CodingExercises.Test
{
    public class FizzBuzz_should_
    {
        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(1, "1")]
        public void return_the_proper_output(int input, string expectedOutput)
        {
            var actualOutput = new FizzBuzz().ParseNumber(input);
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
