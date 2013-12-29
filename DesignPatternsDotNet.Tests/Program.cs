using DesignPatternsDotNet.Tests.Behavioral.State;
using DesignPatternsDotNet.Tests.Behavioral.State.TrafficLight;
using DesignPatternsDotNet.Tests.Demos.Behavioral.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDotNet.Tests
{
    public class Program
    {
        static void Main(string[] args)
        {
            new TrafficLightDemo().DoDemo();
            new TvRemoteDemo().DoDemo();

            Console.WriteLine("<Enter>");
            Console.ReadLine();
        }

        public static void DoStateDemo()
        {
            Console.WriteLine("===================[Begin Demo: State]=====================");

            var fixture = new TrafficLightTests();
            fixture.SetUp();
            fixture.RunTests();

            TrafficLight trafficLight = new TrafficLight();
            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine(trafficLight.Color);
                System.Threading.Thread.Sleep(trafficLight.Duration * 1000);
                trafficLight.Request();
            }

            Console.WriteLine("===================[End Demo: State]======================");
        } 
    }
}
