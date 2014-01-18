using System;

namespace DesignPatternsDotNet.Tests.Tests.Behavioral.Memento.UndoableCalculator
{
    [Serializable]
    public class CalculatorState
    {
        public decimal Total { get; set; }
    }
}
