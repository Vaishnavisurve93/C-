using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ArithmeticLibrary;

public class ArithmeticOperationsTests
{
    public class ArithmeticOperationsTests
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            int result = ArithmeticOperations.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            int result = ArithmeticOperations.Subtract(5, 3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            int result = ArithmeticOperations.Multiply(2, 3);
            Assert.Equal(6, result);
        }

        [Fact]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            int result = ArithmeticOperations.Divide(6, 3);
            Assert.Equal(2, result);
        }

        [Test]
        public void Divide_ByZero_ShouldThrowDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => ArithmeticOperations.Divide(6, 0));
        }
    }
}
