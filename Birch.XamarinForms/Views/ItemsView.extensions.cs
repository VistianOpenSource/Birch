using System;
using System.Collections.Generic;
using System.Text;
using Birch.Components;
using Birch.Reflection;
using Xamarin.Forms.Internals;

namespace Birch.Views
{
    public static class ItemsViewExtensions
    {
        public static TControl EmptyView<TControl>(this TControl control, IPrimitive element)
            where TControl : IReflectedPrimitive<Xamarin.Forms.ItemsView>
        {
            control.Attributes.SetAttribute(ItemsView.EmptyViewAttribute, element);
            return control;
        }
    }
}
