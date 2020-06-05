using System;
using System.Collections.Generic;
using System.Text;
using Birch.Reflection;


namespace Birch.Views
{
    public static partial class Primitives
    {
        public static IReflectedPrimitive<Xamarin.Forms.Slider> Slider(int? min=default, int? max =default)
        {
            if (Components.Primitives.NeverInclude)   
            {
                var _ = new Xamarin.Forms.Slider();
            }

            var control= new XamFormsVisualElement<Xamarin.Forms.Slider>();

            if (min.HasValue && max.HasValue)
            {
                control.MinMax(min.Value, max.Value);
            }

            return control;
        }
    }
}
