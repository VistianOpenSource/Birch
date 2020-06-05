using System;
using System.Linq;
using Birch.Components;

namespace Birch.Views
{
    public class CollectionViewGroupedChild:IGroupedPrimitive,IEquatable<CollectionViewGroupedChild>
    {
        public IPrimitive[] Items { get;  }

        public IPrimitive Header { get; }

        public CollectionViewGroupedChild(IPrimitive[] items, IPrimitive header)
        {
            Items = items;
            Header = header;
        }

        public bool Equals(CollectionViewGroupedChild other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(Header, other.Header)&& Items.SequenceEqual(other.Items);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((CollectionViewGroupedChild) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Items, Header);
        }

        public static bool operator ==(CollectionViewGroupedChild left, CollectionViewGroupedChild right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CollectionViewGroupedChild left, CollectionViewGroupedChild right)
        {
            return !Equals(left, right);
        }
    }
}