using DesignPatternsDotNet.Tests.Base;
using DesignPatternsDotNet.Tests.Behavioral.Observer.Calculator;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatternsDotNet.Tests.Behavioral.State
{
    [TestFixture]
    public class CalculatorTests : BaseTestFixture
    {
        const int NUM_OF_DISPLAYS = 5;

        IList<Mock<CalculatorDisplay>> _displays;

        [SetUp]
        public override void SetUp()
        {
            _displays = new List<Mock<CalculatorDisplay>>();

            for (var i = 0; i < NUM_OF_DISPLAYS; i++)
            {
                var disp = new Mock<CalculatorDisplay>();

                disp.Setup(d => d.Update(It.IsAny<CalculatorState>()))
                    .Verifiable();

                _displays.Add(disp);
            }
        }

        [Test]
        public override void RunTests()
        {
            var state = new CalculatorState();
            var proc = new CalculatorProcessor(state);
            var calc = new Calculator(proc, _displays.Select(m => m.Object).ToArray());

            calc.Add(10);
            calc.Substract(5);

            foreach(var disp in _displays)
            {
                disp.VerifyAll();
            }
        }

    }
}
