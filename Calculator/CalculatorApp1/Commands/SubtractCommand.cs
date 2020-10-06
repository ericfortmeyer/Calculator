namespace CalculatorApp1.Commands
{
    public class SubtractCommand : AbstractCommand, ICalculatorCommand
    {
        public SubtractCommand(double firstOperand) : base(firstOperand) { }
        public double Execute(double secondOperand) => FirstOperand - secondOperand;
    }
}
