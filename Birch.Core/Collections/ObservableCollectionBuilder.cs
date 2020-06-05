using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using Birch.Components;
using Birch.Compose;
using Birch.Hosts;

namespace Birch.Collections
{
    /// <summary>
    /// Stand in, stateful class used to allow observables for data sources to group components.
    /// </summary>
    /// <typeparam name="TControl"></typeparam>
    /// <remarks>
    /// Given that the observables are only ever added to, the model isn't the current items but instead it is just a
    /// count of the items currently in the list.
    /// The PerformLayout then uses to the model to just extract those items from the collection which has been
    /// populated by the exception.</remarks>
    public sealed class ObservableCollectionBuilder<TControl>: StatefulContainer<int> where TControl: IPrimitive
    {
        /// <summary>
        /// Our observable
        /// </summary>
        private readonly IObservable<IElement> _observable;

        /// <summary>
        /// The list of items seen from the observable so far.
        /// </summary>
        private readonly List<IElement> _items = new List<IElement>();

        /// <summary>
        /// Our lock to control access to <see cref="_items"/>
        /// </summary>
        private readonly object _lock = new object();

        /// <summary>
        /// The disposable for the subscription to the observable.
        /// </summary>
        private IDisposable _disposable;

        public ObservableCollectionBuilder(BuildEnvironment environment,IObservable<IElement> observable):base(environment)
        {
            _observable = observable;
            _disposable = SubscribeToChanges();
        }

        public override void Dispose()
        {
            _disposable?.Dispose();
            _disposable = null;
        }

        /// <summary>
        /// Subscribe to the observable, record any changes and update the model state.
        /// </summary>
        /// <returns>
        /// </returns>
        private IDisposable SubscribeToChanges()
        {
            return _observable.Select(v =>
                {
                    lock (_lock)
                    {
                        _items.Add(v);
                        return _items.Count;
                    }
                }).
                Do(this.SetModel).
                Subscribe();
        }

        /// <summary>
        /// Get the initial state, in this case we have no items...
        /// </summary>
        /// <returns></returns>
        public override int InitState()
        {
            lock (_lock)
            {
                return _items.Count;
            }
        }

        /// <summary>
        /// The target component for the children attributes
        /// </summary>
        public TControl Target { get; set; }

        /// <summary>
        /// this is the externally called item, we can't avoid it...
        /// </summary>
        /// <param name="layoutContext"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        protected override IPrimitive PerformLayout(LayoutContext layoutContext, int model)
        {
            lock (_lock)
            {
                Target.Attributes.SetAttribute(Group.ChildrenAttribute, _items.Take(model).Layout(layoutContext));
            }

            return Target;
        }
    }
}