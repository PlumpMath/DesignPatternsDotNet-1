using DesignPatternsDotNet.Tests.Tests.Structural.Composite.ComputerParts;

namespace DesignPatternsDotNet.Tests.Tests.Structural.Composite.Products.Computers
{
    public class OfficeComputer : ComputerBase
    {
        public override string ProductName { get { return "Office computer"; } }
        public OfficeComputer()
        {
            AddChild(new MotherBoard());
            AddChild(new TowerCase());
        }
    }
}
