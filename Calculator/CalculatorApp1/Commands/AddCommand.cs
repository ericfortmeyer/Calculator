namespace CalculatorApp1.Commands
{
    public class AddCommand : AbstractCommand, ICalculatorCommand
    {
        public AddCommand(double firstOperand) : base(firstOperand) { }

        public double Execute(double secondOperand) => FirstOperand + secondOperand;
    }
}
