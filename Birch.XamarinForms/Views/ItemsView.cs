using System;
using System.Collections.Generic;
using System.Text;
using Birch.Components;
using Birch.Reflection;
using Xamarin.Forms;

namespace Birch.Views
{
    public partial class ItemsView
    {
        public static Attribute<IPrimitive> EmptyViewAttribute = Components.Attribute.Register<IPrimitive>(Components.Attribute.Name<Xamarin.Forms.ItemsView>(nameof(EmptyViewAttribute)));
    }
}
