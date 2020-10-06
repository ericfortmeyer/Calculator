using System;

namespace CalculatorApp1.Commands
{
    public class DivideCommand : AbstractCommand, ICalculatorCommand
    {
        public DivideCommand(double firstOperand) : base(firstOperand)
        {
        }

        public double Execute(double divisor)
        {
            if (divisor.Equals(0))
                throw new DivideByZeroException();
            else
                return CalculateDivision(FirstOperand, divisor);
        }

        private double CalculateDivision(double dividend, double divisor) => dividend / divisor;

    }
}
