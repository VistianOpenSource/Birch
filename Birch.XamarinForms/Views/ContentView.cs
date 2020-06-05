using System;
using System.Collections.Generic;
using System.Text;
using Birch.Components;
using Birch.Compose;
using Birch.Shadows;
using Birch.Transactions;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace Birch.Views
{
    [ShadowMapper(typeof(ContentView<>.ContentViewShadowMapper))]
    public class ContentView<TControl>:XamFormsVisualElement<TControl> where TControl:Xamarin.Forms.ContentView
    {
        public ContentView(IPrimitive content)
        {
            this.Attributes.SetAttribute(ViewExtensions.ContentAttribute, content);
        }

        /// <summary>
        /// Basic <see cref="IShadowMapper"/> for Android views whereby the actual views are constructed using reflection.
        /// </summary>
        [Preserve(AllMembers = true)]
        public class ContentViewShadowMapper : BasePrimitiveShadowMapper<XamFormsContext, TControl, XamFormsVisualElement<TControl>>
        {
            protected override TControl CreateItem(XamFormsContext context, XamFormsVisualElement<TControl> element)
            {
                var view = (TControl) Activator.CreateInstance(typeof(TControl));

                return view;
            }

            protected override void Update(XamFormsContext context, IShadow<TControl> shadow, XamFormsVisualElement<TControl> current, XamFormsVisualElement<TControl> next)
            {
                base.Update(context, shadow, current, next);

                shadow.UpdateContent<Xamarin.Forms.View>(context,current?.Attributes.GetAttributeOrDefault(ViewExtensions.ContentAttribute),next?.Attributes.GetAttributeOrDefault(ViewExtensions.ContentAttribute),
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