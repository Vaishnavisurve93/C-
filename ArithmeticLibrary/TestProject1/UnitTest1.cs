using System;
using Xunit;
using ArithmeticLibrary;

namespace ArithmeticLibrary.Tests
{
    public class ArithmeticOperationsTests
    {
        private readonly ArithmeticOperations _arithmeticOperations;

        public ArithmeticOperationsTests()
        {
            _arithmeticOperations = new ArithmeticOperations();
        }

        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            int result = _arithmeticOperations.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Subtract_ReturnsCorrectDifference()
        {
            int result = _arithmeticOperations.Subtract(5, 3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Multiply_ReturnsCorrectProduct()
        {
            int result = _arithmeticOperations.Multiply(2, 3);
            Assert.Equal(6, result);
        }

        [Fact]
        public void Divide_ReturnsCorrectQuotient()
        {
            double result = _arithmeticOperations.Divide(6, 3);
            Assert.Equal(2.0, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => _arithmeticOperations.Divide(6, 0));
        }
    }
}