using System;
using System.Collections.Generic;
using System.Text;
using Birch.Components;
using Birch.Compose;
using Birch.Shadows;
using Birch.Transactions;

namespace Birch.Views
{
    [ShadowMapper(typeof(ShadowMapper))]
    public class Frame : XamFormsVisualElement<Xamarin.Forms.Frame>
    {
        public Frame(IPrimitive content):base()
        {
            this.Attributes.SetAttribute(ViewExtensions.ContentAttribute, content);
        }

        public class ShadowMapper : BasePrimitiveShadowMapper<XamFormsContext,Xamarin.Forms.Frame,Frame>
        {
            protected override Xamarin.Forms.Frame CreateItem(XamFormsContext context, Frame element)
            {
                return new Xamarin.Forms.Frame();
            }

            protected override void Update(XamFormsContext context, IShadow<Xamarin.Forms.Frame> shadow, Frame current, Frame next)
            {
                base.Update(context,shadow,current,next);

                shadow.UpdateContent<Xamarin.Forms.View>(context,current?.Attributes?.GetAttributeOrDefault(ViewExtensions.ContentAttribute),
                    next?.Attributes?.GetAttributeOrDefault(ViewExtensions.ContentAttribute), (s) =>
                    {
                        shadow.Item.Content = s.Item;
                    }, (s) =>
                    {
                        shadow.Item.Content = null;
                    });
            }
        }
    }
}
