
using DesignPatternsDotNet.Tests.Tests.Structural.Composite.Products.Base;

namespace DesignPatternsDotNet.Tests.Tests.Structural.Composite.ComputerParts
{
    public class MotherBoard : Product
    {
        public override string ProductName { get { return "Motherboard"; } }
        public MotherBoard()
        {
            Price = 145m;
        }
    }
}
