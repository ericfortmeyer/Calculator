namespace CalculatorApp1.Commands
{
    public abstract class AbstractCommand
    {
        protected double FirstOperand { get; }
        public AbstractCommand(double firstOperand) => FirstOperand = firstOperand;
    }
}
