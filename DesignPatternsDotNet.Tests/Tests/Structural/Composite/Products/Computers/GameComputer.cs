using DesignPatternsDotNet.Tests.Tests.Structural.Composite.ComputerParts;

namespace DesignPatternsDotNet.Tests.Tests.Structural.Composite.Products.Computers
{
    public class GameComputer : ComputerBase
    {
        public override string ProductName { get { return "Game computer"; } }
        public GameComputer()
        {
            AddChild(new MotherBoard());
            AddChild(new TowerCase());
            AddChild(new DvdRom());
        }
    }
}
