using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DecomposeDll;
using System.Collections.Generic;

namespace DecomposeDll.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [Description("Validation of invalid number on divisors call")]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateZeroEntryToDivisors()
        {
            var dll = new Decompose();

            var result = dll.DivisorsNumbers(0);

            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        [Description("Validation of invalid number on prime numbers call")]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateZeroEntryToPrimeNumbers()
        {
            var dll = new Decompose();

            var result = dll.PrimeNumbers(0);

            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        [Description("Validation of valid number on divisors call and the result")]
        public void ValidateValidEntryToDivisors()
        {
            var dll = new Decompose();

            var correctValues = new List<int> { 1, 3, 5, 9, 15, 45 };

            var result = dll.DivisorsNumbers(45);

            CollectionAssert.AreEqual(correctValues, result);
        }

        [TestMethod]
        [Description("Validation of valid number on prime numbers call and the result")]
        public void ValidateValidEntryToPrimeNumbers()
        {
            var dll = new Decompose();

            var correctValues = new List<int> { 1, 3, 5 };

            var result = dll.PrimeNumbers(45);

            CollectionAssert.AreEqual(correctValues, result);
        }
    }
}
