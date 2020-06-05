using System;
using System.Collections.Generic;
using System.Text;
using Birch.Collections;
using Birch.Components;
using Birch.Compose;
using Birch.Shadows;
using Attribute = Birch.Components.Attribute;

namespace Birch.Views
{
    /// <summary>
    /// Base Shadow Mapper for Xamarin Forms grouped lists.
    /// </summary>
    /// <typeparam name="TView"></typeparam>
    /// <typeparam name="TElement"></typeparam>
    /// <typeparam name="TGroupElement"></typeparam>
    public abstract class XamFormsGroupListShadowMapper<TView,TElement,TGroupElement> : BasePrimitiveShadowMapper<XamFormsContext,TView,TElement> where TGroupElement : IGroupedPrimitive, IEquatable<TGroupElement> where TView : class where TElement: BasePrimitive<TView>
    {
        private readonly Func<XamFormsContext,IShadow<TView>, IDataConnector<TGroupElement>> _connector;
        private readonly Attribute<TGroupElement[]> _attribute;
        private readonly ICollectionComparer<TGroupElement> _comparer;

        protected XamFormsGroupListShadowMapper(Func<XamFormsContext,IShadow<TView>,
                                                IDataConnector<TGroupElement>> connector,
                                                Attribute<TGroupElement[]> attribute,
                                                ICollectionComparer<TGroupElement> comparer=default
                                                )
        {
            _connector = connector;
            _attribute = attribute;
            _comparer = comparer;
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

            var comparer = _comparer??new MyerComparer<TGroupElement>();

            //// create the update handler which connects the comparer with the connector
            var dataUpdateHandler = new BackingStoreUpdateHandler<XamFormsContext, TView,TGroupElement>(groupConnector,_attribute, comparer);

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
