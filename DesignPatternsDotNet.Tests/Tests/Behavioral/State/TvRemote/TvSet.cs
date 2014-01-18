using DesignPatternsDotNet.Behavioral.State;
using DesignPatternsDotNet.Tests.Tests.Behavioral.State.TvRemote.TvStates;

namespace DesignPatternsDotNet.Tests.Tests.Behavioral.State.TvRemote
{
    public class TvSet : BaseContext<BaseTvState>
    {
        public bool IsTurnedOn { get; set; }
        public BaseTvState NextState
        {
            get { return State; }
            set { State = value; }
        }

        public TvSet()
            : base(new TvStateOff())
        {
            Request();
        }

        public override void Request()
        {
            base.Request();
        }

    }
}
