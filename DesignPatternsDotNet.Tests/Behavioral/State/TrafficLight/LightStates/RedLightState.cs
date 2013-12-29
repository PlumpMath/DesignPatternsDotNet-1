namespace DesignPatternsDotNet.Tests.Behavioral.State.TrafficLight.LightStates
{
    public class RedLightState : BaseLightState
    {
        protected override TrafficLightColorType Color
        {
            get { return TrafficLightColorType.Red; }
        }

        protected override int Pause
        {
            get { return 5; }
        }

        protected override BaseLightState NextState
        {
            get { return new GreenLightState(); }
        }
    }
}
