using DesignPatternsDotNet.Tests.Tests.Structural.Composite.Products.Computers;
using DesignPatternsDotNet.Tests.Tests.Structural.Composite.Products.Monitors;

namespace DesignPatternsDotNet.Tests.Tests.Structural.Composite.Products.ComputerConfigurations
{
    public class OfficeComputerWithBigMonitor : ComputerConfigurationBase
    {
        public override string ProductName { get { return "Office PC w/24' monitor"; } }
        public OfficeComputerWithBigMonitor()
        {
            AddChild(new OfficeComputer());
            AddChild(new TwentyFourInchMonitor());
        }
    }
}
