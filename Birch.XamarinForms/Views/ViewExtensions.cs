using System;
using Birch.Components;
using Birch.Reflection;

namespace Birch.Views
{
    public static class ViewExtensions
    {
        public static readonly Attribute<IPrimitive> ContentAttribute = Components.Attribute.Register<IPrimitive>(Components.Attribute.Name<Xamarin.Forms.View>(nameof(ContentAttribute)));
    }
}