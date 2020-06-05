using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Disposables;
using Birch.Components;
using Birch.Compose;
using Birch.Shadows;
using Birch.Transactions;

namespace Birch.Collections
{
    /// <summary>
    /// The connection between a collection of items and its presentation, in this case all of the items are rendered by the user interface.
    /// </summary>
    /// <typeparam name="TChild"></typeparam>
    /// <remarks>
    /// This will have been invoked from a collection update and as such there will be a current <see cref="Transaction"/>.
    /// Thus ALL operations need to added to the current transaction.
    /// Note the comments on the requirement for a read lock to be present at the root build host.
    /// </remarks>
    public class ShadowGroupConnector<TChild>:IDataConnector<IPrimitive> where TChild : class
    {
        /// <summary>
        /// The associated group
        /// </summary>
        private readonly IShadowChildGroup<TChild> _shadowGroup;

        /// <summary>
        /// The associated <see cref="IShadowContext"/>
        /// </summary>
        private readonly IShadowContext _context;

        /// <summary>
        /// The list of <see cref="IShadow"/> children.
        /// </summary>
        private readonly List<IShadow<TChild>> _items = new List<IShadow<TChild>>();

        public ShadowGroupConnector(IShadowContext context,IShadowChildGroup<TChild> shadowGroup)
        {
            _context = context;
            _shadowGroup = shadowGroup;
        }

        /// <summary>
        /// Add a <see cref="IPrimitive"/>
        /// </summary>
        /// <param name="item"></param>
        public void Add(IPrimitive item)
        {
            Insert(_items.Count,item);
        }

        /// <summary>
        /// Insert a <see cref="IPrimitive"/> at the specified index.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="item"></param>
        /// <remarks>
        /// All manipulation of shadows list must occur when the transaction is committed.
        /// </remarks>
        public void Insert(int index, IPrimitive item)
        {
            var raw = _context.MapperFactory.Create(_context, item);

            Transaction.Current.Add(() =>
            {
                var newSubView = (IShadow<TChild>)raw;                        

                _items.Insert(index,newSubView);

                _shadowGroup.Add(newSubView,index);
            });
        }

        /// <summary>
        /// Move a <see cref="IPrimitive"/> from one index to another.
        /// </summary>
        /// <param name="oldIndex"></param>
        /// <param name="newIndex"></param>
        /// <remarks>
        /// All operations on the underlying shadow list must occur during the commit phase
        /// of the transaction.</remarks>
        public void Move(int oldIndex, int newIndex)
        {
            Transaction.Current.Add(() =>
            {
                var v = _items[oldIndex];

                _shadowGroup.RemoveAt(oldIndex);
                _shadowGroup.Add( v, newIndex);

                var component = _items[oldIndex];
                _items.RemoveAt(oldIndex);
                _items.Insert(newIndex, component);
            });
        }

        /// <summary>
        /// Remove the <see cref="IPrimitive"/> at a specified index.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="current"></param>
        /// <remarks>
        /// WARNING : Whilst the remove and update functions expect the shadow to be provided
        /// there is the opportunity for the integrity of the _items array to not
        /// be observed.
        /// This is currently dealt with by having a read lock on the root build host.
        /// </remarks>
        public void Remove(int index,IPrimitive current)
        {
            var shadow = _items[index];

            Transaction.Current.Add(() =>
            {
                _items.RemoveAt(index);

                _shadowGroup.RemoveAt(index);
            });

            _context.MapperFactory.Remove(_context, shadow, current);

        }

        /// <summary>
        /// Update the <see cref="IPrimitive"/> at a specified index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="current"></param>
        /// <param name="next"></param>
        /// <remarks>
        /// WARNING : Whilst the remove and update functions expect the shadow to be provided
        /// there is the opportunity for the integrity of the _items array to not
        /// be observed.
        /// This is currently dealt with by having a read lock on the root build host.
        /// </remarks>
        public void Update(int index, IPrimitive current, IPrimitive next)
        {
            //Debug.Assert()
            if (index < 0 || index >= _items.Count)
            {

            }
            var shadow = _items[index];

            _context.MapperFactory.Update(_context,shadow,current,next);
        }
    }
}