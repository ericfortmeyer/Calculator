namespace CalculatorApp1.Commands
{
    public sealed class CommandFactory
    {
        private double FirstOperand { get; }
        private CommandFactory(double firstOperand)
        {
            FirstOperand = firstOperand;
        }
        public static CommandFactory Init(double firstOperand) => new CommandFactory(firstOperand);
        public ICalculatorCommand GetCommand(Operator @operator)
        {
            if (@operator is Operator.Add) return new AddCommand(FirstOperand);

            if (@operator is Operator.Divide) return new DivideCommand(FirstOperand);

            if (@operator is Operator.Multiply) return new MultiplyCommand(FirstOperand);

            if (@operator is Operator.Subtract) return new SubtractCommand(FirstOperand);

            else return new AddCommand(FirstOperand);
        }
    }
}
