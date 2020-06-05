using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.PlatformConfiguration;
using Birch.Components;
using Birch.Compose;

namespace Birch.Views
{
    /// <summary>
    /// Our base standard Xamarin Forms primitive
    /// </summary>
    /// <typeparam name="TView"></typeparam>
    [ShadowMapper(typeof(ShadowMapper<>))]
    public class XamFormsVisualElement<TView> : BasePrimitive<TView> where TView : Xamarin.Forms.Element
    {
        public XamFormsVisualElement()
        {
        }
    }
}