using System;
using Android.Views;
using Birch.Collections;
using Birch.Components;
using Birch.Compose;
using Birch.Shadows;

namespace Birch.Views
{
    /// <summary>
    /// Provides a default shadow mapping operation for <see cref="ViewGroup"/>
    /// </summary>
    /// <typeparam name="TView"></typeparam>
    [Preserve(AllMembers = true)]
    public class AndroidViewGroupShadowMapper<TView> : BasePrimitiveShadowMapper<AndroidContext,TView,AndroidViewGroup<TView>> where TView : ViewGroup
    {
        protected override TView CreateItem(AndroidContext context,AndroidViewGroup<TView> element) 
        {
            var instance = (TView) Activator.CreateInstance(typeof(TView), context.Context);

            var dimensions = element.Attributes.GetAttributeOrDefault(View.DimensionsAttribute);

            var lp = context.LayoutParamsFactory?.Invoke(dimensions??Dimensions.MatchMatch);

            if (lp != null)
            {
                instance.LayoutParameters = lp;
            }

            return instance;
        }

        /// <summary>
        /// Create the UI
        /// </summary>
        /// <param name="context"></param>
        /// <param name="initial"></param>
        /// <returns></returns>
        protected override IShadow<TView> Create(AndroidContext context, AndroidViewGroup<TView> initial)
        {
            // call down to the base to get the shadow 
            var shadow = (Shadow<TView>) base.Create(context, initial);

            // create the connector to the android view group
            var groupConnector =
                new ShadowGroupConnector<Android.Views.View>(context, new AndroidViewGroupConnection(shadow));

            // get the collection comparer, which the user may have overridden from the default one
            var comparer = initial.Attributes.GetAttributeOrDefault(Group.ComparerAttribute);

            // create the update handler which connects the comparer with the connector
            var dataUpdateHandler = new BackingStoreUpdateHandler<AndroidContext, TView,IPrimitive>(groupConnector,Group.ChildrenAttribute, comparer);

            // and finally set this as the adapter to be used 
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
        protected override void Update(AndroidContext context, IShadow<TView> shadow, AndroidViewGroup<TView> current, AndroidViewGroup<TView> next)
        {
            // create the context
            var childrenContext = CreateChildrenContext(context, shadow, current, next);
            // and update the children using the previously assigned adapter
            this.UpdateChildren(childrenContext, shadow, current, next);

            // and finally do this...
            base.Update(context, shadow, current, next);
        }

        /// <summary>
        ///     Remove this control from the UI
        /// </summary>
        /// <param name="context"></param>
        /// <param name="shadow"></param>
        /// <param name="current"></param>
        /// <remarks>
        ///     We remove the children first, then do any 'remove' at this level
        /// </remarks>
        protected override void Remove(AndroidContext context, IShadow<TView> shadow, AndroidViewGroup<TView> current)
        {
            this.RemoveChildren(context, shadow, current);
            this.ClearChildrenAdapter(context, shadow);
            base.Remove(context, shadow, current);
        }

        protected static AndroidContext CreateChildrenContext(AndroidContext context,IShadow<TView> shadow,AndroidViewGroup<TView>  current,AndroidViewGroup<TView>  next)
        {
            var layoutParamsFactory = (current??next).LayoutParamsFactory;

            var layoutContext = context.With((c) => c.LayoutParamsFactory = layoutParamsFactory);

            return layoutContext;
        }
    }
}