using DesignPatternsDotNet.Behavioral.State;
using DesignPatternsDotNet.Tests.Behavioral.State.TrafficLight.LightStates;

namespace DesignPatternsDotNet.Tests.Behavioral.State.TrafficLight
{
    public class TrafficLight : BaseContext<BaseLightState>
    {
        public int Pause { get; set; }
        public TrafficLightColorType Color { get; set; }

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
