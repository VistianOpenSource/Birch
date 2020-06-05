using Android.Views;
using Birch.Components;
using Birch.Compose;

namespace Birch.Views
{
    /// <summary>
    /// Our base standard Android primitive
    /// </summary>
    /// <typeparam name="TView"></typeparam>
    [ShadowMapper(typeof(AndroidShadowMapper<>))]
    public class AndroidView<TView> : BasePrimitive<TView> where TView : Android.Views.View
    {
    }
}