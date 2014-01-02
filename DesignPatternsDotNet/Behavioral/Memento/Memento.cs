using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DesignPatternsDotNet.Behavioral.Memento
{
    /// <summary>
    /// Memento. Uses deep copy and serialization
    /// to save/restore the state of type TState.
    /// </summary>
    /// <typeparam name="TState"></typeparam>
    public class Memento<TState> : IMemento<TState>, IDisposable
    {
        private readonly MemoryStream _stream;
        private readonly BinaryFormatter _formatter;
        private bool _disposed;

        public Memento()
        {
            _disposed = false;
            _stream = new MemoryStream();
            _formatter = new BinaryFormatter();
        }

        public virtual IMemento<TState> Save(TState state)
        {
            _stream.SetLength(0);
            _formatter.Serialize(_stream, state);
            return this;
        }

        public virtual TState Restore()
        {
            _stream.Seek(0, SeekOrigin.Begin);
            TState state = (TState)_formatter.Deserialize(_stream);
            return state;
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                _stream.Close();
                _stream.Dispose();
                _disposed = true;
            }

            GC.SuppressFinalize(this);
        }

        ~Memento()
        {
            Dispose();
        }

    }
}
