using Birch.Collections;
using Birch.Compose;
using Birch.Shadows;

namespace Birch.Components
{
    /// <summary>
    /// Collection of extensions of the updating and removal of children views.
    /// </summary>
    public static class GroupExtensions
    {
        public static void UpdateChildren<TContext,TView>(this IShadowMapper mapper,TContext context,IShadow<TView> shadow, BasePrimitive<TView> current, BasePrimitive<TView> next) where TView : class 
        {
            var adapter= shadow.State.Get<IBackingDataHandler<TContext,TView>>();

            adapter.Update(context,current,next);
        }

        public static void RemoveChildren<TContext, TView>(this IShadowMapper mapper, TContext context, IShadow<TView> shadow, BasePrimitive<TView> current) where TView : class
        {
            var adapter= shadow.State.Get<IBackingDataHandler<TContext,TView>>();

            adapter.Remove(context,current);
        }

        public static void SetChildrenAdapter<TContext, TView>(this IShadowMapper mapper, TContext context, IShadow<TView> shadow,IBackingDataHandler<TContext,TView> adapter) where TView : class
        {
            shadow.State.Set(adapter);
        }

        public static void ClearChildrenAdapter<TContext, TView>(this IShadowMapper mapper,TContext context,IShadow<TView> shadow) where TView:class
        {
            shadow.State.Delete<IBackingDataHandler<TContext, TView>>();
        }

        public static TControl Comparer<TControl>(this TControl control, ICollectionComparer<IPrimitive> comparer) where TControl : class,IPrimitive
        {
            control.Attributes.SetAttribute(Group.ComparerAttribute, comparer);
            return control;
        }
    }
}