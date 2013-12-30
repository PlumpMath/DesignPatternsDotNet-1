using DesignPatternsDotNet.Tests.Demos.Behavioral.State;
using System;

namespace DesignPatternsDotNet.Tests
{
    public class Program
    {
        static void Main(string[] args)
        {
            new CalculatorDemo().DoDemo();
            new TrafficLightDemo().DoDemo();
            new TvRemoteDemo().DoDemo();

            Console.WriteLine("<Enter>");
            Console.ReadLine();
        }
    }
}
