using System.Collections.Generic;
using System.Linq;
using Android.Views;
using Android.Widget;
using Birch.Collections;
using Birch.Components;
using Birch.Compose;
using Birch.Reflection;

namespace Birch.Views
{
    /// <summary>
    /// Extensions for the use of <see cref="Android.Widget.LinearLayout.LayoutParams"/> specific parameters for child views.
    /// </summary>
    public static class LinearLayoutExtensions
    {
        public static Attribute<GravityFlags> LayoutGravityAttribute = Attribute.Register<GravityFlags>(Attribute.Name(typeof(Android.Widget.LinearLayout),"LinearLayout.LayoutParams.Gravity"));
        public static Attribute<float> LayoutWeightAttribute = Attribute.Register<float>(Attribute.Name(typeof(Android.Widget.LinearLayout),"LinearLayout.LayoutParams.Weight"));

        /// <summary>
        /// Specify the layout gravity for views contained within a <see cref="Android.Widget.LinearLayout"/>
        /// </summary>
        /// <typeparam name="TControl"></typeparam>
        /// <param name="component"></param>
        /// <param name="gravity"></param>
        /// <returns></returns>
        public static TControl LinearLayoutGravity<TControl>(this TControl component, GravityFlags gravity)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            component.Attributes.SetAttribute(LayoutGravityAttribute,gravity);
            return component;
        }

        /// <summary>
        /// Specify the layout weight for views contained within a <see cref="Android.Widget.LinearLayout"/>
        /// </summary>
        /// <typeparam name="TControl"></typeparam>
        /// <param name="component"></param>
        /// <param name="weight"></param>
        /// <returns></returns>
        public static TControl LinearLayoutWeight<TControl>(this TControl component, float weight)  where TControl:IReflectedPrimitive<Android.Views.View>
        {
            component.Attributes.SetAttribute(LayoutWeightAttribute,weight);
            return component;
        }

        /// <summary>
        /// Setup the automatic attribute mappers
        /// </summary>
        static LinearLayoutExtensions()
        {
            AttributeMapperStore.Default.Register(LayoutGravityAttribute,LayoutGravityAttribute.Mapper<GravityFlags,Android.Views.View>((s, a) =>
                {
                    if (s.Item.LayoutParameters is Android.Widget.LinearLayout.LayoutParams lp)
                    {
                        lp.Gravity = a;
                    }
                },update: (s, c, n) =>
                {
                    if (s.Item.LayoutParameters is Android.Widget.LinearLayout.LayoutParams lp)
                    {
                        lp.Gravity = n;
                    }
                }));

            AttributeMapperStore.Default.Register(LayoutWeightAttribute,LayoutWeightAttribute.Mapper<float,Android.Views.View>((s, a) =>
            {
                if (s.Item.LayoutParameters is Android.Widget.LinearLayout.LayoutParams lp)
                {
                    lp.Weight = a;
                }
            },update: (s, c, n) =>
            {
                if (s.Item.LayoutParameters is Android.Widget.LinearLayout.LayoutParams lp)
                {
                    lp.Weight = n;
                }
            }));
        }
    }
}