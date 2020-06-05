using System.Collections.Generic;
using Xamarin.Forms;

namespace Birch.Views
{
    public class GridLengthComparer : IEqualityComparer<GridLength>
    {
        public static GridLengthComparer Default = new GridLengthComparer();

        public bool Equals(GridLength x, GridLength y)
        {
            return x.Value == y.Value && x.GridUnitType == y.GridUnitType;
        }

        public int GetHashCode(GridLength obj)
        {
            return obj.GetHashCode();
        }
    }
}