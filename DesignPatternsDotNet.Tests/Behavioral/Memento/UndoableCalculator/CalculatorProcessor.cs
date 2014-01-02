using DesignPatternsDotNet.Behavioral.Memento;

namespace DesignPatternsDotNet.Tests.Behavioral.Memento.UndoableCalculator
{
    public class CalculatorProcessor : BaseOriginator<CalculatorState>
    {
        public CalculatorProcessor()
        {
            State = new CalculatorState();
        }

        public void Add(decimal number)
        {
            State.Total += number;
        }

        public decimal CurrentTotal
        {
            get
            {
                return State.Total;
            }
        }
    }
}
