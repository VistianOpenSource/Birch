using System;
using System.Collections.Generic;
using System.Text;
using Birch.Collections;
using Birch.Components;
using Birch.Compose;
using Birch.Shadows;

namespace Birch.Views
{
    public abstract class XamFormsItemsViewShadowMapper<TView,TElement> : XamFormsListShadowMapper<TView,TElement> where TElement : BasePrimitive<TView> where TView : Xamarin.Forms.ItemsView
    {
        protected XamFormsItemsViewShadowMapper(Func<XamFormsContext, IShadow<TView>, IDataConnector<IPrimitive>> connector) : base(connector)
        {
        }

        protected override void Update(XamFormsContext context, IShadow<TView> shadow, TElement current, TElement next)
        {
            shadow.UpdateContent<Xamarin.Forms.View>(context,current?.Attributes.GetAttributeOrDefault(ItemsView.EmptyViewAttribute),
                next?.Attributes.GetAttributeOrDefault(ItemsView.EmptyViewAttribute), s =>
                {
                    shadow.Item.EmptyView = s.Item;
                }, s =>
                {
                    shadow.Item.EmptyView = null;
                });

            base.Update(context, shadow, current, next);
        }
    }
}
