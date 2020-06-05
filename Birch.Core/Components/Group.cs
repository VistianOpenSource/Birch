using Birch.Collections;

namespace Birch.Components
{
    public class Group
    {
        public static Attribute<IPrimitive[]> ChildrenAttribute = Attribute.Register(Attribute.Name<Group>(nameof(ChildrenAttribute)),true,ArrayComparer<IPrimitive>.Default);

        public static Attribute<ICollectionComparer<IPrimitive>> ComparerAttribute = Attribute.Register<ICollectionComparer<IPrimitive>>(Attribute.Name<Group>(nameof(ComparerAttribute)));
    }
}