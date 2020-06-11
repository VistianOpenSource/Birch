using System;
using System.Collections.Generic;
using System.Text;
using Birch.Components;
using Birch.Compose;
using Birch.Shadows;

namespace Birch.Views
{
    [ShadowMapper(typeof(ShadowMapper))]
    public class ViewCell:XamFormsVisualElement<Xamarin.Forms.ViewCell>
    {
        public ViewCell(IPrimitive content):base()
        {
            this.Attributes.SetAttribute(ViewExtensions.ContentAttribute, content);
        }

        public class ShadowMapper : BasePrimitiveShadowMapper<XamFormsContext,Xamarin.Forms.ViewCell,ViewCell>
        {
            protected override Xamarin.Forms.ViewCell CreateItem(XamFormsContext context, ViewCell element)
            {
                return new Xamarin.Forms.ViewCell();
            }

            protected override void Update(XamFormsContext context, IShadow<Xamarin.Forms.ViewCell> shadow, ViewCell current, ViewCell next)
            {
                base.Update(context,shadow,current,next);

                shadow.UpdateContent<Xamarin.Forms.View>(context,current?.Attributes?.GetAttributeOrDefault(ViewExtensions.ContentAttribute),
                    next?.Attributes?.GetAttributeOrDefault(ViewExtensions.ContentAttribute), (s) =>
                    {
                        shadow.Item.View = s.Item;
                    }, (s) =>
                    {
                        shadow.Item.View = null;
                    });
            }
        }
    }
}
