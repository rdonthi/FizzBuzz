
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    class FizzBuzzerTest
    {
        [TestCase]
        public void Generate()
        {
            FizzBuzzer test = new FizzBuzzer();
            Assert.AreEqual("Fizz", test.Generate(3));
            Assert.AreEqual("Buzz", test.Generate(5));
            Assert.AreEqual("FizzBuzz", test.Generate(15));
            Assert.AreEqual("1", test.Generate(1));
            Assert.AreEqual("2", test.Generate(2));
        }
    }
}