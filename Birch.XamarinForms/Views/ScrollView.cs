using System;
using System.Collections.Generic;
using System.Text;
using Birch.Collections;
using Birch.Components;
using Birch.Compose;
using Birch.Shadows;
using Birch.Transactions;
using Xamarin.Forms;
using IPrimitiveExtensions = Birch.Compose.IPrimitiveExtensions;

namespace Birch.Views
{
    [ShadowMapper(typeof(ShadowMapper))]
    public class ScrollView : XamFormsVisualElement<Xamarin.Forms.ScrollView>
    {
        public ScrollView(IPrimitive content):base()
        {
            this.Attributes.SetAttribute(ViewExtensions.ContentAttribute, content);
        }


        public class ShadowMapper : BasePrimitiveShadowMapper<XamFormsContext,Xamarin.Forms.ScrollView,ScrollView>
        {
            protected override Xamarin.Forms.ScrollView CreateItem(XamFormsContext context, ScrollView element)
            {
                return new Xamarin.Forms.ScrollView();
            }

            protected override void Update(XamFormsContext context, IShadow<Xamarin.Forms.ScrollView> shadow, ScrollView current, ScrollView next)
            {
                shadow.UpdateContent<Xamarin.Forms.View>(context,current?.Attributes?.GetAttributeOrDefault(ViewExtensions.ContentAttribute),next?.Attributes?.GetAttributeOrDefault(ViewExtensions.ContentAttribute),
                    (s) =>
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
