using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Calculations.Tests
{
    public class CalculatorFixture 
    {
        public Calculator calc => new Calculator();
    }
    public class CalculatorTest : IClassFixture<CalculatorFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly CalculatorFixture _calculatorFixture;
        private readonly MemoryStream memoryStream;
        public CalculatorTest(ITestOutputHelper testOutputHelper, CalculatorFixture calculatorFixture)
        {
            _testOutputHelper = testOutputHelper;
            _calculatorFixture = calculatorFixture;
            memoryStream = new MemoryStream();
        }
        [Fact]
        public void Add_GivenTwoIntValues_ReturnsInt() 
        {
            Calculator calculator = _calculatorFixture.calc ;
            int result = calculator.Add(1, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void AddDouble_GivenTwoDoubleValues_ReturnsDouble() 
        {
            Calculator calculator = _calculatorFixture.calc;
            double result = calculator.AddDouble(1.2, 3.5);
            Assert.Equal(4.7, result);
        }
        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotIncludeZero() 
        {
            Calculator calculator = _calculatorFixture.calc;
            Assert.All(calculator.FiboNumbers, n => Assert.NotEqual(0, n));
        }
        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboIncludes13() 
        {
            Calculator calculator = _calculatorFixture.calc;
            Assert.Contains(13, calculator.FiboNumbers);
        }
        [Fact]
        public void IsOdd_GivenOddValue_ReturnsTrue() 
        {
            Calculator calculator = _calculatorFixture.calc;
            bool result = calculator.IsOdd(1);
            Assert.True(result);
        }
        [Fact]
        public void IsOdd_GivenEvenValue_ReturnsFalse()
        {
            Calculator calculator = _calculatorFixture.calc;
            bool result = calculator.IsOdd(2);
            Assert.False(result);
        }
        [Theory]
        [InlineData(1, true)]
        [InlineData(200, false)]
        public void IsOdd_TestOddAndEven(int value, bool expected) 
        {
            Calculator calculator = _calculatorFixture.calc;
            bool result = calculator.IsOdd(value);
            Assert.Equal(expected,result);
        }
    }
}
