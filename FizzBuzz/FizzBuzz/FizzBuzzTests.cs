using FizzBuzzLib;
using FluentAssertions;

namespace FizzBuzz
{
    public class FizzBuzzTests
    {
        // Given is an integer, return a string where:
        // "FizzBuzz" if number is divisible by 3 and 5,
        // "Fizz" if number is divisible by 3.
        // "Buzz" if number is divisible by 5.
        // number (as a string) if none of the above conditions are true

        [Theory]
        [InlineData(1)]
        [InlineData(7)]
        [InlineData(8)]
        public void GivenANumberNotDivisibleBy3or5_ThenReturnsNumberAsString(int number)
        {
            string result = FizzBuzzGame.Play(number);

            result.Should().Be(number.ToString());
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void GivenANumberDivisibleBy5_ThenReturnsBuzz(int number)
        {
            string result = FizzBuzzGame.Play(number);

            result.Should().Be("Buzz");
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(12)]
        public void GivenANumberDivisibleBy3_ThenReturnsFizz(int number)
        {
            string result = FizzBuzzGame.Play(number);

            result.Should().Be("Fizz");
        } 
        
        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(60)]
        public void GivenANumberDivisibleBy3And5_ThenReturnsFizzBuzz(int number)
        {
            string result = FizzBuzzGame.Play(number);

            result.Should().Be("FizzBuzz");
        }
    }
}