using FizzBuzz;
using Xunit;

namespace FizzBuzzTests
{
    public class FizzBuzzPrinterTests
    {
        private readonly FizzBuzzPrinter _fizzBuzzPrinter;

        public FizzBuzzPrinterTests()
        {
            _fizzBuzzPrinter = new FizzBuzzPrinter();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(11)]
        [InlineData(98)]
        public void Prints_number_for_non_multiples_of_three_or_five(int nonMultiple)
        {
            // Arrange

            // Act
            string actual = _fizzBuzzPrinter.GetLineFor(nonMultiple);

            // Assert
            Assert.Equal(nonMultiple.ToString(), actual);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        [InlineData(99)]
        public void Prints_Fizz_for_multiples_of_only_three(int multipleOfOnlyThree)
        {
            // Arrange

            // Act
            string actual = _fizzBuzzPrinter.GetLineFor(multipleOfOnlyThree);

            // Assert
            Assert.Equal("Fizz", actual);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(100)]
        public void Prints_Buzz_for_multiples_of_only_five(int multipleOfOnlyFive)
        {
            // Arrange

            // Act
            string actual = _fizzBuzzPrinter.GetLineFor(multipleOfOnlyFive);

            // Assert
            Assert.Equal("Buzz", actual);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(90)]
        public void Prints_FizzBuzz_for_multiples_of_three_and_five(int multipleOfBoth)
        {
            // Arrange

            // Act
            string actual = _fizzBuzzPrinter.GetLineFor(multipleOfBoth);

            // Assert
            Assert.Equal("FizzBuzz", actual);
        }
    }
}