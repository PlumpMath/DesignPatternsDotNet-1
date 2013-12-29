using DesignPatternsDotNet.Tests.Base;
using DesignPatternsDotNet.Tests.Behavioral.State;
using System;

namespace DesignPatternsDotNet.Tests.Demos.Behavioral.State
{
    public class TvRemoteDemo : BaseDemo<TvRemoteTests>
    {
        public override string DemoTitle
        {
            get { return "State Pattern (TvRemote)"; }
        }

        public override void DoDemo()
        {
            Console.WriteLine("===================[Begin Demo: "+DemoTitle+"]=====================");

            TestFixture.SetUp();
            TestFixture.RunTests();

            Console.WriteLine("===================[End Demo: "+DemoTitle+"]======================");
        }
    }
}
