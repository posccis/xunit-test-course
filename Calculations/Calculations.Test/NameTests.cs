using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculations.Tests
{
    public class NameTests
    {
        [Fact]
        public void MakeFullName_GivenFirstAndLasName_ReturnsFullName() 
        {
            Names names = new Names();
            string result = names.MakeFullName("Victor", "Hugo");
            Assert.Equal("Victor Hugo", result);
        }

    }
}
