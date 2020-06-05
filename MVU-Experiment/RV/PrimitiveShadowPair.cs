using System;
using System.Threading;
using Android.Views;
using Birch.Components;
using Birch.Compose;
using Birch.Diagnostics;
using Birch.Shadows;
using Birch.Transactions;
using Microsoft.Extensions.Logging;

namespace MVU_Experiment.RV
{
        /// <summary>
    /// Internal map from view component to its shadow, along with the current associated primitive
    /// </summary>
    internal class PrimitiveShadowPair
    {
        /// <summary>
        /// Unique number used for identifying the view associated with the data for the RecyclerView
        /// </summary>
        public int ViewType { get; }

        /// <summary>
        /// The associated shadow view
        /// </summary>
        public IShadow Shadow { get; set; }

        /// <summary>
        /// The layout for the view
        /// </summary>
        public IPrimitive Current { get; set; }

        private PrimitiveShadowPair(int viewType, IPrimitive primitive)
        {
            ViewType = viewType;
            Current = primitive;
        }

        /// <summary>
        /// Counter for creating view types
        /// </summary>
        private static int _viewTypeCounter = 0;

        /// <summary>
        /// Is logging enabled
        /// </summary>
        private static readonly Lazy<bool> IsLoggingEnabled = new Lazy<bool>(() => LoggingRules.For(Categories.Collections).Any);

        /// <summary>
        /// Create a new instance with a unique view type
        /// </summary>
        /// <param name="component"></param>
        /// <returns></returns>
        public static PrimitiveShadowPair Create(IPrimitive component)
        {
            var viewType = Interlocked.Increment(ref _viewTypeCounter);

            return new PrimitiveShadowPair(viewType,component);
        }

        /// <summary>
        /// Create the shadow view 
        /// </summary>
        /// <param name="context"></param>
        public void Create(AndroidContext context)
        {
            if (IsLoggingEnabled.Value)
            {
                Logging.Instance.LogDebug("ComponentShadowPair:Create {item}",Current);
            }

            // use an isolated transaction to ensure the shadow is property populated by the time of the commit and also
            // due to the fact that it will have been invoked from the binding/creation by the recycler view.
            // 
            using var transaction = Transaction.Create(isolated:true);

            Shadow = context.MapperFactory.Create(context, Current);

            transaction.Commit();
        }


        public void Update(AndroidContext context, IPrimitive next)
        {
            if (IsLoggingEnabled.Value)
            {
                Logging.Instance.LogDebug("ComponentShadowPair:Update {from} to {to}",Current,next);
            }

            // If the item is currently being shown
            if (Shadow != null)
            {
                if (Current.CanUpdateTo(next))
                {
                    throw new ArgumentException($"Type Mismatch {Current.GetType().Name}:{next.GetType().Name}");
                }
                else
                {
                    // This will have been called as a result of transactions being committed
                    // hence there won't be any transaction in place and so
                    // we need to create one to perform the update.
                    // This would result in a cascade down and result in further updates occuring under this
                    // isolated transaction
                    using var transaction = Transaction.Create(isolated:true);

                    context.MapperFactory.Update(context, Shadow, Current, next);

                    transaction.Commit();
                }
            }

            Current = next;
        }

        public void Bind(View view,AndroidContext context)
        {
        }

        public void UnBind(AndroidContext context)
        {
            // we have been unbound...this means that the view has been binned off
            // BUT this doesn't mean that the primitive element backing the view doesn't exist either

            if (IsLoggingEnabled.Value)
            {
                Logging.Instance.LogDebug("ComponentShadowPair:Unbind {item}",Current);
            }

            using var transaction = Transaction.Create(isolated: true);
            context.MapperFactory.Remove(context,this.Shadow,Current);
            transaction.Commit();

            // finally clear down the shadow so we know not to try and do updates to it
            Shadow = null;
        }
    }
}