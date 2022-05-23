using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace FRMK.BLL.Test
{
    public class Tests
    {

        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void IsPrimeNumber_Zero_False()
        {
            Assert.IsFalse(_calculator.IsPrimeNumber(0));
        }

        [TestCase(1, false)]
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, false)]
        [TestCase(5, true)]
        [TestCase(9, false)]
        [TestCase(11, true)]
        public void IsPrimeNumber_TestReturns(int number, bool expected)
        {
            Assert.IsFalse(_calculator.IsPrimeNumber(0));
        }


        [TestCase(10, 1, 2, 5, 10)]
        [TestCase(45, 1, 3, 5, 9, 15, 45)]
        public void GetDivisors_TestReturns(int number, params int[] expected)
        {
            var result = _calculator.GetDivisors(number);
            Assert.AreEqual(expected, result.ToArray());
        }


        [TestCase(new[] { 1, 2, 5, 10 }, new []{2, 5})]
        [TestCase(new[] { 1, 3, 5, 9, 15, 45 }, new []{3, 5})]
        public void FilterPrimeNumbers_Results(int [] numbers, int[] expected)
        {
            var result = _calculator.FilterPrimeNumbers(numbers.ToList());
            Assert.AreEqual(expected, result.ToArray());
        }


        [TestCase(10, new[] { 1, 2, 5, 10 }, new[] { 2, 5 })]
        [TestCase(45, new[] { 1, 3, 5, 9, 15, 45 }, new[] { 3, 5 })]
        public void GetDivisorsAndPrimeDivisors_Results(int number, int[] expectedDivisors, int[] expectedPrimeDivisors)
        {
            var result = _calculator.GetDivisorsAndPrimeDivisors(number);
            Assert.AreEqual(expectedDivisors, result.Divisors.ToArray());
            Assert.AreEqual(expectedPrimeDivisors, result.PrimeDivisors.ToArray());
        }

    }
}