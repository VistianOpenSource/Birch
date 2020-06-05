using System.Collections.Generic;
using Xamarin.Forms;

namespace Birch.Views
{
    /// <summary>
    /// Compare <see cref="Xamarin.Forms.ColumnDefinition"/> instances.
    /// </summary>
    public class ColumnDefinitionComparer : IEqualityComparer<ColumnDefinition>
    {
        public static ColumnDefinitionComparer Default = new ColumnDefinitionComparer();

        public bool Equals(ColumnDefinition x, ColumnDefinition y)
        {
            if (x == null && y == null) return true;

            if (x == null || y == null) return false;

            return ReferenceEquals(x, y) || GridLengthComparer.Default.Equals(x.Width, y.Width);
        }

        public int GetHashCode(ColumnDefinition obj)
        {
            return obj.GetHashCode();
        }
    }
}