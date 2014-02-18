using DesignPatternsDotNet.Structural.Composite;
using DesignPatternsDotNet.Tests.Base;
using DesignPatternsDotNet.Tests.Tests.Structural.Composite.Products.Base;
using DesignPatternsDotNet.Tests.Tests.Structural.Composite.Products.ComputerConfigurations;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatternsDotNet.Tests.Tests.Structural.Composite
{
    [TestFixture]
    public class ProductsTests : BaseTestFixture
    {
        IList<KeyValuePair<ComputerConfigurationBase, decimal>> _tests;

        public override void SetUp()
        {
            _tests = new List<KeyValuePair<ComputerConfigurationBase, decimal>>()
            {
                new KeyValuePair<ComputerConfigurationBase, decimal>(new OfficeComputerWithSmallMonitor(), 367m),
                new KeyValuePair<ComputerConfigurationBase, decimal>(new OfficeComputerWithBigMonitor(), 467m),
                new KeyValuePair<ComputerConfigurationBase, decimal>(new GameComputerWithSmallMonitor(), 412m),
                new KeyValuePair<ComputerConfigurationBase, decimal>(new GameComputerWithBigMonitor(), 512m),
            };
        }

        public override void TearDown()
        {
        }

        [Test]
        public override void RunTests()
        {
            foreach ( var test in _tests)
            {
                var configuration = test.Key;
                var name = configuration.ProductName;
                var price = configuration.GetPrice();
                var expected = test.Value;

                Console.WriteLine("Product: {0}, price of ${1:f2}, expected price is ${2:f2}", name, price, expected);
                Assert.AreEqual(expected, price);

                Console.WriteLine("Should be composite, GetComposite() should not be null.");
                var composite = configuration.GetComposite();
                Assert.NotNull(composite);

                PrintProduct(configuration);

                Console.WriteLine("Ok.");
            }
        }

        private void PrintProduct(BaseComponent<Product> component, int indentLevel=0)
        {
            var product = component as Product;
            if (product == null)
                return;

            for (var i = 0; i < indentLevel + 1; i++)
                Console.Write(" ");

            Console.Write("{0}: ${1:f2}", product.ProductName, product.GetPrice());
            if (product.GetParents().Any())
                Console.Write(", incl.");
            Console.WriteLine();
            
            var composite = component.GetComposite();
            if (composite != null)
            {
                foreach (var child in composite.GetChildren())
                    PrintProduct(child, indentLevel + 1);
            }
        }
    }
}
