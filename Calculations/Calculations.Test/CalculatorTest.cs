using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculations.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_GivenTwoIntValues_ReturnsInt() 
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(1, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void AddDouble_GivenTwoDoubleValues_ReturnsDouble() 
        {
            Calculator calculator = new Calculator();
            double result = calculator.AddDouble(1.2, 3.5);
            Assert.Equal(4.7, result);
        }
        [Fact]
        public void FiboDoesNotIncludeZero() 
        {
            Calculator calculator = new Calculator();
            Assert.All(calculator.FiboNumbers, n => Assert.NotEqual(0, n));
        }
        [Fact]
        public void FiboIncludes13() 
        {
            Calculator calculator = new Calculator();
            Assert.Contains(13, calculator.FiboNumbers);
        }
    }
}
