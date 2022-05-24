using NUnit.Framework;
using System;
using NunitDemo;
namespace Nunit.Demo.Test

{
    [TestFixture]
    public class CalculatorTest
    {
        [Test, Order(2)]
        public void Test_Addition_With_Valid_Intigers()
        {
            var calc = new Calculator();
            var result = calc.Addition(3, 5);
            Assert.AreEqual(8, result);

        }
        [Test,Order(1)]
        public void Test_Substraction_Argument_Exception()
        {
            var calc = new Calculator();
            Assert.Catch<SystemException>(() => calc.Subtraction(4, 5));
            Assert.Throws<ArgumentException>(() => calc.Subtraction(4, 5));
        }

        [TestCase(1, 2, 3)]
        [TestCase(2, 3, 5)]
        [TestCase(3, 4, 7)]
        public void Test_Addition_Multiple(int first, int second, int expectedresult)
        {
            var calc = new Calculator();
            var calculated = calc.Addition(first, second);
            Assert.AreEqual(expectedresult, calculated);
        }

        [Ignore("Ignore test")]
        public void Test_To_Ignore()
        {
        }

    }
}
