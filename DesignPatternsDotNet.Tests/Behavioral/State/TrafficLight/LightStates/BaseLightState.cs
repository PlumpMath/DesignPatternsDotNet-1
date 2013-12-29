using DesignPatternsDotNet.Behavioral.State;

namespace DesignPatternsDotNet.Tests.Behavioral.State.TrafficLight.LightStates
{
    public abstract class BaseLightState : IState<IContext> 
    {
        protected abstract TrafficLightColorType Color { get; }
        protected abstract int Duration { get; }
        protected abstract BaseLightState NextLight { get; }

        public void Handle(IContext context)
        {
            TrafficLight trafficLight = context as TrafficLight;
            if (trafficLight != null)
            {
                trafficLight.Color = Color;
                trafficLight.Duration = Duration;
                trafficLight.NextLight = NextLight;
            }
        }
    }
}
