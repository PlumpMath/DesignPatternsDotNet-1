using DesignPatternsDotNet.Behavioral.Observer;
using System;

namespace DesignPatternsDotNet.Tests.Tests.Behavioral.Observer.Calculator
{
    public class CalculatorDisplay : BaseObserver<CalculatorState>
    {
        public override void Update(CalculatorState subjectState)
        {
            CurrentState = subjectState;
            Console.WriteLine("New Calculator Total: {0}", subjectState.Total);
        }
    }
}
