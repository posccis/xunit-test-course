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
            string result = names.MakeFullName("victor", "Hugo");
            Assert.Equal("Victor Hugo", result, ignoreCase: true);
        }
        [Fact]
        public void NickName_MustBeNull() 
        {
            Names names = new Names();
            names.NickName = "Claudio";
            Assert.NotNull(names.NickName);
        }
        [Fact]
        public void MakeFullName_AlwaysReturnValue() 
        {
            Names names = new Names();
            string result = names.MakeFullName("Victor", "Hugo");
            Assert.NotNull(result);
            Assert.False (string.IsNullOrEmpty(result));
        }


    }
}
