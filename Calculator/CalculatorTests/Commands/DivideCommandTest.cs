using CalculatorApp1.Commands;
using NUnit.Framework;
using System;

namespace CalculatorTests.Commands
{
    public class DivideCommandTest
    {
        [Test(TestOf = typeof(DivideCommand)), Sequential]
        public void DividesOperands([Random(3)] double dividend, [Random(3)] double divisor)
        {
            if (divisor == 0)
                Assert.Warn("Division by zero prevented");

            var expectedResult = dividend / divisor;

            var command = new DivideCommand(dividend);

            var actualResult = command.Execute(divisor);

            Assert.That(actualResult, Is.EqualTo(expectedResult));

        }
    }
}
