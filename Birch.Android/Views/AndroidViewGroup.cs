using System;
using Birch.Components;
using Birch.Compose;

namespace Birch.Views
{
    /// <summary>
    /// Base class for android views which are derived from <see cref="Android.Views.ViewGroup"/>
    /// </summary>
    /// <typeparam name="TView"></typeparam>
    [ShadowMapper(typeof(AndroidViewGroupShadowMapper<>))]
    public class AndroidViewGroup<TView> : AndroidView<TView> where TView : Android.Views.ViewGroup
    {
        public Func<Dimensions, Android.Views.ViewGroup.LayoutParams> LayoutParamsFactory { get; }

        public AndroidViewGroup(Func<Dimensions, Android.Views.ViewGroup.LayoutParams> layoutParams)
        {
            LayoutParamsFactory = layoutParams;
        }
    }
}