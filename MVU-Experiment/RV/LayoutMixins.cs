using Android.Support.V7.Widget;
using Birch.Components;
using Birch.Reflection;

namespace MVU_Experiment.RV
{
    public static class LayoutMixins
    {
        public static Attribute<RecyclerView.LayoutManager> LayoutManagerAttribute = Attribute.Register<RecyclerView.LayoutManager>("$Android:linearLayoutManager");

        static LayoutMixins()
        {
            AttributeMapperStore.Default.Register(LayoutManagerAttribute, LayoutManagerAttribute.Mapper<RecyclerView.LayoutManager,RecyclerView>((s, a) =>
                {
                    s.Item.SetLayoutManager(a);
                }, (s, o, n) =>
                {
                    s.Item.SetLayoutManager(n);
                }, (s, c) =>
                {
                    s.Item.SetLayoutManager(null);
                }
            ));
        }

        public static TControl LayoutManager<TControl>(this TControl component, RecyclerView.LayoutManager layoutManager)  where TControl:IPrimitive
        {
            component.Attributes.SetAttribute(LayoutManagerAttribute,layoutManager);
            return component;
        }
    }
}