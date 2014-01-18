using Demos=DesignPatternsDotNet.Tests.Demos;
using System;

namespace DesignPatternsDotNet.Tests
{
    public class Program
    {
        static void Main(string[] args)
        {
            new Demos.Behavioral.State.TrafficLightDemo().DoDemo();
            new Demos.Behavioral.State.TvRemoteDemo().DoDemo();
            new Demos.Behavioral.Observer.CalculatorDemo().DoDemo();
            new Demos.Behavioral.Memento.UndoableCalculatorDemo().DoDemo();

            new Demos.Structural.Composite.ProductsDemo().DoDemo();

            Console.WriteLine("<Enter>");
            Console.ReadLine();
        }
    }
}
