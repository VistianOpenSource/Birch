using System;
using System.Collections.Generic;
using System.Linq;
using Android.Views;
using MVU_Experiment.Collections;

namespace MVU_Experiment
{
    public abstract class BasePrimitiveGroupShadowMapper<TControl,TView,TShadow, TContext> : BasePrimitiveShadowMapper<TContext,TShadow, TView, TControl> 
        where TView : class
        where TContext:IShadowContext 
        where TShadow:Shadow<TView>
        where TControl:BasePrimitiveComponent<TView>
    {
        protected override void Update(TContext context, TShadow shadow, TControl current, TControl next)
        {
            // call down to do the default behaviour 
            base.Update(context,shadow,current,next);

            // and do the children

            UpdateElementCollection(context,shadow,current,next);
        }

        protected virtual void UpdateElementCollection(TContext context, TShadow shadow, TControl current, TControl next)
        {
            /*
            var currentValue = current?.Children;
            var nextValue = next?.Children;

            var collectionUpdate = new CollectionUpdate<TContext,TChild>(current?.Comparer??next?.Comparer);
            collectionUpdate.Apply(context,shadow,currentValue,nextValue);
            */
        }
    }
}