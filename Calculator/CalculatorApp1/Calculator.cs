using CalculatorApp1.Commands;
using System.Linq;

namespace CalculatorApp1
{
    public class Calculator
    {
        private char[] _currentValue = new char[] { '0' };
        private ICalculatorCommand _selectedOperator;
        public double CurrentValue { get => double.Parse(new string(_currentValue)); }

        public void AppendToCurrentValue(char valueToAppend) =>
            _currentValue = _currentValue.Append(valueToAppend).ToArray();

        public void Calculate(double secondOperand) =>
            _currentValue = _selectedOperator.Execute(secondOperand).ToString().ToCharArray();

        public void Clear() => _currentValue = new char[] { '0' };

        public void SetupCalculation(Operator @operator)
        {
            _selectedOperator = CommandFactory.Init(CurrentValue).GetCommand(@operator);
            Clear();
        }
    }
}
