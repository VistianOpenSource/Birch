using System;
using System.Collections.Generic;
using Birch.Reflection;
using Birch.Shadows;
using static Birch.Components.Attribute;

namespace Birch.Components
{
    /// <summary>
    /// Standard set of attributes.
    /// </summary>

    public static class StandardAttributes
    {
        /// <summary>
        /// Standard equality comparer for these actions.
        /// </summary>
        private static readonly IEqualityComparer<Action<BasePrimitive,IShadow>> EqualityComparer = new ActionEqualityComparer<BasePrimitive, IShadow>();

        /// <summary>
        /// Action to be invoked when <see cref="BasePrimitive"/> first created.
        /// </summary>
        public static readonly Attribute<Action<BasePrimitive,IShadow>> CreatedAttribute = Register<Action<BasePrimitive,IShadow>>(Name<BasePrimitive>(nameof(CreatedAttribute)),equalityComparer:EqualityComparer);

        /// <summary>
        /// Action to be invoked when <see cref="IShadow"/> associated with a <see cref="BasePrimitive"/> is destroyed.
        /// </summary>
        public static readonly Attribute<Action<BasePrimitive,IShadow>> DestroyedAttribute = Register<Action<BasePrimitive,IShadow>>(Name<BasePrimitive>(nameof(DestroyedAttribute)),equalityComparer:EqualityComparer);

        /// <summary>
        /// A <see cref="ViewRef"/> to receive the native UI control. 
        /// </summary>
        public static readonly Attribute<ViewRef> RefAttribute = Register<ViewRef>(Name<BasePrimitive>(nameof(RefAttribute)));

        /// <summary>
        /// Action to be invoked whenever a <see cref="IShadow"/>, or its descendents are updated.
        /// </summary>
        /// <remarks>
        /// It should be noted this is a somewhat crude implementation that looks for transaction count changes between updates.</remarks>
        public static readonly Attribute<Action<BasePrimitive,IShadow>> UpdatedAttribute = Register<Action<BasePrimitive, IShadow>>(Name<BasePrimitive>(nameof(UpdatedAttribute)),equalityComparer:EqualityComparer);
    }
}