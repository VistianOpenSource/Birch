using Birch.Components;
using Birch.Reflection;
using Xamarin.Forms;

namespace Birch.Views
{
    public static class FlexLayoutExtensions
    {
        public static Attribute<FlexAlignSelf> FlexAlignSelfAttribute =
            Components.Attribute.Register<FlexAlignSelf>(Components.Attribute.Name<Xamarin.Forms.FlexLayout>(nameof(Xamarin.Forms.FlexLayout.AlignSelfProperty)));

        public static Attribute<FlexBasis> FlexBasisAttribute =
            Components.Attribute.Register<FlexBasis>(Components.Attribute.Name<Xamarin.Forms.FlexLayout>(nameof(Xamarin.Forms.FlexLayout.BasisProperty)));

        public static Attribute<float> FlexShrinkAttribute =
            Components.Attribute.Register<float>(Components.Attribute.Name<Xamarin.Forms.FlexLayout>(nameof(Xamarin.Forms.FlexLayout.ShrinkProperty)));

        public static Attribute<float> FlexGrowAttribute =
            Components.Attribute.Register<float>(Components.Attribute.Name<Xamarin.Forms.FlexLayout>(nameof(Xamarin.Forms.FlexLayout.GrowProperty)));

        public static Attribute<int> FlexOrderAttribute = Components.Attribute.Register<int>(Components.Attribute.Name<Xamarin.Forms.FlexLayout>(nameof(Xamarin.Forms.FlexLayout.OrderProperty)));

        static FlexLayoutExtensions()
        {
            AttributeMapperStore.Default.Register(FlexAlignSelfAttribute, FlexAlignSelfAttribute.Mapper<FlexAlignSelf, Xamarin.Forms.View>(Xamarin.Forms.FlexLayout.SetAlignSelf));

            AttributeMapperStore.Default.Register(FlexBasisAttribute, FlexBasisAttribute.Mapper<FlexBasis, Xamarin.Forms.View>(Xamarin.Forms.FlexLayout.SetBasis));

            AttributeMapperStore.Default.Register(FlexShrinkAttribute, FlexShrinkAttribute.Mapper<float, Xamarin.Forms.View>(Xamarin.Forms.FlexLayout.SetShrink));

            AttributeMapperStore.Default.Register(FlexGrowAttribute, FlexGrowAttribute.Mapper<float, Xamarin.Forms.View>(Xamarin.Forms.FlexLayout.SetGrow));

            AttributeMapperStore.Default.Register(FlexOrderAttribute, FlexOrderAttribute.Mapper<int, Xamarin.Forms.View>(Xamarin.Forms.FlexLayout.SetOrder));
        }

        public static TControl AlignSelf<TControl>(this TControl control, FlexAlignSelf value)
            where TControl : IReflectedPrimitive<Xamarin.Forms.View>
        {
            control.Attributes.SetAttribute(FlexAlignSelfAttribute, value);
            return control;
        }

        public static TControl Basis<TControl>(this TControl control, FlexBasis value)
            where TControl : IReflectedPrimitive<Xamarin.Forms.View>
        {
            control.Attributes.SetAttribute(FlexBasisAttribute, value);
            return control;
        }

        public static TControl Shrink<TControl>(this TControl control, float value)
            where TControl : IReflectedPrimitive<Xamarin.Forms.View>
        {
            control.Attributes.SetAttribute(FlexShrinkAttribute, value);
            return control;
        }

        public static TControl Grow<TControl>(this TControl control, float value)
            where TControl : IReflectedPrimitive<Xamarin.Forms.View>
        {
            control.Attributes.SetAttribute(FlexGrowAttribute, value);
            return control;
        }

        public static TControl Order<TControl>(this TControl control, int value)
            where TControl : IReflectedPrimitive<Xamarin.Forms.View>
        {
            control.Attributes.SetAttribute(FlexOrderAttribute, value);
            return control;
        }
    }
}