using System;
using Android.Views;
using Birch.Components;
using Birch.Compose;
using Birch.Shadows;

namespace Birch.Views
{
    /// <summary>
    /// Basic <see cref="IShadowMapper"/> for Android views whereby the actual views are constructed using reflection.
    /// </summary>
    /// <typeparam name="TView"></typeparam>
    [Preserve(AllMembers = true)]
    public class AndroidShadowMapper<TView> : BasePrimitiveShadowMapper<AndroidContext, TView, AndroidView<TView>> where TView : Android.Views.View 
    {
        protected override TView CreateItem(AndroidContext context, AndroidView<TView> element)
        {
            var view = (TView) Activator.CreateInstance(typeof(TView), context.Context);

            if (context.LayoutParamsFactory != null)
            {
                // hang on, we need to get the dimensions from the attributes
                var dimensions = element.Attributes.GetAttributeOrDefault(View.DimensionsAttribute);

                view.LayoutParameters = context.LayoutParamsFactory(dimensions??Dimensions.WrapWrap);
            }

            return view;
        }
    }
}