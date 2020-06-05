using System;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Birch.Shadows;

namespace MVU_Experiment.RV
{
    public class ShadowViewHolder : RecyclerView.ViewHolder
    {
        public ShadowViewHolder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
            IsRecyclable = false;
        }

        public ShadowViewHolder(IShadow itemView) : base(((IShadow<View>)itemView).Item)
        {
            IsRecyclable = false;
        }
    }
}