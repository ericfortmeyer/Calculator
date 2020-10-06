using CalculatorApp1;
using CalculatorApp1.Commands;
using NUnit.Framework;
using System;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests : Calculator
    {
        private char NumberAsChar(double number) => Char.Parse(number.ToString());
        private void MakeCurrentValue(double number)
        {
            foreach (var c in number.ToString())
                AppendToCurrentValue(c);
        }

        [Test]
        public void The_AppendToCurrentValue_method_appends_given_number_to_current_value([Random(1, 9, 1)] double givenValue, [Random(2, 4, 1)] int timesAppended)
        {
            var expectedCurrentValue = double.Parse(new string(NumberAsChar(givenValue), timesAppended));

            Clear();

            for (var i = 1; i <= timesAppended; i++)
                AppendToCurrentValue(NumberAsChar(givenValue));

            Assert.That(CurrentValue, Is.EqualTo(expectedCurrentValue));
        }

        [Test]
        public void The_AppendtoCurrentValue_method_appends_zero([Random(1, 9, 1)] double givenInitialValue)
        {
            var expectedCurrentValue = givenInitialValue * 10;

            Clear();

            AppendToCurrentValue(Char.Parse(givenInitialValue.ToString()));
            AppendToCurrentValue('0');

            Assert.That(CurrentValue, Is.EqualTo(expectedCurrentValue));
        }

        [Test]
        public void The_CurrentValue_property_returns_a_number_without_prepended_zeros([Random(1, 9, 2)] double givenValueToAppend, [Random(1, 3, 1)] int timesToPrependZero)
        {
            var expectedCurrentValue = givenValueToAppend;

            Clear();

            void prependZeros(int _times)
            {
                for (var i = 1; i <= _times; i++)
                    AppendToCurrentValue('0');
            }

            prependZeros(timesToPrependZero);

            AppendToCurrentValue(NumberAsChar(givenValueToAppend));

            Assert.That(CurrentValue, Is.EqualTo(expectedCurrentValue));
        }

        [Test]
        public void The_Clear_method_resets_the_current_value_to_zero([Random(1, 9, 2)] double givenCurrentValue, [Random(1, 3, 1)] int timesToRepeat)
        {
            MakeCurrentValue(double.Parse(new string(NumberAsChar(givenCurrentValue), timesToRepeat).ToCharArray()));

            Clear();

            Assert.That(CurrentValue, Is.EqualTo(0));
        }

        [Test, Sequential, Description("The Calculate executes the setup calculation using the given second operand")]
        public void SetupCalculationTest([Random(4)] double firstOperand, [Random(4)] double secondOperand, [Values] Operator @operator)
        {
            var expectedResult = CommandFactory.Init(firstOperand).GetCommand(@operator).Execute(secondOperand);

            Clear();

            MakeCurrentValue(firstOperand);

            SetupCalculation(@operator);

            Calculate(secondOperand);

            Assert.That(CurrentValue, Is.EqualTo(expectedResult));
        }
    }
}