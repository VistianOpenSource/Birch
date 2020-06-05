using System.Collections.Generic;
using Xamarin.Forms;

namespace Birch.Views
{
    /// <summary>
    /// Compare <see cref="Xamarin.Forms.RowDefinition"/> instances.
    /// </summary>
    public class RowDefinitionComparer : IEqualityComparer<RowDefinition>
    {
        public static RowDefinitionComparer Default = new RowDefinitionComparer();

        public bool Equals(RowDefinition x, RowDefinition y)
        {
            if (x == null && y == null) return true;

            if (x == null || y == null) return false;

            return ReferenceEquals(x, y) || GridLengthComparer.Default.Equals(x.Height, y.Height);
        }

        public int GetHashCode(RowDefinition obj)
        {
            return obj.GetHashCode();
        }
    }
}