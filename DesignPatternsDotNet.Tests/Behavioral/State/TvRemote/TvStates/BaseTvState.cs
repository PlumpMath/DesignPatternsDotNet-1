using DesignPatternsDotNet.Behavioral.State;

namespace DesignPatternsDotNet.Tests.Behavioral.State.TvRemote.TvStates
{
    public abstract class BaseTvState : IState<IContext>
    {
        protected abstract bool IsTurnedOn { get; }
        protected abstract BaseTvState NextState { get; }

        public void Handle(IContext context)
        {
            TvSet tvSet = context as TvSet;
            if (tvSet != null)
            {
                tvSet.IsTurnedOn = IsTurnedOn;
                tvSet.NextState = NextState;
            }
        }
    }

}
