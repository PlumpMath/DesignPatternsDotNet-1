using DesignPatternsDotNet.Behavioral.Observer;

namespace DesignPatternsDotNet.Tests.Behavioral.Observer.Calculator
{
    public class CalculatorProcessor : BaseSubject<CalculatorState>
    {
        public CalculatorProcessor(CalculatorState state)
            : base(state)
        { }

        public void Add(decimal number)
        {
            this.State.Total += number;
            this.Notify();
        }

        public void Substract(decimal number)
        {
            this.State.Total -= number;
            this.Notify();
        }
    }
}
