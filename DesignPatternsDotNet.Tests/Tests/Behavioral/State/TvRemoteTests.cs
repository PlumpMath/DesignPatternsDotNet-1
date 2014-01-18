using DesignPatternsDotNet.Tests.Base;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Sut = DesignPatternsDotNet.Tests.Tests.Behavioral.State.TvRemote.TvSet;

namespace DesignPatternsDotNet.Tests.Tests.Behavioral.State
{
    [TestFixture]
    public class TvRemoteTests : BaseTestFixture
    {
        IList<bool> Tests;

        public override void SetUp()
        {
            Tests = new List<bool>()
            {
                true, false, true, false, true, false,
            };
        }

        [Test]
        public override void RunTests()
        {
            var sut = new Sut();

            foreach(var test in Tests)
            {
                sut.Request();
                Console.WriteLine("Tv should be " + (test ? "ON" : "OFF"));
                Assert.AreEqual(test, sut.IsTurnedOn);
                Console.WriteLine(" OK.");
            }
        }

    }
}
