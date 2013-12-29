namespace DesignPatternsDotNet.Tests.Behavioral.State.TrafficLight.LightStates
{
    public class OffLightState : BaseLightState
    {
        protected override TrafficLightColorType Color
        {
            get { return TrafficLightColorType.None; }
        }

        protected override int Duration
        {
            get { return 0; }
        }

        protected override BaseLightState NextLight
        {
            get { return new RedLightState(); }
        }
    }
}
