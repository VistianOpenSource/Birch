using Android.Views;
using Birch.Collections;
using Birch.Shadows;

namespace Birch.Views
{
    /// <summary>
    /// Provides mechanism for manipulation of views within a <see cref="ViewGroup"/>
    /// </summary>
    public class AndroidViewGroupConnection:IShadowChildGroup<Android.Views.View>
    {
        /// <summary>
        /// The associated shadow view.
        /// </summary>
        public IShadow<ViewGroup> Shadow { get; }

        public AndroidViewGroupConnection(IShadow<ViewGroup> shadow)
        {
            Shadow = shadow;
        }

        public void RemoveAt(int index)
        {
            Shadow.Item.RemoveViewAt(index);
        }

        public void Add(IShadow<Android.Views.View> childShadow, int index)
        {
            if (index == Shadow.Item.ChildCount)
            {
                Shadow.Item.AddView(childShadow.Item);
            }
            else
            {
                Shadow.Item.AddView(childShadow.Item,index);
            }
        }
    }
}