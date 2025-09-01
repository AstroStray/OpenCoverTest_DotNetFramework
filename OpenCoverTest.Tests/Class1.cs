using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using OpenCoverTest.App;

namespace OpenCoverTest.Tests
{
    public class TestClass
    {
        [Fact]
        public void TestMethod()
        {
            Assert.True(true);
        }
    }


    public class CalculatorTests
    {

        [Fact]
        public void Add_ReturnsSum()
        {
            var calc = new Calculator();
            Assert.Equal(5, calc.Add(2, 3));
        }

        [Fact]
        public void Subtract_ReturnsDifference()
        {
            var calc = new Calculator();
            Assert.Equal(1, calc.Subtract(3, 2));
        }
    }

    public class StringHelperTests
    {
        [Fact]
        public void Reverse_ReturnsReversedString()
        {
            var helper = new StringHelper();
            Assert.Equal("cba", helper.Reverse("abc"));
        }

        [Fact]
        public void Reverse_NullInput_ReturnsNull()
        {
            var helper = new StringHelper();
            Assert.Null(helper.Reverse(null));
        }
    }
}
