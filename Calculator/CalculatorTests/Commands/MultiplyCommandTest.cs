using CalculatorApp1.Commands;
using NUnit.Framework;
using System;

namespace CalculatorTests.Commands
{
    class MultiplyCommandTest
    {
        [Test(TestOf = typeof(MultiplyCommand)), Sequential]
        public void MultipiesOperands([Random(3)] double firstOperand, [Random(3)] double secondOperand)
        {
            var expectedResult = firstOperand * secondOperand;

            var command = new MultiplyCommand(firstOperand);

            var actualResult = command.Execute(secondOperand);

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}
