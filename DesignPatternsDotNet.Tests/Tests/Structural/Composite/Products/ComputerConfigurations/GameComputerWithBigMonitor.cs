using DesignPatternsDotNet.Tests.Tests.Structural.Composite.Products.Computers;
using DesignPatternsDotNet.Tests.Tests.Structural.Composite.Products.Monitors;

namespace DesignPatternsDotNet.Tests.Tests.Structural.Composite.Products.ComputerConfigurations
{
    public class GameComputerWithBigMonitor : ComputerConfigurationBase
    {
        public override string ProductName { get { return "Game PC w/24' monitor"; } }
        public GameComputerWithBigMonitor()
        {
            AddChild(new GameComputer());
            AddChild(new TwentyFourInchMonitor());
        }
    }
}
