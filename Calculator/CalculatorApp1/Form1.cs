using System.Windows.Forms;

namespace CalculatorApp1
{
    public partial class Form1 : Form
    {
        private Calculator Calculator { get; }
        private string DisplayedCurrentValue { get => Calculator.CurrentValue.ToString(); }
        public Form1()
        {
            Calculator = new Calculator();
            InitializeComponent();
            textBox1.Text = DisplayedCurrentValue;
        }


        private void RefreshDisplay() =>
           textBox1.Text = DisplayedCurrentValue;

        private void Clear_Click(object sender, System.EventArgs e)
        {
            Calculator.Clear();
            RefreshDisplay();
        }

        private void Add_Click(object sender, System.EventArgs e) =>
            Calculator.SetupCalculation(Operator.Add);

        private void Divide_Click(object sender, System.EventArgs e) =>
            Calculator.SetupCalculation(Operator.Divide);

        private void Multiply_Click(object sender, System.EventArgs e) =>
            Calculator.SetupCalculation(Operator.Multiply);

        private void Subtract_Click(object sender, System.EventArgs e) =>
            Calculator.SetupCalculation(Operator.Subtract);

        private void Equals_Click(object sender, System.EventArgs e)
        {
            Calculator.Calculate(Calculator.CurrentValue);
            RefreshDisplay();
        }

        private void Seven_Click(object sender, System.EventArgs e)
        {
            Calculator.AppendToCurrentValue('7');
            RefreshDisplay();
        }

        private void Eight_Click(object sender, System.EventArgs e)
        {
            Calculator.AppendToCurrentValue('8');
            RefreshDisplay();
        }

        private void Nine_Click(object sender, System.EventArgs e)
        {
            Calculator.AppendToCurrentValue('9');
            RefreshDisplay();
        }

        private void Four_Click(object sender, System.EventArgs e)
        {
            Calculator.AppendToCurrentValue('4');
            RefreshDisplay();
        }

        private void Five_Click(object sender, System.EventArgs e)
        {
            Calculator.AppendToCurrentValue('5');
            RefreshDisplay();
        }

        private void Six_Click(object sender, System.EventArgs e)
        {
            Calculator.AppendToCurrentValue('6');
            RefreshDisplay();
        }

        private void One_Click(object sender, System.EventArgs e)
        {
            Calculator.AppendToCurrentValue('1');
            RefreshDisplay();
        }

        private void Two_Click(object sender, System.EventArgs e)
        {
            Calculator.AppendToCurrentValue('2');
            RefreshDisplay();
        }

        private void Three_Click(object sender, System.EventArgs e)
        {
            Calculator.AppendToCurrentValue('3');
            RefreshDisplay();
        }

        private void Zero_Click(object sender, System.EventArgs e)
        {
            Calculator.AppendToCurrentValue('0');
            RefreshDisplay();
        }

        private void Decimal_Point_Click(object sender, System.EventArgs e)
        {
            Calculator.AppendToCurrentValue('.');
            RefreshDisplay();
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
