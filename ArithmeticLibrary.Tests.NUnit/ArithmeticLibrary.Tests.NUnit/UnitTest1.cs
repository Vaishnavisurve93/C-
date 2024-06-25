using NUnit.Framework;
using ArithmeticLibrary;
using System;

namespace ArithmeticLibrary.Tests.NUnit
{
    [TestFixture]
    public class ArithmeticOperationsTests
    {
        private ArithmeticOperations _arithmetic;

        [SetUp]
        public void Setup()
        {
            // Initialize a new instance of ArithmeticOperations before each test
            _arithmetic = new ArithmeticOperations();
        }

        [TearDown]
        public void Cleanup()
        {
            // Clean up resources after each test (if necessary)
            _arithmetic = null;
        }

        [Test]
        public void Add_ShouldReturnCorrectSum()
        {
            int result = _arithmetic.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            int result = _arithmetic.Subtract(5, 3);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            int result = _arithmetic.Multiply(2, 3);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            int result = _arithmetic.Divide(6, 3);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Divide_ByZero_ShouldThrowDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => _arithmetic.Divide(6, 0));
        }

        [Test]
        public void AddNullable_ShouldReturnCorrectSum_WhenBothNumbersAreNotNull()
        {
            int? result = _arithmetic.AddNullable(2, 3);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void AddNullable_ShouldReturnNull_WhenFirstNumberIsNull()
        {
            int? result = _arithmetic.AddNullable(null, 3);
            Assert.IsNull(result);
        }

        [Test]
        public void AddNullable_ShouldReturnNull_WhenSecondNumberIsNull()
        {
            int? result = _arithmetic.AddNullable(2, null);
            Assert.IsNull(result);
        }

        [Test]
        public void AddNullable_ShouldReturnNull_WhenBothNumbersAreNull()
        {
            int? result = _arithmetic.AddNullable(null, null);
            Assert.IsNull(result);
        }
    }
}
