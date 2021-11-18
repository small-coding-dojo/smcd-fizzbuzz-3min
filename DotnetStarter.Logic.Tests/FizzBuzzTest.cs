using System;
using Xunit;

namespace DotnetStarter.Logic.Tests
{
    public class FizzBuzzTest
    {
        private const string FizzText = "Fizz";
        private const string BuzzText = "Buzz";

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, FizzText)]
        [InlineData(4, "4")]
        [InlineData(6, FizzText)]
        [InlineData(5, BuzzText)]
        [InlineData(10, BuzzText)]
        [InlineData(14, "14")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(30, "FizzBuzz")]
        [InlineData(100, "Buzz")]
        [InlineData(99, "Fizz")]
        [InlineData(101, "101")]
        public void TableTest(int input, string expected)
        {
            Assert.Equal(expected, FizzBuzz.Evaluate(input));
        }
    }
}