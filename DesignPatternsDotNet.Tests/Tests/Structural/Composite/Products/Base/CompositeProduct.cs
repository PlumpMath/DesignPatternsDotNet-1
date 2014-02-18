using DesignPatternsDotNet.Structural.Composite;
using System.Linq;

namespace DesignPatternsDotNet.Tests.Tests.Structural.Composite.Products.Base
{
    public abstract class CompositeProduct : Product
    {
        public override BaseComponent<Product> GetComposite()
        {
            return this;
        }

        public override decimal GetPrice()
        {
            return GetChildren().Sum(ch => ((Product)ch).GetPrice());
        }
    }
}
