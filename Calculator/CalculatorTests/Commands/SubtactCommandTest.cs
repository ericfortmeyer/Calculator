using CalculatorApp1.Commands;
using NUnit.Framework;
using System;

namespace CalculatorTests.Commands
{
    class SubtactCommandTest
    {
        [Test(TestOf = typeof(SubtractCommand)), Sequential]
        public void SubtractsOperands([Random(3)] int firstOperand, [Random(3)] int secondOperand)
        {
            var expectedResult = firstOperand - secondOperand;

            var actualResult = new SubtractCommand(firstOperand).Execute(secondOperand);

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}
