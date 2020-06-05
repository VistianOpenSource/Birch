using System.Collections.Generic;
using System.Linq;

namespace Birch.Components
{
    public static class IPrimitiveExtensions
    {
        /// <summary>
        /// Given two <see cref="IPrimitive"/> components, determine all of attributes between then which have been specified.
        /// </summary>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        /// <returns></returns>
        public static IEnumerable<int> GetCombinedAttributes(IPrimitive item1, IPrimitive item2)
        {
            var attributeIds = new HashSet<int>(item1?.Attributes.Count() ?? 0 + item2?.Attributes.Count() ?? 0);

            // simple algorithm, add the ids of each attribute in the into a hash

            if (item1 != null)
            {
                foreach (var attribute in item1.Attributes)
                {
                    attributeIds.Add(attribute.Id);
                }
            }

            if (item2 != null)
            {
                foreach (var attribute in item2.Attributes)
                {
                    attributeIds.Add(attribute.Id);
                }
            }

            // and now return the ids
            return attributeIds.AsEnumerable();
        }

        /// <summary>
        /// Given an existing <see cref="IPrimitive"/> determine if it can be updated to a new one.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static bool CanUpdateTo(this IPrimitive from, IPrimitive to)
        {
            return from.GetType() == to.GetType();
        }
    }
}