using System;
using Android.Views;
using Android.Widget;

namespace Birch.Views
{
    /// <summary>
    /// Represents the margins used for <see cref="ViewGroup.MarginLayoutParams"/>
    /// </summary>
    public readonly struct Margins
    {
        public int? Left { get; }

        public int? Right {get;}

        public int? Top { get; }

        public int? Bottom { get; }

        public Margins(int? left=default, int? right=default, int? top=default, int? bottom=default)
        {
            Left = left;
            Right = right;
            Top = top;
            Bottom = bottom;
        }
    }
}