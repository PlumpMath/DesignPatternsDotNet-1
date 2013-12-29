namespace DesignPatternsDotNet.Tests.Behavioral.State.TvRemote.TvStates
{
    public class TvStateOff : BaseTvState
    {
        protected override bool IsTurnedOn
        {
            get { return false; }
        }

        protected override BaseTvState NextState
        {
            get { return new TvStateOn(); }
        }
    }
}
