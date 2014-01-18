namespace DesignPatternsDotNet.Tests.Tests.Behavioral.State.TrafficLight.LightStates
{
    public class RedLightState : BaseLightState
    {
        protected override TrafficLightColorType Color
        {
            get { return TrafficLightColorType.Red; }
        }

        protected override int Duration
        {
            get { return 5; }
        }

        protected override BaseLightState NextLight
        {
            get { return new GreenLightState(); }
        }
    }
}
