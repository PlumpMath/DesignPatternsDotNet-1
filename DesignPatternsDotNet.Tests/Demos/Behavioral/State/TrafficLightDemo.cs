using DesignPatternsDotNet.Tests.Base;
using DesignPatternsDotNet.Tests.Tests.Behavioral.State;
using System;

namespace DesignPatternsDotNet.Tests.Demos.Behavioral.State
{
    public class TrafficLightDemo : BaseDemo<TrafficLightTests>
    {
        public override string DemoTitle
        {
            get { return "State Pattern (TrafficLight)"; }
        }

        public override void DoDemo()
        {
            Console.WriteLine("===================[Begin Demo: "+DemoTitle+"]=====================");

            TestFixture.SetUp();
            TestFixture.RunTests();
            TestFixture.TearDown();

            Console.WriteLine("===================[End Demo: "+DemoTitle+"]======================");
        }
    }
}
