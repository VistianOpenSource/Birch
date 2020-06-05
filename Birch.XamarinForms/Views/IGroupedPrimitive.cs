using Birch.Components;

namespace Birch.Views
{
    public interface IGroupedPrimitive
    {
        IPrimitive[] Items { get;  }
    }
}