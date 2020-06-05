using System.Linq;
using Android.Views;
using Birch.Components;
using Birch.Reflection;

namespace Birch.Views
{
    /// <summary>
    /// Extension to allow for the specification of Margins for <see cref="ViewGroup.MarginLayoutParams"/>.
    /// </summary>
    public static class MarginExtensions
    {
        public static Attribute<Margins> MarginsAttribute = Components.Attribute.Register<Margins>(Components.Attribute.Name<ViewGroup>(".LayoutParams.Margins"));

        /// <summary>
        /// Specify the margins for the view when the <see cref="ViewGroup"/> uses <see cref="ViewGroup.MarginLayoutParams"/>
        /// </summary>
        /// <typeparam name="TControl"></typeparam>
        /// <param name="component"></param>
        /// <param name="margins"></param>
        /// <returns></returns>
        public static TControl Margins<TControl>(this TControl component, Margins margins)  where TControl:IReflectedPrimitive<Android.Views.View> 
        {
            component.Attributes.SetAttribute(MarginsAttribute,margins);
            return component;
        }

        static MarginExtensions()
        {
            AttributeMapperStore.Default.Register(MarginsAttribute, MarginsAttribute.Mapper<Margins, Android.Views.View>((s, a) =>
            {
                if (s.Item.LayoutParameters is ViewGroup.MarginLayoutParams lp)
                {
                    if (a.Left.HasValue)
                    {
                        lp.LeftMargin = a.Left.Value;
                    }

                    if (a.Right.HasValue)
                    {
                        lp.RightMargin = a.Right.Value;
                    }

                    if (a.Top.HasValue)
                    {
                        lp.TopMargin = a.Top.Value;
                    }

                    if (a.Bottom.HasValue)
                    {
                        lp.BottomMargin = a.Bottom.Value;
                    }
                }

            },update: (s, c, n) =>
            {
                if (s.Item.LayoutParameters is ViewGroup.MarginLayoutParams lp)
                {
                    if (c.Left != n.Left)
                    {
                        lp.LeftMargin = n.Left ?? 0;
                    }

                    if (c.Right != n.Right)
                    {
                        lp.RightMargin = n.Right ?? 0;
                    }

                    if (c.Top != n.Top)
                    {
                        lp.TopMargin = n.Top ?? 0;
                    }

                    if (c.Bottom != n.Bottom)
                    {
                        lp.BottomMargin = n.Bottom ?? 0;
                    }
                }
            }));
        }
    }
}