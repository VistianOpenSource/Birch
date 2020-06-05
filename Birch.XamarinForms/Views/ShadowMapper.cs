using System;
using System.Collections.Generic;
using System.Text;
using Birch.Components;
using Birch.Compose;

namespace Birch.Views
{
    /// <summary>
    /// Basic <see cref="IShadowMapper"/> for Xamarin Forms Visual Elements whereby the actual views are constructed using reflection.
    /// </summary>
    /// <typeparam name="TView"></typeparam>
    [Preserve(AllMembers = true)]
    public class ShadowMapper<TView> : BasePrimitiveShadowMapper<XamFormsContext, TView, XamFormsVisualElement<TView>> where TView : Xamarin.Forms.Element
    {
        protected override TView CreateItem(XamFormsContext context, XamFormsVisualElement<TView> element)
        {
            var view = (TView) Activator.CreateInstance(typeof(TView));

            return view;
        }
    }
}
