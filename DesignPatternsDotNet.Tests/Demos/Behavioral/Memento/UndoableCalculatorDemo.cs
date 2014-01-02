using DesignPatternsDotNet.Tests.Base;
using DesignPatternsDotNet.Tests.Behavioral.State;
using System;

namespace DesignPatternsDotNet.Tests.Demos.Behavioral.Memento
{
    public class UndoableCalculatorDemo : BaseDemo<UndoableCalculatorTests>
    {
        public override string DemoTitle
        {
            get { return "Memento Pattern (Undoable Calculator)"; }
        }

        public override void DoDemo()
        {
            Console.WriteLine("===================[Begin Demo: "+DemoTitle+"]=====================");

            Console.WriteLine("===[ 1st Demo ]===");
            TestFixture.SetUp();
            TestFixture.RunTests();
            TestFixture.TearDown();

            Console.WriteLine("===[ 2nd Demo ]===");
            TestFixture.SetUp();
            TestFixture.RunTests();
            TestFixture.TearDown();

            Console.WriteLine("===================[End Demo: "+DemoTitle+"]======================");
        }
    }
}
