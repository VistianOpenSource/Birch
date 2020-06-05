using System;
using Birch.Components;
using Birch.Reflection;
using Xamarin.Forms;
using Attribute = Birch.Components.Attribute;

namespace Birch.Views
{
    public static class SliderExtensions
    {
        /// <summary>
        /// Structure to hold the min and max values for a slider.
        /// </summary>
        internal readonly struct SliderRange
        {
            public double Minimum { get; }
            public double Maximum { get; }

            public SliderRange(double minimum, double maximum)
            {
                if (minimum >= maximum)
                {
                    throw new ArgumentOutOfRangeException($"Minimum:{minimum} greater than or equal to maximum:{maximum}");
                }
                Minimum = minimum;
                Maximum = maximum;
            }
        }

        /// <summary>
        /// Attribute for the Range of a <see cref="Xamarin.Forms.Slider"/>
        /// </summary>
        internal static Attribute<SliderRange> RangeAttribute = Attribute.Register<SliderRange>(Attribute.Name<Slider>(nameof(RangeAttribute)));

        /// <summary>
        /// Specify the min and max values for a <see cref="Xamarin.Forms.Slider"/>
        /// </summary>
        /// <typeparam name="TControl"></typeparam>
        /// <param name="control"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static TControl MinMax<TControl>(this TControl control, double min, double max) where TControl : IReflectedPrimitive<Xamarin.Forms.Slider>
        {
            var range = new SliderRange(min, max);

            control.Attributes.SetAttribute(RangeAttribute, range);

            return control;
        }

        static SliderExtensions()
        {
            AttributeMapperStore.Default.Register(RangeAttribute, RangeAttribute.Mapper<SliderRange, Slider>((s, u) =>
                {
                    s.Item.Maximum = u.Maximum;
                    s.Item.Minimum = u.Minimum;
                }, (s, c, n) =>

                {
                    if (n.Minimum >= c.Maximum)
                    {
                        s.Item.Maximum = n.Maximum;
                        s.Item.Minimum = n.Minimum;
                    }
                    else
                    {
                        s.Item.Minimum = n.Minimum;
                        s.Item.Maximum= n.Maximum;
                    }
                },
                (s, c) =>
                {
                    s.Item.ClearValue(Slider.MaximumProperty);
                    s.Item.ClearValue(Slider.MinimumProperty);
                }));
        }
    }
}