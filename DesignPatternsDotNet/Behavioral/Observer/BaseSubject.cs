using System.Collections.Generic;

namespace DesignPatternsDotNet.Behavioral.Observer
{
    public abstract class BaseSubject<TState>
    {
        private readonly List<BaseObserver<TState>> _observers;
        private TState _subjectState;

        private BaseSubject()
        {
            _observers = new List<BaseObserver<TState>>();
        }

        public BaseSubject(TState subjectState)
            : this()
        {
            _subjectState = subjectState;
        }

        public void Attach(BaseObserver<TState> observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);
        }

        public void Detach(BaseObserver<TState> observer)
        {
            if (_observers.Contains(observer))
                _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
                observer.Update(State);
        }

        public TState State
        {
            get { return _subjectState; }
            set { _subjectState = value; }
        }
    }
}
