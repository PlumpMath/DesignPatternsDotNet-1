using DesignPatternsDotNet.Structural.Composite;

namespace DesignPatternsDotNet.Tests.Tests.Structural.Composite.Products.Base
{
    public abstract class Product : BaseComponent<Product>
    {
        public abstract string ProductName { get; }

        protected decimal Price { get; set; }

        public virtual decimal GetPrice()
        {
            return Price;
        }
    }
}
