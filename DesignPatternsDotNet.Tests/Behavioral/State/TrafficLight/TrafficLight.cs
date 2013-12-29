using DesignPatternsDotNet.Behavioral.State;
using DesignPatternsDotNet.Tests.Behavioral.State.TrafficLight.LightStates;

namespace DesignPatternsDotNet.Tests.Behavioral.State.TrafficLight
{
    /// <summary>
    /// Implements a context object.
    /// </summary>
    /// 
    /// <example>
    /// Usage example:
    /// <code><![CDATA[
    /// 
    ///  TrafficLight trafficLight = new TrafficLight();
    ///  for (var i = 0; i < 10; i++)
    ///  {
    ///      Console.WriteLine(trafficLight.Color);
    ///      System.Threading.Thread.Sleep(trafficLight.Pause * 1000);
    ///      trafficLight.Request();
    ///  }
    /// 
    /// ]]>
    /// </code>
    /// </example>
    public class TrafficLight : BaseContext<BaseLightState>
    {
        public int Duration { get; set; }
        public TrafficLightColorType Color { get; set; }
        public BaseLightState NextLight
        {
            get { return State; }
            set { State = value;  }
        }

        public TrafficLight()
            : base(new RedLightState())
        {
            Request();
        }

        public override void Request()
        {
            base.Request();
        }
    }
}
