using CalculatorApp1.Commands;
using NUnit.Framework;
using System;

namespace CalculatorTests.Commands
{
    class AddCommandTest
    {
        [Test(TestOf = typeof(AddCommand)), Sequential]
        public void AddsOperands([Random(3)] double firstOperand, [Random(3)] double secondOperand)
        {
            var expectedResult = firstOperand + secondOperand;

            var actualResult = new AddCommand(firstOperand).Execute(secondOperand);

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}
