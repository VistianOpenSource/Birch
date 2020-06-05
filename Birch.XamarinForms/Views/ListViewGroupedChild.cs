using System;
using System.Linq;
using Birch.Components;

namespace Birch.Views
{
    public class ListViewGroupedChild:IGroupedPrimitive,IEquatable<ListViewGroupedChild>
    {
        public string ShortName { get;  }

        public string LongName { get;  }

        public IPrimitive[] Items { get;  }

        public ListViewGroupedChild(string shortName, string longName, IPrimitive[] items)
        {
            ShortName = shortName;
            LongName = longName;
            Items = items;
        }

        public bool Equals(ListViewGroupedChild other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return ShortName == other.ShortName && LongName == other.LongName && Items.SequenceEqual(other.Items);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ListViewGroupedChild) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ShortName, LongName, Items);
        }

        public static bool operator ==(ListViewGroupedChild left, ListViewGroupedChild right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ListViewGroupedChild left, ListViewGroupedChild right)
        {
            return !Equals(left, right);
        }
    }
}