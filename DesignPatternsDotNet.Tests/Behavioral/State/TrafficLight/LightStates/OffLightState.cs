namespace DesignPatternsDotNet.Tests.Behavioral.State.TrafficLight.LightStates
{
    public class OffLightState : BaseLightState
    {
        protected override TrafficLightColorType Color
        {
            get { return TrafficLightColorType.None; }
        }

        protected override int Pause
        {
            get { return 0; }
        }

        protected override BaseLightState NextState
        {
            get { return new RedLightState(); }
        }
    }
}
