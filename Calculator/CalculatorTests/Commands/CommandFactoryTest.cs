using CalculatorApp1;
using CalculatorApp1.Commands;
using NUnit.Framework;
using System;

namespace CalculatorTests.Commands
{
    class CommandFactoryTest
    {
        protected CommandFactory GetTestSubject() => CommandFactory.Init(default);

        [Test]
        public void GetCommand_method_returns_an_AddCommand_when_given_an_Operator_Add_enum_value()
        {
            var instance = GetTestSubject().GetCommand(Operator.Add);

            Assert.That(instance, Is.InstanceOf<AddCommand>());
        }
        [Test]
        public void GetCommand_method_returns_a_SubtractCommand_when_given_an_Operator_Subtract_enum_value()
        {
            var instance = GetTestSubject().GetCommand(Operator.Subtract);

            Assert.That(instance, Is.InstanceOf<SubtractCommand>());
        }

        [Test]
        public void GetCommand_method_returns_a_DivideCommand_when_given_an_Operator_Divide_enum_value()
        {
            var instance = GetTestSubject().GetCommand(Operator.Divide);

            Assert.That(instance, Is.InstanceOf<DivideCommand>());
        }

        [Test]
        public void GetCommand_method_returns_a_MultiplyCommand_when_given_an_Operator_Multiply_enum_value()
        {
            var instance = GetTestSubject().GetCommand(Operator.Multiply);

            Assert.That(instance, Is.InstanceOf<MultiplyCommand>());
        }

        [Test]
        public void GetCommand_method_throws_an_argument_exception()
        {
            var invalid_operator_enum_value = unchecked((Operator)UInt64.MaxValue);
            void shouldThrow() => GetTestSubject().GetCommand(invalid_operator_enum_value);

            Assert.Throws<ArgumentException>(shouldThrow);
        }
    }
}
