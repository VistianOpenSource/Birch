using System;
using Birch.Collections;
using Birch.Components;
using Birch.Compose;
using Birch.Shadows;

namespace Birch.Views
{
    /// <summary>
    /// Base Shadow Mapper for Xamarin Forms non grouped lists.
    /// </summary>
    /// <typeparam name="TView"></typeparam>
    /// <typeparam name="TElement"></typeparam>
    public abstract class XamFormsListShadowMapper<TView,TElement> : BasePrimitiveShadowMapper<XamFormsContext,TView,TElement> where TElement : BasePrimitive<TView> where TView : class
    {
        private readonly Func<XamFormsContext,IShadow<TView>, IDataConnector<IPrimitive>> _connector;

        protected XamFormsListShadowMapper(Func<XamFormsContext,IShadow<TView>,IDataConnector<IPrimitive>> connector)
        {
            _connector = connector;
        }

        protected override TView CreateItem(XamFormsContext context, TElement element)
        {
            var instance = (TView)Activator.CreateInstance(typeof(TView));

            return instance;
        }

        protected override IShadow<TView> Create(XamFormsContext context, TElement initial)
        {
            // call down to the base to get the shadow 
            var shadow = (Shadow<TView>) base.Create(context, initial);

            // create the connector to the list view
            var groupConnector = _connector(context,shadow);

            //// get the collection comparer, which the user may have overridden from the default one
            var comparer = initial.Attributes.GetAttributeOrDefault(Group.ComparerAttribute)??PrimitiveCollectionComparer.Default;

            //// create the update handler which connects the comparer with the connector
            var dataUpdateHandler = new BackingStoreUpdateHandler<XamFormsContext, TView,IPrimitive>(groupConnector,XamLayoutGroup.ChildrenAttribute, comparer);

            //// and finally set this as the adapter to be used 
            this.SetChildrenAdapter(context, shadow, dataUpdateHandler);

            return shadow;
        }

        /// <summary>
        /// Update the UI
        /// </summary>
        /// <param name="context"></param>
        /// <param name="shadow"></param>
        /// <param name="current"></param>
        /// <param name="next"></param>
        /// <remarks></remarks>
        /// <remarks>
        /// We do the children first, then we do 'this' level
        /// </remarks>
        protected override void Update(XamFormsContext context, IShadow<TView> shadow, TElement current,
            TElement next)
        {
            // and update the children using the previously assigned adapter
            this.UpdateChildren(context, shadow, current, next);

            // and finally do this...
            base.Update(context, shadow, current, next);
        }

        /// <summary>
        /// Remove this control from the UI
        /// </summary>
        /// <param name="context"></param>
        /// <param name="shadow"></param>
        /// <param name="current"></param>
        /// <remarks>
        ///     We remove the children first, then do any 'remove' at this level
        /// </remarks>
        protected override void Remove(XamFormsContext context, IShadow<TView> shadow, TElement current)
        {
            this.RemoveChildren(context, shadow, current);
            this.ClearChildrenAdapter(context, shadow);
            base.Remove(context, shadow, current);
        }
    }
}