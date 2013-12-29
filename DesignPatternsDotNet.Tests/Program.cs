using DesignPatternsDotNet.Tests.Behavioral.State;
using DesignPatternsDotNet.Tests.Behavioral.State.TrafficLight;
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
            DoDemo();

            Console.WriteLine("<Enter>");
            Console.ReadLine();
        }

        public static void DoDemo()
        {
            Console.WriteLine("===================[Begin demo]=====================");

            var fixture = new TrafficLightTests();
            fixture.SetUp();
            fixture.RunTests();

            TrafficLight trafficLight = new TrafficLight();
            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine(trafficLight.Color);
                System.Threading.Thread.Sleep(trafficLight.Pause * 1000);
                trafficLight.Request();
            }

            Console.WriteLine("===================[End demno]======================");
        } 
    }
}
