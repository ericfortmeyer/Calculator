namespace CalculatorApp1.Commands
{
    public class MultiplyCommand : AbstractCommand, ICalculatorCommand
    {
        public MultiplyCommand(double firstOperand) : base(firstOperand)
        {
        }

        public double Execute(double secondOperand) => FirstOperand * secondOperand;
    }
}
