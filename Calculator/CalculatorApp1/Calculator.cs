using CalculatorApp1.Commands;
using System.Linq;

namespace CalculatorApp1
{
    /// <summary>
    /// Encapsulates values and provides a set of operations used to make a set of mathematical calculations.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Encapsulated data used to keep track of a number that is an operand of a mathematical calculation.
        /// </summary>
        private char[] _currentValue = new char[] { '0' };

        /// <summary>
        /// The operation that has been chosen to compute the target mathematical calculation.
        /// </summary>
        private ICalculatorCommand _selectedOperator;

        /// <summary>
        /// The current state of the operand that will be used in a mathematical calculation.
        /// </summary>
        public double CurrentValue { get => double.Parse(new string(_currentValue)); }

        /// <summary>
        /// Provides a way to add a numeric character to the target operand.
        /// </summary>
        /// <param name="valueToAppend"></param>
        public void AppendToCurrentValue(char valueToAppend) =>
            _currentValue = _currentValue.Append(valueToAppend).ToArray();

        /// <summary>
        /// Computes the target mathematical calculation.
        /// </summary>
        /// <param name="secondOperand"></param>
        public void Calculate(double secondOperand) =>
            _currentValue = _selectedOperator.Execute(secondOperand).ToString().ToCharArray();

        /// <summary>
        /// Resets the current value used for the target operand.
        /// </summary>
        public void Clear() => _currentValue = new char[] { '0' };

        /// <summary>
        /// Prepare the state of this object in order to compute the target mathematical computation.
        /// </summary>
        /// <param name="operator"></param>
        public void SetupCalculation(Operator @operator)
        {
            _selectedOperator = CommandFactory.Init(CurrentValue).GetCommand(@operator);
            Clear();
        }
    }
}
