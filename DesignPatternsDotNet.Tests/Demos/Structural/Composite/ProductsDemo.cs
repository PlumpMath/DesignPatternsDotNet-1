using DesignPatternsDotNet.Tests.Base;
using DesignPatternsDotNet.Tests.Tests.Structural.Composite;
using System;

namespace DesignPatternsDotNet.Tests.Demos.Structural.Composite
{
    public class ProductsDemo : BaseDemo<ProductsTests>
    {
        public override string DemoTitle
        {
            get { return "COmposite Pattern (Products)"; }
        }

        public override void DoDemo()
        {
            Console.WriteLine("===================[Begin Demo: " + DemoTitle + "]=====================");

            TestFixture.SetUp();
            TestFixture.RunTests();
            TestFixture.TearDown();

            Console.WriteLine("===================[End Demo: " + DemoTitle + "]======================");
        }
    }
}
