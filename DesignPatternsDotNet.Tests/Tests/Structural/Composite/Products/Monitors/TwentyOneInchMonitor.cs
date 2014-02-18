namespace DesignPatternsDotNet.Tests.Tests.Structural.Composite.Products.Monitors
{
    public class TwentyOneInchMonitor : MonitorBase
    {
        public override string ProductName { get { return "21' monitor"; } }
        public TwentyOneInchMonitor()
        {
            this.Price = 150m;
        }
    }
}
