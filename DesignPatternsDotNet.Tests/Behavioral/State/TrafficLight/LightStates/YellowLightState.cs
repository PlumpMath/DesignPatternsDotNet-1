namespace DesignPatternsDotNet.Tests.Behavioral.State.TrafficLight.LightStates
{
    public class YellowLightState : BaseLightState
    {
        protected override TrafficLightColorType Color
        {
            get { return TrafficLightColorType.Yellow; }
        }

        protected override int Pause
        {
            get { return 2; }
        }

        protected override BaseLightState NextState
        {
            get { return new RedLightState(); }
        }
    }
}
