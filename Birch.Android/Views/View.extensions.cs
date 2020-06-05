using Birch.Reflection;

namespace Birch.Views
{
    public static class ViewExtensions
    {
        /// <summary>
        /// Specify the dimensions for a <see cref="IReflectedPrimitive{View}"/>
        /// </summary>
        /// <typeparam name="TControl"></typeparam>
        /// <param name="component"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static TControl Dimensions<TControl>(this TControl component, int width, int height)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            return component.Dimensions(new Dimensions(width, height));
        }

        /// <summary>
        /// Specify the dimensions for a <see cref="IReflectedPrimitive{View}"/>
        /// </summary>
        /// <typeparam name="TControl"></typeparam>
        /// <param name="component"></param>
        /// <param name="dimensions"></param>
        /// <returns></returns>
        public static TControl Dimensions<TControl>(this TControl component, Dimensions dimensions)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            component.Attributes.SetAttribute(View.DimensionsAttribute,dimensions);
            return component;
        }
    }
}