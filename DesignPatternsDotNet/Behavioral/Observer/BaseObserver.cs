namespace DesignPatternsDotNet.Behavioral.Observer
{
    public abstract class BaseObserver<TState>
    {
        public TState CurrentState { get; protected set; }
        public abstract void Update(TState subjectState);
    }
}
