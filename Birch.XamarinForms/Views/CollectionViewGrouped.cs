using Birch.Collections;
using Birch.Components;
using Birch.Compose;

namespace Birch.Views
{
    [ShadowMapper(typeof(CollectionViewGroupedShadowMapper))]
    public class CollectionViewGrouped : XamFormsVisualElement<Xamarin.Forms.CollectionView>
    {
        public static Attribute<CollectionViewGroupedChild[]> GroupedChildrenAttribute = Components.Attribute.Register(Components.Attribute.Name<Xamarin.Forms.CollectionView>(nameof(GroupedChildrenAttribute)),true,ArrayComparer<CollectionViewGroupedChild>.Default);

        public CollectionViewGrouped(CollectionViewGroupedChild[] children):base()
        {
            Attributes.SetAttribute(GroupedChildrenAttribute, children);
        }
    }
}