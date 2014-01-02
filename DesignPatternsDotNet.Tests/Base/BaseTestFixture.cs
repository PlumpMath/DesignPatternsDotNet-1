using NUnit.Framework;

namespace DesignPatternsDotNet.Tests.Base
{
    public abstract class BaseTestFixture
    {
        [SetUp]
        public abstract void SetUp();

        [TearDown]
        public virtual void TearDown()
        { }

        public abstract void RunTests();
    }
}
