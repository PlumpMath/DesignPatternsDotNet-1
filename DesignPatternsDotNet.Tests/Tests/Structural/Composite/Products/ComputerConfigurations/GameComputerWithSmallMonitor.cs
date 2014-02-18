using DesignPatternsDotNet.Tests.Tests.Structural.Composite.Products.Computers;
using DesignPatternsDotNet.Tests.Tests.Structural.Composite.Products.Monitors;

namespace DesignPatternsDotNet.Tests.Tests.Structural.Composite.Products.ComputerConfigurations
{
    public class GameComputerWithSmallMonitor : ComputerConfigurationBase
    {
        public override string ProductName { get { return "Game PC w/21' monitor"; } }
        public GameComputerWithSmallMonitor()
        {
            AddChild(new GameComputer());
            AddChild(new TwentyOneInchMonitor());
        }
    }
}
