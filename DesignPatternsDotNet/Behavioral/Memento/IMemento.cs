namespace DesignPatternsDotNet.Behavioral.Memento
{
    /// <summary>
    /// Memento (SolverState): Stores internal state of the Originator object.
    /// </summary>
    /// <typeparam name="TState"></typeparam>
    public interface IMemento<TState>
    {
        IMemento<TState> Save(TState state);
        TState Restore();
    }
}
