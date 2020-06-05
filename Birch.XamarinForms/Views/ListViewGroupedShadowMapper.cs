using Birch.Collections;
using Birch.Components;
using Birch.Compose;
using Birch.Shadows;
using Xamarin.Forms;

namespace Birch.Views
{
    /// <summary>
    /// Shadow mapper for grouped <see cref="Xamarin.Forms.ListView"/>
    /// </summary>
    public class ListViewGroupedShadowMapper:XamFormsGroupListShadowMapper<Xamarin.Forms.ListView, ListViewGrouped, ListViewGroupedChild>
    {
        private static IDataConnector<ListViewGroupedChild> ConnectionFactory(XamFormsContext context,
            IShadow<Xamarin.Forms.ListView> shadow)
        {
            return new ListGroupViewConnector(shadow);
        }

        public ListViewGroupedShadowMapper() : base(ConnectionFactory,ListViewGrouped.GroupedChildrenAttribute)
        {
        }

        protected override Xamarin.Forms.ListView CreateItem(XamFormsContext context, ListViewGrouped element)
        {
            var view = base.CreateItem(context, element);

            view.ItemTemplate = new PrimitiveDataTemplateSelector(context,
                primitiveSelector: (o) => ((PrimitiveHolder) o).Primitive,
                bindingSelector: (o) => (o.Item?.BindingContext as PrimitiveHolder));

            view.IsGroupingEnabled = true;
            view.GroupDisplayBinding = new Binding(nameof(ListGroupChildrenSource.LongName));
            view.GroupShortNameBinding = new Binding(nameof(ListGroupChildrenSource.ShortName));

            return view;
        }
    }


}