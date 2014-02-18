using DesignPatternsDotNet.Tests.Tests.Structural.Composite.Products.Base;

namespace DesignPatternsDotNet.Tests.Tests.Structural.Composite.ComputerParts
{
    public class TowerCase : Product
    {
        public override string ProductName { get { return "Tower box"; } }
        public TowerCase()
        {
            Price = 72m;
        }
    }
}
