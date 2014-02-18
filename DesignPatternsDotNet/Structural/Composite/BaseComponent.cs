using System;
using System.Collections.Generic;

namespace DesignPatternsDotNet.Structural.Composite
{
    /// <summary>
    /// Implements both Component and Composite
    /// </summary>
    /// <typeparam name="TComponent">Actual type</typeparam>
    public abstract class BaseComponent<TComponent>
        where TComponent : BaseComponent<TComponent>
    {

        private Lazy<List<BaseComponent<TComponent>>> _children = new Lazy<List<BaseComponent<TComponent>>>(()
                => new List<BaseComponent<TComponent>>());

        private Lazy<List<BaseComponent<TComponent>>> _parents = new Lazy<List<BaseComponent<TComponent>>>(()
                => new List<BaseComponent<TComponent>>());


        /// <summary>
        /// Override for Composite and return `this`.
        /// </summary>
        /// <returns>null for Component, reference to itself for Composite.</returns>
        public virtual BaseComponent<TComponent> GetComposite()
        {
            return null;
        }


        #region Access To Children

        public IReadOnlyList<BaseComponent<TComponent>> GetChildren()
        {
            IReadOnlyList<BaseComponent<TComponent>> result = _children.Value;
            return result;
        }

        public void AddChild(BaseComponent<TComponent> child)
        {
            if (!_children.Value.Contains(child))
            {
                _children.Value.Add(child);
                child.AddParent(this);
            }
        }

        public void RemoveChild(BaseComponent<TComponent> child)
        {
            if (_children.Value.Contains(child))
            {
                _children.Value.Remove(child);
                child.RemoveParent(this);
            }
        }

        public BaseComponent<TComponent> GetChild(int index)
        {
            if (_children.Value.Count > index)
                return _children.Value[index];
            else
                return null;
        }

        #endregion Access To Children


        #region Access To Parents

        public IReadOnlyList<BaseComponent<TComponent>> GetParents()
        {
            IReadOnlyList<BaseComponent<TComponent>> result = _parents.Value;
            return result;
        }

        public void AddParent(BaseComponent<TComponent> parent)
        {
            if (!_parents.Value.Contains(parent))
            {
                _parents.Value.Add(parent);
                parent.AddChild(this);
            }
        }

        public void RemoveParent(BaseComponent<TComponent> parent)
        {
            if (_parents.Value.Contains(parent))
            {
                _parents.Value.Remove(parent);
                parent.AddChild(this);
            }
        }

        public BaseComponent<TComponent> GetParent(int index)
        {
            if (_parents.Value.Count > index)
                return _parents.Value[index];
            else
                return null;
        }

        #endregion Access To Parents

    }
}