namespace DesignPatternsDotNet.Tests.Behavioral.State.TrafficLight.LightStates
{
    public class GreenLightState : BaseLightState
    {
        protected override TrafficLightColorType Color
        {
            get { return TrafficLightColorType.Green; }
        }

        protected override int Duration
        {
            get { return 5; }
        }

        protected override BaseLightState NextLight
        {
            get { return new YellowLightState(); }
        }
    }
}
