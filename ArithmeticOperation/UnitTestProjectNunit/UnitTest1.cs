using ClassLibraryArithmetic;
using NUnit.Framework;
using System;

namespace UnitTestProjectNunit
{
    [TestFixture]
    public class UnitTest1
    {
        ArithOperation arith;
        [SetUp]
        public void init()
        {
            arith = new ArithOperation();
        }
        [Test]
        public void SquareTest()
        {
            arith = new ArithOperation();
            int? expectedresult = arith.square(2);
            int? actualResult = 4;
            Assert.That(expectedresult, Is.EqualTo(actualResult));
        }
        [Test]
        public void NullCheckSquareTest()
        {
            arith = new ArithOperation();
            int? expectedresult = arith.square(null);
            int? actualResult = null;
            Assert.That(expectedresult, Is.EqualTo(actualResult));
        }
        [Test]
        public void CubeTest()
        {
            arith = new ArithOperation();
            int? expectedresult = arith.cube(2);
            int? actualResult = 8;
            Assert.That(expectedresult, Is.EqualTo(actualResult));
        }
        [Test]
        public void CubeNullCheckTest()
        {
            arith = new ArithOperation();
            int? expectedresult = arith.cube(null);
            int? actualResult = null;
            Assert.That(expectedresult, Is.EqualTo(actualResult));
        }
        [Test]
        public void DivideTest()
        {
            arith = new ArithOperation();
            double? expectedresult = arith.divide(8, 4);
            double? actualResult = 2;
            Assert.That(expectedresult, Is.EqualTo(actualResult));
        }
        [Test]
        public void DivideNullCheckTest()
        {
            arith = new ArithOperation();
            double? expectedresult = arith.divide(null, null);
            double? actualResult = null;
            Assert.That(expectedresult, Is.EqualTo(actualResult));
        }

        [TearDown]
        public void completed()
        {
            arith = null;
        }
    }
}