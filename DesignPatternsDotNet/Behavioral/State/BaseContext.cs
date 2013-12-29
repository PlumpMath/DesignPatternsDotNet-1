namespace DesignPatternsDotNet.Behavioral.State
{
    public abstract class BaseContext<TState> : IContext
        where TState : IState<IContext>
    {
        public TState State { get; protected set; }

        public BaseContext(TState state)
        {
            State = state;
        }

        public virtual void Request()
        {
            State.Handle(this);
        }
    }
}
