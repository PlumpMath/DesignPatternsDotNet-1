using DesignPatternsDotNet.Behavioral.Memento;
using DesignPatternsDotNet.Tests.Base;
using DesignPatternsDotNet.Tests.Behavioral.Memento.UndoableCalculator;
using NUnit.Framework;
using System;

namespace DesignPatternsDotNet.Tests.Behavioral.State
{
    [TestFixture]
    public class UndoableCalculatorTests : BaseTestFixture
    {
        Calculator _calculator;
        Memento<CalculatorState> _memento;

        public override void SetUp()
        {
            _memento = new Memento<CalculatorState>();
            _calculator = new Calculator(new CalculatorProcessor(), _memento);
        }

        public override void TearDown()
        {
            _memento.Dispose();
        }

        [Test]
        public override void RunTests()
        {
            Console.WriteLine(_calculator.ToString());

            Console.WriteLine("Adding 5...");
            _calculator.Add(5);
            Console.WriteLine(_calculator.ToString());
            Assert.AreEqual(5, _calculator.CurrentTotal);

            Console.WriteLine("Adding 10...");
            _calculator.Add(10);
            Console.WriteLine(_calculator.ToString());
            Assert.AreEqual(15, _calculator.CurrentTotal);

            Console.WriteLine("Undoing ...");
            _calculator.Undo();
            Console.WriteLine(_calculator.ToString());
            Assert.AreEqual(5, _calculator.CurrentTotal);

            Console.WriteLine("Undoing (one level only) ...");
            _calculator.Undo();
            Console.WriteLine(_calculator.ToString());
            Assert.AreEqual(5, _calculator.CurrentTotal);

        }

    }
}
