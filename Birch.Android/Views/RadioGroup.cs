using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Birch.Collections;
using Birch.Components;
using Birch.Compose;
using Birch.Reflection;

namespace Birch.Views
{
    public static partial class Primitives
    {
        /// <summary>
        /// Specific implementation of a <see cref="Android.Widget.RadioGroup"/> wrapper.
        /// </summary>
        /// <param name="buttons"></param>
        /// <param name="dimensions"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static AndroidViewGroup<Android.Widget.RadioGroup> RadioGroup(IEnumerable<IReflectedPrimitive<RadioButton>> buttons,Dimensions dimensions=default,int? id = default)
        {
            // code to ensure the constructor isn't lost.
            if (Birch.Components.Primitives.NeverInclude)
            {
                var _ = new RadioGroup(null);
            }

            var control = ViewGroup<Android.Widget.RadioGroup>(buttons,(d) => new Android.Widget.RadioGroup.LayoutParams(d.Width, d.Height),dimensions,id);
            return control;
        }    
    }
}