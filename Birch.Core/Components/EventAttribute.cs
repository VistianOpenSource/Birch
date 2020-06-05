using System;
using System.Collections.Generic;

namespace Birch.Components
{
    /// <summary>
    /// Represents an attribute which is used for holding events.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    [Preserve(AllMembers = true)]
    public sealed class EventAttribute<TValue> : Attribute<TValue>
    {
        public EventAttribute(int id) : base(id)
        {
        }

        public EventAttribute(int id, IEqualityComparer<TValue> equalityComparer) : base(id,
            equalityComparer: equalityComparer)
        {

        }
    }
}