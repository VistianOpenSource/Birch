using System;
using System.Collections.Generic;
using System.Text;
using Birch.Components;
using Birch.Compose;
using Birch.Shadows;
using Birch.Transactions;
using Xamarin.Forms.PlatformConfiguration;

namespace Birch.Views
{
    /// <summary>
    /// <see cref="IElement"/> representing a standard <see cref="Xamarin.Forms.ContentPage"/>
    /// 
    /// </summary>
    [ShadowMapper(typeof(ShadowMapper))]
    public class ContentPage : BasePrimitive<Xamarin.Forms.ContentPage>
    {
        /// <summary>
        /// The actual content page
        /// </summary>
        public Xamarin.Forms.ContentPage TheContentPage { get; }

        /// <summary>
        /// The content view 
        /// </summary>
        public IPrimitive ContentView { get; }

        public ContentPage(Xamarin.Forms.ContentPage contentPage,IPrimitive contentView)
        {
            TheContentPage = contentPage;
            ContentView = contentView;
        }

        [Preserve(AllMembers = true)]
        public class ShadowMapper : BasePrimitiveShadowMapper<XamFormsContext,Xamarin.Forms.ContentPage,ContentPage>
        {
            protected override Xamarin.Forms.ContentPage CreateItem(XamFormsContext context, ContentPage element)
            {
                return element.TheContentPage;
            }

            protected override void Update(XamFormsContext context, IShadow<Xamarin.Forms.ContentPage> shadow, ContentPage current, ContentPage next)
            {
                shadow.UpdateContent<Xamarin.Forms.View>(context,current?.ContentView,next?.ContentView, (s) =>
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
