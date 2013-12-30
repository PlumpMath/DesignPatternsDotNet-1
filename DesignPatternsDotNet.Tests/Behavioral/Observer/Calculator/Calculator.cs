namespace DesignPatternsDotNet.Tests.Behavioral.Observer.Calculator
{
    public class Calculator
    {
        private CalculatorProcessor _processor;

        public Calculator(CalculatorProcessor processor)
        {
            _processor = processor;
        }

        public Calculator(CalculatorProcessor processor, CalculatorDisplay display)
        {
            _processor = processor;
            AddDisplay(display);
        }

        public Calculator(CalculatorProcessor processor, params CalculatorDisplay[] displays)
        {
            _processor = processor;

            foreach (var display in displays)
            {
                AddDisplay(display);
            }
        }

        public void AddDisplay(CalculatorDisplay display)
        {
            _processor.Attach(display);
        }

        public void Add(decimal number)
        {
            _processor.Add(number);
        }

        public void Substract(decimal number)
        {
            _processor.Substract(number);
        }

        public decimal CurrentTotal
        {
            get { return _processor.State.Total; }
        }
    }
}
