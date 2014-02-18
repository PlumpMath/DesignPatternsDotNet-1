using DesignPatternsDotNet.Tests.Tests.Structural.Composite.Products.Base;

namespace DesignPatternsDotNet.Tests.Tests.Structural.Composite.ComputerParts
{
    public class DvdRom : Product
    {
        public override string ProductName { get { return "DVD Rom"; } }

        public DvdRom()
        {
            Price = 45m;
        }
    }
}
