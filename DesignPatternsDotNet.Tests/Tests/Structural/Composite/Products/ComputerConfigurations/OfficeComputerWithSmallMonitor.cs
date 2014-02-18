using DesignPatternsDotNet.Tests.Tests.Structural.Composite.Products.Computers;
using DesignPatternsDotNet.Tests.Tests.Structural.Composite.Products.Monitors;

namespace DesignPatternsDotNet.Tests.Tests.Structural.Composite.Products.ComputerConfigurations
{
    public class OfficeComputerWithSmallMonitor : ComputerConfigurationBase
    {
        public override string ProductName { get { return "Office PC w/21' monitor"; } }

        public OfficeComputerWithSmallMonitor()
        {
            AddChild(new OfficeComputer());
            AddChild(new TwentyOneInchMonitor());
        }
    }
}
