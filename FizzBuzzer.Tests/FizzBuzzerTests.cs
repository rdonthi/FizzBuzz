using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        [TestCase]
        public void Generate()
        {
            FizzBuzzer test = new FizzBuzzer();
                  
            Assert.AreEqual("Fizz", test.Generate(3));
            Assert.AreEqual("Buzz", test.Generate(5));
            Assert.AreEqual("FizzBuzz", test.Generate(15));
            Assert.AreEqual("1", test.Generate(1));
        }
    }
}