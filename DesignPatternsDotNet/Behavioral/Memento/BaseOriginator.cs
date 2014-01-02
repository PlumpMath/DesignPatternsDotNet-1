using System;

namespace DesignPatternsDotNet.Behavioral.Memento
{
    public abstract class BaseOriginator<TState> : IOriginator<TState>
    {
        protected TState State { get; set; }

        public void SetMemento(IMemento<TState> memento)
        {
            State = memento.Restore();
        }

        public void CreateMemento(IMemento<TState> memento)
        {
            memento.Save(State);
        }
    }
}
