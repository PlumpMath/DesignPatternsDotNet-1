using DesignPatternsDotNet.Tests.Base;
using DesignPatternsDotNet.Tests.Behavioral.Observer.Calculator;
using DesignPatternsDotNet.Tests.Behavioral.State;
using System;
using System.Collections.Generic;

namespace DesignPatternsDotNet.Tests.Demos.Behavioral.Observer
{
    public class CalculatorDemo : BaseDemo<CalculatorTests>
    {
        public override string DemoTitle
        {
            get { return "Observer Pattern (Calculator)"; }
        }

        public override void DoDemo()
        {
            Console.WriteLine("===================[Begin Demo: "+DemoTitle+"]=====================");

            TestFixture.SetUp();
            TestFixture.RunTests();
            TestFixture.TearDown();

            var state = new CalculatorState();
            var proc = new CalculatorProcessor(state);
            var disp = new List<CalculatorDisplay>
            {
                new CalculatorDisplay(),
                new CalculatorDisplay(),
                new CalculatorDisplay(),
            };

            var calc = new Calculator(proc, disp.ToArray());

            Console.WriteLine("Running calculator with " + disp.Count + " displays");

            Console.WriteLine("Adding 10 ...");
            calc.Add(10);

            Console.WriteLine("Substracting 5 ...");
            calc.Substract(5);

            Console.WriteLine("===================[End Demo: "+DemoTitle+"]======================");
        }

        void ShowDisplayStatus(int n, CalculatorDisplay disp)
        {
            var state = disp.CurrentState;

            Console.WriteLine("Calculator display #{0} is: \"{1}\"",
                n, (state == null ? string.Empty : state.Total.ToString("f2")));
        }

    }
}
