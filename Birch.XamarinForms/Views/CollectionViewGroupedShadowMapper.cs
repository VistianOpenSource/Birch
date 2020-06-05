using Birch.Collections;
using Birch.Components;
using Birch.Compose;
using Birch.Shadows;

namespace Birch.Views
{
    /// <summary>
    /// Shadow mapper for <see cref="CollectionViewGrouped"/>
    /// </summary>
    public class CollectionViewGroupedShadowMapper : XamFormsGroupListShadowMapper<Xamarin.Forms.CollectionView, CollectionViewGrouped, CollectionViewGroupedChild>
    {
        private static IDataConnector<CollectionViewGroupedChild> ConnectionFactory(XamFormsContext context,
            IShadow<Xamarin.Forms.CollectionView> shadow)
        {
            return new CollectionViewGroupConnector(shadow);
        }

        public CollectionViewGroupedShadowMapper() : base(ConnectionFactory,CollectionViewGrouped.GroupedChildrenAttribute)
        {
        }

        protected override Xamarin.Forms.CollectionView CreateItem(XamFormsContext context, CollectionViewGrouped element)
        {
            var cv = base.CreateItem(context, element);

            cv.ItemTemplate = new PrimitiveDataTemplateSelector(context,
                primitiveSelector: (o) => ((PrimitiveHolder) o).Primitive,
                bindingSelector: (o) => (o.Item?.BindingContext as PrimitiveHolder));

            cv.IsGrouped = true;

            cv.GroupHeaderTemplate = new PrimitiveHeaderDataTemplateSelector(context,
                bindingSelector: (o) => ((CollectionViewGroupSource) (o.Item?.BindingContext))?.GroupPrimitiveHolder,
                primitiveSelector: (o) => ((CollectionViewGroupSource) o).GroupHeader);

            return cv;
        }

        protected override void Update(XamFormsContext context, IShadow<Xamarin.Forms.CollectionView> shadow, CollectionViewGrouped current, CollectionViewGrouped next)
        {
            XamLayoutGroup.HeaderAttribute.Update(context, shadow, current, next, (s, c, a) =>
                {
                    s.Item.HeaderTemplate = new PrimitiveDataTemplateSelector(context,primitiveSelector:(o) => ((PrimitiveHolder) o).Primitive,bindingSelector:(o) => (o.Item?.BindingContext as PrimitiveHolder));
                    s.Item.Header = new PrimitiveHolder() {Primitive = a};
                },
                (s, x, c, n) =>
                {
                    (s.Item.Header as PrimitiveHolder).Primitive= n;
                },
                (s, x, c) => { }
            );

            base.Update(context, shadow, current, next);
        }
    }
}