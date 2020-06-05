using Birch.Shadows;

namespace Birch.Collections
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TChild"></typeparam>
    public interface IShadowChildGroup<in TChild>
    {
        void RemoveAt(int index);

        void Add(IShadow<TChild> childShadow, int index);
    }
}