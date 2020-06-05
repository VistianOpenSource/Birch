using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Birch.Components;
using Birch.Compose;
using Birch.Hosts;

namespace Birch.Collections
{
    /// <summary>
    /// Builders for construction of <see cref="BasePrimitive"/> where content comes from collections.
    /// </summary>
    public static partial class Collection
    {
        /// <summary>
        /// A weak collection table of the observables mapping to stateful containers. Relies on fact that the observable for the <see cref="IElement"/> is clearly persistent.
        /// </summary>
        private static readonly ConditionalWeakTable<IObservable<IElement>,StatefulContainer<int>> Builders = new ConditionalWeakTable<IObservable<IElement>, StatefulContainer<int>>();

        /// <summary>
        /// Create a observable collection builder from an <see cref="IObservable{T}"/>
        /// </summary>
        /// <typeparam name="TControl"></typeparam>
        /// <param name="buildEnvironment"></param>
        /// <param name="observable"></param>
        /// <param name="control"></param>
        /// <returns></returns>
        public static ObservableCollectionBuilder<TControl> From<TControl>(BuildEnvironment buildEnvironment,IObservable<IElement> observable, TControl control) 
            where TControl : IPrimitive
        {
            if (!Builders.TryGetValue(observable, out var builder))
            {
                builder = new ObservableCollectionBuilder<TControl>(buildEnvironment,observable);
                Builders.AddOrUpdate(observable,builder);
            }

            var collectionBuilder = (ObservableCollectionBuilder<TControl>) builder;
            collectionBuilder.Target = control;

            return collectionBuilder;
        }

        /// <summary>
        /// Create a collection from a specified enumeration of <see cref="IElement"/> instances.
        /// </summary>
        /// <typeparam name="TControl"></typeparam>
        /// <param name="context"></param>
        /// <param name="children"></param>
        /// <param name="control"></param>
        /// <returns></returns>
        public static TControl From<TControl>(LayoutContext context,IEnumerable<IElement> children,TControl control) where TControl : BasePrimitive
        {
            control.Attributes.SetAttribute(Group.ChildrenAttribute, children.Layout(context));
            return control;
        }
    }
}
