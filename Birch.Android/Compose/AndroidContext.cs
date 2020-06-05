using System;
using Android.Content;
using Birch.Views;

namespace Birch.Compose
{
    /// <summary>
    /// The <see cref="IShadowContext"/> used for Android based solutions.
    /// </summary>
    public class AndroidContext : TransactionContext
    {
        /// <summary>
        /// The actual Android context
        /// </summary>
        public Context Context { get; }

        /// <summary>
        /// A function which will return a <see cref="Android.Views.ViewGroup.LayoutParams"/> given <see cref="Dimensions"/>
        /// </summary>
        public Func<Dimensions, Android.Views.ViewGroup.LayoutParams> LayoutParamsFactory { get; set; }

        public AndroidContext(ShadowMapperFactory mapperFactory, Context context, 
            Func<Dimensions, Android.Views.ViewGroup.LayoutParams> layoutParamsFactory,BuildOwner buildOwner) : base(mapperFactory,buildOwner)
        {
            Context = context;
            LayoutParamsFactory = layoutParamsFactory;
        }

        protected AndroidContext(AndroidContext androidContext):base(androidContext)
        {
            Context = androidContext.Context;
            LayoutParamsFactory = androidContext.LayoutParamsFactory;
        }

        /// <summary>
        /// Create a new cloned instance, applying the action after cloning.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        /// <remarks>
        /// This is typically used when the LayoutParamsFactory changes when being used in one of Androids view groups.
        /// Apologies to F#!
        /// </remarks>
        public AndroidContext With(Action<AndroidContext> action=default)
        {
            var newContext = new AndroidContext(this);

            action?.Invoke(newContext);

            return newContext;
        }
    }
}