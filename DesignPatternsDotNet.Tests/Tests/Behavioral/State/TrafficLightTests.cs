using DesignPatternsDotNet.Tests.Base;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Color = DesignPatternsDotNet.Tests.Tests.Behavioral.State.TrafficLight.TrafficLightColorType;
using Sut = DesignPatternsDotNet.Tests.Tests.Behavioral.State.TrafficLight.TrafficLight;

namespace DesignPatternsDotNet.Tests.Tests.Behavioral.State
{
    [TestFixture]
    public class TrafficLightTests : BaseTestFixture
    {
        public class TestData
        {
            public Color Color { get; set; }
            public int Pause { get; set; }
        }

        IList<TestData> Tests;

        public override void SetUp()
        {
            Tests = new List<TestData>()
            {
                new TestData { Color = Color.Red, Pause = 5 },
                new TestData { Color = Color.Green, Pause = 5 },
                new TestData { Color = Color.Yellow, Pause = 2 },
                new TestData { Color = Color.Red, Pause = 5 },
                new TestData { Color = Color.Green, Pause = 5 },
                new TestData { Color = Color.Yellow, Pause = 2 },
            };
        }

        [Test]
        public override void RunTests()
        {
            var sut = new Sut();

            foreach(var test in Tests)
            {
                Console.WriteLine("Current light should be: {0} for {1} seconds.", test.Color, test.Pause);
                Assert.AreEqual(test.Color, sut.Color);
                Assert.AreEqual(test.Pause, sut.Duration);
                Console.WriteLine(" OK.");

                sut.Request();
            }
        }

    }
}
