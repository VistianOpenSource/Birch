using Birch.Collections;
using Birch.Components;
using Birch.Compose;

namespace Birch.Views
{
    [ShadowMapper(typeof(ListViewGroupedShadowMapper))]
    public class ListViewGrouped : XamFormsVisualElement<Xamarin.Forms.ListView>
    {
        public static Attribute<ListViewGroupedChild[]> GroupedChildrenAttribute = Components.Attribute.Register(Components.Attribute.Name<Xamarin.Forms.ListView>(nameof(ListViewGroupedChild)),true,ArrayComparer<ListViewGroupedChild>.Default);

        public ListViewGrouped(ListViewGroupedChild[] children):base()
        {
            Attributes.SetAttribute(GroupedChildrenAttribute, children);
        }
    }
}