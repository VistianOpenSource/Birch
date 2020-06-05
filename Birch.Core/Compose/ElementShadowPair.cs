using Birch.Components;
using Birch.Shadows;

namespace Birch.Compose
{
    public class ElementShadowPair
    {
        public IShadow Shadow { get; }

        public IPrimitive Element { get; }

        public ElementShadowPair(IShadow shadow, IPrimitive element)
        {
            Shadow = shadow;
            Element = element;
        }

        public static ElementShadowPair Empty => new ElementShadowPair(default,default);
    }
}