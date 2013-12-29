namespace DesignPatternsDotNet.Tests.Behavioral.State.TvRemote.TvStates
{
    public class TvStateOn : BaseTvState
    {
        protected override bool IsTurnedOn
        {
            get { return true; }
        }

        protected override BaseTvState NextState
        {
            get { return new TvStateOff(); }
        }
    }
}
