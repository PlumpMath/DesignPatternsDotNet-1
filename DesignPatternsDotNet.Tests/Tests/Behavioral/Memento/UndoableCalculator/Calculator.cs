using DesignPatternsDotNet.Behavioral.Memento;

namespace DesignPatternsDotNet.Tests.Tests.Behavioral.Memento.UndoableCalculator
{
    /// <summary>
    /// Caretaker is the object that controls when to create Memento but the Originator.
    /// Will use the stored into the Caretaker state to restore from.
    /// </summary>
    public class Calculator
    {
        private readonly CalculatorProcessor _processor;
        private readonly Memento<CalculatorState> _memento;

        public Calculator(CalculatorProcessor processor, Memento<CalculatorState> memento)
        {
            _processor = processor;
            _memento = memento;
            _processor.CreateMemento(_memento);
        }

        public void Add(decimal number)
        {
            _processor.CreateMemento(_memento);
            _processor.Add(number);
        }

        public decimal CurrentTotal
        {
            get { return _processor.CurrentTotal; }
        }

        public void Undo()
        {
            _processor.SetMemento(_memento);
        }

        public override string ToString()
        {
            return "Undoable Calculator Total: " + _processor.CurrentTotal.ToString("f2");
        }
    }
}
