namespace DesignPatternsDotNet.Tests.Tests.Structural.Composite.Products.Monitors
{
    public class TwentyFourInchMonitor : MonitorBase
    {
        public override string ProductName { get { return "24' monitor"; } }
        public TwentyFourInchMonitor()
        {
            this.Price = 250m;
        }
    }
}
