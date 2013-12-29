using System;
using System.Linq;

namespace DesignPatternsDotNet.Tests.Base
{
    public abstract class BaseDemo<TTestFixture>
        where TTestFixture : BaseTestFixture
    {
        protected TTestFixture TestFixture { get; private set; }

        public BaseDemo()
        {
            Type fixtureType = typeof(TTestFixture);
            if (!fixtureType.GetConstructors().Any(c => c.GetParameters().Length == 0))
            {
                throw new MissingMemberException("Type " + fixtureType.Name + " does not have parameterless constructor.");
            }

            TestFixture = Activator.CreateInstance<TTestFixture>();
        }

        public abstract string DemoTitle { get; }
        public abstract void DoDemo();
    }
}
