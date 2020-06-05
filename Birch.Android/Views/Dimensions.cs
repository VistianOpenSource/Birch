using System;

namespace Birch.Views
{
    /// <summary>
    /// Helper class to enable dimensions to be handled more efficiently.
    /// </summary>
    public sealed class Dimensions:IEquatable<Dimensions>
    {
        public Dimensions(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; }

        public int Height { get; }

        /// <summary>
        /// Pre-defined , common values for <see cref="Dimensions"/>
        /// </summary>
        public static Dimensions MatchMatch => new Dimensions(Android.Views.ViewGroup.LayoutParams.MatchParent,Android.Views.ViewGroup.LayoutParams.MatchParent);
        public static Dimensions WrapMatch => new Dimensions(Android.Views.ViewGroup.LayoutParams.WrapContent,Android.Views.ViewGroup.LayoutParams.MatchParent);
        public static Dimensions MatchWrap => new Dimensions(Android.Views.ViewGroup.LayoutParams.MatchParent,Android.Views.ViewGroup.LayoutParams.WrapContent);
        public static Dimensions WrapWrap => new Dimensions(Android.Views.ViewGroup.LayoutParams.WrapContent,Android.Views.ViewGroup.LayoutParams.WrapContent);

        public bool Equals(Dimensions other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Width == other.Width && Height == other.Height;
        }

        public override bool Equals(object obj)
        {
            return ReferenceEquals(this, obj) || obj is Dimensions other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Width * 397) ^ Height;
            }
        }

        public static bool operator ==(Dimensions left, Dimensions right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Dimensions left, Dimensions right)
        {
            return !Equals(left, right);
        }
    }
}