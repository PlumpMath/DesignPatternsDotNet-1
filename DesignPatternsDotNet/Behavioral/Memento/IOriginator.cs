namespace DesignPatternsDotNet.Behavioral.Memento
{
    /// <summary>
    /// Originator (ContainerSolver): is the object which state to remember and restore back if needed.
    /// </summary>
    interface IOriginator<TState>
    {
        void SetMemento(IMemento<TState> memento);
        void CreateMemento(IMemento<TState> memento);
    }
}
