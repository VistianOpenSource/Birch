using Android.Views;
using Birch.Components;
using Birch.Reflection;

namespace Birch.Views
{
    /// <summary>
    /// Attribute extension for <see cref="Android.Views.View"/> management.
    /// </summary>
    public static class View
    {
        /// <summary>
        /// Our derived <see cref="Dimensions"/> attribute used by all views.
        /// </summary>
        public static readonly Attribute<Dimensions> DimensionsAttribute = Attribute.Register<Dimensions>(Attribute.Name<Android.Views.View>(nameof(DimensionsAttribute)));

        static View()
        {
            AttributeMapperStore.Default.Register(DimensionsAttribute,
                DimensionsAttribute.Mapper<Dimensions, Android.Views.View>((s, a) =>
                {
                    if (s?.Item?.LayoutParameters != null)
                    {
                        s.Item.LayoutParameters.Width = a.Width;
                        s.Item.LayoutParameters.Height = a.Height;

                        s.Item.LayoutParameters = s.Item.LayoutParameters;
                    }
                    else
                    {
                        var lp = new Android.Views.ViewGroup.LayoutParams(a.Width, a.Height);
                        s.Item.LayoutParameters = lp;
                    }
                }));
        }
    }
}